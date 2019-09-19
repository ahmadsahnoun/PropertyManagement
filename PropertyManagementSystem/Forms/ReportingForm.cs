using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using PropertyManagementSystem.Models;
using PropertyManagementSystem.Reports;

namespace PropertyManagementSystem.Forms
{
    public partial class ReportingForm : Form
    {
        private readonly MyDbContext _db = new MyDbContext();
        public ReportingForm()
        {
            InitializeComponent();
        }

        private void rbDetailedHistory_CheckedChanged(object sender, EventArgs e)
        {
            gbDetailed.Visible = rbDetailedHistory.Checked;
            cbPropertyType.Items = new[] { "Residential", "Commercial", "Farm", "Warehouse" };
        }

        private void cbPropertyType_onItemSelected(object sender, EventArgs e)
        {
            cbTempProperty.DataSource = null;
            cbTempProperty.Items.Clear();
            cbProperty.Clear();
            if (cbPropertyType.selectedIndex <= -1) return;
            var buildingType = cbPropertyType.selectedValue.Equals("Residential") ? BuildingType.Residential :
                cbPropertyType.selectedValue.Equals("Farm") ? BuildingType.Farm :
                cbPropertyType.selectedValue.Equals("Commercial") ? BuildingType.Commercial :
                BuildingType.Warehouse;
            var properties = _db.Properties.Where(p => p.BuildingType == buildingType).ToList();
            cbTempProperty.DisplayMember = "Name";
            cbTempProperty.ValueMember = "Id";
            cbTempProperty.DataSource = properties;
            foreach (var property in properties)
            {
                cbProperty.AddItem(property.Name);
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (rbDetailedHistory.Checked)
            {
                if (cbReportFor.selectedIndex == 0 || (cbReportFor.selectedIndex == 1 &&
                                                       cbPropertyType.selectedIndex > -1 &&
                                                       cbProperty.selectedIndex > -1))
                {
                    var dt = new DataTable();
                    dt.Columns.Add("Customer");
                    dt.Columns.Add("Price");
                    dt.Columns.Add("Method");
                    dt.Columns.Add("Period");
                    dt.Columns.Add("Start");
                    dt.Columns.Add("End");
                    dt.Columns.Add("Property");
                    // ReSharper disable ConvertIfStatementToSwitchStatement
                    if (cbReportFor.selectedIndex == 0)
                    {
                        var properties = _db.Properties.ToList();
                        foreach (var property in properties)
                        {
                            var contracts = _db.Contracts.Where(c => c.PropertyId == property.Id).ToList();
                            foreach (var contract in contracts)
                            {
                                var customers = _db.Clients.Where(c => c.Id == contract.ClientId).ToList();
                                foreach (var customer in customers)
                                {
                                    dt.Rows.Add(customer.Name, contract.Price, contract.Method,
                                        contract.PayEvery + " " + contract.Period,
                                        contract.Start.ToShortDateString(), contract.End.ToShortDateString(),
                                        property.Name);
                                }
                            }
                        }

                        var rpt = new rptDetailedHistory();
                        rpt.SetDataSource(dt);
                        rpt.PrintToPrinter(1, true, 0, 0);
                    }
                    else if (cbReportFor.selectedIndex == 1)
                    {
                        if (cbProperty.selectedIndex >= 0 || cbPropertyType.selectedIndex >= 0)
                        {
                            var propertyId = int.Parse(cbTempProperty.SelectedValue.ToString());
                            var property = _db.Properties.Find(propertyId);
                            if (property == null) return;
                            var contracts = _db.Contracts.Where(c => c.PropertyId == property.Id).ToList();
                            foreach (var contract in contracts)
                            {
                                var customers = _db.Clients.Where(c => c.Id == contract.ClientId).ToList();
                                foreach (var customer in customers)
                                {
                                    dt.Rows.Add(customer.Name, contract.Price, contract.Method,
                                        contract.PayEvery + " " + contract.Period,
                                        contract.Start.ToShortDateString(), contract.End.ToShortDateString());
                                }
                            }

                            var rpt = new rptDetailedHistory();
                            rpt.SetDataSource(dt);
                            rpt.PrintToPrinter(1, true, 0, 0);
                        }
                        else
                            MessageBox.Show(@"Please fill all the fields", "", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show(@"Please fill all the fields", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (rbOccupation.Checked)
            {
                if (cbReportFor2.selectedIndex == 0 || (cbReportFor2.selectedIndex == 1 &&
                                                        cbPropertyType2.selectedIndex > -1 &&
                                                        cbProperty2.selectedIndex > -1))
                {
                    var dt = new DataTable();
                    dt.Columns.Add("Property");
                    dt.Columns.Add("PropertyType");
                    dt.Columns.Add("Status");
                    dt.Columns.Add("Client");
                    dt.Columns.Add("Start");
                    dt.Columns.Add("End");
                    dt.Columns.Add("Rate");
                    if (cbReportFor2.selectedIndex == 0)
                    {
                        var properties = _db.Properties.ToList();
                        foreach (var property in properties)
                        {
                            var contract = _db.Contracts.FirstOrDefault(c => c.PropertyId == property.Id);
                            if (contract != null)
                            {
                                var contracts = _db.Contracts.Where(c => c.PropertyId == property.Id).ToList();
                                foreach (var c in contracts)
                                {
                                    var client = _db.Clients.Find(c.ClientId);
                                    // ReSharper disable once PossibleNullReferenceException
                                    dt.Rows.Add(property.Name, property.BuildingType.ToString(),
                                        property.Status.ToString(),
                                        client.Name, c.Start.ToShortDateString(), c.End.ToShortDateString(),
                                        c.Price);
                                }
                            }
                            else
                                dt.Rows.Add(property.Name, property.BuildingType.ToString(), property.Status.ToString(),
                                    "", "", "", "");
                        }
                        var rpt = new rptAllOccupation();
                        rpt.SetDataSource(dt);
                        rpt.PrintToPrinter(1, true, 0, 0);
                    }
                    else if (cbReportFor2.selectedIndex == 1)
                    {
                        var propertyId = int.Parse(cbTempProperty.SelectedValue.ToString());
                        var property = _db.Properties.Find(propertyId);
                        if (property == null) return;
                        var contract = _db.Contracts.Where(c => c.PropertyId == property.Id)
                            .OrderByDescending(c => c.Id).FirstOrDefault();
                        if (contract != null)
                        {
                            var client = _db.Clients.Find(contract.ClientId);
                            // ReSharper disable once PossibleNullReferenceException
                            dt.Rows.Add(property.Name, property.BuildingType.ToString(), property.Status.ToString(),
                                client.Name, contract.Start.ToShortDateString(), contract.End.ToShortDateString(),
                                contract.Price);
                        }
                        else
                            dt.Rows.Add(property.Name, property.BuildingType.ToString(), property.Status.ToString(),
                                "", "", "", "");
                        var rpt = new rptAllOccupation();
                        rpt.SetDataSource(dt);
                        rpt.PrintToPrinter(1, true, 0, 0);
                    }
                }
                else
                    MessageBox.Show(@"Please fill all the fields", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (rbCashFlow.Checked)
            {

                // ReSharper disable NotAccessedVariable
                double collectedTotal = 0;
                double notCollectedTotal = 0;
                var start = dtpStart.Value;
                var end = dtpEnd.Value;

                var dt = new DataTable();
                dt.Columns.Add("Client");
                dt.Columns.Add("Property");
                dt.Columns.Add("PaymentDate");
                dt.Columns.Add("Amount");
                dt.Columns.Add("Status");
                dt.Columns.Add("CollectedTotal");
                dt.Columns.Add("NotCollectedTotal");
                var payments = _db.Payments.Where(p => p.PaymentDate >= start && p.PaymentDate <= end).ToList();
                using (var db = new MyDbContext())
                {
                    foreach (var payment in payments)
                    {
                        var contract = db.Contracts.Find(payment.ContractId);
                        if(contract == null) continue;
                        // ReSharper disable PossibleNullReferenceException
                        var property = db.Properties.Find(contract.PropertyId);
                        var client = db.Clients.Find(contract.ClientId);
                        dt.Rows.Add(client.Name, property.Name,
                            string.IsNullOrWhiteSpace(payment.PaymentDate.ToShortDateString())
                                ? contract.PayDate.ToShortDateString()
                                : payment.PaymentDate.ToShortDateString(),
                            payment.PayedAmount.ToString(CultureInfo.InvariantCulture), "Collected");
                        collectedTotal += payment.PayedAmount;
                    }
                }


                if (chbUncollected.Checked)
                {
                    // ReSharper disable once RedundantAssignment
                    var contractsPending = new List<Contract>();
                    using (var db = new MyDbContext())
                    {
                        contractsPending = db.Contracts.Where(c =>
                            c.PayStatus.Equals("Pending") && c.PayDate >= start && c.PayDate <= end).ToList();
                    }

                    foreach (var contract in contractsPending)
                    {
                        using (var db = new MyDbContext())
                        {
                            var property = db.Properties.Find(contract.PropertyId);

                            var client = db.Clients.Find(contract.ClientId);

                            dt.Rows.Add(client.Name, property.Name, contract.PayDate.ToShortDateString(),
                                contract.Price.ToString(CultureInfo.InvariantCulture), "Not Collected");
                            notCollectedTotal += contract.Price;
                        }
                    }
                }


                var rpt = new rptCashFlow();
                var textCollectedTotal = (TextObject)rpt.ReportDefinition.ReportObjects["CollectedTotal"];
                var textNotCollectedTotal = (TextObject)rpt.ReportDefinition.ReportObjects["NotCollectedTotal"];
                textCollectedTotal.Text = collectedTotal.ToString(CultureInfo.InvariantCulture);
                textNotCollectedTotal.Text = notCollectedTotal.ToString(CultureInfo.InvariantCulture);
                rpt.SetDataSource(dt);
                rpt.PrintToPrinter(1, true, 0, 0);

            }
        }

        private void cbReportFor_onItemSelected(object sender, EventArgs e)
        {
            if (cbReportFor.selectedIndex == 0)
                cbPropertyType.Enabled = cbProperty.Enabled = false;
            else
                cbPropertyType.Enabled = cbProperty.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbProperty_onItemSelected(object sender, EventArgs e)
        {
            cbTempProperty.SelectedIndex = cbProperty.selectedIndex;
        }

        private void rbOccupation_CheckedChanged(object sender, EventArgs e)
        {
            gbOccupation.Visible = rbOccupation.Checked;
            cbPropertyType2.Items = new[] { "Residential", "Commercial", "Farm", "Warehouse" };
            cbReportFor2.selectedIndex = 0;
        }

        private void cbReportFor2_onItemSelected(object sender, EventArgs e)
        {
            if (cbReportFor2.selectedIndex == 0)
                cbPropertyType2.Enabled = cbProperty2.Enabled = false;
            else
                cbPropertyType2.Enabled = cbProperty2.Enabled = true;
        }

        private void cbPropertyType2_onItemSelected(object sender, EventArgs e)
        {
            cbTempProperty.DataSource = null;
            cbTempProperty.Items.Clear();
            cbProperty2.Clear();
            if (cbPropertyType2.selectedIndex <= -1) return;
            var buildingType = cbPropertyType2.selectedValue.Equals("Residential") ? BuildingType.Residential :
                cbPropertyType2.selectedValue.Equals("Farm") ? BuildingType.Farm :
                cbPropertyType2.selectedValue.Equals("Commercial") ? BuildingType.Commercial :
                BuildingType.Warehouse;
            var properties = _db.Properties.Where(p => p.BuildingType == buildingType).ToList();
            cbTempProperty.DisplayMember = "Name";
            cbTempProperty.ValueMember = "Id";
            cbTempProperty.DataSource = properties;
            foreach (var property in properties)
            {
                cbProperty2.AddItem(property.Name);
            }
        }

        private void cbProperty2_onItemSelected(object sender, EventArgs e)
        {
            cbTempProperty.SelectedIndex = cbProperty2.selectedIndex;
        }

        private void rbCashFlow_CheckedChanged(object sender, EventArgs e)
        {
            gbCashFlow.Visible = rbCashFlow.Checked;
        }
    }
}

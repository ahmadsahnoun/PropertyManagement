using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using PropertyManagementSystem.Models;
using PropertyManagementSystem.Reports;

namespace PropertyManagementSystem.Forms
{
    public partial class Claims : Form
    {
        private readonly MyDbContext _db = new MyDbContext();
        public Claims()
        {
            InitializeComponent();
        }

        private void Claims_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void Populate()
        {
            dataGridView1.Rows.Clear();
            var contracts = _db.Contracts.Where(c => c.PayStatus.Equals("Pending")).ToList();
            foreach (var contract in contracts)
            {
                var client = _db.Clients.Find(contract.ClientId);
                var property = _db.Properties.Find(contract.PropertyId);
                // ReSharper disable PossibleNullReferenceException
                dataGridView1.Rows.Add(contract.Id, client.Name, property.BuildingType.ToString(), property.Name,
                    contract.Start.ToShortDateString(), contract.End.ToShortDateString());
            }
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            var contractId = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            var contract = _db.Contracts.Find(contractId);
            txtClient.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtProperty.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtPrice.Text = contract.Price.ToString(CultureInfo.InvariantCulture);
            txtPayEvery.Text = contract.PayEvery.ToString(CultureInfo.InvariantCulture) + @" " +
                               contract.Period;
            txtMethod.Text = contract.Method.ToString();
            txtPaymentDate.Text = contract.PayDate.ToShortDateString();

            btnPrint.Enabled = btnPayed.Enabled = btnBrowse.Enabled = btnScan.Enabled = pbClaimDoc.Enabled =  true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            if (txtMethod.Text.Equals("Transform"))
            {
                var rpt = new rptBankClaim();
                var textDate = (TextObject) rpt.ReportDefinition.ReportObjects["textDate"];
                var textClient = (TextObject) rpt.ReportDefinition.ReportObjects["textClient"];
                var textPropertyType = (TextObject)rpt.ReportDefinition.ReportObjects["textPropertyType"];
                var textPropertyName = (TextObject)rpt.ReportDefinition.ReportObjects["textPropertyName"];
                var textPropertyType2 = (TextObject)rpt.ReportDefinition.ReportObjects["textPropertyType2"];
                var textPropertyName2 = (TextObject)rpt.ReportDefinition.ReportObjects["textPropertyName2"];
                var textPrice = (TextObject)rpt.ReportDefinition.ReportObjects["textPrice"];
                var textFrom = (TextObject)rpt.ReportDefinition.ReportObjects["textFrom"];
                var textTo = (TextObject)rpt.ReportDefinition.ReportObjects["textTo"];
                var textBank = (TextObject)rpt.ReportDefinition.ReportObjects["textBank"];
                var textAccountNo = (TextObject)rpt.ReportDefinition.ReportObjects["textAccountNo"];
                var textBranch = (TextObject)rpt.ReportDefinition.ReportObjects["textBranch"];

                textDate.Text = DateTime.Now.ToShortDateString();
                textClient.Text = txtClient.Text;
                textPropertyType.Text =
                    textPropertyType2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textPropertyName.Text = textPropertyName2.Text = txtProperty.Text;
                textPrice.Text = txtPrice.Text;
                textFrom.Text = txtPaymentDate.Text;
                textTo.Text = DateTime.Parse(txtPaymentDate.Text).AddDays(5).ToShortDateString();
                textBank.Text = "الخرطوم";
                textAccountNo.Text = "3333";
                textBranch.Text = "العربي";
                rpt.PrintToPrinter(1, true, 0, 0);
            }
            else if (txtMethod.Text.Equals("Cash") || txtMethod.Text.Equals("Cheque"))
            {
                var rpt = new rptCashClaim();
                var textDate = (TextObject)rpt.ReportDefinition.ReportObjects["textDate"];
                var textClient = (TextObject)rpt.ReportDefinition.ReportObjects["textClient"];
                var textPropertyType = (TextObject)rpt.ReportDefinition.ReportObjects["textPropertyType"];
                var textPropertyName = (TextObject)rpt.ReportDefinition.ReportObjects["textPropertyName"];
                var textPropertyType2 = (TextObject)rpt.ReportDefinition.ReportObjects["textPropertyType2"];
                var textPropertyName2 = (TextObject)rpt.ReportDefinition.ReportObjects["textProperty2"];
                var textPrice = (TextObject)rpt.ReportDefinition.ReportObjects["textPrice"];
                var textFrom = (TextObject)rpt.ReportDefinition.ReportObjects["textFrom"];
                var textTo = (TextObject)rpt.ReportDefinition.ReportObjects["textTo"];

                textDate.Text = DateTime.Now.ToShortDateString();
                textClient.Text = txtClient.Text;
                textPropertyType.Text =
                    textPropertyType2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textPropertyName.Text = textPropertyName2.Text = txtProperty.Text;
                textPrice.Text = txtPrice.Text;
                textFrom.Text = txtPaymentDate.Text;
                textTo.Text = DateTime.Parse(txtPaymentDate.Text).AddDays(5).ToShortDateString();
                rpt.PrintToPrinter(1, true, 0, 0);
            }
        }

        private void btnPayed_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            var contractId = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            var contract = _db.Contracts.Find(contractId);
            contract.PayStatus = "Payed";
            contract.ClaimDocument = ImageToByteArray(pbClaimDoc.Image);
            var payDate = contract.Period == PaymentPeriod.Day
                ? contract.PayDate.AddDays(contract.PayEvery)
                :
                contract.Period == PaymentPeriod.Week
                    ? contract.PayDate.AddDays(contract.PayEvery * 7)
                    :
                    contract.Period == PaymentPeriod.Month
                        ?
                        contract.PayDate.AddMonths(int.Parse(contract.PayEvery.ToString(CultureInfo.InvariantCulture)))
                        : contract.PayDate.AddYears(int.Parse(contract.PayEvery.ToString(CultureInfo.InvariantCulture)));
            if (contract.End > payDate)
                contract.PayDate = payDate;
            else
            {
                var property = _db.Properties.Find(contract.PropertyId);
                property.Status = PropertyStatus.Free;
                _db.SaveChanges();
            }
            _db.SaveChanges();
            var payment = new Payment()
            {
                ContractId = contract.Id,
                PayedAmount = contract.Price,
                PaymentDate = DateTime.Now
            };
            _db.Payments.Add(payment);
            _db.SaveChanges();
            MessageBox.Show(@"Payment Registered Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Populate();
            Clear();
            DisableAll();
        }

        private void DisableAll()
        {
            pbClaimDoc.Enabled = btnBrowse.Enabled = btnScan.Enabled = txtClient.Enabled = txtProperty.Enabled =
                txtPrice.Enabled = txtPayEvery.Enabled = txtMethod.Enabled =
                    txtPaymentDate.Enabled = btnPrint.Enabled = btnPayed.Enabled = false;
        }

        private void Clear()
        {
            txtPayEvery.Text = txtClient.Text =
                txtProperty.Text = txtPrice.Text = txtMethod.Text = txtPaymentDate.Text = "";
            pbClaimDoc.Image = null;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Multiselect = false;
                openFileDialog1.ShowDialog();
                pbClaimDoc.Image = Image.FromFile(openFileDialog1.FileName);
            }
            catch (Exception)
            {
                // ignored
            }
        }

        public static byte[] ImageToByteArray(Image imageIn)
        {
            var ms = new MemoryStream();
            try
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            }
            catch (Exception)
            {
                // ignored
            }

            return ms.ToArray();
        }

        private void pbClaimDoc_DoubleClick(object sender, EventArgs e)
        {
            new ViewDocument(pbClaimDoc.Image).ShowDialog();
        }
    }
}

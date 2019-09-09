using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using PropertyManagementSystem.Models;
using WIA;

namespace PropertyManagementSystem.Forms
{
    public partial class AddContract : Form
    {
        private readonly MyDbContext _db = new MyDbContext();
        public AddContract()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Populate()
        {
            cbClients.Clear();
            cbProperties.Clear();
            cbPropertyTypes.Clear();
            List<Client> clients = _db.Clients.ToList();
            //var dt = new DataTable();
            //dt.Columns.Add("Id");
            //dt.Columns.Add("Name");
            //foreach (var client in clients)
            //{
            //    dt.Rows.Add(client.Id, client.Name);
            //}

            cbTempClient.DisplayMember = "Name";
            cbTempClient.ValueMember = "Id";
            cbTempClient.DataSource = clients;
            foreach (var client in clients)
            {
                cbClients.AddItem(client.Name);
            }

            var propertyType = new[] {"Residential", "Commercial", "Farm", "Warehouse"};
            cbPropertyTypes.Items = propertyType;
        }

        private void AddContract_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AddClient().ShowDialog();
            Populate();
        }

        private void pbContract_DoubleClick(object sender, EventArgs e)
        {
            new ViewDocument(pbContract.Image).ShowDialog();
        }

        private void cbPropertyTypes_onItemSelected(object sender, EventArgs e)
        {
            cbTempProperty.DataSource = null;
            cbTempProperty.Items.Clear();
            cbProperties.Clear();
            if (cbPropertyTypes.selectedIndex <= -1) return;
            var buildingType = cbPropertyTypes.selectedValue.Equals("Residential") ? BuildingType.Residential :
                cbPropertyTypes.selectedValue.Equals("Farm") ? BuildingType.Farm :
                cbPropertyTypes.selectedValue.Equals("Commercial") ? BuildingType.Commercial :
                BuildingType.Warehouse;
            var properties = _db.Properties.Where(p => p.BuildingType == buildingType && p.Status == PropertyStatus.Free).ToList();
            cbTempProperty.DisplayMember = "Name";
            cbTempProperty.ValueMember = "Id";
            cbTempProperty.DataSource = properties;
            foreach (var property in properties)
            {
                cbProperties.AddItem(property.Name);
            }
        }

        private static void AllowOnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && ((BunifuMaterialTextbox)sender).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyNumbers(sender, e);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Multiselect = false;
                openFileDialog1.ShowDialog();
                pbContract.Image = Image.FromFile(openFileDialog1.FileName);
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (pbContract.Image != null)
            {
                dgvContract.Rows.Add(pbContract.Image, 0);
                txtNum.Text = txtTotal.Text = dgvContract.Rows.Count.ToString();
                pbContract.Image = null;
            }
            else
            {
                MessageBox.Show(@"Please upload or scan first", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbLeft_Click(object sender, EventArgs e)
        {
            txtNum.Text = (int.Parse(txtNum.Text) - 1).ToString();
            if (int.Parse(txtNum.Text) <= 1)
                pbContract.Enabled = false;
            pbContract.Image = dgvContract.Rows[int.Parse(txtNum.Text) - 1].Cells[0].Value as Image;
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            pbLeft.Enabled = pbRight.Enabled = true;

            if (int.Parse(txtNum.Text) <= 1)
            {
                pbLeft.Enabled = false;
            }

            if (int.Parse(txtNum.Text) == int.Parse(txtTotal.Text))
            {
                pbRight.Enabled = false;
            }
        }

        private void pbRight_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtNum.Text) == int.Parse(txtTotal.Text))
            {
                pbLeft.Enabled = true;
                pbRight.Enabled = false;
            }
            if (int.Parse(txtNum.Text) > 1)
                pbLeft.Enabled = true;
            txtNum.Text = (int.Parse(txtNum.Text) + 1).ToString();
            pbContract.Image = dgvContract.Rows[int.Parse(txtNum.Text) - 1].Cells[0].Value as Image;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbClients.selectedIndex >= 0 && cbPropertyTypes.selectedIndex >= 0 && cbProperties.selectedIndex >= 0 &&
                !string.IsNullOrWhiteSpace(txtPrice.Text) && !string.IsNullOrWhiteSpace(dtpStart.Value.ToShortDateString()) &&
                !string.IsNullOrWhiteSpace(dtpEnd.Value.ToShortDateString()) && (rbPostpaid.Checked || rbPrepaid.Checked) &&
                (rbCash.Checked || rbCheque.Checked || rbTransform.Checked) &&
                !string.IsNullOrWhiteSpace(txtPayEvery.Text) && cbPeriod.selectedIndex >= 0)
            {
                var contract = new Contract()
                {
                    ClientId = int.Parse(cbTempClient.SelectedValue.ToString()),
                    End = dtpEnd.Value,
                    Method = rbCash.Checked ? PaymentMethod.Cash :
                        rbCheque.Checked ? PaymentMethod.Cheque : PaymentMethod.Transform,
                    PayEvery = float.Parse(txtPayEvery.Text),
                    Payment = rbPrepaid.Checked ? PaymentTypes.Prepaid : PaymentTypes.Postpaid,
                    Period = cbPeriod.selectedIndex == 0 ? PaymentPeriod.Day :
                        cbPeriod.selectedIndex == 1 ? PaymentPeriod.Week :
                        cbPeriod.selectedIndex == 2 ? PaymentPeriod.Month : PaymentPeriod.Year,
                    Price = double.Parse(txtPrice.Text),
                    PropertyId = int.Parse(cbTempProperty.SelectedValue.ToString()),
                    Start = dtpStart.Value,
                    PayDate = rbPostpaid.Checked ? (cbPeriod.selectedIndex == 0
                            ?
                            dtpStart.Value.AddDays(int.Parse(txtPayEvery.Text))
                            : cbPeriod.selectedIndex == 1
                                ? dtpStart.Value.AddDays(int.Parse(txtPayEvery.Text) * 7)
                                : cbPeriod.selectedIndex == 2
                                    ? dtpStart.Value.AddMonths(int.Parse(txtPayEvery.Text))
                                    : dtpStart.Value.AddYears(int.Parse(txtPayEvery.Text))) : dtpStart.Value,
                    PayStatus = rbPrepaid.Checked? "Pending" : ""
                };
                _db.Contracts.Add(contract);
                _db.SaveChanges();
                foreach (DataGridViewRow row in dgvContract.Rows)
                {
                    var contractDoc = new ContractDocument()
                    {
                        Image = ImageToByteArray(row.Cells[0].Value as Image),
                        ContractId = contract.Id
                    };
                    _db.ContractDocuments.Add(contractDoc);
                    _db.SaveChanges();
                }
                var propertyId = int.Parse(cbTempProperty.SelectedValue.ToString());
                var property = _db.Properties.Find(propertyId);
                if (property != null) property.Status = PropertyStatus.Rented;
                _db.SaveChanges();
                MessageBox.Show(@"Contract created successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Populate();
                Clear();
            }
            else
                MessageBox.Show(@"Please fill all the fields", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Clear()
        {
            cbClients.selectedIndex =
                cbPeriod.selectedIndex = cbProperties.selectedIndex = cbPropertyTypes.selectedIndex = -1;
            txtPrice.Text = dtpStart.Text = dtpEnd.Text = txtPayEvery.Text = "";
            rbCash.Checked = rbCheque.Checked = rbPostpaid.Checked = rbPrepaid.Checked = rbTransform.Checked = false;
            pbContract.Image = null;
            dgvContract.Rows.Clear();
            pbLeft.Enabled = pbRight.Enabled = false;
            txtNum.Text = txtTotal.Text = @"0";
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

        private void cbClients_onItemSelected(object sender, EventArgs e)
        {
            cbTempClient.SelectedIndex = cbClients.selectedIndex;
        }

        private void cbProperties_onItemSelected(object sender, EventArgs e)
        {
            cbTempProperty.SelectedText = cbProperties.selectedValue;
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            try
            {
                var deviceManager = new DeviceManager();
                DeviceInfo availableScanner = null;
                for (var i = 1; i <= deviceManager.DeviceInfos.Count; i++) // Loop Through the get List Of Devices.
                {
                    if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType) // Skip device If it is not a scanner
                    {
                        continue;
                    }
                    availableScanner = deviceManager.DeviceInfos[i];
                    break;
                }
                if (availableScanner != null)
                {
                    var device = availableScanner.Connect(); //Connect to the available scanner.
                    var scanerItem = device.Items[1]; // select the scanner.
                    var imgFile =
                        (ImageFile)scanerItem.Transfer(FormatID
                            .wiaFormatJPEG); //Retrieve an image in Jpg format and store it into a variable.
                    var imageBytes = (byte[])imgFile.FileData.get_BinaryData();
                    var ms = new MemoryStream(imageBytes);
                    var img = Image.FromStream(ms);
                    pbContract.Image = img;
                }
                else
                    MessageBox.Show(@"Sorry, no scanner is available", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (COMException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

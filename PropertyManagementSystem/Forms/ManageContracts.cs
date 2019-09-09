using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using PropertyManagementSystem.Models;
using WIA;

namespace PropertyManagementSystem.Forms
{
    public partial class ManageContracts : Form
    {
        private readonly MyDbContext _db = new MyDbContext();

        public ManageContracts()
        {
            InitializeComponent();
        }

        private void ManageContracts_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void Populate()
        {
            cbClients.Clear();
            cbPropertyTypes.Clear();
            cbProperties.Clear();
            dataGridView1.Rows.Clear();
            var contracts = _db.Contracts.ToList();
            foreach (var contract in contracts)
            {
                var client = _db.Clients.Find(contract.ClientId);
                var property = _db.Properties.Find(contract.PropertyId);
                // ReSharper disable PossibleNullReferenceException
                dataGridView1.Rows.Add(contract.Id, client.Name, property.BuildingType.ToString(), property.Name,
                    contract.Start.ToShortDateString(), contract.End.ToShortDateString());
            }
            dataGridView1.ClearSelection();

            var clients = _db.Clients.ToList();
            cbTempClient.ValueMember = "Id";
            cbTempClient.DisplayMember = "Name";
            cbTempClient.DataSource = clients;
            foreach (var client in clients)
            {
                cbClients.AddItem(client.Name);
            }

            cbTempClient.SelectedIndex = cbClients.selectedIndex = -1;
            var propertyType = new[] { "Residential", "Commercial", "Farm", "Warehouse" };
            cbPropertyTypes.Items = propertyType;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AddContract().ShowDialog();
            Populate();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void pbContract_DoubleClick(object sender, EventArgs e)
        {
            new ViewDocument(pbContract.Image).ShowDialog();
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

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(txtTotal.Text) == 0)
                btnScan.Enabled = btnBrowse.Enabled = false;
            else
                btnScan.Enabled = btnBrowse.Enabled = true;
        }

        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            var ms = new MemoryStream(byteArrayIn);
            ms.Seek(0, SeekOrigin.Begin);
            var returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            var contractId = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            var contract = _db.Contracts.Find(contractId);
            var client = _db.Clients.Find(contract.ClientId);
            var property = _db.Properties.Find(contract.PropertyId);
            EnableAll();
            cbTempClient.SelectedValue = client.Id;
            cbPropertyTypes.selectedIndex = property.BuildingType == BuildingType.Residential ? 0 :
                property.BuildingType == BuildingType.Commercial ? 1 :
                property.BuildingType == BuildingType.Farm ? 2 : 3;
            cbClients.selectedIndex = cbTempClient.SelectedIndex;
            cbTempProperty.SelectedValue = property.Id;
            cbProperties.selectedIndex = cbTempProperty.SelectedIndex;
            txtPrice.Text = contract.Price.ToString(CultureInfo.InvariantCulture);
            cbPeriod.selectedIndex = contract.Period == PaymentPeriod.Day ? 0 :
                contract.Period == PaymentPeriod.Week ? 1 :
                contract.Period == PaymentPeriod.Month ? 2 : 3;
            dtpStart.Value = contract.Start;
            dtpEnd.Value = contract.End;
            rbCash.Checked = contract.Method == PaymentMethod.Cash;
            rbCheque.Checked = contract.Method == PaymentMethod.Cheque;
            rbTransform.Checked = contract.Method == PaymentMethod.Transform;
            rbPostpaid.Checked = contract.Payment == PaymentTypes.Postpaid;
            rbPrepaid.Checked = contract.Payment == PaymentTypes.Prepaid;
            txtPayEvery.Text = contract.PayEvery.ToString(CultureInfo.InvariantCulture);
            var documents = _db.ContractDocuments.Where(d => d.ContractId == contract.Id);
            dgvContract.Rows.Clear();
            foreach (var document in documents)
            {
                dgvContract.Rows.Add(ByteArrayToImage(document.Image), document.Id);
            }

            if (dgvContract.Rows.Count == 0)
                return;
            txtNum.Text = txtTotal.Text = dgvContract.Rows.Count.ToString();
            pbContract.Image = dgvContract.Rows[int.Parse(txtNum.Text) - 1].Cells[0].Value as Image;
            dgvContract.Rows[int.Parse(txtNum.Text) - 1].Selected = true;
        }

        private void EnableAll()
        {
            cbClients.Enabled = btnAddClient.Enabled = cbPropertyTypes.Enabled = cbProperties.Enabled =
                txtPrice.Enabled = dtpEnd.Enabled = dtpStart.Enabled = txtPayEvery.Enabled = cbPeriod.Enabled =
                    gbPaymentMethod.Enabled = gbPaymentType.Enabled = btnEdit.Enabled = btnDelete.Enabled = true;
        }

        private void DisableAll()
        {
            cbClients.Enabled = btnAddClient.Enabled = cbPropertyTypes.Enabled = cbProperties.Enabled =
                txtPrice.Enabled = dtpEnd.Enabled = dtpStart.Enabled = txtPayEvery.Enabled = cbPeriod.Enabled =
                    gbPaymentMethod.Enabled = gbPaymentType.Enabled = btnEdit.Enabled = btnDelete.Enabled = false;
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
            var properties = _db.Properties.Where(p => p.BuildingType == buildingType && p.Status == PropertyStatus.Rented).ToList();
            cbTempProperty.ValueMember = "Id";
            cbTempProperty.DisplayMember = "Name";
            cbTempProperty.DataSource = properties;
            foreach (var property in properties)
            {
                cbProperties.AddItem(property.Name);
            }
        }

        public void Clear()
        {
            cbClients.selectedIndex =
                cbPropertyTypes.selectedIndex = cbProperties.selectedIndex = cbPeriod.selectedIndex = -1;
            txtPrice.Text = txtPayEvery.Text = dtpEnd.Text = dtpStart.Text = "";
            rbCash.Checked = rbCheque.Checked = rbTransform.Checked = rbPostpaid.Checked = rbPrepaid.Checked = false;
            pbContract.Image = null;
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

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Multiselect = false;
                openFileDialog1.ShowDialog();
                pbContract.Image = Image.FromFile(openFileDialog1.FileName);
                dgvContract.SelectedRows[0].Cells[0].Value = null;
                dgvContract.SelectedRows[0].Cells[0].Value = pbContract.Image;
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(@"Are you sure you want to delete this contract?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;
            var contractId = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            var contract = _db.Contracts.Find(contractId);
            if (contract != null) _db.Contracts.Remove(contract);
            _db.SaveChanges();
            foreach (DataGridViewRow row in dgvContract.Rows)
            {
                var docId = int.Parse(row.Cells[1].Value.ToString());
                var document = _db.ContractDocuments.Find(docId);
                if (document != null) _db.ContractDocuments.Remove(document);
                _db.SaveChanges();
            }
            
            MessageBox.Show(@"Contract Deleted Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();
            Populate();
            DisableAll();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPrice.Text) && !string.IsNullOrWhiteSpace(txtPayEvery.Text) &&
                cbClients.selectedIndex >= 0 && cbProperties.selectedIndex >= 0 && cbPropertyTypes.selectedIndex >= 0 &&
                cbPeriod.selectedIndex > -1 && !string.IsNullOrWhiteSpace(dtpEnd.Value.ToShortDateString()) &&
                !string.IsNullOrWhiteSpace(dtpStart.Value.ToShortDateString()) &&
                (rbCash.Checked || rbCheque.Checked || rbTransform.Checked) &&
                (rbPrepaid.Checked || rbPostpaid.Checked))
            {
                var contractId = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                var contract = _db.Contracts.Find(contractId);
                if (contract == null)
                    MessageBox.Show(@"Failed to find contract", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // ReSharper disable once PossibleNullReferenceException
                contract.End = dtpEnd.Value;
                contract.Method = rbCash.Checked ? PaymentMethod.Cash :
                    rbCheque.Checked ? PaymentMethod.Cheque : PaymentMethod.Transform;
                contract.PayEvery = float.Parse(txtPayEvery.Text);
                contract.Payment = rbPrepaid.Checked ? PaymentTypes.Prepaid : PaymentTypes.Postpaid;
                contract.Period = cbPeriod.selectedIndex == 0 ? PaymentPeriod.Day :
                    cbPeriod.selectedIndex == 1 ? PaymentPeriod.Week :
                    cbPeriod.selectedIndex == 2 ? PaymentPeriod.Month : PaymentPeriod.Year;
                contract.Price = double.Parse(txtPrice.Text);
                contract.PropertyId = int.Parse(cbTempProperty.SelectedValue.ToString());
                contract.Start = dtpStart.Value;
                contract.ClientId = int.Parse(cbTempClient.SelectedValue.ToString());
                _db.SaveChanges();

                foreach (DataGridViewRow row in dgvContract.Rows)
                {
                    var docId = int.Parse(row.Cells[1].Value.ToString());
                    var document = _db.ContractDocuments.Find(docId);
                    if (document != null) document.Image = ImageToByteArray(row.Cells[0].Value as Image);
                    _db.SaveChanges();
                }

                MessageBox.Show(@"Edited Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                Populate();
                DisableAll();
            }
            else
                MessageBox.Show(@"Please fill all the fields", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    dgvContract.SelectedRows[0].Cells[0].Value = null;
                    dgvContract.SelectedRows[0].Cells[0].Value = img;
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

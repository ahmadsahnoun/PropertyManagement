using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using PropertyManagementSystem.Models;
using WIA;

namespace PropertyManagementSystem.Forms
{
    public partial class ManageClients : Form
    {
        private readonly MyDbContext _db = new MyDbContext();
        public ManageClients()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ManageClients_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void Populate()
        {
            dataGridView1.Rows.Clear();
            var clients = _db.Clients.ToList();
            // ReSharper disable once CollectionNeverQueried.Local
            foreach (var client in clients)
            {
                dataGridView1.Rows.Add(client.Id, client.Name, client.ClientType == Models.ClientType.Company? "Company":"Individual", client.Address,
                    client.Email);
            }
            dataGridView1.ClearSelection();
        }

        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            var ms = new MemoryStream(byteArrayIn);
            ms.Seek(0, SeekOrigin.Begin);
            var returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AddClient().ShowDialog();
            Populate();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            var clientId = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            var client = _db.Clients.Find(clientId);
            if (client == null) return;
            EnableAll();
            txtName.Text = client.Name;
            txtAddress.Text = client.Address;
            txtEmail.Text = client.Email;
            txtPhone.Text = client.Phone;
            rbIndividual.Checked = client.ClientType == Models.ClientType.Individual;
            rbCompany.Checked = client.ClientType == Models.ClientType.Company;
            if (rbCompany.Checked)
                pbClientLogo.Image = ByteArrayToImage(client.Logo);
            else pbClientLogo.Image = null;
        }

        private void EnableAll()
        {
            txtName.Enabled = txtAddress.Enabled = txtPhone.Enabled =
                txtEmail.Enabled =
                    rbIndividual.Enabled = rbCompany.Enabled = btnDelete.Enabled =
                        btnEdit.Enabled = btnLogoBrowse.Enabled = btnLogoScan.Enabled = true;
        }

        private void DisableAll()
        {
            txtName.Enabled = txtAddress.Enabled = txtPhone.Enabled =
                txtEmail.Enabled =
                    rbIndividual.Enabled = rbCompany.Enabled = btnDelete.Enabled =
                        btnEdit.Enabled = btnLogoBrowse.Enabled = btnLogoScan.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !string.IsNullOrWhiteSpace(txtAddress.Text) &&
                !string.IsNullOrWhiteSpace(txtEmail.Text) && !string.IsNullOrWhiteSpace(txtPhone.Text) &&
                (rbIndividual.Checked || rbCompany.Checked))
            {
                var clientId = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                var client = _db.Clients.Find(clientId);
                if (client == null)
                    MessageBox.Show(@"Failed to find client", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // ReSharper disable once PossibleNullReferenceException
                client.Name = txtName.Text;
                client.ClientType = rbIndividual.Checked ? Models.ClientType.Individual : Models.ClientType.Company;
                client.Address = txtAddress.Text;
                client.Email = txtEmail.Text;
                client.Phone = txtPhone.Text;
                client.Logo = ImageToByteArray(pbClientLogo.Image);
                _db.SaveChanges();
                MessageBox.Show(@"Edited Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                Populate();
                DisableAll();
            }
            else
                MessageBox.Show(@"Please fill all the fields", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Clear()
        {
            txtAddress.Text = txtEmail.Text = txtPhone.Text = txtName.Text = "";
            pbClientLogo.Image = null;
            rbIndividual.Checked = false;
            rbCompany.Checked = true;
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

        private void btnLogoBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Multiselect = false;
                openFileDialog1.ShowDialog();
                pbClientLogo.Image = Image.FromFile(openFileDialog1.FileName);
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(@"Are you sure you want to delete this client?", "", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;
            var clientId = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            var client = _db.Clients.Find(clientId);
            if (client != null) _db.Clients.Remove(client);
            _db.SaveChanges();
            MessageBox.Show(@"Client Deleted Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();
            Populate();
            DisableAll();
        }

        private void txtSearch_OnValueChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                var clients = _db.Clients.Where(c => c.Name.Contains(txtSearch.Text)|| c.Address.Contains(txtSearch.Text) || c.Email.Contains(txtSearch.Text) || c.Phone.Contains(txtSearch.Text)).OrderBy(c => c.Id).ToList();
                foreach (var client in clients)
                {
                    dataGridView1.Rows.Add(client.Id, client.Name,
                        client.ClientType == Models.ClientType.Company ? "Company" : "Individual", client.Address,
                        client.Email);
                }
                dataGridView1.ClearSelection();
            }
            else
                Populate();
        }

        private void pbClientLogo_DoubleClick(object sender, EventArgs e)
        {
            new ViewDocument(pbClientLogo.Image).ShowDialog();
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyNumbers(e);
        }

        private static void AllowOnlyNumbers(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void rbCompany_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCompany.Checked)
                pbClientLogo.Enabled = btnLogoScan.Enabled = btnLogoBrowse.Enabled = true;
        }

        private void rbIndividual_CheckedChanged(object sender, EventArgs e)
        {
            if (rbIndividual.Checked)
            {
                pbClientLogo.Enabled = btnLogoScan.Enabled = btnLogoBrowse.Enabled = false;
                pbClientLogo.Image = null;
            }
        }

        private void btnLogoScan_Click(object sender, EventArgs e)
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
                    pbClientLogo.Image = img;
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

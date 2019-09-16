using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using PropertyManagementSystem.Models;
using WIA;

namespace PropertyManagementSystem.Forms
{
    public partial class AddClient : Form
    {
        private readonly MyDbContext _db = new MyDbContext();
        public AddClient()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !string.IsNullOrWhiteSpace(txtAddress.Text) &&
                !string.IsNullOrWhiteSpace(txtEmail.Text) && !string.IsNullOrWhiteSpace(txtPhone.Text) &&
                (rbCompany.Checked || rbIndividual.Checked))
            {
                if ((rbCompany.Checked && pbClientLogo.Image != null) || rbIndividual.Checked)
                {
                    var client = new Client()
                    {
                        Name = txtName.Text,
                        ClientType = rbIndividual.Checked? ClientType.Individual : ClientType.Company,
                        Email = txtEmail.Text,
                        Logo = pbClientLogo.Image == null? null : ImageToByteArray(pbClientLogo.Image),
                        Phone = txtPhone.Text,
                        Address = txtAddress.Text
                    };
                    _db.Clients.Add(client);
                    _db.SaveChanges();
                    MessageBox.Show(@"Saved Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                    MessageBox.Show(@"Please fill the company logo", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show(@"Please fill all the fields", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Clear()
        {
            txtName.Text = txtPhone.Text = txtAddress.Text = txtEmail.Text = "";
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
                pbClientLogo.Enabled = btnLogoBrowse.Enabled = btnLogoScan.Enabled = true;
        }

        private void rbIndividual_CheckedChanged(object sender, EventArgs e)
        {
            if (rbIndividual.Checked)
            {
                pbClientLogo.Enabled = btnLogoBrowse.Enabled = btnLogoScan.Enabled = false;
                pbClientLogo.Image = null;
            }
        }

        private void pbClientLogo_DoubleClick(object sender, EventArgs e)
        {
            new ViewDocument(pbClientLogo.Image).ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
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
                    var imageBytes = (byte[]) imgFile.FileData.get_BinaryData();
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

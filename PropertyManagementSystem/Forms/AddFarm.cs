﻿using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using PropertyManagementSystem.Models;
using WIA;
using Property = PropertyManagementSystem.Models.Property;

namespace PropertyManagementSystem.Forms
{
    public partial class AddFarm : Form
    {
        private readonly MyDbContext _db = new MyDbContext();
        public AddFarm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOwnerBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Multiselect = false;
                openFileDialog1.ShowDialog();
                pbOwnershipDocs.Image = Image.FromFile(openFileDialog1.FileName);
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void btnDrawingBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Multiselect = false;
                openFileDialog1.ShowDialog();
                pbDrawings.Image = Image.FromFile(openFileDialog1.FileName);
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void btnOwnerConfirm_Click(object sender, EventArgs e)
        {
            if (pbOwnershipDocs.Image != null)
            {
                dgvOwnershipDocs.Rows.Add(pbOwnershipDocs.Image, 0);
                txtOwnerNum.Text = txtOwnerTotal.Text = dgvOwnershipDocs.Rows.Count.ToString();
                pbOwnershipDocs.Image = null;
            }
            else
            {
                MessageBox.Show(@"Please upload or scan first", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtOwnerNum_TextChanged(object sender, EventArgs e)
        {
            pbOwnerLeft.Enabled = pbOwnerRight.Enabled = true;

            if (int.Parse(txtOwnerNum.Text) <= 1)
            {
                pbOwnerLeft.Enabled = false;
            }

            if (int.Parse(txtOwnerNum.Text) == int.Parse(txtOwnerTotal.Text))
            {
                pbOwnerRight.Enabled = false;
            }
        }

        private void pbOwnerLeft_Click(object sender, EventArgs e)
        {
            txtOwnerNum.Text = (int.Parse(txtOwnerNum.Text) - 1).ToString();
            if (int.Parse(txtOwnerNum.Text) <= 1)
                pbOwnerLeft.Enabled = false;
            pbOwnershipDocs.Image = dgvOwnershipDocs.Rows[int.Parse(txtOwnerNum.Text) - 1].Cells[0].Value as Image;
        }

        private void pbOwnerRight_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtOwnerNum.Text) == int.Parse(txtOwnerTotal.Text))
            {
                pbOwnerLeft.Enabled = true;
                pbOwnerRight.Enabled = false;
            }
            if (int.Parse(txtOwnerNum.Text) > 1)
                pbOwnerLeft.Enabled = true;
            txtOwnerNum.Text = (int.Parse(txtOwnerNum.Text) + 1).ToString();
            pbOwnershipDocs.Image = dgvOwnershipDocs.Rows[int.Parse(txtOwnerNum.Text) - 1].Cells[0].Value as Image;
        }

        private void btnDrawingConfirm_Click(object sender, EventArgs e)
        {
            if (pbDrawings.Image != null)
            {
                dgvBuildingDrawings.Rows.Add(pbDrawings.Image, 0);
                txtDrawingNum.Text = txtDrawingTotal.Text = dgvBuildingDrawings.Rows.Count.ToString();
                pbDrawings.Image = null;
            }
            else
            {
                MessageBox.Show(@"Please upload or scan first", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbDrawingLeft_Click(object sender, EventArgs e)
        {
            txtDrawingNum.Text = (int.Parse(txtDrawingNum.Text) - 1).ToString();
            if (int.Parse(txtDrawingNum.Text) <= 1)
                pbDrawingLeft.Enabled = false;
            pbDrawings.Image = dgvBuildingDrawings.Rows[int.Parse(txtDrawingNum.Text) - 1].Cells[0].Value as Image;
        }

        private void txtDrawingNum_TextChanged(object sender, EventArgs e)
        {
            pbDrawingLeft.Enabled = pbDrawingRight.Enabled = true;

            if (int.Parse(txtDrawingNum.Text) <= 1)
            {
                pbDrawingLeft.Enabled = false;
            }

            if (int.Parse(txtDrawingNum.Text) == int.Parse(txtDrawingTotal.Text))
            {
                pbDrawingRight.Enabled = false;
            }
        }

        private void pbDrawingRight_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtDrawingNum.Text) == int.Parse(txtDrawingTotal.Text))
            {
                pbDrawingLeft.Enabled = true;
                pbDrawingRight.Enabled = false;
            }
            if (int.Parse(txtDrawingNum.Text) > 1)
                pbDrawingLeft.Enabled = true;
            txtDrawingNum.Text = (int.Parse(txtDrawingNum.Text) + 1).ToString();
            pbDrawings.Image = dgvBuildingDrawings.Rows[int.Parse(txtDrawingNum.Text) - 1].Cells[0].Value as Image;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !string.IsNullOrWhiteSpace(txtTotalArea.Text) &&
                !string.IsNullOrWhiteSpace(txtAddress.Text) &&
                !string.IsNullOrWhiteSpace(txtLocationUrl.Text) && cbUnit.selectedIndex > -1)
            {
                if (dgvBuildingDrawings.Rows.Count > 0 && dgvOwnershipDocs.Rows.Count > 0)
                {
                    var property = new Property()
                    {
                        BuildingType = BuildingType.Farm,
                        Location = txtAddress.Text,
                        LocationUrl = txtLocationUrl.Text,
                        Name = txtName.Text,
                        TotalArea = double.Parse(txtTotalArea.Text),
                        MeasureUnit = cbUnit.selectedValue == @"Meter" ? MeasureUnits.Meter : MeasureUnits.Hectare,
                        Status = PropertyStatus.Free
                    };
                    _db.Properties.Add(property);
                    _db.SaveChanges();
                    PropertyDocument document;

                    foreach (DataGridViewRow row in dgvBuildingDrawings.Rows)
                    {
                        document = new PropertyDocument()
                        {
                            Image = ImageToByteArray(row.Cells[0].Value as Image),
                            PropertyId = property.Id,
                            DocumentType = DocumentType.BuildingDrawing
                        };
                        _db.PropertyDocuments.Add(document);
                        _db.SaveChanges();
                    }

                    foreach (DataGridViewRow row in dgvOwnershipDocs.Rows)
                    {
                        document = new PropertyDocument()
                        {
                            Image = ImageToByteArray(row.Cells[0].Value as Image),
                            PropertyId = property.Id,
                            DocumentType = DocumentType.OwnershipDoc
                        };
                        _db.PropertyDocuments.Add(document);
                        _db.SaveChanges();
                    }

                    MessageBox.Show(@"Saved Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                    MessageBox.Show(@"Please upload or scan all the documents", "", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            else
                MessageBox.Show(@"Please fill all the fields", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Clear()
        {
            txtName.Text = txtTotalArea.Text = txtTotalArea.Text = txtAddress.Text = txtLocationUrl.Text = "";
            dgvOwnershipDocs.Rows.Clear();
            dgvBuildingDrawings.Rows.Clear();
            pbOwnershipDocs.Image = pbDrawings.Image = null;
            pbDrawingLeft.Enabled = pbOwnerLeft.Enabled = pbDrawingRight.Enabled = pbOwnerRight.Enabled = false;
            txtDrawingNum.Text = txtOwnerNum.Text = txtDrawingTotal.Text = txtOwnerTotal.Text = @"0";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pbDrawings_DoubleClick(object sender, EventArgs e)
        {
            new ViewDocument(pbDrawings.Image).ShowDialog();
        }

        private void pbOwnershipDocs_DoubleClick(object sender, EventArgs e)
        {
            new ViewDocument(pbOwnershipDocs.Image).ShowDialog();
        }

        private void txtTotalArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyNumbers(sender, e);
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

        private void btnDrawingScan_Click(object sender, EventArgs e)
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
                    pbDrawings.Image = img;
                }
                else
                    MessageBox.Show(@"Sorry, no scanner is available", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (COMException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOwnerScan_Click(object sender, EventArgs e)
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
                    pbOwnershipDocs.Image = img;
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

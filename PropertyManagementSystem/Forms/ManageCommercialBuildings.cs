using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using PropertyManagementSystem.Models;
using WIA;

namespace PropertyManagementSystem.Forms
{
    public partial class ManageCommercialBuildings : Form
    {
        private readonly MyDbContext _db = new MyDbContext();
        public ManageCommercialBuildings()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AddCommercialBuilding().ShowDialog();
            Populate();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ManageCommercialBuildings_Load(object sender, EventArgs e)
        {
            Populate();
            CheckPermission();
        }

        private void CheckPermission()
        {
            if (CurrentUser.UserType == UserType.Administrator)
                return;
            txtName.Enabled = txtAddress.Enabled = txtBuiltArea.Enabled = txtNotBuiltArea.Enabled = cbUnit.Enabled =
                txtLocationUrl.Enabled = txtNoOfFloors.Enabled =
                    btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnOwnerBrowse.Enabled =
                        btnDrawingBrowse.Enabled = btnImgBrowse.Enabled =
                            btnDrawingScan.Enabled = btnImgScan.Enabled = btnOwnerScan.Enabled = false;
        }

        private void Populate()
        {
            listView1.Items.Clear();
            var properties = _db.Properties.Where(p => p.BuildingType == BuildingType.Commercial).OrderBy(p => p.Id).ToList();
            // ReSharper disable once CollectionNeverQueried.Local
            var documents = new List<PropertyDocument>();
            foreach (var property in properties)
            {
                var doc = _db.PropertyDocuments.FirstOrDefault(pd => pd.PropertyId == property.Id);
                documents.Add(doc);
            }

            listView1.Columns.Add("Property Name", 300);
            var imgList = new ImageList { ImageSize = new Size(100, 100) };
            foreach (var propertyDocument in documents)
            {
                var image = ByteArrayToImage(propertyDocument.Image);
                imgList.Images.Add(image);
            }

            listView1.LargeImageList = imgList;
            var count = 0;
            foreach (var property in properties)
            {
                listView1.Items.Add(property.Id.ToString(), property.Name, count);
                count++;
            }
        }
        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            var ms = new MemoryStream(byteArrayIn);
            ms.Seek(0, SeekOrigin.Begin);
            var returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            var propertyId = int.Parse(listView1.SelectedItems[0].Name);
            var property = _db.Properties.Find(propertyId);
            EnableAll();
            if (property == null) return;
            txtName.Text = property.Name;
            txtStatus.Text = property.Status.ToString();
            txtBuiltArea.Text = property.BuiltArea.ToString(CultureInfo.CurrentCulture);
            txtNotBuiltArea.Text = property.NotBuiltArea.ToString(CultureInfo.CurrentCulture);
            txtTotalArea.Text = (int.Parse(txtBuiltArea.Text) + int.Parse(txtNotBuiltArea.Text)).ToString();
            cbUnit.selectedIndex = property.MeasureUnit.ToString().Equals("Meter") ? 0 : 1;
            txtAddress.Text = property.Location;
            txtLocationUrl.Text = property.LocationUrl;
            txtNoOfFloors.Text = property.NoOfFloors.ToString();
            var documents = _db.PropertyDocuments.Where(pd => pd.PropertyId == property.Id).ToList();
            dgvBuildingImages.Rows.Clear();
            dgvOwnershipDocs.Rows.Clear();
            dgvBuildingDrawings.Rows.Clear();
            foreach (var document in documents)
            {
                switch (document.DocumentType)
                {
                    case DocumentType.BuildingDrawing:
                        dgvBuildingDrawings.Rows.Add(ByteArrayToImage(document.Image), document.Id);
                        break;
                    case DocumentType.BuildingImage:
                        dgvBuildingImages.Rows.Add(ByteArrayToImage(document.Image), document.Id);
                        break;
                    case DocumentType.OwnershipDoc:
                        dgvOwnershipDocs.Rows.Add(ByteArrayToImage(document.Image), document.Id);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            if (dgvBuildingImages.Rows.Count == 0 || dgvOwnershipDocs.Rows.Count == 0 ||
                dgvBuildingDrawings.Rows.Count == 0)
                return;
            txtImgNum.Text = txtImgTotal.Text = dgvBuildingImages.Rows.Count.ToString();
            pbBuildingImages.Image = dgvBuildingImages.Rows[int.Parse(txtImgNum.Text) - 1].Cells[0].Value as Image;
            dgvBuildingImages.Rows[int.Parse(txtImgNum.Text) - 1].Selected = true;
            txtDrawingNum.Text = txtDrawingTotal.Text = dgvBuildingDrawings.Rows.Count.ToString();
            pbDrawings.Image = dgvBuildingDrawings.Rows[int.Parse(txtDrawingNum.Text) - 1].Cells[0].Value as Image;
            dgvBuildingDrawings.Rows[int.Parse(txtDrawingNum.Text) - 1].Selected = true;
            txtOwnerNum.Text = txtOwnerTotal.Text = dgvOwnershipDocs.Rows.Count.ToString();
            pbOwnershipDocs.Image = dgvOwnershipDocs.Rows[int.Parse(txtOwnerNum.Text) - 1].Cells[0].Value as Image;
            dgvOwnershipDocs.Rows[int.Parse(txtOwnerNum.Text) - 1].Selected = true;
            CheckPermission();
        }

        private void EnableAll()
        {
            txtName.Enabled = txtAddress.Enabled = txtBuiltArea.Enabled = txtNotBuiltArea.Enabled =
                cbUnit.Enabled = txtLocationUrl.Enabled = btnEdit.Enabled = btnDelete.Enabled = txtNoOfFloors.Enabled =  true;
        }

        private void DisableAll()
        {
            txtName.Enabled = txtAddress.Enabled = txtBuiltArea.Enabled = txtNotBuiltArea.Enabled =
                cbUnit.Enabled = txtLocationUrl.Enabled = btnEdit.Enabled = btnDelete.Enabled = txtNoOfFloors.Enabled =  false;
        }

        private void txtImgNum_TextChanged(object sender, EventArgs e)
        {
            pbImgLeft.Enabled = pbImgRight.Enabled = true;

            if (int.Parse(txtImgNum.Text) <= 1)
            {
                pbImgLeft.Enabled = false;
            }

            if (int.Parse(txtImgNum.Text) == int.Parse(txtImgTotal.Text))
            {
                pbImgRight.Enabled = false;
            }
        }

        private void pbImgLeft_Click(object sender, EventArgs e)
        {
            txtImgNum.Text = (int.Parse(txtImgNum.Text) - 1).ToString();
            if (int.Parse(txtImgNum.Text) <= 1)
                pbImgLeft.Enabled = false;
            pbBuildingImages.Image = dgvBuildingImages.Rows[int.Parse(txtImgNum.Text) - 1].Cells[0].Value as Image;
            dgvBuildingImages.Rows[int.Parse(txtImgNum.Text) - 1].Selected = true;
        }

        private void pbImgRight_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtImgNum.Text) == int.Parse(txtImgTotal.Text))
            {
                pbImgLeft.Enabled = true;
                pbImgRight.Enabled = false;
            }
            if (int.Parse(txtImgNum.Text) > 1)
                pbImgLeft.Enabled = true;
            txtImgNum.Text = (int.Parse(txtImgNum.Text) + 1).ToString();
            pbBuildingImages.Image = dgvBuildingImages.Rows[int.Parse(txtImgNum.Text) - 1].Cells[0].Value as Image;
            dgvBuildingImages.Rows[int.Parse(txtImgNum.Text) - 1].Selected = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !string.IsNullOrWhiteSpace(txtBuiltArea.Text) &&
                !string.IsNullOrWhiteSpace(txtNotBuiltArea.Text) && !string.IsNullOrWhiteSpace(txtAddress.Text) &&
                !string.IsNullOrWhiteSpace(txtLocationUrl.Text) && !string.IsNullOrWhiteSpace(txtNoOfFloors.Text) &&
                cbUnit.selectedIndex > -1)
            {
                var propertyId = int.Parse(listView1.SelectedItems[0].Name);
                var property = _db.Properties.Find(propertyId);
                if (property == null)
                    MessageBox.Show(@"Failed to find property", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // ReSharper disable once PossibleNullReferenceException
                property.Name = txtName.Text;
                property.BuiltArea = double.Parse(txtBuiltArea.Text);
                property.NotBuiltArea = double.Parse(txtNotBuiltArea.Text);
                property.MeasureUnit = cbUnit.selectedIndex == 0 ? MeasureUnits.Meter : MeasureUnits.Hectare;
                property.Location = txtAddress.Text;
                property.LocationUrl = txtLocationUrl.Text;
                property.NoOfFloors = int.Parse(txtNoOfFloors.Text);
                _db.SaveChanges();
                foreach (DataGridViewRow row in dgvBuildingImages.Rows)
                {
                    var docId = int.Parse(row.Cells[1].Value.ToString());
                    var document = _db.PropertyDocuments.Find(docId);
                    if (document != null) document.Image = ImageToByteArray(row.Cells[0].Value as Image);
                    _db.SaveChanges();
                }

                foreach (DataGridViewRow row in dgvBuildingDrawings.Rows)
                {
                    var docId = int.Parse(row.Cells[1].Value.ToString());
                    var document = _db.PropertyDocuments.Find(docId);
                    if (document != null) document.Image = ImageToByteArray(row.Cells[0].Value as Image);
                    _db.SaveChanges();
                }

                foreach (DataGridViewRow row in dgvOwnershipDocs.Rows)
                {
                    var docId = int.Parse(row.Cells[1].Value.ToString());
                    var document = _db.PropertyDocuments.Find(docId);
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

        private void Clear()
        {
            txtName.Text = txtBuiltArea.Text =
                txtNotBuiltArea.Text = txtTotalArea.Text =
                    txtAddress.Text = txtLocationUrl.Text = txtStatus.Text = txtNoOfFloors.Text = "";
            dgvBuildingImages.Rows.Clear();
            dgvOwnershipDocs.Rows.Clear();
            dgvBuildingDrawings.Rows.Clear();
            pbOwnershipDocs.Image = pbBuildingImages.Image = pbDrawings.Image = null;
            pbDrawingLeft.Enabled = pbImgLeft.Enabled = pbOwnerLeft.Enabled = pbImgRight.Enabled =
                pbDrawingRight.Enabled = pbOwnerRight.Enabled = btnEdit.Enabled = btnDelete.Enabled = false;
            txtImgNum.Text = txtDrawingNum.Text =
                txtOwnerNum.Text = txtImgTotal.Text = txtDrawingTotal.Text = txtOwnerTotal.Text = @"0";
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

        private void pbDrawingLeft_Click(object sender, EventArgs e)
        {
            txtDrawingNum.Text = (int.Parse(txtDrawingNum.Text) - 1).ToString();
            if (int.Parse(txtDrawingNum.Text) <= 1)
                pbDrawingLeft.Enabled = false;
            pbDrawings.Image = dgvBuildingDrawings.Rows[int.Parse(txtDrawingNum.Text) - 1].Cells[0].Value as Image;
            dgvBuildingDrawings.Rows[int.Parse(txtDrawingNum.Text) - 1].Selected = true;
        }

        private void pbDrawingRight_Click_1(object sender, EventArgs e)
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
            dgvBuildingDrawings.Rows[int.Parse(txtDrawingNum.Text) - 1].Selected = true;
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

        private void pbOwnerLeft_Click(object sender, EventArgs e)
        {
            txtOwnerNum.Text = (int.Parse(txtOwnerNum.Text) - 1).ToString();
            if (int.Parse(txtOwnerNum.Text) <= 1)
                pbOwnerLeft.Enabled = false;
            pbOwnershipDocs.Image = dgvOwnershipDocs.Rows[int.Parse(txtOwnerNum.Text) - 1].Cells[0].Value as Image;
            dgvOwnershipDocs.Rows[int.Parse(txtOwnerNum.Text) - 1].Selected = true;
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
            dgvOwnershipDocs.Rows[int.Parse(txtOwnerNum.Text) - 1].Selected = true;
        }

        private void btnImgBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Multiselect = false;
                openFileDialog1.ShowDialog();
                pbBuildingImages.Image = Image.FromFile(openFileDialog1.FileName);
                dgvBuildingImages.SelectedRows[0].Cells[0].Value = null;
                dgvBuildingImages.SelectedRows[0].Cells[0].Value = pbBuildingImages.Image;
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void btnOwnerBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Multiselect = false;
                openFileDialog1.ShowDialog();
                pbOwnershipDocs.Image = Image.FromFile(openFileDialog1.FileName);
                dgvOwnershipDocs.SelectedRows[0].Cells[0].Value = null;
                dgvOwnershipDocs.SelectedRows[0].Cells[0].Value = pbOwnershipDocs.Image;
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
                dgvBuildingDrawings.SelectedRows[0].Cells[0].Value = null;
                dgvBuildingDrawings.SelectedRows[0].Cells[0].Value = pbDrawings.Image;
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void txtImgTotal_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(txtImgTotal.Text) == 0)
            {
                btnImgBrowse.Enabled = btnImgScan.Enabled = false;
            }
            else
            {
                btnImgBrowse.Enabled = btnImgScan.Enabled = true;
            }
        }

        private void txtDrawingTotal_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(txtDrawingTotal.Text) == 0)
            {
                btnDrawingBrowse.Enabled = btnDrawingScan.Enabled = false;
            }
            else
            {
                btnDrawingBrowse.Enabled = btnDrawingScan.Enabled = true;
            }
        }

        private void txtOwnerTotal_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(txtOwnerTotal.Text) == 0)
                btnOwnerScan.Enabled = btnOwnerBrowse.Enabled = false;
            else
                btnOwnerScan.Enabled = btnOwnerBrowse.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(@"Are you sure you want to delete this property?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;
            var propertyId = int.Parse(listView1.SelectedItems[0].Name);
            var property = _db.Properties.Find(propertyId);
            if (property != null) _db.Properties.Remove(property);
            _db.SaveChanges();
            foreach (DataGridViewRow row in dgvBuildingImages.Rows)
            {
                var docId = int.Parse(row.Cells[1].Value.ToString());
                var document = _db.PropertyDocuments.Find(docId);
                if (document != null) _db.PropertyDocuments.Remove(document);
                _db.SaveChanges();
            }
            foreach (DataGridViewRow row in dgvBuildingDrawings.Rows)
            {
                var docId = int.Parse(row.Cells[1].Value.ToString());
                var document = _db.PropertyDocuments.Find(docId);
                if (document != null) _db.PropertyDocuments.Remove(document);
                _db.SaveChanges();
            }
            foreach (DataGridViewRow row in dgvOwnershipDocs.Rows)
            {
                var docId = int.Parse(row.Cells[1].Value.ToString());
                var document = _db.PropertyDocuments.Find(docId);
                if (document != null) _db.PropertyDocuments.Remove(document);
                _db.SaveChanges();
            }
            MessageBox.Show(@"Property Deleted Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();
            Populate();
            DisableAll();
        }

        private void txtSearch_OnValueChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                var properties = _db.Properties.Where(p =>
                    p.BuildingType == BuildingType.Commercial && p.Name.Contains(txtSearch.Text)).OrderBy(p => p.Id).ToList();
                var documents = new List<PropertyDocument>();
                foreach (var property in properties)
                {
                    var doc = _db.PropertyDocuments.FirstOrDefault(pd => pd.PropertyId == property.Id);
                    documents.Add(doc);
                }

                listView1.Columns.Add("Property Name", 300);
                var imgList = new ImageList { ImageSize = new Size(100, 100) };
                foreach (var propertyDocument in documents)
                {
                    var image = ByteArrayToImage(propertyDocument.Image);
                    imgList.Images.Add(image);
                }

                listView1.LargeImageList = imgList;
                var count = 0;
                foreach (var property in properties)
                {
                    listView1.Items.Add(property.Id.ToString(), property.Name, count);
                    count++;
                }
            }
            else
                Populate();
        }

        private void txtBuiltArea_KeyPress(object sender, KeyPressEventArgs e)
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
            if (e.KeyChar == '.' && ((BunifuMaterialTextbox) sender).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtNotBuiltArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyNumbers(sender, e);
        }

        private void txtNoOfFloors_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyNumbersFloor(sender, e);
        }

        public void AllowOnlyNumbersFloor(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void pbBuildingImages_DoubleClick(object sender, EventArgs e)
        {
            new ViewDocument(pbBuildingImages.Image).ShowDialog();
        }

        private void pbDrawings_DoubleClick(object sender, EventArgs e)
        {
            new ViewDocument(pbDrawings.Image).ShowDialog();
        }

        private void pbOwnershipDocs_DoubleClick(object sender, EventArgs e)
        {
            new ViewDocument(pbOwnershipDocs.Image).ShowDialog();
        }

        private void txtBuiltArea_Leave(object sender, EventArgs e)
        {
            txtTotalArea.Text = (int.Parse(string.IsNullOrWhiteSpace(txtBuiltArea.Text) ? "0" : txtBuiltArea.Text) +
                                 int.Parse(string.IsNullOrWhiteSpace(txtNotBuiltArea.Text)
                                     ? "0"
                                     : txtNotBuiltArea.Text)).ToString();
        }

        private void txtNotBuiltArea_Leave(object sender, EventArgs e)
        {
            txtTotalArea.Text = (int.Parse(string.IsNullOrWhiteSpace(txtBuiltArea.Text) ? "0" : txtBuiltArea.Text) +
                                 int.Parse(string.IsNullOrWhiteSpace(txtNotBuiltArea.Text)
                                     ? "0"
                                     : txtNotBuiltArea.Text)).ToString();
        }

        private void btnImgScan_Click(object sender, EventArgs e)
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
                    pbBuildingImages.Image = img;
                    dgvBuildingImages.SelectedRows[0].Cells[0].Value = null;
                    dgvBuildingImages.SelectedRows[0].Cells[0].Value = img;
                }
                else
                    MessageBox.Show(@"Sorry, no scanner is available", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (COMException ex)
            {
                MessageBox.Show(ex.Message);
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
                    dgvBuildingDrawings.SelectedRows[0].Cells[0].Value = null;
                    dgvBuildingDrawings.SelectedRows[0].Cells[0].Value = img;
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
                    dgvOwnershipDocs.SelectedRows[0].Cells[0].Value = null;
                    dgvOwnershipDocs.SelectedRows[0].Cells[0].Value = img;
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

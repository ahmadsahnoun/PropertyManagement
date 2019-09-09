using System;
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
    public partial class ManageWarehouses : Form
    {
        private readonly MyDbContext _db = new MyDbContext();
        public ManageWarehouses()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ManageWarehouses_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void Populate()
        {
            dataGridView1.Rows.Clear();
            var properties = _db.Properties.Where(p => p.BuildingType == BuildingType.Warehouse).OrderBy(p => p.Id).ToList();
            // ReSharper disable once CollectionNeverQueried.Local
            foreach (var property in properties)
            {
                dataGridView1.Rows.Add(property.Id, property.Name, property.TotalArea, property.Location,
                    property.LocationUrl);
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
            new AddWarehouse().ShowDialog();
            Populate();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            var propertyId = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            var property = _db.Properties.Find(propertyId);
            if (property == null) return;
            EnableAll();
            txtName.Text = property.Name;
            txtStatus.Text = property.Status.ToString();
            txtCoveredArea.Text = property.CoveredArea.ToString(CultureInfo.InvariantCulture);
            txtNotCoveredArea.Text = property.NotCoveredArea.ToString(CultureInfo.InvariantCulture);
            txtTotalArea.Text = property.TotalArea.ToString(CultureInfo.InvariantCulture);
            cbUnit.selectedIndex = property.MeasureUnit.ToString().Equals("Meter") ? 0 : 1;
            txtAddress.Text = property.Location;
            txtLocationUrl.Text = property.LocationUrl;
            var documents = _db.PropertyDocuments.Where(pd => pd.PropertyId == propertyId).ToList();
            dgvOwnershipDocs.Rows.Clear();
            dgvOwnershipDocs.Rows.Clear();
            dgvBuildingDrawings.Rows.Clear();
            foreach (var document in documents)
            {
                switch (document.DocumentType)
                {
                    case DocumentType.BuildingDrawing:
                        dgvBuildingDrawings.Rows.Add(ByteArrayToImage(document.Image), document.Id);
                        break;
                    case DocumentType.OwnershipDoc:
                        dgvOwnershipDocs.Rows.Add(ByteArrayToImage(document.Image), document.Id);
                        break;
                    case DocumentType.BuildingImage:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            if (dgvOwnershipDocs.Rows.Count == 0 || dgvBuildingDrawings.Rows.Count == 0)
                return;
            txtDrawingNum.Text = txtDrawingTotal.Text = dgvBuildingDrawings.Rows.Count.ToString();
            pbDrawings.Image = dgvBuildingDrawings.Rows[int.Parse(txtDrawingNum.Text) - 1].Cells[0].Value as Image;
            dgvBuildingDrawings.Rows[int.Parse(txtDrawingNum.Text) - 1].Selected = true;
            txtOwnerNum.Text = txtOwnerTotal.Text = dgvOwnershipDocs.Rows.Count.ToString();
            pbOwnershipDocs.Image = dgvOwnershipDocs.Rows[int.Parse(txtOwnerNum.Text) - 1].Cells[0].Value as Image;
            dgvOwnershipDocs.Rows[int.Parse(txtOwnerNum.Text) - 1].Selected = true;
        }
        private void EnableAll()
        {
            txtName.Enabled = txtAddress.Enabled = txtCoveredArea.Enabled = txtNotCoveredArea.Enabled =
                cbUnit.Enabled = txtLocationUrl.Enabled = btnEdit.Enabled = btnDelete.Enabled = true;
        }

        private void DisableAll()
        {
            txtName.Enabled = txtAddress.Enabled = txtCoveredArea.Enabled = txtNotCoveredArea.Enabled =
                cbUnit.Enabled = txtLocationUrl.Enabled = btnEdit.Enabled = btnDelete.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !string.IsNullOrWhiteSpace(txtCoveredArea.Text) &&
                !string.IsNullOrWhiteSpace(txtNotCoveredArea.Text) && !string.IsNullOrWhiteSpace(txtAddress.Text) &&
                !string.IsNullOrWhiteSpace(txtLocationUrl.Text) && cbUnit.selectedIndex > -1)
            {
                var propertyId = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                var property = _db.Properties.Find(propertyId);
                if (property == null)
                    MessageBox.Show(@"Failed to find property", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // ReSharper disable once PossibleNullReferenceException
                property.Name = txtName.Text;
                property.CoveredArea = double.Parse(txtCoveredArea.Text);
                property.NotCoveredArea = double.Parse(txtNotCoveredArea.Text);
                property.MeasureUnit = cbUnit.selectedIndex == 0 ? MeasureUnits.Meter : MeasureUnits.Hectare;
                property.Location = txtAddress.Text;
                property.LocationUrl = txtLocationUrl.Text;
                _db.SaveChanges();

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
            txtName.Text = txtTotalArea.Text = txtAddress.Text = txtLocationUrl.Text =
                txtStatus.Text = txtCoveredArea.Text = txtNotCoveredArea.Text = "";
            dgvOwnershipDocs.Rows.Clear();
            dgvBuildingDrawings.Rows.Clear();
            pbOwnershipDocs.Image = pbDrawings.Image = null;
            pbDrawingLeft.Enabled = pbOwnerLeft.Enabled = pbDrawingRight.Enabled =
                pbOwnerRight.Enabled = btnEdit.Enabled = btnDelete.Enabled = false;
            txtDrawingNum.Text = txtOwnerNum.Text = txtDrawingTotal.Text = txtOwnerTotal.Text = @"0";
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
            dgvBuildingDrawings.Rows[int.Parse(txtDrawingNum.Text) - 1].Selected = true; if (int.Parse(txtDrawingNum.Text) == int.Parse(txtDrawingTotal.Text))
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
            var result = MessageBox.Show(@"Are you sure you want to delete this Warehouse?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;
            var propertyId = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            var property = _db.Properties.Find(propertyId);
            if (property != null) _db.Properties.Remove(property);
            _db.SaveChanges();
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
            MessageBox.Show(@"Warehouse Deleted Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();
            Populate();
            DisableAll();
        }

        private void txtSearch_OnValueChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                var properties = _db.Properties.Where(p =>
                    p.BuildingType == BuildingType.Farm && p.Name.Contains(txtSearch.Text)).OrderBy(p => p.Id).ToList();

                foreach (var property in properties)
                {
                    dataGridView1.Rows.Add(property.Id, property.Name, property.TotalArea, property.Location,
                        property.LocationUrl);
                }
                dataGridView1.ClearSelection();
            }
            else
                Populate();
        }

        private void pbOwnershipDocs_DockChanged(object sender, EventArgs e)
        {
            new ViewDocument(pbOwnershipDocs.Image).ShowDialog();
        }

        private void pbDrawings_DoubleClick(object sender, EventArgs e)
        {
            new ViewDocument(pbDrawings.Image).ShowDialog();
        }

        private void txtCoveredArea_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNotCoveredArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyNumbers(sender, e);
        }

        private void txtCoveredArea_Leave(object sender, EventArgs e)
        {
            txtTotalArea.Text = (int.Parse(string.IsNullOrWhiteSpace(txtCoveredArea.Text) ? "0" : txtCoveredArea.Text) +
                                 int.Parse(string.IsNullOrWhiteSpace(txtNotCoveredArea.Text)
                                     ? "0"
                                     : txtNotCoveredArea.Text)).ToString();
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
    }
}

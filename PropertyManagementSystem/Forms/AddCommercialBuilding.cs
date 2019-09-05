using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using PropertyManagementSystem.Models;

namespace PropertyManagementSystem.Forms
{
    public partial class AddCommercialBuilding : Form
    {
        private readonly MyDbContext _db = new MyDbContext();
        public AddCommercialBuilding()
        {
            InitializeComponent();
        }

        private void AddCommercialBuilding_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImgBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Multiselect = false;
                openFileDialog1.ShowDialog();
                pbBuildingImages.Image = Image.FromFile(openFileDialog1.FileName);
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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

        private void btnImgConfirm_Click(object sender, EventArgs e)
        {
            if (pbBuildingImages.Image != null)
            {
                dgvBuildingImages.Rows.Add(pbBuildingImages.Image, 0);
                txtImgNum.Text = txtImgTotal.Text = dgvBuildingImages.Rows.Count.ToString();
                pbBuildingImages.Image = null;
            }
            else
            {
                MessageBox.Show(@"Please upload or scan first", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void pbImgLeft_Click(object sender, EventArgs e)
        {
            txtImgNum.Text = (int.Parse(txtImgNum.Text) - 1).ToString();
            if (int.Parse(txtImgNum.Text) <= 1)
                pbImgLeft.Enabled = false;
            pbBuildingImages.Image = dgvBuildingImages.Rows[int.Parse(txtImgNum.Text) - 1].Cells[0].Value as Image;
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
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !string.IsNullOrWhiteSpace(txtBuiltArea.Text) &&
                !string.IsNullOrWhiteSpace(txtNotBuiltArea.Text) && !string.IsNullOrWhiteSpace(txtAddress.Text) &&
                !string.IsNullOrWhiteSpace(txtLocationUrl.Text) && !string.IsNullOrWhiteSpace(txtNoOfFloors.Text) &&
                cbUnit.selectedIndex > -1)
            {
                if (dgvBuildingImages.Rows.Count > 0 && dgvBuildingDrawings.Rows.Count > 0 &&
                    dgvOwnershipDocs.Rows.Count > 0)
                {
                    var property = new Property()
                    {
                        BuildingType = BuildingType.Commercial,
                        Location = txtAddress.Text,
                        LocationUrl = txtLocationUrl.Text,
                        Name = txtName.Text,
                        BuiltArea = double.Parse(txtBuiltArea.Text),
                        NotBuiltArea = double.Parse(txtNotBuiltArea.Text),
                        MeasureUnit = cbUnit.selectedValue == @"Meter" ? MeasureUnits.Meter : MeasureUnits.Hectare,
                        Status = PropertyStatus.Free,
                        NoOfFloors = int.Parse(txtNoOfFloors.Text)
                    };
                    _db.Properties.Add(property);
                    _db.SaveChanges();
                    PropertyDocument document;
                    foreach (DataGridViewRow row in dgvBuildingImages.Rows)
                    {
                        document = new PropertyDocument()
                        {
                            Image = ImageToByteArray(row.Cells[0].Value as Image),
                            PropertyId = property.Id,
                            DocumentType = DocumentType.BuildingImage
                        };
                        _db.PropertyDocuments.Add(document);
                        _db.SaveChanges();
                    }

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
            txtName.Text = txtBuiltArea.Text =
                txtNotBuiltArea.Text = txtTotalArea.Text = txtAddress.Text = txtLocationUrl.Text = txtNoOfFloors.Text = "";
            dgvBuildingImages.Rows.Clear();
            dgvOwnershipDocs.Rows.Clear();
            dgvBuildingDrawings.Rows.Clear();
            pbOwnershipDocs.Image = pbBuildingImages.Image = pbDrawings.Image = null;
            pbDrawingLeft.Enabled = pbImgLeft.Enabled = pbOwnerLeft.Enabled =
                pbImgRight.Enabled = pbDrawingRight.Enabled = pbOwnerRight.Enabled = false;
            txtImgNum.Text = txtDrawingNum.Text =
                txtOwnerNum.Text = txtImgTotal.Text = txtDrawingTotal.Text = txtOwnerTotal.Text = @"0";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
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

        private void txtNoOfFloors_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTotalArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyNumbers(sender, e);
        }

        private void txtBuiltArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyNumbers(sender, e);
        }

        private void txtNotBuiltArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyNumbers(sender, e);
        }

        private void pbBuildingImages_DoubleClick(object sender, EventArgs e)
        {
            new ViewDocument(pbBuildingImages.Image).ShowDialog();
        }

        private void pbOwnershipDocs_DoubleClick(object sender, EventArgs e)
        {
            new ViewDocument(pbOwnershipDocs.Image).ShowDialog();
        }

        private void pbDrawings_DoubleClick(object sender, EventArgs e)
        {
            new ViewDocument(pbDrawings.Image).ShowDialog();
        }
    }
}

namespace PropertyManagementSystem.Forms
{
    partial class AddFarm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFarm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnDrawingConfirm = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnOwnerConfirm = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgvBuildingDrawings = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOwnershipDocs = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDrawingTotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtOwnerTotal = new System.Windows.Forms.TextBox();
            this.btnOwnerScan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDrawingScan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDrawingBrowse = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnOwnerBrowse = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDrawingNum = new System.Windows.Forms.TextBox();
            this.pbDrawingLeft = new System.Windows.Forms.PictureBox();
            this.pbDrawingRight = new System.Windows.Forms.PictureBox();
            this.txtOwnerNum = new System.Windows.Forms.TextBox();
            this.pbOwnerLeft = new System.Windows.Forms.PictureBox();
            this.pbOwnerRight = new System.Windows.Forms.PictureBox();
            this.pbDrawings = new System.Windows.Forms.PictureBox();
            this.pbOwnershipDocs = new System.Windows.Forms.PictureBox();
            this.cbUnit = new Bunifu.Framework.UI.BunifuDropdown();
            this.label15 = new System.Windows.Forms.Label();
            this.txtLocationUrl = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtAddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTotalArea = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblFullName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuildingDrawings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwnershipDocs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawingLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawingRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOwnerLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOwnerRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOwnershipDocs)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PropertyManagementSystem.Properties.Resources.Close;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(916, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 15);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnDrawingConfirm
            // 
            this.btnDrawingConfirm.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnDrawingConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnDrawingConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDrawingConfirm.BorderRadius = 7;
            this.btnDrawingConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnDrawingConfirm.ButtonText = "Confirm";
            this.btnDrawingConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDrawingConfirm.DisabledColor = System.Drawing.Color.Gray;
            this.btnDrawingConfirm.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDrawingConfirm.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDrawingConfirm.Iconimage")));
            this.btnDrawingConfirm.Iconimage_right = null;
            this.btnDrawingConfirm.Iconimage_right_Selected = null;
            this.btnDrawingConfirm.Iconimage_Selected = null;
            this.btnDrawingConfirm.IconMarginLeft = 0;
            this.btnDrawingConfirm.IconMarginRight = 0;
            this.btnDrawingConfirm.IconRightVisible = true;
            this.btnDrawingConfirm.IconRightZoom = 0D;
            this.btnDrawingConfirm.IconVisible = true;
            this.btnDrawingConfirm.IconZoom = 50D;
            this.btnDrawingConfirm.IsTab = false;
            this.btnDrawingConfirm.Location = new System.Drawing.Point(343, 212);
            this.btnDrawingConfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDrawingConfirm.Name = "btnDrawingConfirm";
            this.btnDrawingConfirm.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnDrawingConfirm.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnDrawingConfirm.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDrawingConfirm.selected = false;
            this.btnDrawingConfirm.Size = new System.Drawing.Size(106, 29);
            this.btnDrawingConfirm.TabIndex = 181;
            this.btnDrawingConfirm.Text = "Confirm";
            this.btnDrawingConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDrawingConfirm.Textcolor = System.Drawing.Color.White;
            this.btnDrawingConfirm.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrawingConfirm.Click += new System.EventHandler(this.btnDrawingConfirm_Click);
            // 
            // btnOwnerConfirm
            // 
            this.btnOwnerConfirm.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnOwnerConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnOwnerConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOwnerConfirm.BorderRadius = 7;
            this.btnOwnerConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnOwnerConfirm.ButtonText = "Confirm";
            this.btnOwnerConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOwnerConfirm.DisabledColor = System.Drawing.Color.Gray;
            this.btnOwnerConfirm.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOwnerConfirm.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnOwnerConfirm.Iconimage")));
            this.btnOwnerConfirm.Iconimage_right = null;
            this.btnOwnerConfirm.Iconimage_right_Selected = null;
            this.btnOwnerConfirm.Iconimage_Selected = null;
            this.btnOwnerConfirm.IconMarginLeft = 0;
            this.btnOwnerConfirm.IconMarginRight = 0;
            this.btnOwnerConfirm.IconRightVisible = true;
            this.btnOwnerConfirm.IconRightZoom = 0D;
            this.btnOwnerConfirm.IconVisible = true;
            this.btnOwnerConfirm.IconZoom = 50D;
            this.btnOwnerConfirm.IsTab = false;
            this.btnOwnerConfirm.Location = new System.Drawing.Point(809, 212);
            this.btnOwnerConfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOwnerConfirm.Name = "btnOwnerConfirm";
            this.btnOwnerConfirm.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnOwnerConfirm.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnOwnerConfirm.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOwnerConfirm.selected = false;
            this.btnOwnerConfirm.Size = new System.Drawing.Size(106, 28);
            this.btnOwnerConfirm.TabIndex = 180;
            this.btnOwnerConfirm.Text = "Confirm";
            this.btnOwnerConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOwnerConfirm.Textcolor = System.Drawing.Color.White;
            this.btnOwnerConfirm.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOwnerConfirm.Click += new System.EventHandler(this.btnOwnerConfirm_Click);
            // 
            // dgvBuildingDrawings
            // 
            this.dgvBuildingDrawings.AllowUserToAddRows = false;
            this.dgvBuildingDrawings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuildingDrawings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn2,
            this.dataGridViewTextBoxColumn2});
            this.dgvBuildingDrawings.Location = new System.Drawing.Point(60, 103);
            this.dgvBuildingDrawings.Name = "dgvBuildingDrawings";
            this.dgvBuildingDrawings.Size = new System.Drawing.Size(240, 150);
            this.dgvBuildingDrawings.TabIndex = 179;
            this.dgvBuildingDrawings.Visible = false;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Img";
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dgvOwnershipDocs
            // 
            this.dgvOwnershipDocs.AllowUserToAddRows = false;
            this.dgvOwnershipDocs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOwnershipDocs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn1});
            this.dgvOwnershipDocs.Location = new System.Drawing.Point(526, 114);
            this.dgvOwnershipDocs.Name = "dgvOwnershipDocs";
            this.dgvOwnershipDocs.Size = new System.Drawing.Size(240, 149);
            this.dgvOwnershipDocs.TabIndex = 178;
            this.dgvOwnershipDocs.Visible = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Img";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.Location = new System.Drawing.Point(171, 297);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 17);
            this.label14.TabIndex = 177;
            this.label14.Text = "of";
            // 
            // txtDrawingTotal
            // 
            this.txtDrawingTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.txtDrawingTotal.Location = new System.Drawing.Point(206, 281);
            this.txtDrawingTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDrawingTotal.Name = "txtDrawingTotal";
            this.txtDrawingTotal.ReadOnly = true;
            this.txtDrawingTotal.Size = new System.Drawing.Size(60, 53);
            this.txtDrawingTotal.TabIndex = 176;
            this.txtDrawingTotal.Text = "0";
            this.txtDrawingTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(637, 296);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 17);
            this.label13.TabIndex = 175;
            this.label13.Text = "of";
            // 
            // txtOwnerTotal
            // 
            this.txtOwnerTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.txtOwnerTotal.Location = new System.Drawing.Point(672, 283);
            this.txtOwnerTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOwnerTotal.Name = "txtOwnerTotal";
            this.txtOwnerTotal.ReadOnly = true;
            this.txtOwnerTotal.Size = new System.Drawing.Size(60, 53);
            this.txtOwnerTotal.TabIndex = 174;
            this.txtOwnerTotal.Text = "0";
            this.txtOwnerTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOwnerScan
            // 
            this.btnOwnerScan.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnOwnerScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnOwnerScan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOwnerScan.BorderRadius = 7;
            this.btnOwnerScan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnOwnerScan.ButtonText = "Scan";
            this.btnOwnerScan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOwnerScan.DisabledColor = System.Drawing.Color.Gray;
            this.btnOwnerScan.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOwnerScan.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnOwnerScan.Iconimage")));
            this.btnOwnerScan.Iconimage_right = null;
            this.btnOwnerScan.Iconimage_right_Selected = null;
            this.btnOwnerScan.Iconimage_Selected = null;
            this.btnOwnerScan.IconMarginLeft = 0;
            this.btnOwnerScan.IconMarginRight = 0;
            this.btnOwnerScan.IconRightVisible = true;
            this.btnOwnerScan.IconRightZoom = 0D;
            this.btnOwnerScan.IconVisible = true;
            this.btnOwnerScan.IconZoom = 50D;
            this.btnOwnerScan.IsTab = false;
            this.btnOwnerScan.Location = new System.Drawing.Point(809, 173);
            this.btnOwnerScan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOwnerScan.Name = "btnOwnerScan";
            this.btnOwnerScan.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnOwnerScan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnOwnerScan.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOwnerScan.selected = false;
            this.btnOwnerScan.Size = new System.Drawing.Size(106, 28);
            this.btnOwnerScan.TabIndex = 173;
            this.btnOwnerScan.Text = "Scan";
            this.btnOwnerScan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOwnerScan.Textcolor = System.Drawing.Color.White;
            this.btnOwnerScan.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOwnerScan.Click += new System.EventHandler(this.btnOwnerScan_Click);
            // 
            // btnDrawingScan
            // 
            this.btnDrawingScan.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnDrawingScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnDrawingScan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDrawingScan.BorderRadius = 7;
            this.btnDrawingScan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnDrawingScan.ButtonText = "Scan";
            this.btnDrawingScan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDrawingScan.DisabledColor = System.Drawing.Color.Gray;
            this.btnDrawingScan.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDrawingScan.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDrawingScan.Iconimage")));
            this.btnDrawingScan.Iconimage_right = null;
            this.btnDrawingScan.Iconimage_right_Selected = null;
            this.btnDrawingScan.Iconimage_Selected = null;
            this.btnDrawingScan.IconMarginLeft = 0;
            this.btnDrawingScan.IconMarginRight = 0;
            this.btnDrawingScan.IconRightVisible = true;
            this.btnDrawingScan.IconRightZoom = 0D;
            this.btnDrawingScan.IconVisible = true;
            this.btnDrawingScan.IconZoom = 50D;
            this.btnDrawingScan.IsTab = false;
            this.btnDrawingScan.Location = new System.Drawing.Point(343, 173);
            this.btnDrawingScan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDrawingScan.Name = "btnDrawingScan";
            this.btnDrawingScan.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnDrawingScan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnDrawingScan.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDrawingScan.selected = false;
            this.btnDrawingScan.Size = new System.Drawing.Size(106, 29);
            this.btnDrawingScan.TabIndex = 172;
            this.btnDrawingScan.Text = "Scan";
            this.btnDrawingScan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDrawingScan.Textcolor = System.Drawing.Color.White;
            this.btnDrawingScan.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrawingScan.Click += new System.EventHandler(this.btnDrawingScan_Click);
            // 
            // btnDrawingBrowse
            // 
            this.btnDrawingBrowse.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnDrawingBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnDrawingBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDrawingBrowse.BorderRadius = 7;
            this.btnDrawingBrowse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnDrawingBrowse.ButtonText = "Browse";
            this.btnDrawingBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDrawingBrowse.DisabledColor = System.Drawing.Color.Gray;
            this.btnDrawingBrowse.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDrawingBrowse.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDrawingBrowse.Iconimage")));
            this.btnDrawingBrowse.Iconimage_right = null;
            this.btnDrawingBrowse.Iconimage_right_Selected = null;
            this.btnDrawingBrowse.Iconimage_Selected = null;
            this.btnDrawingBrowse.IconMarginLeft = 0;
            this.btnDrawingBrowse.IconMarginRight = 0;
            this.btnDrawingBrowse.IconRightVisible = true;
            this.btnDrawingBrowse.IconRightZoom = 0D;
            this.btnDrawingBrowse.IconVisible = true;
            this.btnDrawingBrowse.IconZoom = 50D;
            this.btnDrawingBrowse.IsTab = false;
            this.btnDrawingBrowse.Location = new System.Drawing.Point(343, 134);
            this.btnDrawingBrowse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDrawingBrowse.Name = "btnDrawingBrowse";
            this.btnDrawingBrowse.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnDrawingBrowse.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnDrawingBrowse.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDrawingBrowse.selected = false;
            this.btnDrawingBrowse.Size = new System.Drawing.Size(106, 29);
            this.btnDrawingBrowse.TabIndex = 171;
            this.btnDrawingBrowse.Text = "Browse";
            this.btnDrawingBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDrawingBrowse.Textcolor = System.Drawing.Color.White;
            this.btnDrawingBrowse.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrawingBrowse.Click += new System.EventHandler(this.btnDrawingBrowse_Click);
            // 
            // btnOwnerBrowse
            // 
            this.btnOwnerBrowse.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnOwnerBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnOwnerBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOwnerBrowse.BorderRadius = 7;
            this.btnOwnerBrowse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnOwnerBrowse.ButtonText = "Browse";
            this.btnOwnerBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOwnerBrowse.DisabledColor = System.Drawing.Color.Gray;
            this.btnOwnerBrowse.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOwnerBrowse.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnOwnerBrowse.Iconimage")));
            this.btnOwnerBrowse.Iconimage_right = null;
            this.btnOwnerBrowse.Iconimage_right_Selected = null;
            this.btnOwnerBrowse.Iconimage_Selected = null;
            this.btnOwnerBrowse.IconMarginLeft = 0;
            this.btnOwnerBrowse.IconMarginRight = 0;
            this.btnOwnerBrowse.IconRightVisible = true;
            this.btnOwnerBrowse.IconRightZoom = 0D;
            this.btnOwnerBrowse.IconVisible = true;
            this.btnOwnerBrowse.IconZoom = 50D;
            this.btnOwnerBrowse.IsTab = false;
            this.btnOwnerBrowse.Location = new System.Drawing.Point(809, 134);
            this.btnOwnerBrowse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOwnerBrowse.Name = "btnOwnerBrowse";
            this.btnOwnerBrowse.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnOwnerBrowse.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnOwnerBrowse.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOwnerBrowse.selected = false;
            this.btnOwnerBrowse.Size = new System.Drawing.Size(106, 28);
            this.btnOwnerBrowse.TabIndex = 170;
            this.btnOwnerBrowse.Text = "Browse";
            this.btnOwnerBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOwnerBrowse.Textcolor = System.Drawing.Color.White;
            this.btnOwnerBrowse.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOwnerBrowse.Click += new System.EventHandler(this.btnOwnerBrowse_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(121, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 17);
            this.label8.TabIndex = 169;
            this.label8.Text = "Building Drawings";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(587, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 17);
            this.label7.TabIndex = 168;
            this.label7.Text = "Ownership Documents";
            // 
            // txtDrawingNum
            // 
            this.txtDrawingNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.txtDrawingNum.Location = new System.Drawing.Point(94, 281);
            this.txtDrawingNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDrawingNum.Name = "txtDrawingNum";
            this.txtDrawingNum.ReadOnly = true;
            this.txtDrawingNum.Size = new System.Drawing.Size(60, 53);
            this.txtDrawingNum.TabIndex = 167;
            this.txtDrawingNum.Text = "0";
            this.txtDrawingNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDrawingNum.TextChanged += new System.EventHandler(this.txtDrawingNum_TextChanged);
            // 
            // pbDrawingLeft
            // 
            this.pbDrawingLeft.BackgroundImage = global::PropertyManagementSystem.Properties.Resources.left;
            this.pbDrawingLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDrawingLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDrawingLeft.Location = new System.Drawing.Point(24, 281);
            this.pbDrawingLeft.Name = "pbDrawingLeft";
            this.pbDrawingLeft.Size = new System.Drawing.Size(64, 56);
            this.pbDrawingLeft.TabIndex = 166;
            this.pbDrawingLeft.TabStop = false;
            this.pbDrawingLeft.Click += new System.EventHandler(this.pbDrawingLeft_Click);
            // 
            // pbDrawingRight
            // 
            this.pbDrawingRight.BackgroundImage = global::PropertyManagementSystem.Properties.Resources.Right;
            this.pbDrawingRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDrawingRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDrawingRight.Location = new System.Drawing.Point(272, 281);
            this.pbDrawingRight.Name = "pbDrawingRight";
            this.pbDrawingRight.Size = new System.Drawing.Size(64, 56);
            this.pbDrawingRight.TabIndex = 165;
            this.pbDrawingRight.TabStop = false;
            this.pbDrawingRight.Click += new System.EventHandler(this.pbDrawingRight_Click);
            // 
            // txtOwnerNum
            // 
            this.txtOwnerNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.txtOwnerNum.Location = new System.Drawing.Point(560, 283);
            this.txtOwnerNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOwnerNum.Name = "txtOwnerNum";
            this.txtOwnerNum.ReadOnly = true;
            this.txtOwnerNum.Size = new System.Drawing.Size(60, 53);
            this.txtOwnerNum.TabIndex = 164;
            this.txtOwnerNum.Text = "0";
            this.txtOwnerNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOwnerNum.TextChanged += new System.EventHandler(this.txtOwnerNum_TextChanged);
            // 
            // pbOwnerLeft
            // 
            this.pbOwnerLeft.BackgroundImage = global::PropertyManagementSystem.Properties.Resources.left;
            this.pbOwnerLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbOwnerLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbOwnerLeft.Location = new System.Drawing.Point(490, 281);
            this.pbOwnerLeft.Name = "pbOwnerLeft";
            this.pbOwnerLeft.Size = new System.Drawing.Size(64, 55);
            this.pbOwnerLeft.TabIndex = 163;
            this.pbOwnerLeft.TabStop = false;
            this.pbOwnerLeft.Click += new System.EventHandler(this.pbOwnerLeft_Click);
            // 
            // pbOwnerRight
            // 
            this.pbOwnerRight.BackgroundImage = global::PropertyManagementSystem.Properties.Resources.Right;
            this.pbOwnerRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbOwnerRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbOwnerRight.Location = new System.Drawing.Point(738, 281);
            this.pbOwnerRight.Name = "pbOwnerRight";
            this.pbOwnerRight.Size = new System.Drawing.Size(64, 55);
            this.pbOwnerRight.TabIndex = 162;
            this.pbOwnerRight.TabStop = false;
            this.pbOwnerRight.Click += new System.EventHandler(this.pbOwnerRight_Click);
            // 
            // pbDrawings
            // 
            this.pbDrawings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDrawings.Location = new System.Drawing.Point(24, 94);
            this.pbDrawings.Name = "pbDrawings";
            this.pbDrawings.Size = new System.Drawing.Size(312, 181);
            this.pbDrawings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDrawings.TabIndex = 161;
            this.pbDrawings.TabStop = false;
            this.pbDrawings.DoubleClick += new System.EventHandler(this.pbDrawings_DoubleClick);
            // 
            // pbOwnershipDocs
            // 
            this.pbOwnershipDocs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbOwnershipDocs.Location = new System.Drawing.Point(490, 94);
            this.pbOwnershipDocs.Name = "pbOwnershipDocs";
            this.pbOwnershipDocs.Size = new System.Drawing.Size(312, 180);
            this.pbOwnershipDocs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOwnershipDocs.TabIndex = 160;
            this.pbOwnershipDocs.TabStop = false;
            this.pbOwnershipDocs.DoubleClick += new System.EventHandler(this.pbOwnershipDocs_DoubleClick);
            // 
            // cbUnit
            // 
            this.cbUnit.BackColor = System.Drawing.Color.Transparent;
            this.cbUnit.BorderRadius = 7;
            this.cbUnit.DisabledColor = System.Drawing.Color.Gray;
            this.cbUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbUnit.ForeColor = System.Drawing.Color.White;
            this.cbUnit.Items = new string[] {
        "Meter",
        "Hectare"};
            this.cbUnit.Location = new System.Drawing.Point(772, 375);
            this.cbUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.cbUnit.onHoverColor = System.Drawing.Color.Blue;
            this.cbUnit.selectedIndex = -1;
            this.cbUnit.Size = new System.Drawing.Size(147, 33);
            this.cbUnit.TabIndex = 271;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label15.Location = new System.Drawing.Point(720, 384);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 17);
            this.label15.TabIndex = 270;
            this.label15.Text = "Unit";
            // 
            // txtLocationUrl
            // 
            this.txtLocationUrl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLocationUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtLocationUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLocationUrl.HintForeColor = System.Drawing.Color.Empty;
            this.txtLocationUrl.HintText = "";
            this.txtLocationUrl.isPassword = false;
            this.txtLocationUrl.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtLocationUrl.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.txtLocationUrl.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtLocationUrl.LineThickness = 3;
            this.txtLocationUrl.Location = new System.Drawing.Point(536, 420);
            this.txtLocationUrl.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocationUrl.Name = "txtLocationUrl";
            this.txtLocationUrl.Size = new System.Drawing.Size(379, 33);
            this.txtLocationUrl.TabIndex = 267;
            this.txtLocationUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtAddress
            // 
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddress.HintForeColor = System.Drawing.Color.Empty;
            this.txtAddress.HintText = "";
            this.txtAddress.isPassword = false;
            this.txtAddress.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtAddress.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.txtAddress.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtAddress.LineThickness = 3;
            this.txtAddress.Location = new System.Drawing.Point(92, 420);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(282, 33);
            this.txtAddress.TabIndex = 266;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTotalArea
            // 
            this.txtTotalArea.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTotalArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotalArea.HintForeColor = System.Drawing.Color.Empty;
            this.txtTotalArea.HintText = "";
            this.txtTotalArea.isPassword = false;
            this.txtTotalArea.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtTotalArea.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.txtTotalArea.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtTotalArea.LineThickness = 3;
            this.txtTotalArea.Location = new System.Drawing.Point(511, 368);
            this.txtTotalArea.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalArea.Name = "txtTotalArea";
            this.txtTotalArea.Size = new System.Drawing.Size(164, 33);
            this.txtTotalArea.TabIndex = 265;
            this.txtTotalArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotalArea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalArea_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(440, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 264;
            this.label4.Text = "Area";
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.HintForeColor = System.Drawing.Color.Empty;
            this.txtName.HintText = "";
            this.txtName.isPassword = false;
            this.txtName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.txtName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtName.LineThickness = 3;
            this.txtName.Location = new System.Drawing.Point(96, 368);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(278, 33);
            this.txtName.TabIndex = 263;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(440, 436);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 262;
            this.label3.Text = "Location URL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(21, 436);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 261;
            this.label9.Text = "Address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(25, 384);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 17);
            this.label11.TabIndex = 260;
            this.label11.Text = "Name";
            // 
            // btnCancel
            // 
            this.btnCancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.BorderRadius = 7;
            this.btnCancel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancel.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCancel.Iconimage")));
            this.btnCancel.Iconimage_right = null;
            this.btnCancel.Iconimage_right_Selected = null;
            this.btnCancel.Iconimage_Selected = null;
            this.btnCancel.IconMarginLeft = 0;
            this.btnCancel.IconMarginRight = 0;
            this.btnCancel.IconRightVisible = true;
            this.btnCancel.IconRightZoom = 0D;
            this.btnCancel.IconVisible = true;
            this.btnCancel.IconZoom = 50D;
            this.btnCancel.IsTab = false;
            this.btnCancel.Location = new System.Drawing.Point(475, 501);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnCancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancel.selected = false;
            this.btnCancel.Size = new System.Drawing.Size(126, 43);
            this.btnCancel.TabIndex = 273;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Textcolor = System.Drawing.Color.White;
            this.btnCancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 7;
            this.btnSave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnSave.ButtonText = "Save";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSave.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSave.Iconimage")));
            this.btnSave.Iconimage_right = null;
            this.btnSave.Iconimage_right_Selected = null;
            this.btnSave.Iconimage_Selected = null;
            this.btnSave.IconMarginLeft = 0;
            this.btnSave.IconMarginRight = 0;
            this.btnSave.IconRightVisible = true;
            this.btnSave.IconRightZoom = 0D;
            this.btnSave.IconVisible = true;
            this.btnSave.IconZoom = 50D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(315, 501);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(126, 43);
            this.btnSave.TabIndex = 272;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Monotype Corsiva", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.lblFullName.Location = new System.Drawing.Point(471, 8);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(90, 24);
            this.lblFullName.TabIndex = 274;
            this.lblFullName.Text = "Add Farm";
            // 
            // AddFarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PropertyManagementSystem.Properties.Resources.Border;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(940, 561);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbUnit);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtLocationUrl);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtTotalArea);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnDrawingConfirm);
            this.Controls.Add(this.btnOwnerConfirm);
            this.Controls.Add(this.dgvBuildingDrawings);
            this.Controls.Add(this.dgvOwnershipDocs);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtDrawingTotal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtOwnerTotal);
            this.Controls.Add(this.btnOwnerScan);
            this.Controls.Add(this.btnDrawingScan);
            this.Controls.Add(this.btnDrawingBrowse);
            this.Controls.Add(this.btnOwnerBrowse);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDrawingNum);
            this.Controls.Add(this.pbDrawingLeft);
            this.Controls.Add(this.pbDrawingRight);
            this.Controls.Add(this.txtOwnerNum);
            this.Controls.Add(this.pbOwnerLeft);
            this.Controls.Add(this.pbOwnerRight);
            this.Controls.Add(this.pbDrawings);
            this.Controls.Add(this.pbOwnershipDocs);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddFarm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddFarm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuildingDrawings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwnershipDocs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawingLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawingRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOwnerLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOwnerRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOwnershipDocs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Bunifu.Framework.UI.BunifuFlatButton btnDrawingConfirm;
        private Bunifu.Framework.UI.BunifuFlatButton btnOwnerConfirm;
        private System.Windows.Forms.DataGridView dgvBuildingDrawings;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView dgvOwnershipDocs;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDrawingTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtOwnerTotal;
        private Bunifu.Framework.UI.BunifuFlatButton btnOwnerScan;
        private Bunifu.Framework.UI.BunifuFlatButton btnDrawingScan;
        private Bunifu.Framework.UI.BunifuFlatButton btnDrawingBrowse;
        private Bunifu.Framework.UI.BunifuFlatButton btnOwnerBrowse;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDrawingNum;
        private System.Windows.Forms.PictureBox pbDrawingLeft;
        private System.Windows.Forms.PictureBox pbDrawingRight;
        private System.Windows.Forms.TextBox txtOwnerNum;
        private System.Windows.Forms.PictureBox pbOwnerLeft;
        private System.Windows.Forms.PictureBox pbOwnerRight;
        private System.Windows.Forms.PictureBox pbDrawings;
        private System.Windows.Forms.PictureBox pbOwnershipDocs;
        private Bunifu.Framework.UI.BunifuDropdown cbUnit;
        private System.Windows.Forms.Label label15;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtLocationUrl;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAddress;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTotalArea;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private System.Windows.Forms.Label lblFullName;
    }
}
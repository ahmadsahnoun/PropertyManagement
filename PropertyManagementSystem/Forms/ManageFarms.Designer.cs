namespace PropertyManagementSystem.Forms
{
    partial class ManageFarms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageFarms));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.farmid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.txtOwnerTotal = new System.Windows.Forms.TextBox();
            this.txtOwnerNum = new System.Windows.Forms.TextBox();
            this.pbOwnerLeft = new System.Windows.Forms.PictureBox();
            this.pbOwnerRight = new System.Windows.Forms.PictureBox();
            this.pbOwnershipDocs = new System.Windows.Forms.PictureBox();
            this.dgvOwnershipDocs = new System.Windows.Forms.DataGridView();
            this.img = new System.Windows.Forms.DataGridViewImageColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDrawingScan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDrawingBrowse = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgvBuildingDrawings = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDrawingTotal = new System.Windows.Forms.TextBox();
            this.txtDrawingNum = new System.Windows.Forms.TextBox();
            this.pbDrawingRight = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pbDrawings = new System.Windows.Forms.PictureBox();
            this.pbDrawingLeft = new System.Windows.Forms.PictureBox();
            this.cbUnit = new Bunifu.Framework.UI.BunifuDropdown();
            this.label15 = new System.Windows.Forms.Label();
            this.txtStatus = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLocationUrl = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtAddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTotalArea = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEdit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnOwnerScan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnOwnerBrowse = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblFullName = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOwnerLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOwnerRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOwnershipDocs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwnershipDocs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuildingDrawings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawingRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawingLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PropertyManagementSystem.Properties.Resources.Close;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(1064, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 18);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 89;
            this.label9.Text = "Search";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(682, 258);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Farms";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.farmid,
            this.name,
            this.Area,
            this.address,
            this.LocationUrl});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(676, 238);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // farmid
            // 
            this.farmid.HeaderText = "Farm Id";
            this.farmid.Name = "farmid";
            this.farmid.ReadOnly = true;
            this.farmid.Visible = false;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 249;
            // 
            // Area
            // 
            this.Area.HeaderText = "Area";
            this.Area.Name = "Area";
            this.Area.ReadOnly = true;
            this.Area.Width = 75;
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // LocationUrl
            // 
            this.LocationUrl.HeaderText = "Location URL";
            this.LocationUrl.Name = "LocationUrl";
            this.LocationUrl.ReadOnly = true;
            this.LocationUrl.Width = 248;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(828, 277);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 17);
            this.label11.TabIndex = 224;
            this.label11.Text = "of";
            // 
            // txtOwnerTotal
            // 
            this.txtOwnerTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.txtOwnerTotal.Location = new System.Drawing.Point(854, 260);
            this.txtOwnerTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOwnerTotal.Name = "txtOwnerTotal";
            this.txtOwnerTotal.ReadOnly = true;
            this.txtOwnerTotal.Size = new System.Drawing.Size(60, 53);
            this.txtOwnerTotal.TabIndex = 223;
            this.txtOwnerTotal.Text = "0";
            this.txtOwnerTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOwnerTotal.TextChanged += new System.EventHandler(this.txtOwnerTotal_TextChanged);
            // 
            // txtOwnerNum
            // 
            this.txtOwnerNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.txtOwnerNum.Location = new System.Drawing.Point(762, 260);
            this.txtOwnerNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOwnerNum.Name = "txtOwnerNum";
            this.txtOwnerNum.ReadOnly = true;
            this.txtOwnerNum.Size = new System.Drawing.Size(60, 53);
            this.txtOwnerNum.TabIndex = 222;
            this.txtOwnerNum.Text = "0";
            this.txtOwnerNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOwnerNum.TextChanged += new System.EventHandler(this.txtOwnerNum_TextChanged);
            // 
            // pbOwnerLeft
            // 
            this.pbOwnerLeft.BackgroundImage = global::PropertyManagementSystem.Properties.Resources.left;
            this.pbOwnerLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbOwnerLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbOwnerLeft.Enabled = false;
            this.pbOwnerLeft.Location = new System.Drawing.Point(700, 257);
            this.pbOwnerLeft.Name = "pbOwnerLeft";
            this.pbOwnerLeft.Size = new System.Drawing.Size(56, 56);
            this.pbOwnerLeft.TabIndex = 221;
            this.pbOwnerLeft.TabStop = false;
            this.pbOwnerLeft.Click += new System.EventHandler(this.pbOwnerLeft_Click);
            // 
            // pbOwnerRight
            // 
            this.pbOwnerRight.BackgroundImage = global::PropertyManagementSystem.Properties.Resources.Right;
            this.pbOwnerRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbOwnerRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbOwnerRight.Enabled = false;
            this.pbOwnerRight.Location = new System.Drawing.Point(917, 257);
            this.pbOwnerRight.Name = "pbOwnerRight";
            this.pbOwnerRight.Size = new System.Drawing.Size(56, 56);
            this.pbOwnerRight.TabIndex = 220;
            this.pbOwnerRight.TabStop = false;
            this.pbOwnerRight.Click += new System.EventHandler(this.pbOwnerRight_Click);
            // 
            // pbOwnershipDocs
            // 
            this.pbOwnershipDocs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbOwnershipDocs.Location = new System.Drawing.Point(700, 73);
            this.pbOwnershipDocs.Name = "pbOwnershipDocs";
            this.pbOwnershipDocs.Size = new System.Drawing.Size(273, 181);
            this.pbOwnershipDocs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOwnershipDocs.TabIndex = 219;
            this.pbOwnershipDocs.TabStop = false;
            this.pbOwnershipDocs.DoubleClick += new System.EventHandler(this.pbOwnershipDocs_DoubleClick);
            // 
            // dgvOwnershipDocs
            // 
            this.dgvOwnershipDocs.AllowUserToAddRows = false;
            this.dgvOwnershipDocs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOwnershipDocs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.img,
            this.id});
            this.dgvOwnershipDocs.Location = new System.Drawing.Point(718, 87);
            this.dgvOwnershipDocs.MultiSelect = false;
            this.dgvOwnershipDocs.Name = "dgvOwnershipDocs";
            this.dgvOwnershipDocs.Size = new System.Drawing.Size(240, 150);
            this.dgvOwnershipDocs.TabIndex = 225;
            this.dgvOwnershipDocs.Visible = false;
            // 
            // img
            // 
            this.img.HeaderText = "Img";
            this.img.Name = "img";
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(764, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 17);
            this.label7.TabIndex = 218;
            this.label7.Text = "Ownership Documents";
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
            this.btnDrawingScan.Enabled = false;
            this.btnDrawingScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
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
            this.btnDrawingScan.Location = new System.Drawing.Point(981, 432);
            this.btnDrawingScan.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnDrawingScan.Name = "btnDrawingScan";
            this.btnDrawingScan.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnDrawingScan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnDrawingScan.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDrawingScan.selected = false;
            this.btnDrawingScan.Size = new System.Drawing.Size(95, 37);
            this.btnDrawingScan.TabIndex = 242;
            this.btnDrawingScan.Text = "Scan";
            this.btnDrawingScan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDrawingScan.Textcolor = System.Drawing.Color.White;
            this.btnDrawingScan.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnDrawingBrowse.Enabled = false;
            this.btnDrawingBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
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
            this.btnDrawingBrowse.Location = new System.Drawing.Point(981, 381);
            this.btnDrawingBrowse.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnDrawingBrowse.Name = "btnDrawingBrowse";
            this.btnDrawingBrowse.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnDrawingBrowse.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnDrawingBrowse.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDrawingBrowse.selected = false;
            this.btnDrawingBrowse.Size = new System.Drawing.Size(95, 37);
            this.btnDrawingBrowse.TabIndex = 241;
            this.btnDrawingBrowse.Text = "Browse";
            this.btnDrawingBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDrawingBrowse.Textcolor = System.Drawing.Color.White;
            this.btnDrawingBrowse.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrawingBrowse.Click += new System.EventHandler(this.btnDrawingBrowse_Click);
            // 
            // dgvBuildingDrawings
            // 
            this.dgvBuildingDrawings.AllowUserToAddRows = false;
            this.dgvBuildingDrawings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuildingDrawings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn1});
            this.dgvBuildingDrawings.Location = new System.Drawing.Point(723, 349);
            this.dgvBuildingDrawings.MultiSelect = false;
            this.dgvBuildingDrawings.Name = "dgvBuildingDrawings";
            this.dgvBuildingDrawings.Size = new System.Drawing.Size(240, 150);
            this.dgvBuildingDrawings.TabIndex = 240;
            this.dgvBuildingDrawings.Visible = false;
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(828, 544);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 17);
            this.label13.TabIndex = 239;
            this.label13.Text = "of";
            // 
            // txtDrawingTotal
            // 
            this.txtDrawingTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.txtDrawingTotal.Location = new System.Drawing.Point(854, 527);
            this.txtDrawingTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDrawingTotal.Name = "txtDrawingTotal";
            this.txtDrawingTotal.ReadOnly = true;
            this.txtDrawingTotal.Size = new System.Drawing.Size(60, 53);
            this.txtDrawingTotal.TabIndex = 238;
            this.txtDrawingTotal.Text = "0";
            this.txtDrawingTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDrawingTotal.TextChanged += new System.EventHandler(this.txtDrawingTotal_TextChanged);
            // 
            // txtDrawingNum
            // 
            this.txtDrawingNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.txtDrawingNum.Location = new System.Drawing.Point(762, 527);
            this.txtDrawingNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDrawingNum.Name = "txtDrawingNum";
            this.txtDrawingNum.ReadOnly = true;
            this.txtDrawingNum.Size = new System.Drawing.Size(60, 53);
            this.txtDrawingNum.TabIndex = 237;
            this.txtDrawingNum.Text = "0";
            this.txtDrawingNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDrawingNum.TextChanged += new System.EventHandler(this.txtDrawingNum_TextChanged);
            // 
            // pbDrawingRight
            // 
            this.pbDrawingRight.BackgroundImage = global::PropertyManagementSystem.Properties.Resources.Right;
            this.pbDrawingRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDrawingRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDrawingRight.Enabled = false;
            this.pbDrawingRight.Location = new System.Drawing.Point(917, 524);
            this.pbDrawingRight.Name = "pbDrawingRight";
            this.pbDrawingRight.Size = new System.Drawing.Size(56, 56);
            this.pbDrawingRight.TabIndex = 236;
            this.pbDrawingRight.TabStop = false;
            this.pbDrawingRight.Click += new System.EventHandler(this.pbDrawingRight_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(783, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 17);
            this.label8.TabIndex = 235;
            this.label8.Text = "Building Drawings";
            // 
            // pbDrawings
            // 
            this.pbDrawings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDrawings.Location = new System.Drawing.Point(700, 340);
            this.pbDrawings.Name = "pbDrawings";
            this.pbDrawings.Size = new System.Drawing.Size(273, 181);
            this.pbDrawings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDrawings.TabIndex = 234;
            this.pbDrawings.TabStop = false;
            this.pbDrawings.DoubleClick += new System.EventHandler(this.pbDrawings_DoubleClick);
            // 
            // pbDrawingLeft
            // 
            this.pbDrawingLeft.BackgroundImage = global::PropertyManagementSystem.Properties.Resources.left;
            this.pbDrawingLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDrawingLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDrawingLeft.Enabled = false;
            this.pbDrawingLeft.Location = new System.Drawing.Point(700, 524);
            this.pbDrawingLeft.Name = "pbDrawingLeft";
            this.pbDrawingLeft.Size = new System.Drawing.Size(56, 56);
            this.pbDrawingLeft.TabIndex = 243;
            this.pbDrawingLeft.TabStop = false;
            this.pbDrawingLeft.Click += new System.EventHandler(this.pbDrawingLeft_Click);
            // 
            // cbUnit
            // 
            this.cbUnit.BackColor = System.Drawing.Color.Transparent;
            this.cbUnit.BorderRadius = 7;
            this.cbUnit.DisabledColor = System.Drawing.Color.Gray;
            this.cbUnit.Enabled = false;
            this.cbUnit.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cbUnit.ForeColor = System.Drawing.Color.White;
            this.cbUnit.Items = new string[] {
        "Meter",
        "Hectare"};
            this.cbUnit.Location = new System.Drawing.Point(433, 394);
            this.cbUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.cbUnit.onHoverColor = System.Drawing.Color.Blue;
            this.cbUnit.selectedIndex = -1;
            this.cbUnit.Size = new System.Drawing.Size(164, 35);
            this.cbUnit.TabIndex = 255;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label15.Location = new System.Drawing.Point(364, 407);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 17);
            this.label15.TabIndex = 254;
            this.label15.Text = "Unit";
            // 
            // txtStatus
            // 
            this.txtStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStatus.Enabled = false;
            this.txtStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStatus.HintForeColor = System.Drawing.Color.Empty;
            this.txtStatus.HintText = "";
            this.txtStatus.isPassword = false;
            this.txtStatus.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtStatus.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.txtStatus.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtStatus.LineThickness = 3;
            this.txtStatus.Location = new System.Drawing.Point(530, 340);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(67, 35);
            this.txtStatus.TabIndex = 253;
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(463, 357);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 17);
            this.label10.TabIndex = 252;
            this.label10.Text = "Status";
            // 
            // txtLocationUrl
            // 
            this.txtLocationUrl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLocationUrl.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtLocationUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLocationUrl.HintForeColor = System.Drawing.Color.Empty;
            this.txtLocationUrl.HintText = "";
            this.txtLocationUrl.isPassword = false;
            this.txtLocationUrl.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtLocationUrl.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.txtLocationUrl.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtLocationUrl.LineThickness = 3;
            this.txtLocationUrl.Location = new System.Drawing.Point(433, 438);
            this.txtLocationUrl.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocationUrl.Name = "txtLocationUrl";
            this.txtLocationUrl.Size = new System.Drawing.Size(164, 35);
            this.txtLocationUrl.TabIndex = 251;
            this.txtLocationUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtAddress
            // 
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddress.HintForeColor = System.Drawing.Color.Empty;
            this.txtAddress.HintText = "";
            this.txtAddress.isPassword = false;
            this.txtAddress.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtAddress.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.txtAddress.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtAddress.LineThickness = 3;
            this.txtAddress.Location = new System.Drawing.Point(131, 438);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(164, 35);
            this.txtAddress.TabIndex = 250;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTotalArea
            // 
            this.txtTotalArea.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalArea.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTotalArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotalArea.HintForeColor = System.Drawing.Color.Empty;
            this.txtTotalArea.HintText = "";
            this.txtTotalArea.isPassword = false;
            this.txtTotalArea.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtTotalArea.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.txtTotalArea.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtTotalArea.LineThickness = 3;
            this.txtTotalArea.Location = new System.Drawing.Point(131, 389);
            this.txtTotalArea.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalArea.Name = "txtTotalArea";
            this.txtTotalArea.Size = new System.Drawing.Size(164, 35);
            this.txtTotalArea.TabIndex = 249;
            this.txtTotalArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotalArea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalArea_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 248;
            this.label4.Text = "Area";
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.HintForeColor = System.Drawing.Color.Empty;
            this.txtName.HintText = "";
            this.txtName.isPassword = false;
            this.txtName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.txtName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtName.LineThickness = 3;
            this.txtName.Location = new System.Drawing.Point(132, 340);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(281, 35);
            this.txtName.TabIndex = 247;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 455);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 246;
            this.label6.Text = "Location URL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 455);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 245;
            this.label5.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 244;
            this.label1.Text = "Name";
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
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
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
            this.btnCancel.Location = new System.Drawing.Point(444, 541);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnCancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancel.selected = false;
            this.btnCancel.Size = new System.Drawing.Size(110, 46);
            this.btnCancel.TabIndex = 259;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Textcolor = System.Drawing.Color.White;
            this.btnCancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderRadius = 7;
            this.btnDelete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnDelete.ButtonText = "Delete";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelete.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDelete.Iconimage")));
            this.btnDelete.Iconimage_right = null;
            this.btnDelete.Iconimage_right_Selected = null;
            this.btnDelete.Iconimage_Selected = null;
            this.btnDelete.IconMarginLeft = 0;
            this.btnDelete.IconMarginRight = 0;
            this.btnDelete.IconRightVisible = true;
            this.btnDelete.IconRightZoom = 0D;
            this.btnDelete.IconVisible = true;
            this.btnDelete.IconZoom = 50D;
            this.btnDelete.IsTab = false;
            this.btnDelete.Location = new System.Drawing.Point(142, 541);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(110, 46);
            this.btnDelete.TabIndex = 258;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Textcolor = System.Drawing.Color.White;
            this.btnDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.BorderRadius = 7;
            this.btnEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnEdit.ButtonText = "Edit";
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.DisabledColor = System.Drawing.Color.Gray;
            this.btnEdit.Enabled = false;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnEdit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEdit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEdit.Iconimage")));
            this.btnEdit.Iconimage_right = null;
            this.btnEdit.Iconimage_right_Selected = null;
            this.btnEdit.Iconimage_Selected = null;
            this.btnEdit.IconMarginLeft = 0;
            this.btnEdit.IconMarginRight = 0;
            this.btnEdit.IconRightVisible = true;
            this.btnEdit.IconRightZoom = 0D;
            this.btnEdit.IconVisible = true;
            this.btnEdit.IconZoom = 50D;
            this.btnEdit.IsTab = false;
            this.btnEdit.Location = new System.Drawing.Point(444, 490);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnEdit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnEdit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEdit.selected = false;
            this.btnEdit.Size = new System.Drawing.Size(110, 46);
            this.btnEdit.TabIndex = 257;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEdit.Textcolor = System.Drawing.Color.White;
            this.btnEdit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.BorderRadius = 7;
            this.btnAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnAdd.ButtonText = "Add";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdd.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAdd.Iconimage")));
            this.btnAdd.Iconimage_right = null;
            this.btnAdd.Iconimage_right_Selected = null;
            this.btnAdd.Iconimage_Selected = null;
            this.btnAdd.IconMarginLeft = 0;
            this.btnAdd.IconMarginRight = 0;
            this.btnAdd.IconRightVisible = true;
            this.btnAdd.IconRightZoom = 0D;
            this.btnAdd.IconVisible = true;
            this.btnAdd.IconZoom = 50D;
            this.btnAdd.IsTab = false;
            this.btnAdd.Location = new System.Drawing.Point(142, 490);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnAdd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdd.selected = false;
            this.btnAdd.Size = new System.Drawing.Size(110, 46);
            this.btnAdd.TabIndex = 256;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Textcolor = System.Drawing.Color.White;
            this.btnAdd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.HintForeColor = System.Drawing.Color.Empty;
            this.txtSearch.HintText = "";
            this.txtSearch.isPassword = false;
            this.txtSearch.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSearch.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.txtSearch.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSearch.LineThickness = 3;
            this.txtSearch.Location = new System.Drawing.Point(97, 14);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(168, 35);
            this.txtSearch.TabIndex = 260;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.OnValueChanged += new System.EventHandler(this.txtSearch_OnValueChanged);
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
            this.btnOwnerScan.Enabled = false;
            this.btnOwnerScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
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
            this.btnOwnerScan.Location = new System.Drawing.Point(981, 154);
            this.btnOwnerScan.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnOwnerScan.Name = "btnOwnerScan";
            this.btnOwnerScan.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnOwnerScan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnOwnerScan.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOwnerScan.selected = false;
            this.btnOwnerScan.Size = new System.Drawing.Size(95, 37);
            this.btnOwnerScan.TabIndex = 262;
            this.btnOwnerScan.Text = "Scan";
            this.btnOwnerScan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOwnerScan.Textcolor = System.Drawing.Color.White;
            this.btnOwnerScan.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnOwnerBrowse.Enabled = false;
            this.btnOwnerBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
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
            this.btnOwnerBrowse.Location = new System.Drawing.Point(981, 103);
            this.btnOwnerBrowse.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnOwnerBrowse.Name = "btnOwnerBrowse";
            this.btnOwnerBrowse.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnOwnerBrowse.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnOwnerBrowse.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOwnerBrowse.selected = false;
            this.btnOwnerBrowse.Size = new System.Drawing.Size(95, 37);
            this.btnOwnerBrowse.TabIndex = 261;
            this.btnOwnerBrowse.Text = "Browse";
            this.btnOwnerBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOwnerBrowse.Textcolor = System.Drawing.Color.White;
            this.btnOwnerBrowse.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOwnerBrowse.Click += new System.EventHandler(this.btnOwnerBrowse_Click);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Monotype Corsiva", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.lblFullName.Location = new System.Drawing.Point(470, 9);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(127, 24);
            this.lblFullName.TabIndex = 263;
            this.lblFullName.Text = "Manage Farms";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ManageFarms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PropertyManagementSystem.Properties.Resources.Border;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1093, 605);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.btnOwnerScan);
            this.Controls.Add(this.btnOwnerBrowse);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbUnit);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtLocationUrl);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtTotalArea);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbDrawingLeft);
            this.Controls.Add(this.btnDrawingScan);
            this.Controls.Add(this.btnDrawingBrowse);
            this.Controls.Add(this.dgvBuildingDrawings);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtDrawingTotal);
            this.Controls.Add(this.txtDrawingNum);
            this.Controls.Add(this.pbDrawingRight);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pbDrawings);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtOwnerTotal);
            this.Controls.Add(this.txtOwnerNum);
            this.Controls.Add(this.pbOwnerLeft);
            this.Controls.Add(this.pbOwnerRight);
            this.Controls.Add(this.pbOwnershipDocs);
            this.Controls.Add(this.dgvOwnershipDocs);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageFarms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageFarms";
            this.Load += new System.EventHandler(this.ManageFarms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOwnerLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOwnerRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOwnershipDocs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwnershipDocs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuildingDrawings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawingRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawingLeft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtOwnerTotal;
        private System.Windows.Forms.TextBox txtOwnerNum;
        private System.Windows.Forms.PictureBox pbOwnerLeft;
        private System.Windows.Forms.PictureBox pbOwnerRight;
        private System.Windows.Forms.PictureBox pbOwnershipDocs;
        private System.Windows.Forms.DataGridView dgvOwnershipDocs;
        private System.Windows.Forms.DataGridViewImageColumn img;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuFlatButton btnDrawingScan;
        private Bunifu.Framework.UI.BunifuFlatButton btnDrawingBrowse;
        private System.Windows.Forms.DataGridView dgvBuildingDrawings;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDrawingTotal;
        private System.Windows.Forms.TextBox txtDrawingNum;
        private System.Windows.Forms.PictureBox pbDrawingRight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pbDrawings;
        private System.Windows.Forms.PictureBox pbDrawingLeft;
        private Bunifu.Framework.UI.BunifuDropdown cbUnit;
        private System.Windows.Forms.Label label15;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtStatus;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtLocationUrl;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAddress;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTotalArea;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnEdit;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdd;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearch;
        private Bunifu.Framework.UI.BunifuFlatButton btnOwnerScan;
        private Bunifu.Framework.UI.BunifuFlatButton btnOwnerBrowse;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn farmid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationUrl;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
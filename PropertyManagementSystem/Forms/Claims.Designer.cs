namespace PropertyManagementSystem.Forms
{
    partial class Claims
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Claims));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propertytype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propertyname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starton = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtClient = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProperty = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPayEvery = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMethod = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPaymentDate = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPrint = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPayed = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnScan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBrowse = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label8 = new System.Windows.Forms.Label();
            this.pbClaimDoc = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClaimDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PropertyManagementSystem.Properties.Resources.Close;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(1012, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 15);
            this.pictureBox1.TabIndex = 276;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Monotype Corsiva", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.lblFullName.Location = new System.Drawing.Point(450, 11);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(144, 24);
            this.lblFullName.TabIndex = 277;
            this.lblFullName.Text = "Financial Claims";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(12, 92);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(682, 249);
            this.groupBox1.TabIndex = 278;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Claims";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.clientname,
            this.propertytype,
            this.propertyname,
            this.starton,
            this.endon});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(676, 229);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // clientname
            // 
            this.clientname.HeaderText = "Client";
            this.clientname.Name = "clientname";
            this.clientname.ReadOnly = true;
            this.clientname.Width = 195;
            // 
            // propertytype
            // 
            this.propertytype.HeaderText = "Property Type";
            this.propertytype.Name = "propertytype";
            this.propertytype.ReadOnly = true;
            this.propertytype.Width = 125;
            // 
            // propertyname
            // 
            this.propertyname.HeaderText = "Property Name";
            this.propertyname.Name = "propertyname";
            this.propertyname.ReadOnly = true;
            this.propertyname.Width = 150;
            // 
            // starton
            // 
            this.starton.HeaderText = "Start On";
            this.starton.Name = "starton";
            this.starton.ReadOnly = true;
            // 
            // endon
            // 
            this.endon.HeaderText = "End On";
            this.endon.Name = "endon";
            this.endon.ReadOnly = true;
            // 
            // txtClient
            // 
            this.txtClient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClient.Enabled = false;
            this.txtClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtClient.HintForeColor = System.Drawing.Color.Empty;
            this.txtClient.HintText = "";
            this.txtClient.isPassword = false;
            this.txtClient.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtClient.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.txtClient.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtClient.LineThickness = 3;
            this.txtClient.Location = new System.Drawing.Point(107, 361);
            this.txtClient.Margin = new System.Windows.Forms.Padding(4);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(204, 27);
            this.txtClient.TabIndex = 301;
            this.txtClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(30, 371);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 300;
            this.label1.Text = "Client";
            // 
            // txtProperty
            // 
            this.txtProperty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProperty.Enabled = false;
            this.txtProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtProperty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProperty.HintForeColor = System.Drawing.Color.Empty;
            this.txtProperty.HintText = "";
            this.txtProperty.isPassword = false;
            this.txtProperty.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtProperty.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.txtProperty.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtProperty.LineThickness = 3;
            this.txtProperty.Location = new System.Drawing.Point(454, 361);
            this.txtProperty.Margin = new System.Windows.Forms.Padding(4);
            this.txtProperty.Name = "txtProperty";
            this.txtProperty.Size = new System.Drawing.Size(223, 27);
            this.txtProperty.TabIndex = 303;
            this.txtProperty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(375, 371);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 302;
            this.label2.Text = "Property";
            // 
            // txtPrice
            // 
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.Enabled = false;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrice.HintForeColor = System.Drawing.Color.Empty;
            this.txtPrice.HintText = "";
            this.txtPrice.isPassword = false;
            this.txtPrice.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPrice.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.txtPrice.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPrice.LineThickness = 3;
            this.txtPrice.Location = new System.Drawing.Point(107, 409);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(160, 27);
            this.txtPrice.TabIndex = 305;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(28, 419);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 304;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(273, 419);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 306;
            this.label4.Text = "SDG";
            // 
            // txtPayEvery
            // 
            this.txtPayEvery.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPayEvery.Enabled = false;
            this.txtPayEvery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPayEvery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPayEvery.HintForeColor = System.Drawing.Color.Empty;
            this.txtPayEvery.HintText = "";
            this.txtPayEvery.isPassword = false;
            this.txtPayEvery.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPayEvery.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.txtPayEvery.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPayEvery.LineThickness = 3;
            this.txtPayEvery.Location = new System.Drawing.Point(454, 409);
            this.txtPayEvery.Margin = new System.Windows.Forms.Padding(4);
            this.txtPayEvery.Name = "txtPayEvery";
            this.txtPayEvery.Size = new System.Drawing.Size(223, 27);
            this.txtPayEvery.TabIndex = 309;
            this.txtPayEvery.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(377, 419);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 308;
            this.label5.Text = "Pay every";
            // 
            // txtMethod
            // 
            this.txtMethod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMethod.Enabled = false;
            this.txtMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMethod.HintForeColor = System.Drawing.Color.Empty;
            this.txtMethod.HintText = "";
            this.txtMethod.isPassword = false;
            this.txtMethod.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMethod.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.txtMethod.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMethod.LineThickness = 3;
            this.txtMethod.Location = new System.Drawing.Point(107, 454);
            this.txtMethod.Margin = new System.Windows.Forms.Padding(4);
            this.txtMethod.Name = "txtMethod";
            this.txtMethod.Size = new System.Drawing.Size(204, 27);
            this.txtMethod.TabIndex = 311;
            this.txtMethod.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(28, 464);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 310;
            this.label6.Text = "Method";
            // 
            // txtPaymentDate
            // 
            this.txtPaymentDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPaymentDate.Enabled = false;
            this.txtPaymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPaymentDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPaymentDate.HintForeColor = System.Drawing.Color.Empty;
            this.txtPaymentDate.HintText = "";
            this.txtPaymentDate.isPassword = false;
            this.txtPaymentDate.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPaymentDate.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.txtPaymentDate.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPaymentDate.LineThickness = 3;
            this.txtPaymentDate.Location = new System.Drawing.Point(454, 454);
            this.txtPaymentDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaymentDate.Name = "txtPaymentDate";
            this.txtPaymentDate.Size = new System.Drawing.Size(223, 27);
            this.txtPaymentDate.TabIndex = 313;
            this.txtPaymentDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(340, 464);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 17);
            this.label7.TabIndex = 312;
            this.label7.Text = "Payment Date";
            // 
            // btnPrint
            // 
            this.btnPrint.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrint.BorderRadius = 7;
            this.btnPrint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnPrint.ButtonText = "Print Claim";
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.DisabledColor = System.Drawing.Color.Gray;
            this.btnPrint.Enabled = false;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnPrint.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPrint.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPrint.Iconimage")));
            this.btnPrint.Iconimage_right = null;
            this.btnPrint.Iconimage_right_Selected = null;
            this.btnPrint.Iconimage_Selected = null;
            this.btnPrint.IconMarginLeft = 0;
            this.btnPrint.IconMarginRight = 0;
            this.btnPrint.IconRightVisible = true;
            this.btnPrint.IconRightZoom = 0D;
            this.btnPrint.IconVisible = true;
            this.btnPrint.IconZoom = 50D;
            this.btnPrint.IsTab = false;
            this.btnPrint.Location = new System.Drawing.Point(157, 500);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnPrint.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnPrint.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPrint.selected = false;
            this.btnPrint.Size = new System.Drawing.Size(119, 46);
            this.btnPrint.TabIndex = 314;
            this.btnPrint.Text = "Print Claim";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrint.Textcolor = System.Drawing.Color.White;
            this.btnPrint.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnPayed
            // 
            this.btnPayed.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnPayed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnPayed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPayed.BorderRadius = 7;
            this.btnPayed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnPayed.ButtonText = "Mark as payed";
            this.btnPayed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayed.DisabledColor = System.Drawing.Color.Gray;
            this.btnPayed.Enabled = false;
            this.btnPayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnPayed.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPayed.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPayed.Iconimage")));
            this.btnPayed.Iconimage_right = null;
            this.btnPayed.Iconimage_right_Selected = null;
            this.btnPayed.Iconimage_Selected = null;
            this.btnPayed.IconMarginLeft = 0;
            this.btnPayed.IconMarginRight = 0;
            this.btnPayed.IconRightVisible = true;
            this.btnPayed.IconRightZoom = 0D;
            this.btnPayed.IconVisible = true;
            this.btnPayed.IconZoom = 50D;
            this.btnPayed.IsTab = false;
            this.btnPayed.Location = new System.Drawing.Point(440, 500);
            this.btnPayed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPayed.Name = "btnPayed";
            this.btnPayed.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnPayed.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnPayed.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPayed.selected = false;
            this.btnPayed.Size = new System.Drawing.Size(146, 46);
            this.btnPayed.TabIndex = 315;
            this.btnPayed.Tag = "";
            this.btnPayed.Text = "Mark as payed";
            this.btnPayed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPayed.Textcolor = System.Drawing.Color.White;
            this.btnPayed.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayed.Click += new System.EventHandler(this.btnPayed_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(750, 500);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnCancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancel.selected = false;
            this.btnCancel.Size = new System.Drawing.Size(126, 46);
            this.btnCancel.TabIndex = 316;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Textcolor = System.Drawing.Color.White;
            this.btnCancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.txtSearch.Location = new System.Drawing.Point(87, 51);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(168, 35);
            this.txtSearch.TabIndex = 318;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(11, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 317;
            this.label9.Text = "Search";
            this.label9.Visible = false;
            // 
            // btnScan
            // 
            this.btnScan.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnScan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScan.BorderRadius = 7;
            this.btnScan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnScan.ButtonText = "Scan";
            this.btnScan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScan.DisabledColor = System.Drawing.Color.Gray;
            this.btnScan.Enabled = false;
            this.btnScan.Iconcolor = System.Drawing.Color.Transparent;
            this.btnScan.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnScan.Iconimage")));
            this.btnScan.Iconimage_right = null;
            this.btnScan.Iconimage_right_Selected = null;
            this.btnScan.Iconimage_Selected = null;
            this.btnScan.IconMarginLeft = 0;
            this.btnScan.IconMarginRight = 0;
            this.btnScan.IconRightVisible = true;
            this.btnScan.IconRightZoom = 0D;
            this.btnScan.IconVisible = true;
            this.btnScan.IconZoom = 50D;
            this.btnScan.IsTab = false;
            this.btnScan.Location = new System.Drawing.Point(935, 186);
            this.btnScan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnScan.Name = "btnScan";
            this.btnScan.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnScan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnScan.OnHoverTextColor = System.Drawing.Color.White;
            this.btnScan.selected = false;
            this.btnScan.Size = new System.Drawing.Size(90, 29);
            this.btnScan.TabIndex = 322;
            this.btnScan.Text = "Scan";
            this.btnScan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnScan.Textcolor = System.Drawing.Color.White;
            this.btnScan.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnBrowse
            // 
            this.btnBrowse.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBrowse.BorderRadius = 7;
            this.btnBrowse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnBrowse.ButtonText = "Browse";
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.DisabledColor = System.Drawing.Color.Gray;
            this.btnBrowse.Enabled = false;
            this.btnBrowse.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBrowse.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBrowse.Iconimage")));
            this.btnBrowse.Iconimage_right = null;
            this.btnBrowse.Iconimage_right_Selected = null;
            this.btnBrowse.Iconimage_Selected = null;
            this.btnBrowse.IconMarginLeft = 0;
            this.btnBrowse.IconMarginRight = 0;
            this.btnBrowse.IconRightVisible = true;
            this.btnBrowse.IconRightZoom = 0D;
            this.btnBrowse.IconVisible = true;
            this.btnBrowse.IconZoom = 50D;
            this.btnBrowse.IsTab = false;
            this.btnBrowse.Location = new System.Drawing.Point(935, 147);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnBrowse.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnBrowse.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBrowse.selected = false;
            this.btnBrowse.Size = new System.Drawing.Size(90, 29);
            this.btnBrowse.TabIndex = 321;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBrowse.Textcolor = System.Drawing.Color.White;
            this.btnBrowse.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(774, 88);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 17);
            this.label8.TabIndex = 320;
            this.label8.Text = "Company Logo";
            // 
            // pbClaimDoc
            // 
            this.pbClaimDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbClaimDoc.Location = new System.Drawing.Point(715, 110);
            this.pbClaimDoc.Margin = new System.Windows.Forms.Padding(2);
            this.pbClaimDoc.Name = "pbClaimDoc";
            this.pbClaimDoc.Size = new System.Drawing.Size(214, 187);
            this.pbClaimDoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClaimDoc.TabIndex = 319;
            this.pbClaimDoc.TabStop = false;
            this.pbClaimDoc.DoubleClick += new System.EventHandler(this.pbClaimDoc_DoubleClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Claims
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PropertyManagementSystem.Properties.Resources.Border;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1039, 573);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pbClaimDoc);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPayed);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtPaymentDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMethod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPayEvery);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProperty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Claims";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Claims";
            this.Load += new System.EventHandler(this.Claims_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClaimDoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientname;
        private System.Windows.Forms.DataGridViewTextBoxColumn propertytype;
        private System.Windows.Forms.DataGridViewTextBoxColumn propertyname;
        private System.Windows.Forms.DataGridViewTextBoxColumn starton;
        private System.Windows.Forms.DataGridViewTextBoxColumn endon;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtClient;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtProperty;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPayEvery;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMethod;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPaymentDate;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrint;
        private Bunifu.Framework.UI.BunifuFlatButton btnPayed;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearch;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuFlatButton btnScan;
        private Bunifu.Framework.UI.BunifuFlatButton btnBrowse;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pbClaimDoc;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
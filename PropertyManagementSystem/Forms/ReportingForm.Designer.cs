namespace PropertyManagementSystem.Forms
{
    partial class ReportingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportingForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rbCashFlow = new System.Windows.Forms.RadioButton();
            this.rbOccupation = new System.Windows.Forms.RadioButton();
            this.rbDetailedHistory = new System.Windows.Forms.RadioButton();
            this.gbDetailed = new System.Windows.Forms.GroupBox();
            this.cbProperty = new Bunifu.Framework.UI.BunifuDropdown();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPropertyType = new Bunifu.Framework.UI.BunifuDropdown();
            this.label2 = new System.Windows.Forms.Label();
            this.cbReportFor = new Bunifu.Framework.UI.BunifuDropdown();
            this.label1 = new System.Windows.Forms.Label();
            this.gbOccupation = new System.Windows.Forms.GroupBox();
            this.cbProperty2 = new Bunifu.Framework.UI.BunifuDropdown();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPropertyType2 = new Bunifu.Framework.UI.BunifuDropdown();
            this.label5 = new System.Windows.Forms.Label();
            this.cbReportFor2 = new Bunifu.Framework.UI.BunifuDropdown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnReport = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cbTempProperty = new System.Windows.Forms.ComboBox();
            this.gbCashFlow = new System.Windows.Forms.GroupBox();
            this.chbUncollected = new System.Windows.Forms.CheckBox();
            this.cbPeriod = new Bunifu.Framework.UI.BunifuDropdown();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpStart = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpEnd = new Bunifu.Framework.UI.BunifuDatepicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbDetailed.SuspendLayout();
            this.gbOccupation.SuspendLayout();
            this.gbCashFlow.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PropertyManagementSystem.Properties.Resources.Close;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(572, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 15);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Monotype Corsiva", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.lblFullName.Location = new System.Drawing.Point(237, 9);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(136, 24);
            this.lblFullName.TabIndex = 275;
            this.lblFullName.Text = "Reporting Form";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(12, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 17);
            this.label11.TabIndex = 276;
            this.label11.Text = "Report Type :";
            // 
            // rbCashFlow
            // 
            this.rbCashFlow.AutoSize = true;
            this.rbCashFlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbCashFlow.Location = new System.Drawing.Point(27, 111);
            this.rbCashFlow.Name = "rbCashFlow";
            this.rbCashFlow.Size = new System.Drawing.Size(137, 21);
            this.rbCashFlow.TabIndex = 277;
            this.rbCashFlow.TabStop = true;
            this.rbCashFlow.Text = "Cash Flow Report";
            this.rbCashFlow.UseVisualStyleBackColor = true;
            this.rbCashFlow.CheckedChanged += new System.EventHandler(this.rbCashFlow_CheckedChanged);
            // 
            // rbOccupation
            // 
            this.rbOccupation.AutoSize = true;
            this.rbOccupation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbOccupation.Location = new System.Drawing.Point(191, 111);
            this.rbOccupation.Name = "rbOccupation";
            this.rbOccupation.Size = new System.Drawing.Size(145, 21);
            this.rbOccupation.TabIndex = 278;
            this.rbOccupation.TabStop = true;
            this.rbOccupation.Text = "Occupation Report";
            this.rbOccupation.UseVisualStyleBackColor = true;
            this.rbOccupation.CheckedChanged += new System.EventHandler(this.rbOccupation_CheckedChanged);
            // 
            // rbDetailedHistory
            // 
            this.rbDetailedHistory.AutoSize = true;
            this.rbDetailedHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbDetailedHistory.Location = new System.Drawing.Point(367, 111);
            this.rbDetailedHistory.Name = "rbDetailedHistory";
            this.rbDetailedHistory.Size = new System.Drawing.Size(220, 21);
            this.rbDetailedHistory.TabIndex = 279;
            this.rbDetailedHistory.TabStop = true;
            this.rbDetailedHistory.Text = "Detailed History For Properties";
            this.rbDetailedHistory.UseVisualStyleBackColor = true;
            this.rbDetailedHistory.CheckedChanged += new System.EventHandler(this.rbDetailedHistory_CheckedChanged);
            // 
            // gbDetailed
            // 
            this.gbDetailed.Controls.Add(this.cbProperty);
            this.gbDetailed.Controls.Add(this.label3);
            this.gbDetailed.Controls.Add(this.cbPropertyType);
            this.gbDetailed.Controls.Add(this.label2);
            this.gbDetailed.Controls.Add(this.cbReportFor);
            this.gbDetailed.Controls.Add(this.label1);
            this.gbDetailed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gbDetailed.Location = new System.Drawing.Point(13, 169);
            this.gbDetailed.Name = "gbDetailed";
            this.gbDetailed.Size = new System.Drawing.Size(574, 168);
            this.gbDetailed.TabIndex = 280;
            this.gbDetailed.TabStop = false;
            this.gbDetailed.Visible = false;
            // 
            // cbProperty
            // 
            this.cbProperty.BackColor = System.Drawing.Color.Transparent;
            this.cbProperty.BorderRadius = 7;
            this.cbProperty.DisabledColor = System.Drawing.Color.Gray;
            this.cbProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbProperty.ForeColor = System.Drawing.Color.White;
            this.cbProperty.Items = new string[0];
            this.cbProperty.Location = new System.Drawing.Point(121, 100);
            this.cbProperty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbProperty.Name = "cbProperty";
            this.cbProperty.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.cbProperty.onHoverColor = System.Drawing.Color.Blue;
            this.cbProperty.selectedIndex = -1;
            this.cbProperty.Size = new System.Drawing.Size(239, 33);
            this.cbProperty.TabIndex = 286;
            this.cbProperty.onItemSelected += new System.EventHandler(this.cbProperty_onItemSelected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(11, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 285;
            this.label3.Text = "Property";
            // 
            // cbPropertyType
            // 
            this.cbPropertyType.BackColor = System.Drawing.Color.Transparent;
            this.cbPropertyType.BorderRadius = 7;
            this.cbPropertyType.DisabledColor = System.Drawing.Color.Gray;
            this.cbPropertyType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbPropertyType.ForeColor = System.Drawing.Color.White;
            this.cbPropertyType.Items = new string[0];
            this.cbPropertyType.Location = new System.Drawing.Point(121, 63);
            this.cbPropertyType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPropertyType.Name = "cbPropertyType";
            this.cbPropertyType.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.cbPropertyType.onHoverColor = System.Drawing.Color.Blue;
            this.cbPropertyType.selectedIndex = -1;
            this.cbPropertyType.Size = new System.Drawing.Size(239, 33);
            this.cbPropertyType.TabIndex = 284;
            this.cbPropertyType.onItemSelected += new System.EventHandler(this.cbPropertyType_onItemSelected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(11, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 283;
            this.label2.Text = "Property type";
            // 
            // cbReportFor
            // 
            this.cbReportFor.BackColor = System.Drawing.Color.Transparent;
            this.cbReportFor.BorderRadius = 7;
            this.cbReportFor.DisabledColor = System.Drawing.Color.Gray;
            this.cbReportFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbReportFor.ForeColor = System.Drawing.Color.White;
            this.cbReportFor.Items = new string[] {
        "All",
        "Single Property"};
            this.cbReportFor.Location = new System.Drawing.Point(121, 26);
            this.cbReportFor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbReportFor.Name = "cbReportFor";
            this.cbReportFor.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.cbReportFor.onHoverColor = System.Drawing.Color.Blue;
            this.cbReportFor.selectedIndex = -1;
            this.cbReportFor.Size = new System.Drawing.Size(239, 33);
            this.cbReportFor.TabIndex = 282;
            this.cbReportFor.onItemSelected += new System.EventHandler(this.cbReportFor_onItemSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(11, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 281;
            this.label1.Text = "Report for";
            // 
            // gbOccupation
            // 
            this.gbOccupation.Controls.Add(this.cbProperty2);
            this.gbOccupation.Controls.Add(this.label4);
            this.gbOccupation.Controls.Add(this.cbPropertyType2);
            this.gbOccupation.Controls.Add(this.label5);
            this.gbOccupation.Controls.Add(this.cbReportFor2);
            this.gbOccupation.Controls.Add(this.label6);
            this.gbOccupation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gbOccupation.Location = new System.Drawing.Point(15, 163);
            this.gbOccupation.Name = "gbOccupation";
            this.gbOccupation.Size = new System.Drawing.Size(574, 168);
            this.gbOccupation.TabIndex = 287;
            this.gbOccupation.TabStop = false;
            this.gbOccupation.Visible = false;
            // 
            // cbProperty2
            // 
            this.cbProperty2.BackColor = System.Drawing.Color.Transparent;
            this.cbProperty2.BorderRadius = 7;
            this.cbProperty2.DisabledColor = System.Drawing.Color.Gray;
            this.cbProperty2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbProperty2.ForeColor = System.Drawing.Color.White;
            this.cbProperty2.Items = new string[0];
            this.cbProperty2.Location = new System.Drawing.Point(121, 100);
            this.cbProperty2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbProperty2.Name = "cbProperty2";
            this.cbProperty2.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.cbProperty2.onHoverColor = System.Drawing.Color.Blue;
            this.cbProperty2.selectedIndex = -1;
            this.cbProperty2.Size = new System.Drawing.Size(239, 33);
            this.cbProperty2.TabIndex = 286;
            this.cbProperty2.onItemSelected += new System.EventHandler(this.cbProperty2_onItemSelected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(11, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 285;
            this.label4.Text = "Property";
            // 
            // cbPropertyType2
            // 
            this.cbPropertyType2.BackColor = System.Drawing.Color.Transparent;
            this.cbPropertyType2.BorderRadius = 7;
            this.cbPropertyType2.DisabledColor = System.Drawing.Color.Gray;
            this.cbPropertyType2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbPropertyType2.ForeColor = System.Drawing.Color.White;
            this.cbPropertyType2.Items = new string[0];
            this.cbPropertyType2.Location = new System.Drawing.Point(121, 63);
            this.cbPropertyType2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPropertyType2.Name = "cbPropertyType2";
            this.cbPropertyType2.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.cbPropertyType2.onHoverColor = System.Drawing.Color.Blue;
            this.cbPropertyType2.selectedIndex = -1;
            this.cbPropertyType2.Size = new System.Drawing.Size(239, 33);
            this.cbPropertyType2.TabIndex = 284;
            this.cbPropertyType2.onItemSelected += new System.EventHandler(this.cbPropertyType2_onItemSelected);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(11, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 283;
            this.label5.Text = "Property type";
            // 
            // cbReportFor2
            // 
            this.cbReportFor2.BackColor = System.Drawing.Color.Transparent;
            this.cbReportFor2.BorderRadius = 7;
            this.cbReportFor2.DisabledColor = System.Drawing.Color.Gray;
            this.cbReportFor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbReportFor2.ForeColor = System.Drawing.Color.White;
            this.cbReportFor2.Items = new string[] {
        "All",
        "Single Property"};
            this.cbReportFor2.Location = new System.Drawing.Point(121, 26);
            this.cbReportFor2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbReportFor2.Name = "cbReportFor2";
            this.cbReportFor2.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.cbReportFor2.onHoverColor = System.Drawing.Color.Blue;
            this.cbReportFor2.selectedIndex = -1;
            this.cbReportFor2.Size = new System.Drawing.Size(239, 33);
            this.cbReportFor2.TabIndex = 282;
            this.cbReportFor2.onItemSelected += new System.EventHandler(this.cbReportFor2_onItemSelected);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(11, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 281;
            this.label6.Text = "Report for";
            // 
            // btnReport
            // 
            this.btnReport.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReport.BorderRadius = 7;
            this.btnReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnReport.ButtonText = "Report";
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.DisabledColor = System.Drawing.Color.Gray;
            this.btnReport.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReport.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnReport.Iconimage")));
            this.btnReport.Iconimage_right = null;
            this.btnReport.Iconimage_right_Selected = null;
            this.btnReport.Iconimage_Selected = null;
            this.btnReport.IconMarginLeft = 0;
            this.btnReport.IconMarginRight = 0;
            this.btnReport.IconRightVisible = true;
            this.btnReport.IconRightZoom = 0D;
            this.btnReport.IconVisible = true;
            this.btnReport.IconZoom = 50D;
            this.btnReport.IsTab = false;
            this.btnReport.Location = new System.Drawing.Point(241, 365);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReport.Name = "btnReport";
            this.btnReport.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnReport.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.btnReport.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReport.selected = false;
            this.btnReport.Size = new System.Drawing.Size(126, 43);
            this.btnReport.TabIndex = 281;
            this.btnReport.Text = "Report";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReport.Textcolor = System.Drawing.Color.White;
            this.btnReport.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // cbTempProperty
            // 
            this.cbTempProperty.FormattingEnabled = true;
            this.cbTempProperty.Location = new System.Drawing.Point(27, 13);
            this.cbTempProperty.Name = "cbTempProperty";
            this.cbTempProperty.Size = new System.Drawing.Size(33, 21);
            this.cbTempProperty.TabIndex = 282;
            this.cbTempProperty.Visible = false;
            // 
            // gbCashFlow
            // 
            this.gbCashFlow.Controls.Add(this.label8);
            this.gbCashFlow.Controls.Add(this.dtpEnd);
            this.gbCashFlow.Controls.Add(this.label7);
            this.gbCashFlow.Controls.Add(this.dtpStart);
            this.gbCashFlow.Controls.Add(this.chbUncollected);
            this.gbCashFlow.Controls.Add(this.cbPeriod);
            this.gbCashFlow.Controls.Add(this.label9);
            this.gbCashFlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gbCashFlow.Location = new System.Drawing.Point(15, 157);
            this.gbCashFlow.Name = "gbCashFlow";
            this.gbCashFlow.Size = new System.Drawing.Size(574, 168);
            this.gbCashFlow.TabIndex = 288;
            this.gbCashFlow.TabStop = false;
            this.gbCashFlow.Visible = false;
            // 
            // chbUncollected
            // 
            this.chbUncollected.AutoSize = true;
            this.chbUncollected.Location = new System.Drawing.Point(124, 141);
            this.chbUncollected.Name = "chbUncollected";
            this.chbUncollected.Size = new System.Drawing.Size(206, 21);
            this.chbUncollected.TabIndex = 283;
            this.chbUncollected.Text = "Include uncollected amounts";
            this.chbUncollected.UseVisualStyleBackColor = true;
            // 
            // cbPeriod
            // 
            this.cbPeriod.BackColor = System.Drawing.Color.Transparent;
            this.cbPeriod.BorderRadius = 7;
            this.cbPeriod.DisabledColor = System.Drawing.Color.Gray;
            this.cbPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbPeriod.ForeColor = System.Drawing.Color.White;
            this.cbPeriod.Items = new string[] {
        "First quarter of the year",
        "Second quarter of the year",
        "Third quarter of the year",
        "Fourth quarter of the year"};
            this.cbPeriod.Location = new System.Drawing.Point(121, 20);
            this.cbPeriod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPeriod.Name = "cbPeriod";
            this.cbPeriod.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.cbPeriod.onHoverColor = System.Drawing.Color.Blue;
            this.cbPeriod.selectedIndex = -1;
            this.cbPeriod.Size = new System.Drawing.Size(239, 33);
            this.cbPeriod.TabIndex = 282;
            this.cbPeriod.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(11, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 17);
            this.label9.TabIndex = 281;
            this.label9.Text = "Choose Period";
            // 
            // dtpStart
            // 
            this.dtpStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.dtpStart.BorderRadius = 7;
            this.dtpStart.ForeColor = System.Drawing.Color.White;
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpStart.FormatCustom = null;
            this.dtpStart.Location = new System.Drawing.Point(121, 59);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(239, 33);
            this.dtpStart.TabIndex = 284;
            this.dtpStart.Value = new System.DateTime(2019, 9, 1, 18, 21, 38, 542);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(52, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 285;
            this.label7.Text = "From";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(52, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 17);
            this.label8.TabIndex = 287;
            this.label8.Text = "To";
            // 
            // dtpEnd
            // 
            this.dtpEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(110)))), ((int)(((byte)(247)))));
            this.dtpEnd.BorderRadius = 7;
            this.dtpEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpEnd.ForeColor = System.Drawing.Color.White;
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpEnd.FormatCustom = null;
            this.dtpEnd.Location = new System.Drawing.Point(121, 99);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(239, 33);
            this.dtpEnd.TabIndex = 286;
            this.dtpEnd.Value = new System.DateTime(2019, 9, 1, 18, 21, 38, 542);
            // 
            // ReportingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PropertyManagementSystem.Properties.Resources.Border;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(599, 422);
            this.Controls.Add(this.gbCashFlow);
            this.Controls.Add(this.gbOccupation);
            this.Controls.Add(this.cbTempProperty);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.gbDetailed);
            this.Controls.Add(this.rbDetailedHistory);
            this.Controls.Add(this.rbOccupation);
            this.Controls.Add(this.rbCashFlow);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportingForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbDetailed.ResumeLayout(false);
            this.gbDetailed.PerformLayout();
            this.gbOccupation.ResumeLayout(false);
            this.gbOccupation.PerformLayout();
            this.gbCashFlow.ResumeLayout(false);
            this.gbCashFlow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rbCashFlow;
        private System.Windows.Forms.RadioButton rbOccupation;
        private System.Windows.Forms.RadioButton rbDetailedHistory;
        private System.Windows.Forms.GroupBox gbDetailed;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDropdown cbProperty;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDropdown cbPropertyType;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDropdown cbReportFor;
        private Bunifu.Framework.UI.BunifuFlatButton btnReport;
        private System.Windows.Forms.ComboBox cbTempProperty;
        private System.Windows.Forms.GroupBox gbOccupation;
        private Bunifu.Framework.UI.BunifuDropdown cbProperty2;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuDropdown cbPropertyType2;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuDropdown cbReportFor2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbCashFlow;
        private Bunifu.Framework.UI.BunifuDropdown cbPeriod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chbUncollected;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuDatepicker dtpEnd;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuDatepicker dtpStart;
    }
}
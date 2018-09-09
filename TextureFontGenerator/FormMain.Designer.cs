namespace TextureFontGenerator
{
    partial class FormMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cbxFont = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chbBold = new System.Windows.Forms.CheckBox();
            this.nudOutline = new System.Windows.Forms.NumericUpDown();
            this.chbOutline = new System.Windows.Forms.CheckBox();
            this.chbShadow = new System.Windows.Forms.CheckBox();
            this.nudWhitespacePercent = new System.Windows.Forms.NumericUpDown();
            this.chbTrimCharWidth = new System.Windows.Forms.CheckBox();
            this.cbxWhitespaceMode = new System.Windows.Forms.ComboBox();
            this.chbPremultipliedAlpha = new System.Windows.Forms.CheckBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panBackColorImage = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.chbCompressImage = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudImageWidth = new System.Windows.Forms.NumericUpDown();
            this.chbBackgroundTransparent = new System.Windows.Forms.CheckBox();
            this.chbAntiAlias = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nudPadding = new System.Windows.Forms.NumericUpDown();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panShadowColor = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panTextColor = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.nudSize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxMaxChar = new System.Windows.Forms.TextBox();
            this.tbxMinChar = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panBackgroundColor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbxPreview = new System.Windows.Forms.PictureBox();
            this.chbItalic = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWhitespacePercent)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudImageWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPadding)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(160, 380);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 28);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Generate";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cbxFont
            // 
            this.cbxFont.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxFont.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxFont.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbxFont.FormattingEnabled = true;
            this.cbxFont.Location = new System.Drawing.Point(0, 16);
            this.cbxFont.Name = "cbxFont";
            this.cbxFont.Size = new System.Drawing.Size(189, 21);
            this.cbxFont.Sorted = true;
            this.cbxFont.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(806, 602);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.chbItalic);
            this.panel1.Controls.Add(this.chbBold);
            this.panel1.Controls.Add(this.nudOutline);
            this.panel1.Controls.Add(this.chbOutline);
            this.panel1.Controls.Add(this.chbShadow);
            this.panel1.Controls.Add(this.nudWhitespacePercent);
            this.panel1.Controls.Add(this.chbTrimCharWidth);
            this.panel1.Controls.Add(this.cbxWhitespaceMode);
            this.panel1.Controls.Add(this.chbPremultipliedAlpha);
            this.panel1.Controls.Add(this.btnInfo);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.chbCompressImage);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.nudImageWidth);
            this.panel1.Controls.Add(this.chbBackgroundTransparent);
            this.panel1.Controls.Add(this.chbAntiAlias);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.nudPadding);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.nudSize);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbxMaxChar);
            this.panel1.Controls.Add(this.tbxMinChar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cbxFont);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Location = new System.Drawing.Point(9, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 584);
            this.panel1.TabIndex = 0;
            // 
            // chbBold
            // 
            this.chbBold.AutoSize = true;
            this.chbBold.Location = new System.Drawing.Point(0, 39);
            this.chbBold.Name = "chbBold";
            this.chbBold.Size = new System.Drawing.Size(47, 17);
            this.chbBold.TabIndex = 1;
            this.chbBold.Text = "Bold";
            this.chbBold.UseVisualStyleBackColor = true;
            // 
            // nudOutline
            // 
            this.nudOutline.DecimalPlaces = 2;
            this.nudOutline.Location = new System.Drawing.Point(0, 252);
            this.nudOutline.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudOutline.Name = "nudOutline";
            this.nudOutline.Size = new System.Drawing.Size(173, 20);
            this.nudOutline.TabIndex = 10;
            this.nudOutline.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // chbOutline
            // 
            this.chbOutline.AutoSize = true;
            this.chbOutline.Location = new System.Drawing.Point(0, 235);
            this.chbOutline.Name = "chbOutline";
            this.chbOutline.Size = new System.Drawing.Size(59, 17);
            this.chbOutline.TabIndex = 9;
            this.chbOutline.Text = "Outline";
            this.chbOutline.UseVisualStyleBackColor = true;
            this.chbOutline.CheckedChanged += new System.EventHandler(this.chbOutline_CheckedChanged);
            // 
            // chbShadow
            // 
            this.chbShadow.AutoSize = true;
            this.chbShadow.Location = new System.Drawing.Point(0, 368);
            this.chbShadow.Name = "chbShadow";
            this.chbShadow.Size = new System.Drawing.Size(65, 17);
            this.chbShadow.TabIndex = 1;
            this.chbShadow.Text = "Shadow";
            this.chbShadow.UseVisualStyleBackColor = true;
            // 
            // nudWhitespacePercent
            // 
            this.nudWhitespacePercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudWhitespacePercent.Location = new System.Drawing.Point(193, 88);
            this.nudWhitespacePercent.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudWhitespacePercent.Name = "nudWhitespacePercent";
            this.nudWhitespacePercent.Size = new System.Drawing.Size(58, 20);
            this.nudWhitespacePercent.TabIndex = 3;
            this.nudWhitespacePercent.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // chbTrimCharWidth
            // 
            this.chbTrimCharWidth.AutoSize = true;
            this.chbTrimCharWidth.Checked = true;
            this.chbTrimCharWidth.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbTrimCharWidth.Location = new System.Drawing.Point(0, 212);
            this.chbTrimCharWidth.Name = "chbTrimCharWidth";
            this.chbTrimCharWidth.Size = new System.Drawing.Size(122, 17);
            this.chbTrimCharWidth.TabIndex = 3;
            this.chbTrimCharWidth.Text = "Trim character width";
            this.chbTrimCharWidth.UseVisualStyleBackColor = true;
            // 
            // cbxWhitespaceMode
            // 
            this.cbxWhitespaceMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxWhitespaceMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxWhitespaceMode.FormattingEnabled = true;
            this.cbxWhitespaceMode.Items.AddRange(new object[] {
            "Original",
            "Avarage character width",
            "Max character width"});
            this.cbxWhitespaceMode.Location = new System.Drawing.Point(0, 87);
            this.cbxWhitespaceMode.Name = "cbxWhitespaceMode";
            this.cbxWhitespaceMode.Size = new System.Drawing.Size(189, 21);
            this.cbxWhitespaceMode.TabIndex = 1;
            this.cbxWhitespaceMode.SelectedIndexChanged += new System.EventHandler(this.cbxWhitespaceMode_SelectedIndexChanged);
            // 
            // chbPremultipliedAlpha
            // 
            this.chbPremultipliedAlpha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chbPremultipliedAlpha.AutoEllipsis = true;
            this.chbPremultipliedAlpha.Checked = true;
            this.chbPremultipliedAlpha.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbPremultipliedAlpha.Location = new System.Drawing.Point(0, 414);
            this.chbPremultipliedAlpha.Name = "chbPremultipliedAlpha";
            this.chbPremultipliedAlpha.Size = new System.Drawing.Size(148, 17);
            this.chbPremultipliedAlpha.TabIndex = 8;
            this.chbPremultipliedAlpha.Text = "Premultiplied alpha";
            this.chbPremultipliedAlpha.UseVisualStyleBackColor = true;
            // 
            // btnInfo
            // 
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnInfo.Location = new System.Drawing.Point(0, 556);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(251, 28);
            this.btnInfo.TabIndex = 1;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.panBackColorImage);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(0, 305);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(251, 23);
            this.panel5.TabIndex = 7;
            // 
            // panBackColorImage
            // 
            this.panBackColorImage.BackColor = System.Drawing.Color.Magenta;
            this.panBackColorImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panBackColorImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panBackColorImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.panBackColorImage.Location = new System.Drawing.Point(0, 0);
            this.panBackColorImage.Name = "panBackColorImage";
            this.panBackColorImage.Size = new System.Drawing.Size(56, 23);
            this.panBackColorImage.TabIndex = 1;
            this.panBackColorImage.Click += new System.EventHandler(this.panBackgroundColor_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoEllipsis = true;
            this.label7.Location = new System.Drawing.Point(59, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Background color image";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chbCompressImage
            // 
            this.chbCompressImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chbCompressImage.AutoEllipsis = true;
            this.chbCompressImage.Checked = true;
            this.chbCompressImage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbCompressImage.Location = new System.Drawing.Point(0, 396);
            this.chbCompressImage.Name = "chbCompressImage";
            this.chbCompressImage.Size = new System.Drawing.Size(154, 17);
            this.chbCompressImage.TabIndex = 1;
            this.chbCompressImage.Text = "Compress image";
            this.chbCompressImage.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Image width";
            // 
            // nudImageWidth
            // 
            this.nudImageWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudImageWidth.Location = new System.Drawing.Point(160, 350);
            this.nudImageWidth.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.nudImageWidth.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudImageWidth.Name = "nudImageWidth";
            this.nudImageWidth.Size = new System.Drawing.Size(80, 20);
            this.nudImageWidth.TabIndex = 3;
            this.nudImageWidth.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // chbBackgroundTransparent
            // 
            this.chbBackgroundTransparent.AutoEllipsis = true;
            this.chbBackgroundTransparent.Checked = true;
            this.chbBackgroundTransparent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbBackgroundTransparent.Location = new System.Drawing.Point(0, 334);
            this.chbBackgroundTransparent.Name = "chbBackgroundTransparent";
            this.chbBackgroundTransparent.Size = new System.Drawing.Size(138, 17);
            this.chbBackgroundTransparent.TabIndex = 3;
            this.chbBackgroundTransparent.Text = "Transparent";
            this.chbBackgroundTransparent.UseVisualStyleBackColor = true;
            // 
            // chbAntiAlias
            // 
            this.chbAntiAlias.AutoEllipsis = true;
            this.chbAntiAlias.Checked = true;
            this.chbAntiAlias.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbAntiAlias.Location = new System.Drawing.Point(0, 351);
            this.chbAntiAlias.Name = "chbAntiAlias";
            this.chbAntiAlias.Size = new System.Drawing.Size(138, 17);
            this.chbAntiAlias.TabIndex = 1;
            this.chbAntiAlias.Text = "Use AntiAlias";
            this.chbAntiAlias.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-3, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Whitespace mode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Font";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(160, 414);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 28);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Padding";
            // 
            // nudPadding
            // 
            this.nudPadding.Location = new System.Drawing.Point(130, 186);
            this.nudPadding.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudPadding.Name = "nudPadding";
            this.nudPadding.Size = new System.Drawing.Size(49, 20);
            this.nudPadding.TabIndex = 1;
            this.nudPadding.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.panShadowColor);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(0, 137);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(251, 23);
            this.panel6.TabIndex = 5;
            // 
            // panShadowColor
            // 
            this.panShadowColor.BackColor = System.Drawing.Color.Black;
            this.panShadowColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panShadowColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panShadowColor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panShadowColor.Location = new System.Drawing.Point(0, 0);
            this.panShadowColor.Name = "panShadowColor";
            this.panShadowColor.Size = new System.Drawing.Size(56, 23);
            this.panShadowColor.TabIndex = 1;
            this.panShadowColor.Click += new System.EventHandler(this.panBackgroundColor_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoEllipsis = true;
            this.label9.Location = new System.Drawing.Point(59, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Shadow color";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.panTextColor);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(0, 115);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(251, 23);
            this.panel4.TabIndex = 5;
            // 
            // panTextColor
            // 
            this.panTextColor.BackColor = System.Drawing.Color.White;
            this.panTextColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panTextColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panTextColor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panTextColor.Location = new System.Drawing.Point(0, 0);
            this.panTextColor.Name = "panTextColor";
            this.panTextColor.Size = new System.Drawing.Size(56, 23);
            this.panTextColor.TabIndex = 1;
            this.panTextColor.Click += new System.EventHandler(this.panBackgroundColor_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoEllipsis = true;
            this.label3.Location = new System.Drawing.Point(59, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Text color";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudSize
            // 
            this.nudSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudSize.Location = new System.Drawing.Point(193, 16);
            this.nudSize.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.nudSize.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(58, 20);
            this.nudSize.TabIndex = 3;
            this.nudSize.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Character range";
            // 
            // tbxMaxChar
            // 
            this.tbxMaxChar.Location = new System.Drawing.Point(58, 186);
            this.tbxMaxChar.MaxLength = 5;
            this.tbxMaxChar.Name = "tbxMaxChar";
            this.tbxMaxChar.Size = new System.Drawing.Size(55, 20);
            this.tbxMaxChar.TabIndex = 3;
            this.tbxMaxChar.Text = "255";
            // 
            // tbxMinChar
            // 
            this.tbxMinChar.Location = new System.Drawing.Point(0, 186);
            this.tbxMinChar.MaxLength = 5;
            this.tbxMinChar.Name = "tbxMinChar";
            this.tbxMinChar.Size = new System.Drawing.Size(55, 20);
            this.tbxMinChar.TabIndex = 3;
            this.tbxMinChar.Text = "32";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.panBackgroundColor);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 280);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 23);
            this.panel2.TabIndex = 2;
            // 
            // panBackgroundColor
            // 
            this.panBackgroundColor.BackColor = System.Drawing.Color.Magenta;
            this.panBackgroundColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panBackgroundColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panBackgroundColor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panBackgroundColor.Location = new System.Drawing.Point(0, 0);
            this.panBackgroundColor.Name = "panBackgroundColor";
            this.panBackgroundColor.Size = new System.Drawing.Size(56, 23);
            this.panBackgroundColor.TabIndex = 1;
            this.panBackgroundColor.Click += new System.EventHandler(this.panBackgroundColor_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoEllipsis = true;
            this.label1.Location = new System.Drawing.Point(59, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Background color characters";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.pbxPreview);
            this.panel3.Location = new System.Drawing.Point(269, 1);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(536, 600);
            this.panel3.TabIndex = 1;
            // 
            // pbxPreview
            // 
            this.pbxPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxPreview.Location = new System.Drawing.Point(0, 0);
            this.pbxPreview.Name = "pbxPreview";
            this.pbxPreview.Size = new System.Drawing.Size(100, 100);
            this.pbxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxPreview.TabIndex = 0;
            this.pbxPreview.TabStop = false;
            // 
            // chbItalic
            // 
            this.chbItalic.AutoSize = true;
            this.chbItalic.Location = new System.Drawing.Point(53, 39);
            this.chbItalic.Name = "chbItalic";
            this.chbItalic.Size = new System.Drawing.Size(48, 17);
            this.chbItalic.TabIndex = 1;
            this.chbItalic.Text = "Italic";
            this.chbItalic.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 612);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TextureFont Generator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWhitespacePercent)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudImageWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPadding)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cbxFont;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panBackgroundColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pbxPreview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxMaxChar;
        private System.Windows.Forms.TextBox tbxMinChar;
        private System.Windows.Forms.NumericUpDown nudSize;
        private System.Windows.Forms.CheckBox chbBackgroundTransparent;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panTextColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudPadding;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chbAntiAlias;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudImageWidth;
        private System.Windows.Forms.CheckBox chbCompressImage;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panBackColorImage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.CheckBox chbPremultipliedAlpha;
        private System.Windows.Forms.ComboBox cbxWhitespaceMode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chbTrimCharWidth;
        private System.Windows.Forms.NumericUpDown nudWhitespacePercent;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panShadowColor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chbShadow;
        private System.Windows.Forms.CheckBox chbOutline;
        private System.Windows.Forms.NumericUpDown nudOutline;
        private System.Windows.Forms.CheckBox chbBold;
        private System.Windows.Forms.CheckBox chbItalic;
    }
}


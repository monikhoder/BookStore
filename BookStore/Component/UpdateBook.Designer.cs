namespace BookStore.Component
{
    partial class UpdateBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateBook));
            KimTools.WinForms.KtSwitch.KtSwitchState ktSwitchState1 = new KimTools.WinForms.KtSwitch.KtSwitchState();
            KimTools.WinForms.KtSwitch.KtSwitchState ktSwitchState2 = new KimTools.WinForms.KtSwitch.KtSwitchState();
            this.Toppanel = new System.Windows.Forms.Panel();
            this.txtTitle = new KimTools.WinForms.KtTextBox();
            this.lblBookTitle = new KimTools.WinForms.KtLabel();
            this.BookCover = new System.Windows.Forms.PictureBox();
            this.lblAuthor = new KimTools.WinForms.KtLabel();
            this.cmbAuthor = new KimTools.WinForms.KtComboBox();
            this.cmbPublisher = new KimTools.WinForms.KtComboBox();
            this.lblPublisher = new KimTools.WinForms.KtLabel();
            this.lblPublishingDate = new KimTools.WinForms.KtLabel();
            this.cmbGenre = new KimTools.WinForms.KtComboBox();
            this.lblGenre = new KimTools.WinForms.KtLabel();
            this.lblCostPrice = new KimTools.WinForms.KtLabel();
            this.lblSalePrice = new KimTools.WinForms.KtLabel();
            this.lblIsSequel = new KimTools.WinForms.KtLabel();
            this.IsSequelSwith = new KimTools.WinForms.KtSwitch();
            this.btnClose = new KimTools.WinForms.KtButton();
            this.btnUpdate = new KimTools.WinForms.KtButton();
            this.txbSalePrice = new KimTools.WinForms.KtTextBox();
            this.txbCostPrice = new KimTools.WinForms.KtTextBox();
            this.PublishingDatePicker = new KimTools.WinForms.KtDate();
            this.ktLabel1 = new KimTools.WinForms.KtLabel();
            this.lblPages = new KimTools.WinForms.KtLabel();
            this.txbStock = new KimTools.WinForms.KtTextBox();
            this.txbPages = new KimTools.WinForms.KtTextBox();
            this.txbId = new KimTools.WinForms.KtTextBox();
            this.Toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookCover)).BeginInit();
            this.SuspendLayout();
            // 
            // Toppanel
            // 
            this.Toppanel.Controls.Add(this.txbId);
            this.Toppanel.Controls.Add(this.txtTitle);
            this.Toppanel.Controls.Add(this.lblBookTitle);
            this.Toppanel.Controls.Add(this.BookCover);
            this.Toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Toppanel.Location = new System.Drawing.Point(0, 0);
            this.Toppanel.Name = "Toppanel";
            this.Toppanel.Size = new System.Drawing.Size(671, 170);
            this.Toppanel.TabIndex = 1;
            // 
            // txtTitle
            // 
            this.txtTitle.AcceptsReturn = false;
            this.txtTitle.AcceptsTab = false;
            this.txtTitle.AnimationSpeed = 200;
            this.txtTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTitle.AutoSizeHeight = true;
            this.txtTitle.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.txtTitle.Bg = KimTools.WinForms.KtColor.ForeColor;
            this.txtTitle.Content = KimTools.WinForms.KtColor.BackColor;
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.CustomBorderColor = System.Drawing.Color.Empty;
            this.txtTitle.CustomBorderColorActive = System.Drawing.Color.Empty;
            this.txtTitle.CustomBorderColorDisabled = System.Drawing.Color.Empty;
            this.txtTitle.CustomFillColor = System.Drawing.Color.White;
            this.txtTitle.CustomIconLeft = null;
            this.txtTitle.CustomIconRight = null;
            this.txtTitle.CustomPlaceholderColor = System.Drawing.Color.Empty;
            this.txtTitle.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.Color.Black;
            this.txtTitle.HideSelection = true;
            this.txtTitle.Lines = new string[0];
            this.txtTitle.Location = new System.Drawing.Point(238, 60);
            this.txtTitle.MaxLength = 32767;
            this.txtTitle.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtTitle.Modified = false;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Password = false;
            this.txtTitle.PasswordChar = '\0';
            this.txtTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTitle.SelectedText = "";
            this.txtTitle.SelectionLength = 0;
            this.txtTitle.SelectionStart = 0;
            this.txtTitle.ShortcutsEnabled = true;
            this.txtTitle.Size = new System.Drawing.Size(341, 52);
            this.txtTitle.Style = KimTools.WinForms.KtTextBox.KtTextBoxStyle.Custom;
            this.txtTitle.TabIndex = 2;
            this.txtTitle.TextMarginBottom = 0;
            this.txtTitle.TextPlaceholder = "";
            this.txtTitle.TextChange += new System.EventHandler(this.TextBook_TextChange);
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblBookTitle.ForeColor = System.Drawing.Color.Black;
            this.lblBookTitle.KtFontSize = KimTools.WinForms.KtFont.Default;
            this.lblBookTitle.LabelColor = KimTools.WinForms.KtColor.Tailwind_Black;
            this.lblBookTitle.Location = new System.Drawing.Point(165, 20);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(96, 25);
            this.lblBookTitle.TabIndex = 1;
            this.lblBookTitle.Text = "Book Title";
            // 
            // BookCover
            // 
            this.BookCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BookCover.Image = global::BookStore.Properties.Resources.add_book;
            this.BookCover.Location = new System.Drawing.Point(34, 17);
            this.BookCover.Name = "BookCover";
            this.BookCover.Size = new System.Drawing.Size(100, 135);
            this.BookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BookCover.TabIndex = 0;
            this.BookCover.TabStop = false;
            this.BookCover.Click += new System.EventHandler(this.BookCover_Click);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblAuthor.ForeColor = System.Drawing.Color.Black;
            this.lblAuthor.KtFontSize = KimTools.WinForms.KtFont.Default;
            this.lblAuthor.LabelColor = KimTools.WinForms.KtColor.Tailwind_Black;
            this.lblAuthor.Location = new System.Drawing.Point(38, 185);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(70, 25);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Author";
            // 
            // cmbAuthor
            // 
            this.cmbAuthor.BackColor = System.Drawing.Color.Transparent;
            this.cmbAuthor.BackgroundColor = System.Drawing.Color.White;
            this.cmbAuthor.BorderColor = System.Drawing.Color.Silver;
            this.cmbAuthor.BorderRadius = 1;
            this.cmbAuthor.Color = System.Drawing.Color.Silver;
            this.cmbAuthor.Direction = KimTools.WinForms.KtComboBox.Directions.Down;
            this.cmbAuthor.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbAuthor.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbAuthor.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbAuthor.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbAuthor.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbAuthor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAuthor.DropdownBorderThickness = KimTools.WinForms.KtComboBox.BorderThickness.Thin;
            this.cmbAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAuthor.DropDownTextAlign = KimTools.WinForms.KtComboBox.TextAlign.Left;
            this.cmbAuthor.FillDropDown = true;
            this.cmbAuthor.FillIndicator = false;
            this.cmbAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAuthor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbAuthor.ForeColor = System.Drawing.Color.Black;
            this.cmbAuthor.FormattingEnabled = true;
            this.cmbAuthor.Icon = null;
            this.cmbAuthor.IndicatorAlignment = KimTools.WinForms.KtComboBox.Indicator.Right;
            this.cmbAuthor.IndicatorColor = System.Drawing.Color.Gray;
            this.cmbAuthor.IndicatorLocation = KimTools.WinForms.KtComboBox.Indicator.Right;
            this.cmbAuthor.ItemBackColor = System.Drawing.Color.White;
            this.cmbAuthor.ItemBorderColor = System.Drawing.Color.SlateBlue;
            this.cmbAuthor.ItemForeColor = System.Drawing.Color.Black;
            this.cmbAuthor.ItemHeight = 26;
            this.cmbAuthor.ItemHighLightColor = System.Drawing.Color.SlateBlue;
            this.cmbAuthor.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cmbAuthor.ItemTopMargin = 3;
            this.cmbAuthor.Location = new System.Drawing.Point(38, 232);
            this.cmbAuthor.Name = "cmbAuthor";
            this.cmbAuthor.Size = new System.Drawing.Size(236, 32);
            this.cmbAuthor.TabIndex = 3;
            this.cmbAuthor.Text = null;
            this.cmbAuthor.TextAlignment = KimTools.WinForms.KtComboBox.TextAlign.Left;
            this.cmbAuthor.TextLeftMargin = 5;
            this.cmbAuthor.SelectedIndexChanged += new System.EventHandler(this.cmbBox_SelectedIndexChanged_1);
            // 
            // cmbPublisher
            // 
            this.cmbPublisher.BackColor = System.Drawing.Color.Transparent;
            this.cmbPublisher.BackgroundColor = System.Drawing.Color.White;
            this.cmbPublisher.BorderColor = System.Drawing.Color.Silver;
            this.cmbPublisher.BorderRadius = 1;
            this.cmbPublisher.Color = System.Drawing.Color.Silver;
            this.cmbPublisher.Direction = KimTools.WinForms.KtComboBox.Directions.Down;
            this.cmbPublisher.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbPublisher.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbPublisher.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbPublisher.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbPublisher.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbPublisher.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPublisher.DropdownBorderThickness = KimTools.WinForms.KtComboBox.BorderThickness.Thin;
            this.cmbPublisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPublisher.DropDownTextAlign = KimTools.WinForms.KtComboBox.TextAlign.Left;
            this.cmbPublisher.FillDropDown = true;
            this.cmbPublisher.FillIndicator = false;
            this.cmbPublisher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPublisher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbPublisher.ForeColor = System.Drawing.Color.Black;
            this.cmbPublisher.FormattingEnabled = true;
            this.cmbPublisher.Icon = null;
            this.cmbPublisher.IndicatorAlignment = KimTools.WinForms.KtComboBox.Indicator.Right;
            this.cmbPublisher.IndicatorColor = System.Drawing.Color.Gray;
            this.cmbPublisher.IndicatorLocation = KimTools.WinForms.KtComboBox.Indicator.Right;
            this.cmbPublisher.ItemBackColor = System.Drawing.Color.White;
            this.cmbPublisher.ItemBorderColor = System.Drawing.Color.White;
            this.cmbPublisher.ItemForeColor = System.Drawing.Color.Black;
            this.cmbPublisher.ItemHeight = 26;
            this.cmbPublisher.ItemHighLightColor = System.Drawing.Color.SlateBlue;
            this.cmbPublisher.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cmbPublisher.ItemTopMargin = 3;
            this.cmbPublisher.Location = new System.Drawing.Point(397, 232);
            this.cmbPublisher.Name = "cmbPublisher";
            this.cmbPublisher.Size = new System.Drawing.Size(236, 32);
            this.cmbPublisher.TabIndex = 5;
            this.cmbPublisher.Text = null;
            this.cmbPublisher.TextAlignment = KimTools.WinForms.KtComboBox.TextAlign.Left;
            this.cmbPublisher.TextLeftMargin = 5;
            this.cmbPublisher.SelectedIndexChanged += new System.EventHandler(this.cmbBox_SelectedIndexChanged_1);
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblPublisher.ForeColor = System.Drawing.Color.Black;
            this.lblPublisher.KtFontSize = KimTools.WinForms.KtFont.Default;
            this.lblPublisher.LabelColor = KimTools.WinForms.KtColor.Tailwind_Black;
            this.lblPublisher.Location = new System.Drawing.Point(397, 185);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(90, 25);
            this.lblPublisher.TabIndex = 4;
            this.lblPublisher.Text = "Publisher";
            // 
            // lblPublishingDate
            // 
            this.lblPublishingDate.AutoSize = true;
            this.lblPublishingDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblPublishingDate.ForeColor = System.Drawing.Color.Black;
            this.lblPublishingDate.KtFontSize = KimTools.WinForms.KtFont.Default;
            this.lblPublishingDate.LabelColor = KimTools.WinForms.KtColor.Tailwind_Black;
            this.lblPublishingDate.Location = new System.Drawing.Point(397, 295);
            this.lblPublishingDate.Name = "lblPublishingDate";
            this.lblPublishingDate.Size = new System.Drawing.Size(144, 25);
            this.lblPublishingDate.TabIndex = 8;
            this.lblPublishingDate.Text = "Publishing Date";
            // 
            // cmbGenre
            // 
            this.cmbGenre.BackColor = System.Drawing.Color.Transparent;
            this.cmbGenre.BackgroundColor = System.Drawing.Color.White;
            this.cmbGenre.BorderColor = System.Drawing.Color.Silver;
            this.cmbGenre.BorderRadius = 1;
            this.cmbGenre.Color = System.Drawing.Color.Silver;
            this.cmbGenre.Direction = KimTools.WinForms.KtComboBox.Directions.Down;
            this.cmbGenre.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbGenre.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbGenre.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbGenre.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbGenre.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbGenre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbGenre.DropdownBorderThickness = KimTools.WinForms.KtComboBox.BorderThickness.Thin;
            this.cmbGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenre.DropDownTextAlign = KimTools.WinForms.KtComboBox.TextAlign.Left;
            this.cmbGenre.FillDropDown = true;
            this.cmbGenre.FillIndicator = false;
            this.cmbGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGenre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbGenre.ForeColor = System.Drawing.Color.Black;
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Icon = null;
            this.cmbGenre.IndicatorAlignment = KimTools.WinForms.KtComboBox.Indicator.Right;
            this.cmbGenre.IndicatorColor = System.Drawing.Color.Gray;
            this.cmbGenre.IndicatorLocation = KimTools.WinForms.KtComboBox.Indicator.Right;
            this.cmbGenre.ItemBackColor = System.Drawing.Color.White;
            this.cmbGenre.ItemBorderColor = System.Drawing.Color.White;
            this.cmbGenre.ItemForeColor = System.Drawing.Color.Black;
            this.cmbGenre.ItemHeight = 26;
            this.cmbGenre.ItemHighLightColor = System.Drawing.Color.SlateBlue;
            this.cmbGenre.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cmbGenre.ItemTopMargin = 3;
            this.cmbGenre.Location = new System.Drawing.Point(38, 342);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(236, 32);
            this.cmbGenre.TabIndex = 7;
            this.cmbGenre.Text = null;
            this.cmbGenre.TextAlignment = KimTools.WinForms.KtComboBox.TextAlign.Left;
            this.cmbGenre.TextLeftMargin = 5;
            this.cmbGenre.SelectedIndexChanged += new System.EventHandler(this.cmbBox_SelectedIndexChanged_1);
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblGenre.ForeColor = System.Drawing.Color.Black;
            this.lblGenre.KtFontSize = KimTools.WinForms.KtFont.Default;
            this.lblGenre.LabelColor = KimTools.WinForms.KtColor.Tailwind_Black;
            this.lblGenre.Location = new System.Drawing.Point(38, 295);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(63, 25);
            this.lblGenre.TabIndex = 6;
            this.lblGenre.Text = "Genre";
            // 
            // lblCostPrice
            // 
            this.lblCostPrice.AutoSize = true;
            this.lblCostPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblCostPrice.ForeColor = System.Drawing.Color.Black;
            this.lblCostPrice.KtFontSize = KimTools.WinForms.KtFont.Default;
            this.lblCostPrice.LabelColor = KimTools.WinForms.KtColor.Tailwind_Black;
            this.lblCostPrice.Location = new System.Drawing.Point(38, 398);
            this.lblCostPrice.Name = "lblCostPrice";
            this.lblCostPrice.Size = new System.Drawing.Size(95, 25);
            this.lblCostPrice.TabIndex = 2;
            this.lblCostPrice.Text = "Cost Price";
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.AutoSize = true;
            this.lblSalePrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblSalePrice.ForeColor = System.Drawing.Color.Black;
            this.lblSalePrice.KtFontSize = KimTools.WinForms.KtFont.Default;
            this.lblSalePrice.LabelColor = KimTools.WinForms.KtColor.Tailwind_Black;
            this.lblSalePrice.Location = new System.Drawing.Point(397, 398);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(92, 25);
            this.lblSalePrice.TabIndex = 4;
            this.lblSalePrice.Text = "Sale price";
            // 
            // lblIsSequel
            // 
            this.lblIsSequel.AutoSize = true;
            this.lblIsSequel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblIsSequel.ForeColor = System.Drawing.Color.Black;
            this.lblIsSequel.KtFontSize = KimTools.WinForms.KtFont.Default;
            this.lblIsSequel.LabelColor = KimTools.WinForms.KtColor.Tailwind_Black;
            this.lblIsSequel.Location = new System.Drawing.Point(38, 639);
            this.lblIsSequel.Name = "lblIsSequel";
            this.lblIsSequel.Size = new System.Drawing.Size(87, 25);
            this.lblIsSequel.TabIndex = 14;
            this.lblIsSequel.Text = "Is Sequel";
            // 
            // IsSequelSwith
            // 
            this.IsSequelSwith.Animation = 5;
            this.IsSequelSwith.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.IsSequelSwith.BackColor = System.Drawing.Color.Transparent;
            this.IsSequelSwith.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IsSequelSwith.BackgroundImage")));
            this.IsSequelSwith.Checked = false;
            ktSwitchState1.Bg = System.Drawing.Color.Empty;
            ktSwitchState1.Thumb = System.Drawing.Color.Empty;
            this.IsSequelSwith.CustomStateOff = ktSwitchState1;
            ktSwitchState2.Bg = System.Drawing.Color.Empty;
            ktSwitchState2.Thumb = System.Drawing.Color.Empty;
            this.IsSequelSwith.CustomStateOn = ktSwitchState2;
            this.IsSequelSwith.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.IsSequelSwith.InnerCirclePadding = 5;
            this.IsSequelSwith.Location = new System.Drawing.Point(141, 637);
            this.IsSequelSwith.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.IsSequelSwith.Name = "IsSequelSwith";
            this.IsSequelSwith.Size = new System.Drawing.Size(61, 35);
            this.IsSequelSwith.TabIndex = 15;
            this.IsSequelSwith.ThumbMargin = 5;
            this.IsSequelSwith.Value = false;
            this.IsSequelSwith.CheckedChanged += new System.EventHandler<KimTools.WinForms.KtSwitch.CheckedChangedEventArgs>(this.IsSequelSwith_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Empty;
            this.btnClose.BorderShape = KimTools.WinForms.KtSize.Default;
            this.btnClose.BorderSize = KimTools.WinForms.KtSize.Default;
            this.btnClose.CustomColors = new System.Drawing.Color[0];
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.IconName = "";
            this.btnClose.IconSize = 16;
            this.btnClose.IconStroke = 2.5D;
            this.btnClose.Location = new System.Drawing.Point(364, 633);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 50);
            this.btnClose.Style = KimTools.WinForms.KtStyle.Tailwind;
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Empty;
            this.btnUpdate.BorderShape = KimTools.WinForms.KtSize.Default;
            this.btnUpdate.BorderSize = KimTools.WinForms.KtSize.Default;
            this.btnUpdate.CustomColors = new System.Drawing.Color[0];
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdate.IconName = "";
            this.btnUpdate.IconSize = 16;
            this.btnUpdate.IconStroke = 2.5D;
            this.btnUpdate.Location = new System.Drawing.Point(508, 633);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 50);
            this.btnUpdate.Style = KimTools.WinForms.KtStyle.Tailwind;
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txbSalePrice
            // 
            this.txbSalePrice.AcceptsReturn = false;
            this.txbSalePrice.AcceptsTab = false;
            this.txbSalePrice.AnimationSpeed = 200;
            this.txbSalePrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbSalePrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbSalePrice.AutoSizeHeight = true;
            this.txbSalePrice.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.txbSalePrice.Bg = KimTools.WinForms.KtColor.ForeColor;
            this.txbSalePrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSalePrice.CustomBorderColor = System.Drawing.Color.Empty;
            this.txbSalePrice.CustomBorderColorActive = System.Drawing.Color.Empty;
            this.txbSalePrice.CustomBorderColorDisabled = System.Drawing.Color.Empty;
            this.txbSalePrice.CustomFillColor = System.Drawing.Color.White;
            this.txbSalePrice.CustomIconLeft = null;
            this.txbSalePrice.CustomIconRight = null;
            this.txbSalePrice.CustomPlaceholderColor = System.Drawing.Color.Empty;
            this.txbSalePrice.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSalePrice.ForeColor = System.Drawing.Color.Black;
            this.txbSalePrice.HideSelection = true;
            this.txbSalePrice.Lines = new string[0];
            this.txbSalePrice.Location = new System.Drawing.Point(397, 445);
            this.txbSalePrice.MaxLength = 32767;
            this.txbSalePrice.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbSalePrice.Modified = false;
            this.txbSalePrice.Name = "txbSalePrice";
            this.txbSalePrice.Password = false;
            this.txbSalePrice.PasswordChar = '\0';
            this.txbSalePrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbSalePrice.SelectedText = "";
            this.txbSalePrice.SelectionLength = 0;
            this.txbSalePrice.SelectionStart = 0;
            this.txbSalePrice.ShortcutsEnabled = true;
            this.txbSalePrice.Size = new System.Drawing.Size(236, 44);
            this.txbSalePrice.Style = KimTools.WinForms.KtTextBox.KtTextBoxStyle.Custom;
            this.txbSalePrice.TabIndex = 11;
            this.txbSalePrice.TextMarginBottom = 0;
            this.txbSalePrice.TextPlaceholder = "";
            this.txbSalePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSalePrice_KeyPress);
            this.txbSalePrice.TextChange += new System.EventHandler(this.TextBook_TextChange);
            // 
            // txbCostPrice
            // 
            this.txbCostPrice.AcceptsReturn = false;
            this.txbCostPrice.AcceptsTab = false;
            this.txbCostPrice.AnimationSpeed = 200;
            this.txbCostPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbCostPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbCostPrice.AutoSizeHeight = true;
            this.txbCostPrice.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.txbCostPrice.Bg = KimTools.WinForms.KtColor.ForeColor;
            this.txbCostPrice.BorderRadius = 0;
            this.txbCostPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbCostPrice.CustomBorderColor = System.Drawing.Color.Empty;
            this.txbCostPrice.CustomBorderColorActive = System.Drawing.Color.Empty;
            this.txbCostPrice.CustomBorderColorDisabled = System.Drawing.Color.Empty;
            this.txbCostPrice.CustomFillColor = System.Drawing.Color.White;
            this.txbCostPrice.CustomIconLeft = null;
            this.txbCostPrice.CustomIconRight = null;
            this.txbCostPrice.CustomPlaceholderColor = System.Drawing.Color.Empty;
            this.txbCostPrice.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCostPrice.ForeColor = System.Drawing.Color.Black;
            this.txbCostPrice.HideSelection = true;
            this.txbCostPrice.Lines = new string[0];
            this.txbCostPrice.Location = new System.Drawing.Point(38, 445);
            this.txbCostPrice.MaxLength = 32767;
            this.txbCostPrice.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbCostPrice.Modified = false;
            this.txbCostPrice.Name = "txbCostPrice";
            this.txbCostPrice.Password = false;
            this.txbCostPrice.PasswordChar = '\0';
            this.txbCostPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbCostPrice.SelectedText = "";
            this.txbCostPrice.SelectionLength = 0;
            this.txbCostPrice.SelectionStart = 0;
            this.txbCostPrice.ShortcutsEnabled = true;
            this.txbCostPrice.Size = new System.Drawing.Size(236, 44);
            this.txbCostPrice.Style = KimTools.WinForms.KtTextBox.KtTextBoxStyle.Custom;
            this.txbCostPrice.TabIndex = 3;
            this.txbCostPrice.TextMarginBottom = 0;
            this.txbCostPrice.TextPlaceholder = "";
            this.txbCostPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCostPrice_KeyPress);
            this.txbCostPrice.TextChange += new System.EventHandler(this.TextBook_TextChange);
            // 
            // PublishingDatePicker
            // 
            this.PublishingDatePicker.BackColor = System.Drawing.Color.Transparent;
            this.PublishingDatePicker.BorderRadius = 1;
            this.PublishingDatePicker.CalendarTitleBackColor = System.Drawing.Color.SlateBlue;
            this.PublishingDatePicker.Color = System.Drawing.Color.Silver;
            this.PublishingDatePicker.DateBorderThickness = KimTools.WinForms.KtDate.BorderThickness.Thin;
            this.PublishingDatePicker.DateTextAlign = KimTools.WinForms.KtDate.TextAlign.Right;
            this.PublishingDatePicker.DisabledColor = System.Drawing.Color.Gray;
            this.PublishingDatePicker.DisplayWeekNumbers = false;
            this.PublishingDatePicker.DPHeight = 0;
            this.PublishingDatePicker.FillDatePicker = false;
            this.PublishingDatePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PublishingDatePicker.ForeColor = System.Drawing.Color.Black;
            this.PublishingDatePicker.Icon = ((System.Drawing.Image)(resources.GetObject("PublishingDatePicker.Icon")));
            this.PublishingDatePicker.IconColor = System.Drawing.Color.Gray;
            this.PublishingDatePicker.IconLocation = KimTools.WinForms.KtDate.Indicator.Left;
            this.PublishingDatePicker.LeftTextMargin = 5;
            this.PublishingDatePicker.Location = new System.Drawing.Point(397, 342);
            this.PublishingDatePicker.MinimumSize = new System.Drawing.Size(4, 32);
            this.PublishingDatePicker.Name = "PublishingDatePicker";
            this.PublishingDatePicker.Size = new System.Drawing.Size(236, 32);
            this.PublishingDatePicker.TabIndex = 10;
            // 
            // ktLabel1
            // 
            this.ktLabel1.AutoSize = true;
            this.ktLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ktLabel1.ForeColor = System.Drawing.Color.Black;
            this.ktLabel1.KtFontSize = KimTools.WinForms.KtFont.Default;
            this.ktLabel1.LabelColor = KimTools.WinForms.KtColor.Tailwind_Black;
            this.ktLabel1.Location = new System.Drawing.Point(38, 512);
            this.ktLabel1.Name = "ktLabel1";
            this.ktLabel1.Size = new System.Drawing.Size(56, 25);
            this.ktLabel1.TabIndex = 2;
            this.ktLabel1.Text = "Stock";
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblPages.ForeColor = System.Drawing.Color.Black;
            this.lblPages.KtFontSize = KimTools.WinForms.KtFont.Default;
            this.lblPages.LabelColor = KimTools.WinForms.KtColor.Tailwind_Black;
            this.lblPages.Location = new System.Drawing.Point(397, 512);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(60, 25);
            this.lblPages.TabIndex = 4;
            this.lblPages.Text = "Pages";
            // 
            // txbStock
            // 
            this.txbStock.AcceptsReturn = false;
            this.txbStock.AcceptsTab = false;
            this.txbStock.AnimationSpeed = 200;
            this.txbStock.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbStock.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbStock.AutoSizeHeight = true;
            this.txbStock.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.txbStock.Bg = KimTools.WinForms.KtColor.ForeColor;
            this.txbStock.BorderRadius = 0;
            this.txbStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbStock.CustomBorderColor = System.Drawing.Color.Empty;
            this.txbStock.CustomBorderColorActive = System.Drawing.Color.Empty;
            this.txbStock.CustomBorderColorDisabled = System.Drawing.Color.Empty;
            this.txbStock.CustomFillColor = System.Drawing.Color.White;
            this.txbStock.CustomIconLeft = null;
            this.txbStock.CustomIconRight = null;
            this.txbStock.CustomPlaceholderColor = System.Drawing.Color.Empty;
            this.txbStock.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStock.ForeColor = System.Drawing.Color.Black;
            this.txbStock.HideSelection = true;
            this.txbStock.Lines = new string[0];
            this.txbStock.Location = new System.Drawing.Point(38, 559);
            this.txbStock.MaxLength = 32767;
            this.txbStock.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbStock.Modified = false;
            this.txbStock.Name = "txbStock";
            this.txbStock.Password = false;
            this.txbStock.PasswordChar = '\0';
            this.txbStock.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbStock.SelectedText = "";
            this.txbStock.SelectionLength = 0;
            this.txbStock.SelectionStart = 0;
            this.txbStock.ShortcutsEnabled = true;
            this.txbStock.Size = new System.Drawing.Size(236, 44);
            this.txbStock.Style = KimTools.WinForms.KtTextBox.KtTextBoxStyle.Custom;
            this.txbStock.TabIndex = 3;
            this.txbStock.TextMarginBottom = 0;
            this.txbStock.TextPlaceholder = "";
            this.txbStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_KeyPress);
            this.txbStock.TextChange += new System.EventHandler(this.TextBook_TextChange);
            // 
            // txbPages
            // 
            this.txbPages.AcceptsReturn = false;
            this.txbPages.AcceptsTab = false;
            this.txbPages.AnimationSpeed = 200;
            this.txbPages.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbPages.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbPages.AutoSizeHeight = true;
            this.txbPages.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.txbPages.Bg = KimTools.WinForms.KtColor.ForeColor;
            this.txbPages.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPages.CustomBorderColor = System.Drawing.Color.Empty;
            this.txbPages.CustomBorderColorActive = System.Drawing.Color.Empty;
            this.txbPages.CustomBorderColorDisabled = System.Drawing.Color.Empty;
            this.txbPages.CustomFillColor = System.Drawing.Color.White;
            this.txbPages.CustomIconLeft = null;
            this.txbPages.CustomIconRight = null;
            this.txbPages.CustomPlaceholderColor = System.Drawing.Color.Empty;
            this.txbPages.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPages.ForeColor = System.Drawing.Color.Black;
            this.txbPages.HideSelection = true;
            this.txbPages.Lines = new string[0];
            this.txbPages.Location = new System.Drawing.Point(397, 559);
            this.txbPages.MaxLength = 32767;
            this.txbPages.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbPages.Modified = false;
            this.txbPages.Name = "txbPages";
            this.txbPages.Password = false;
            this.txbPages.PasswordChar = '\0';
            this.txbPages.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbPages.SelectedText = "";
            this.txbPages.SelectionLength = 0;
            this.txbPages.SelectionStart = 0;
            this.txbPages.ShortcutsEnabled = true;
            this.txbPages.Size = new System.Drawing.Size(236, 44);
            this.txbPages.Style = KimTools.WinForms.KtTextBox.KtTextBoxStyle.Custom;
            this.txbPages.TabIndex = 11;
            this.txbPages.TextMarginBottom = 0;
            this.txbPages.TextPlaceholder = "";
            this.txbPages.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_KeyPress);
            this.txbPages.TextChange += new System.EventHandler(this.TextBook_TextChange);
            // 
            // txbId
            // 
            this.txbId.AcceptsReturn = false;
            this.txbId.AcceptsTab = false;
            this.txbId.AnimationSpeed = 200;
            this.txbId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbId.AutoSizeHeight = true;
            this.txbId.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.txbId.Bg = KimTools.WinForms.KtColor.ForeColor;
            this.txbId.Content = KimTools.WinForms.KtColor.BackColor;
            this.txbId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbId.CustomBorderColor = System.Drawing.Color.Empty;
            this.txbId.CustomBorderColorActive = System.Drawing.Color.Empty;
            this.txbId.CustomBorderColorDisabled = System.Drawing.Color.Empty;
            this.txbId.CustomFillColor = System.Drawing.Color.White;
            this.txbId.CustomIconLeft = null;
            this.txbId.CustomIconRight = null;
            this.txbId.CustomPlaceholderColor = System.Drawing.Color.Empty;
            this.txbId.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbId.ForeColor = System.Drawing.Color.Black;
            this.txbId.HideSelection = true;
            this.txbId.Lines = new string[0];
            this.txbId.Location = new System.Drawing.Point(167, 60);
            this.txbId.MaxLength = 32767;
            this.txbId.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbId.Modified = true;
            this.txbId.Name = "txbId";
            this.txbId.Password = false;
            this.txbId.PasswordChar = '\0';
            this.txbId.ReadOnly = true;
            this.txbId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbId.SelectedText = "";
            this.txbId.SelectionLength = 0;
            this.txbId.SelectionStart = 0;
            this.txbId.ShortcutsEnabled = true;
            this.txbId.Size = new System.Drawing.Size(65, 52);
            this.txbId.Style = KimTools.WinForms.KtTextBox.KtTextBoxStyle.Custom;
            this.txbId.TabIndex = 3;
            this.txbId.TextMarginBottom = 0;
            this.txbId.TextPlaceholder = "";
            // 
            // UpdateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(671, 714);
            this.Controls.Add(this.IsSequelSwith);
            this.Controls.Add(this.lblIsSequel);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txbPages);
            this.Controls.Add(this.txbStock);
            this.Controls.Add(this.txbSalePrice);
            this.Controls.Add(this.txbCostPrice);
            this.Controls.Add(this.PublishingDatePicker);
            this.Controls.Add(this.lblPublishingDate);
            this.Controls.Add(this.cmbGenre);
            this.Controls.Add(this.lblPages);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblSalePrice);
            this.Controls.Add(this.cmbPublisher);
            this.Controls.Add(this.ktLabel1);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.lblCostPrice);
            this.Controls.Add(this.cmbAuthor);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.Toppanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateBook";
            this.Text = "AddBook";
            this.Load += new System.EventHandler(this.AddBook_Load);
            this.Toppanel.ResumeLayout(false);
            this.Toppanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BookCover;
        private System.Windows.Forms.Panel Toppanel;
        private KimTools.WinForms.KtLabel lblBookTitle;
        private KimTools.WinForms.KtLabel lblAuthor;
        private KimTools.WinForms.KtLabel lblPublisher;
        private KimTools.WinForms.KtLabel lblPublishingDate;
        private KimTools.WinForms.KtLabel lblGenre;
        private KimTools.WinForms.KtLabel lblCostPrice;
        private KimTools.WinForms.KtLabel lblSalePrice;
        private KimTools.WinForms.KtButton btnUpdate;
        private KimTools.WinForms.KtButton btnClose;
        private KimTools.WinForms.KtLabel lblIsSequel;
        private KimTools.WinForms.KtLabel ktLabel1;
        private KimTools.WinForms.KtLabel lblPages;
        public KimTools.WinForms.KtTextBox txtTitle;
        public KimTools.WinForms.KtComboBox cmbAuthor;
        public KimTools.WinForms.KtComboBox cmbPublisher;
        public KimTools.WinForms.KtComboBox cmbGenre;
        public KimTools.WinForms.KtDate PublishingDatePicker;
        public KimTools.WinForms.KtTextBox txbCostPrice;
        public KimTools.WinForms.KtTextBox txbSalePrice;
        public KimTools.WinForms.KtSwitch IsSequelSwith;
        public KimTools.WinForms.KtTextBox txbStock;
        public KimTools.WinForms.KtTextBox txbPages;
        public KimTools.WinForms.KtTextBox txbId;
    }
}
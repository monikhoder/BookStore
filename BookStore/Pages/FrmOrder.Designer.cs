namespace BookStore.Pages
{
    partial class FrmOrder
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
            KimTools.WinForms.KtTableColumn ktTableColumn10 = new KimTools.WinForms.KtTableColumn();
            KimTools.WinForms.KtTableColumn ktTableColumn11 = new KimTools.WinForms.KtTableColumn();
            KimTools.WinForms.KtTableColumn ktTableColumn12 = new KimTools.WinForms.KtTableColumn();
            KimTools.WinForms.KtTableColumn ktTableColumn13 = new KimTools.WinForms.KtTableColumn();
            KimTools.WinForms.KtTableColumn ktTableColumn14 = new KimTools.WinForms.KtTableColumn();
            KimTools.WinForms.KtTableColumn ktTableColumn15 = new KimTools.WinForms.KtTableColumn();
            KimTools.WinForms.KtTableColumn ktTableColumn16 = new KimTools.WinForms.KtTableColumn();
            KimTools.WinForms.KtTableColumn ktTableColumn17 = new KimTools.WinForms.KtTableColumn();
            KimTools.WinForms.KtTableColumn ktTableColumn18 = new KimTools.WinForms.KtTableColumn();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.TopLeftPanel = new System.Windows.Forms.Panel();
            this.btnCancel = new KimTools.WinForms.KtButton();
            this.btnAdd = new KimTools.WinForms.KtButton();
            this.txtSearch = new KimTools.WinForms.KtTextBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.buttomPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbDiscount = new KimTools.WinForms.KtTextBox();
            this.lblDiscountSet = new System.Windows.Forms.Label();
            this.btnAddtoCard = new KimTools.WinForms.KtButton();
            this.txbQuntity = new KimTools.WinForms.KtTextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.buttomLeft = new System.Windows.Forms.Panel();
            this.BookCover = new System.Windows.Forms.PictureBox();
            this.tblBook = new KimTools.WinForms.KtTable();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.ButtomRight = new System.Windows.Forms.Panel();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.tblOrder = new KimTools.WinForms.KtTable();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.TopPanel.SuspendLayout();
            this.TopLeftPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.buttomPanel.SuspendLayout();
            this.buttomLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookCover)).BeginInit();
            this.RightPanel.SuspendLayout();
            this.ButtomRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.TopLeftPanel);
            this.TopPanel.Controls.Add(this.txtSearch);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1021, 60);
            this.TopPanel.TabIndex = 1;
            // 
            // TopLeftPanel
            // 
            this.TopLeftPanel.Controls.Add(this.btnCancel);
            this.TopLeftPanel.Controls.Add(this.btnAdd);
            this.TopLeftPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.TopLeftPanel.Location = new System.Drawing.Point(653, 0);
            this.TopLeftPanel.Name = "TopLeftPanel";
            this.TopLeftPanel.Size = new System.Drawing.Size(368, 60);
            this.TopLeftPanel.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Empty;
            this.btnCancel.Bg = KimTools.WinForms.KtColor.Tailwind_Red;
            this.btnCancel.BorderShape = KimTools.WinForms.KtSize.Default;
            this.btnCancel.BorderSize = KimTools.WinForms.KtSize.Default;
            this.btnCancel.CustomColors = new System.Drawing.Color[0];
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.IconName = "Tabler.outline.http_delete";
            this.btnCancel.IconSize = 18;
            this.btnCancel.IconStroke = 2.5D;
            this.btnCancel.Location = new System.Drawing.Point(24, 14);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 39);
            this.btnCancel.Style = KimTools.WinForms.KtStyle.Tailwind;
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Empty;
            this.btnAdd.BorderShape = KimTools.WinForms.KtSize.Default;
            this.btnAdd.BorderSize = KimTools.WinForms.KtSize.Default;
            this.btnAdd.CustomColors = new System.Drawing.Color[0];
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.IconName = "Tabler.outline.plus";
            this.btnAdd.IconSize = 18;
            this.btnAdd.IconStroke = 2.5D;
            this.btnAdd.Location = new System.Drawing.Point(216, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 39);
            this.btnAdd.Style = KimTools.WinForms.KtStyle.Material;
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "New Order";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.AcceptsReturn = false;
            this.txtSearch.AcceptsTab = false;
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSearch.AnimationSpeed = 200;
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSearch.AutoSizeHeight = true;
            this.txtSearch.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.CustomBorderColor = System.Drawing.Color.Empty;
            this.txtSearch.CustomBorderColorActive = System.Drawing.Color.Empty;
            this.txtSearch.CustomBorderColorDisabled = System.Drawing.Color.Empty;
            this.txtSearch.CustomFillColor = System.Drawing.Color.Empty;
            this.txtSearch.CustomIconLeft = null;
            this.txtSearch.CustomIconRight = null;
            this.txtSearch.CustomPlaceholderColor = System.Drawing.Color.Empty;
            this.txtSearch.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtSearch.ForeColor = System.Drawing.Color.Empty;
            this.txtSearch.HideSelection = true;
            this.txtSearch.IconLeft = "Tabler.outline.search";
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(14, 7);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSearch.Modified = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Password = false;
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(282, 43);
            this.txtSearch.Style = KimTools.WinForms.KtTextBox.KtTextBoxStyle.Tailwind;
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextMarginBottom = 0;
            this.txtSearch.TextPlaceholder = "";
            this.txtSearch.TextChange += new System.EventHandler(this.txtSearch_TextChange);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.buttomPanel);
            this.mainPanel.Controls.Add(this.tblBook);
            this.mainPanel.Controls.Add(this.RightPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 60);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1021, 480);
            this.mainPanel.TabIndex = 2;
            // 
            // buttomPanel
            // 
            this.buttomPanel.Controls.Add(this.label2);
            this.buttomPanel.Controls.Add(this.label1);
            this.buttomPanel.Controls.Add(this.txbDiscount);
            this.buttomPanel.Controls.Add(this.lblDiscountSet);
            this.buttomPanel.Controls.Add(this.btnAddtoCard);
            this.buttomPanel.Controls.Add(this.txbQuntity);
            this.buttomPanel.Controls.Add(this.lblPrice);
            this.buttomPanel.Controls.Add(this.lblTitle);
            this.buttomPanel.Controls.Add(this.buttomLeft);
            this.buttomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttomPanel.Location = new System.Drawing.Point(0, 299);
            this.buttomPanel.Name = "buttomPanel";
            this.buttomPanel.Size = new System.Drawing.Size(647, 181);
            this.buttomPanel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Price :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Title :";
            // 
            // txbDiscount
            // 
            this.txbDiscount.AcceptsReturn = false;
            this.txbDiscount.AcceptsTab = false;
            this.txbDiscount.AnimationSpeed = 200;
            this.txbDiscount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbDiscount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbDiscount.AutoSizeHeight = true;
            this.txbDiscount.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.txbDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbDiscount.CustomBorderColor = System.Drawing.Color.Empty;
            this.txbDiscount.CustomBorderColorActive = System.Drawing.Color.Empty;
            this.txbDiscount.CustomBorderColorDisabled = System.Drawing.Color.Empty;
            this.txbDiscount.CustomFillColor = System.Drawing.Color.Empty;
            this.txbDiscount.CustomIconLeft = null;
            this.txbDiscount.CustomIconRight = null;
            this.txbDiscount.CustomPlaceholderColor = System.Drawing.Color.Empty;
            this.txbDiscount.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txbDiscount.ForeColor = System.Drawing.Color.Empty;
            this.txbDiscount.HideSelection = true;
            this.txbDiscount.IconRight = "Tabler.outline.percentage";
            this.txbDiscount.Lines = new string[] {
        "0"};
            this.txbDiscount.Location = new System.Drawing.Point(268, 118);
            this.txbDiscount.MaxLength = 32767;
            this.txbDiscount.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbDiscount.Modified = false;
            this.txbDiscount.Name = "txbDiscount";
            this.txbDiscount.Password = false;
            this.txbDiscount.PasswordChar = '\0';
            this.txbDiscount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbDiscount.SelectedText = "";
            this.txbDiscount.SelectionLength = 0;
            this.txbDiscount.SelectionStart = 0;
            this.txbDiscount.ShortcutsEnabled = true;
            this.txbDiscount.Size = new System.Drawing.Size(93, 39);
            this.txbDiscount.Style = KimTools.WinForms.KtTextBox.KtTextBoxStyle.Tailwind;
            this.txbDiscount.TabIndex = 6;
            this.txbDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbDiscount.TextMarginBottom = 0;
            this.txbDiscount.TextPlaceholder = "";
            this.txbDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbDiscount_KeyPress);
            this.txbDiscount.Leave += new System.EventHandler(this.txbDiscount_Leave);
            // 
            // lblDiscountSet
            // 
            this.lblDiscountSet.AutoSize = true;
            this.lblDiscountSet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountSet.Location = new System.Drawing.Point(174, 124);
            this.lblDiscountSet.Name = "lblDiscountSet";
            this.lblDiscountSet.Size = new System.Drawing.Size(89, 28);
            this.lblDiscountSet.TabIndex = 5;
            this.lblDiscountSet.Text = "Discount";
            // 
            // btnAddtoCard
            // 
            this.btnAddtoCard.BackColor = System.Drawing.Color.Empty;
            this.btnAddtoCard.BorderShape = KimTools.WinForms.KtSize.Default;
            this.btnAddtoCard.BorderSize = KimTools.WinForms.KtSize.Default;
            this.btnAddtoCard.CustomColors = new System.Drawing.Color[0];
            this.btnAddtoCard.FlatAppearance.BorderSize = 0;
            this.btnAddtoCard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddtoCard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddtoCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddtoCard.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddtoCard.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddtoCard.IconName = "Tabler.outline.plus";
            this.btnAddtoCard.IconSize = 18;
            this.btnAddtoCard.IconStroke = 2.5D;
            this.btnAddtoCard.Location = new System.Drawing.Point(509, 118);
            this.btnAddtoCard.Name = "btnAddtoCard";
            this.btnAddtoCard.Size = new System.Drawing.Size(132, 39);
            this.btnAddtoCard.Style = KimTools.WinForms.KtStyle.Material;
            this.btnAddtoCard.TabIndex = 3;
            this.btnAddtoCard.Text = "Add to Card";
            this.btnAddtoCard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddtoCard.UseVisualStyleBackColor = false;
            this.btnAddtoCard.Click += new System.EventHandler(this.btnAddtoCard_Click);
            // 
            // txbQuntity
            // 
            this.txbQuntity.AcceptsReturn = false;
            this.txbQuntity.AcceptsTab = false;
            this.txbQuntity.AnimationSpeed = 200;
            this.txbQuntity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbQuntity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbQuntity.AutoSizeHeight = true;
            this.txbQuntity.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.txbQuntity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbQuntity.CustomBorderColor = System.Drawing.Color.Empty;
            this.txbQuntity.CustomBorderColorActive = System.Drawing.Color.Empty;
            this.txbQuntity.CustomBorderColorDisabled = System.Drawing.Color.Empty;
            this.txbQuntity.CustomFillColor = System.Drawing.Color.Empty;
            this.txbQuntity.CustomIconLeft = null;
            this.txbQuntity.CustomIconRight = null;
            this.txbQuntity.CustomPlaceholderColor = System.Drawing.Color.Empty;
            this.txbQuntity.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txbQuntity.ForeColor = System.Drawing.Color.Empty;
            this.txbQuntity.HideSelection = true;
            this.txbQuntity.IconLeft = "Tabler.outline.minus";
            this.txbQuntity.IconRight = "Tabler.outline.plus";
            this.txbQuntity.Lines = new string[] {
        "1"};
            this.txbQuntity.Location = new System.Drawing.Point(371, 118);
            this.txbQuntity.MaxLength = 32767;
            this.txbQuntity.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbQuntity.Modified = false;
            this.txbQuntity.Name = "txbQuntity";
            this.txbQuntity.Password = false;
            this.txbQuntity.PasswordChar = '\0';
            this.txbQuntity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbQuntity.SelectedText = "";
            this.txbQuntity.SelectionLength = 0;
            this.txbQuntity.SelectionStart = 0;
            this.txbQuntity.ShortcutsEnabled = true;
            this.txbQuntity.Size = new System.Drawing.Size(132, 39);
            this.txbQuntity.Style = KimTools.WinForms.KtTextBox.KtTextBoxStyle.Tailwind;
            this.txbQuntity.TabIndex = 4;
            this.txbQuntity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbQuntity.TextMarginBottom = 0;
            this.txbQuntity.TextPlaceholder = "";
            this.txbQuntity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbQuntity_KeyPress);
            this.txbQuntity.IconLeftClick += new System.EventHandler(this.txbQuntity_IconLeftClick);
            this.txbQuntity.IconRightClick += new System.EventHandler(this.txbQuntity_IconRightClick);
            this.txbQuntity.Leave += new System.EventHandler(this.txbQuntity_Leave);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(237, 81);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(66, 28);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "{Price}";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(235, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(68, 30);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "{Title}";
            // 
            // buttomLeft
            // 
            this.buttomLeft.Controls.Add(this.BookCover);
            this.buttomLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttomLeft.Location = new System.Drawing.Point(0, 0);
            this.buttomLeft.Name = "buttomLeft";
            this.buttomLeft.Size = new System.Drawing.Size(155, 181);
            this.buttomLeft.TabIndex = 1;
            // 
            // BookCover
            // 
            this.BookCover.ErrorImage = global::BookStore.Properties.Resources.add_book;
            this.BookCover.Image = global::BookStore.Properties.Resources.book;
            this.BookCover.Location = new System.Drawing.Point(23, 6);
            this.BookCover.Name = "BookCover";
            this.BookCover.Size = new System.Drawing.Size(108, 146);
            this.BookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BookCover.TabIndex = 0;
            this.BookCover.TabStop = false;
            this.BookCover.WaitOnLoad = true;
            // 
            // tblBook
            // 
            this.tblBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(22)))), ((int)(((byte)(51)))));
            ktTableColumn10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.NotSet;
            ktTableColumn10.Fill = "";
            ktTableColumn10.Format = "";
            ktTableColumn10.Group = "";
            ktTableColumn10.IsPrimaryKey = false;
            ktTableColumn10.Key = "tblId";
            ktTableColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.NotSet;
            ktTableColumn10.Search = false;
            ktTableColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            ktTableColumn10.Template = "";
            ktTableColumn10.Title = "ID";
            ktTableColumn10.ToolTip = "";
            ktTableColumn10.Type = KimTools.WinForms.KtTableColumnTypes.Text;
            ktTableColumn10.Value = "";
            ktTableColumn10.Visible = true;
            ktTableColumn10.Width = 50;
            ktTableColumn10.Width_ = "50";
            ktTableColumn11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.NotSet;
            ktTableColumn11.Fill = "";
            ktTableColumn11.Format = "";
            ktTableColumn11.Group = "";
            ktTableColumn11.IsPrimaryKey = false;
            ktTableColumn11.Key = "tblTitle";
            ktTableColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.NotSet;
            ktTableColumn11.Search = true;
            ktTableColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            ktTableColumn11.Template = "";
            ktTableColumn11.Title = "Title";
            ktTableColumn11.ToolTip = "";
            ktTableColumn11.Type = KimTools.WinForms.KtTableColumnTypes.Text;
            ktTableColumn11.Value = "";
            ktTableColumn11.Visible = true;
            ktTableColumn11.Width = 0;
            ktTableColumn11.Width_ = "";
            ktTableColumn12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.NotSet;
            ktTableColumn12.Fill = "";
            ktTableColumn12.Format = "";
            ktTableColumn12.Group = "";
            ktTableColumn12.IsPrimaryKey = false;
            ktTableColumn12.Key = "tblPrice";
            ktTableColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.NotSet;
            ktTableColumn12.Search = true;
            ktTableColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            ktTableColumn12.Template = "";
            ktTableColumn12.Title = "Price";
            ktTableColumn12.ToolTip = "";
            ktTableColumn12.Type = KimTools.WinForms.KtTableColumnTypes.Text;
            ktTableColumn12.Value = "";
            ktTableColumn12.Visible = true;
            ktTableColumn12.Width = 70;
            ktTableColumn12.Width_ = "70";
            ktTableColumn13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.NotSet;
            ktTableColumn13.Fill = "";
            ktTableColumn13.Format = "";
            ktTableColumn13.Group = "";
            ktTableColumn13.IsPrimaryKey = false;
            ktTableColumn13.Key = "tblStock";
            ktTableColumn13.Resizable = System.Windows.Forms.DataGridViewTriState.NotSet;
            ktTableColumn13.Search = true;
            ktTableColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            ktTableColumn13.Template = "";
            ktTableColumn13.Title = "Stock";
            ktTableColumn13.ToolTip = "";
            ktTableColumn13.Type = KimTools.WinForms.KtTableColumnTypes.Text;
            ktTableColumn13.Value = "";
            ktTableColumn13.Visible = true;
            ktTableColumn13.Width = 70;
            ktTableColumn13.Width_ = "70";
            this.tblBook.Columns = new KimTools.WinForms.KtTableColumn[] {
        ktTableColumn10,
        ktTableColumn11,
        ktTableColumn12,
        ktTableColumn13};
            this.tblBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblBook.KeyCaseSensitive = false;
            this.tblBook.Latency = 500;
            this.tblBook.Location = new System.Drawing.Point(0, 0);
            this.tblBook.MultiSelect = false;
            this.tblBook.Name = "tblBook";
            this.tblBook.Padding = new System.Windows.Forms.Padding(5);
            this.tblBook.ShowFooter = false;
            this.tblBook.ShowHeader = false;
            this.tblBook.ShowSearch = false;
            this.tblBook.Size = new System.Drawing.Size(647, 480);
            this.tblBook.TabIndex = 0;
            this.tblBook.CellClick += new KimTools.WinForms.KtTable.KtTableRowCellEventArgs(this.tblBook_CellClick);
            this.tblBook.RowSelected += new KimTools.WinForms.KtTable.KtTableRowEventArgs(this.tblBook_RowSelected);
            // 
            // RightPanel
            // 
            this.RightPanel.Controls.Add(this.ButtomRight);
            this.RightPanel.Controls.Add(this.tblOrder);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(647, 0);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(374, 480);
            this.RightPanel.TabIndex = 1;
            // 
            // ButtomRight
            // 
            this.ButtomRight.Controls.Add(this.lblTotalPrice);
            this.ButtomRight.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtomRight.Location = new System.Drawing.Point(0, 392);
            this.ButtomRight.Name = "ButtomRight";
            this.ButtomRight.Size = new System.Drawing.Size(374, 88);
            this.ButtomRight.TabIndex = 1;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(33, 32);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(200, 30);
            this.lblTotalPrice.TabIndex = 4;
            this.lblTotalPrice.Text = "Total Price : 00.00 $";
            // 
            // tblOrder
            // 
            this.tblOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(64)))));
            this.tblOrder.ColorBase = KimTools.WinForms.KtColor.Secondary;
            ktTableColumn14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.NotSet;
            ktTableColumn14.Fill = "";
            ktTableColumn14.Format = "";
            ktTableColumn14.Group = "";
            ktTableColumn14.IsPrimaryKey = true;
            ktTableColumn14.Key = "tblTitle";
            ktTableColumn14.Resizable = System.Windows.Forms.DataGridViewTriState.NotSet;
            ktTableColumn14.Search = true;
            ktTableColumn14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            ktTableColumn14.Template = "";
            ktTableColumn14.Title = "Title";
            ktTableColumn14.ToolTip = "";
            ktTableColumn14.Type = KimTools.WinForms.KtTableColumnTypes.Text;
            ktTableColumn14.Value = "";
            ktTableColumn14.Visible = true;
            ktTableColumn14.Width = 0;
            ktTableColumn14.Width_ = "";
            ktTableColumn15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.NotSet;
            ktTableColumn15.Fill = "";
            ktTableColumn15.Format = "";
            ktTableColumn15.Group = "";
            ktTableColumn15.IsPrimaryKey = false;
            ktTableColumn15.Key = "tblUnitPrice";
            ktTableColumn15.Resizable = System.Windows.Forms.DataGridViewTriState.NotSet;
            ktTableColumn15.Search = true;
            ktTableColumn15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            ktTableColumn15.Template = "";
            ktTableColumn15.Title = "Unit Price";
            ktTableColumn15.ToolTip = "";
            ktTableColumn15.Type = KimTools.WinForms.KtTableColumnTypes.Text;
            ktTableColumn15.Value = "";
            ktTableColumn15.Visible = true;
            ktTableColumn15.Width = 0;
            ktTableColumn15.Width_ = "";
            ktTableColumn16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.NotSet;
            ktTableColumn16.Fill = "";
            ktTableColumn16.Format = "";
            ktTableColumn16.Group = "";
            ktTableColumn16.IsPrimaryKey = false;
            ktTableColumn16.Key = "tblDiscountPercent";
            ktTableColumn16.Resizable = System.Windows.Forms.DataGridViewTriState.NotSet;
            ktTableColumn16.Search = true;
            ktTableColumn16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            ktTableColumn16.Template = "";
            ktTableColumn16.Title = "Dis";
            ktTableColumn16.ToolTip = "";
            ktTableColumn16.Type = KimTools.WinForms.KtTableColumnTypes.Text;
            ktTableColumn16.Value = "";
            ktTableColumn16.Visible = true;
            ktTableColumn16.Width = 0;
            ktTableColumn16.Width_ = "";
            ktTableColumn17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.NotSet;
            ktTableColumn17.Fill = "";
            ktTableColumn17.Format = "";
            ktTableColumn17.Group = "";
            ktTableColumn17.IsPrimaryKey = false;
            ktTableColumn17.Key = "tblQTY";
            ktTableColumn17.Resizable = System.Windows.Forms.DataGridViewTriState.NotSet;
            ktTableColumn17.Search = false;
            ktTableColumn17.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            ktTableColumn17.Template = "";
            ktTableColumn17.Title = "QTY";
            ktTableColumn17.ToolTip = "";
            ktTableColumn17.Type = KimTools.WinForms.KtTableColumnTypes.Text;
            ktTableColumn17.Value = "";
            ktTableColumn17.Visible = true;
            ktTableColumn17.Width = 0;
            ktTableColumn17.Width_ = "";
            ktTableColumn18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.NotSet;
            ktTableColumn18.Fill = "";
            ktTableColumn18.Format = "";
            ktTableColumn18.Group = "";
            ktTableColumn18.IsPrimaryKey = false;
            ktTableColumn18.Key = "tblTotal";
            ktTableColumn18.Resizable = System.Windows.Forms.DataGridViewTriState.NotSet;
            ktTableColumn18.Search = true;
            ktTableColumn18.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            ktTableColumn18.Template = "";
            ktTableColumn18.Title = "T.Price";
            ktTableColumn18.ToolTip = "";
            ktTableColumn18.Type = KimTools.WinForms.KtTableColumnTypes.Text;
            ktTableColumn18.Value = "";
            ktTableColumn18.Visible = true;
            ktTableColumn18.Width = 0;
            ktTableColumn18.Width_ = "";
            this.tblOrder.Columns = new KimTools.WinForms.KtTableColumn[] {
        ktTableColumn14,
        ktTableColumn15,
        ktTableColumn16,
        ktTableColumn17,
        ktTableColumn18};
            this.tblOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblOrder.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.tblOrder.KeyCaseSensitive = false;
            this.tblOrder.Latency = 500;
            this.tblOrder.Location = new System.Drawing.Point(0, 0);
            this.tblOrder.MultiSelect = false;
            this.tblOrder.Name = "tblOrder";
            this.tblOrder.Padding = new System.Windows.Forms.Padding(7);
            this.tblOrder.ShowFooter = false;
            this.tblOrder.ShowHeader = false;
            this.tblOrder.ShowSearch = false;
            this.tblOrder.Size = new System.Drawing.Size(374, 480);
            this.tblOrder.TabIndex = 0;
            this.tblOrder.RowUpdated += new KimTools.WinForms.KtTable.KtTableRowEventArgs(this.tblOrder_RowUpdated);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::BookStore.Properties.Resources.edit;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::BookStore.Properties.Resources.delete;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 8;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // FrmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 540);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOrder";
            this.Opacity = 1D;
            this.Text = "FrmGenresView";
            this.Load += new System.EventHandler(this.FrmOrder_Load);
            this.Leave += new System.EventHandler(this.FrmOrder_Leave);
            this.TopPanel.ResumeLayout(false);
            this.TopLeftPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.buttomPanel.ResumeLayout(false);
            this.buttomPanel.PerformLayout();
            this.buttomLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BookCover)).EndInit();
            this.RightPanel.ResumeLayout(false);
            this.ButtomRight.ResumeLayout(false);
            this.ButtomRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Panel TopPanel;
        private KimTools.WinForms.KtTextBox txtSearch;
        private System.Windows.Forms.Panel mainPanel;
        private KimTools.WinForms.KtButton btnAdd;
        private System.Windows.Forms.Panel TopLeftPanel;
        private System.Windows.Forms.Panel RightPanel;
        private KimTools.WinForms.KtButton btnCancel;
        private KimTools.WinForms.KtTable tblBook;
        private KimTools.WinForms.KtTable tblOrder;
        private System.Windows.Forms.Panel buttomPanel;
        private KimTools.WinForms.KtButton btnAddtoCard;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel buttomLeft;
        private System.Windows.Forms.PictureBox BookCover;
        private System.Windows.Forms.Panel ButtomRight;
        private System.Windows.Forms.Label lblTotalPrice;
        private KimTools.WinForms.KtTextBox txbQuntity;
        private KimTools.WinForms.KtTextBox txbDiscount;
        private System.Windows.Forms.Label lblDiscountSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
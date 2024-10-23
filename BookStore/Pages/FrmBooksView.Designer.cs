namespace BookStore.Pages
{
    partial class FrmBooksView
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
            KimTools.WinForms.KtTableColumn ktTableColumn23 = new KimTools.WinForms.KtTableColumn();
            KimTools.WinForms.KtTableColumn ktTableColumn24 = new KimTools.WinForms.KtTableColumn();
            KimTools.WinForms.KtTableColumn ktTableColumn25 = new KimTools.WinForms.KtTableColumn();
            KimTools.WinForms.KtTableColumn ktTableColumn26 = new KimTools.WinForms.KtTableColumn();
            KimTools.WinForms.KtTableColumn ktTableColumn27 = new KimTools.WinForms.KtTableColumn();
            KimTools.WinForms.KtTableColumn ktTableColumn28 = new KimTools.WinForms.KtTableColumn();
            KimTools.WinForms.KtTableColumn ktTableColumn29 = new KimTools.WinForms.KtTableColumn();
            KimTools.WinForms.KtTableColumn ktTableColumn30 = new KimTools.WinForms.KtTableColumn();
            KimTools.WinForms.KtTableColumn ktTableColumn31 = new KimTools.WinForms.KtTableColumn();
            KimTools.WinForms.KtTableColumn ktTableColumn32 = new KimTools.WinForms.KtTableColumn();
            KimTools.WinForms.KtTableColumn ktTableColumn33 = new KimTools.WinForms.KtTableColumn();
            this.tblBook = new KimTools.WinForms.KtTable();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.TopLeftPanel = new System.Windows.Forms.Panel();
            this.btnDelete = new KimTools.WinForms.KtButton();
            this.btnEdit = new KimTools.WinForms.KtButton();
            this.btnAdd = new KimTools.WinForms.KtButton();
            this.txtSearch = new KimTools.WinForms.KtTextBox();
            this.centerpanel = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.TopPanel.SuspendLayout();
            this.TopLeftPanel.SuspendLayout();
            this.centerpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblBook
            // 
            this.tblBook.AutoScroll = true;
            this.tblBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(22)))), ((int)(((byte)(51)))));
            ktTableColumn23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.NotSet;
            ktTableColumn23.Fill = "";
            ktTableColumn23.Format = "";
            ktTableColumn23.Group = "";
            ktTableColumn23.IsPrimaryKey = true;
            ktTableColumn23.Key = "tblID";
            ktTableColumn23.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            ktTableColumn23.Search = false;
            ktTableColumn23.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            ktTableColumn23.Template = "";
            ktTableColumn23.Title = "ID";
            ktTableColumn23.ToolTip = "";
            ktTableColumn23.Type = KimTools.WinForms.KtTableColumnTypes.Text;
            ktTableColumn23.Value = "tblId";
            ktTableColumn23.Visible = true;
            ktTableColumn23.Width = 40;
            ktTableColumn23.Width_ = "40";
            ktTableColumn24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            ktTableColumn24.Fill = "";
            ktTableColumn24.Format = "";
            ktTableColumn24.Group = "";
            ktTableColumn24.IsPrimaryKey = false;
            ktTableColumn24.Key = "tblCover";
            ktTableColumn24.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            ktTableColumn24.Search = false;
            ktTableColumn24.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            ktTableColumn24.Template = "";
            ktTableColumn24.Title = "Cover";
            ktTableColumn24.ToolTip = "";
            ktTableColumn24.Type = KimTools.WinForms.KtTableColumnTypes.Image;
            ktTableColumn24.Value = "";
            ktTableColumn24.Visible = true;
            ktTableColumn24.Width = 70;
            ktTableColumn24.Width_ = "70";
            ktTableColumn25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.NotSet;
            ktTableColumn25.Fill = "";
            ktTableColumn25.Format = "";
            ktTableColumn25.Group = "";
            ktTableColumn25.IsPrimaryKey = false;
            ktTableColumn25.Key = "tblTitle";
            ktTableColumn25.Resizable = System.Windows.Forms.DataGridViewTriState.NotSet;
            ktTableColumn25.Search = true;
            ktTableColumn25.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            ktTableColumn25.Template = "";
            ktTableColumn25.Title = "Book Title";
            ktTableColumn25.ToolTip = "";
            ktTableColumn25.Type = KimTools.WinForms.KtTableColumnTypes.Text;
            ktTableColumn25.Value = "";
            ktTableColumn25.Visible = true;
            ktTableColumn25.Width = 0;
            ktTableColumn25.Width_ = "";
            ktTableColumn26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.NotSet;
            ktTableColumn26.Fill = "";
            ktTableColumn26.Format = "";
            ktTableColumn26.Group = "";
            ktTableColumn26.IsPrimaryKey = false;
            ktTableColumn26.Key = "tblGenre";
            ktTableColumn26.Resizable = System.Windows.Forms.DataGridViewTriState.NotSet;
            ktTableColumn26.Search = true;
            ktTableColumn26.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            ktTableColumn26.Template = "";
            ktTableColumn26.Title = "Genre";
            ktTableColumn26.ToolTip = "";
            ktTableColumn26.Type = KimTools.WinForms.KtTableColumnTypes.Text;
            ktTableColumn26.Value = "";
            ktTableColumn26.Visible = true;
            ktTableColumn26.Width = 0;
            ktTableColumn26.Width_ = "";
            ktTableColumn27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.NotSet;
            ktTableColumn27.Fill = "";
            ktTableColumn27.Format = "";
            ktTableColumn27.Group = "";
            ktTableColumn27.IsPrimaryKey = false;
            ktTableColumn27.Key = "tblAuthor";
            ktTableColumn27.Resizable = System.Windows.Forms.DataGridViewTriState.NotSet;
            ktTableColumn27.Search = true;
            ktTableColumn27.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            ktTableColumn27.Template = "";
            ktTableColumn27.Title = "Author";
            ktTableColumn27.ToolTip = "";
            ktTableColumn27.Type = KimTools.WinForms.KtTableColumnTypes.Text;
            ktTableColumn27.Value = "";
            ktTableColumn27.Visible = true;
            ktTableColumn27.Width = 0;
            ktTableColumn27.Width_ = "";
            ktTableColumn28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            ktTableColumn28.Fill = "";
            ktTableColumn28.Format = "";
            ktTableColumn28.Group = "";
            ktTableColumn28.IsPrimaryKey = false;
            ktTableColumn28.Key = "tblPublisher";
            ktTableColumn28.Resizable = System.Windows.Forms.DataGridViewTriState.NotSet;
            ktTableColumn28.Search = true;
            ktTableColumn28.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            ktTableColumn28.Template = "";
            ktTableColumn28.Title = "Publisher";
            ktTableColumn28.ToolTip = "";
            ktTableColumn28.Type = KimTools.WinForms.KtTableColumnTypes.Text;
            ktTableColumn28.Value = "";
            ktTableColumn28.Visible = true;
            ktTableColumn28.Width = 0;
            ktTableColumn28.Width_ = "";
            ktTableColumn29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            ktTableColumn29.Fill = "";
            ktTableColumn29.Format = "";
            ktTableColumn29.Group = "";
            ktTableColumn29.IsPrimaryKey = false;
            ktTableColumn29.Key = "tblPage";
            ktTableColumn29.Resizable = System.Windows.Forms.DataGridViewTriState.NotSet;
            ktTableColumn29.Search = true;
            ktTableColumn29.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            ktTableColumn29.Template = "";
            ktTableColumn29.Title = "Page";
            ktTableColumn29.ToolTip = "";
            ktTableColumn29.Type = KimTools.WinForms.KtTableColumnTypes.Text;
            ktTableColumn29.Value = "";
            ktTableColumn29.Visible = true;
            ktTableColumn29.Width = 50;
            ktTableColumn29.Width_ = "50";
            ktTableColumn30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.NotSet;
            ktTableColumn30.Fill = "";
            ktTableColumn30.Format = "";
            ktTableColumn30.Group = "";
            ktTableColumn30.IsPrimaryKey = false;
            ktTableColumn30.Key = "tblPublishingDate";
            ktTableColumn30.Resizable = System.Windows.Forms.DataGridViewTriState.NotSet;
            ktTableColumn30.Search = true;
            ktTableColumn30.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            ktTableColumn30.Template = "";
            ktTableColumn30.Title = "Publishing Date";
            ktTableColumn30.ToolTip = "";
            ktTableColumn30.Type = KimTools.WinForms.KtTableColumnTypes.Text;
            ktTableColumn30.Value = "";
            ktTableColumn30.Visible = true;
            ktTableColumn30.Width = 0;
            ktTableColumn30.Width_ = "";
            ktTableColumn31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.NotSet;
            ktTableColumn31.Fill = "";
            ktTableColumn31.Format = "";
            ktTableColumn31.Group = "";
            ktTableColumn31.IsPrimaryKey = false;
            ktTableColumn31.Key = "tblCostPrice";
            ktTableColumn31.Resizable = System.Windows.Forms.DataGridViewTriState.NotSet;
            ktTableColumn31.Search = true;
            ktTableColumn31.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            ktTableColumn31.Template = "";
            ktTableColumn31.Title = "CostPrice";
            ktTableColumn31.ToolTip = "";
            ktTableColumn31.Type = KimTools.WinForms.KtTableColumnTypes.Text;
            ktTableColumn31.Value = "";
            ktTableColumn31.Visible = true;
            ktTableColumn31.Width = 0;
            ktTableColumn31.Width_ = "";
            ktTableColumn32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.NotSet;
            ktTableColumn32.Fill = "";
            ktTableColumn32.Format = "";
            ktTableColumn32.Group = "";
            ktTableColumn32.IsPrimaryKey = false;
            ktTableColumn32.Key = "tblSalePrice";
            ktTableColumn32.Resizable = System.Windows.Forms.DataGridViewTriState.NotSet;
            ktTableColumn32.Search = true;
            ktTableColumn32.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            ktTableColumn32.Template = "";
            ktTableColumn32.Title = "Sale Price";
            ktTableColumn32.ToolTip = "";
            ktTableColumn32.Type = KimTools.WinForms.KtTableColumnTypes.Text;
            ktTableColumn32.Value = "";
            ktTableColumn32.Visible = true;
            ktTableColumn32.Width = 0;
            ktTableColumn32.Width_ = "";
            ktTableColumn33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.NotSet;
            ktTableColumn33.Fill = "";
            ktTableColumn33.Format = "";
            ktTableColumn33.Group = "";
            ktTableColumn33.IsPrimaryKey = false;
            ktTableColumn33.Key = "tblIsSequel";
            ktTableColumn33.Resizable = System.Windows.Forms.DataGridViewTriState.NotSet;
            ktTableColumn33.Search = true;
            ktTableColumn33.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            ktTableColumn33.Template = "";
            ktTableColumn33.Title = "IsSequel";
            ktTableColumn33.ToolTip = "";
            ktTableColumn33.Type = KimTools.WinForms.KtTableColumnTypes.Text;
            ktTableColumn33.Value = "";
            ktTableColumn33.Visible = true;
            ktTableColumn33.Width = 50;
            ktTableColumn33.Width_ = "50";
            this.tblBook.Columns = new KimTools.WinForms.KtTableColumn[] {
        ktTableColumn23,
        ktTableColumn24,
        ktTableColumn25,
        ktTableColumn26,
        ktTableColumn27,
        ktTableColumn28,
        ktTableColumn29,
        ktTableColumn30,
        ktTableColumn31,
        ktTableColumn32,
        ktTableColumn33};
            this.tblBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblBook.KeyCaseSensitive = false;
            this.tblBook.Latency = 500;
            this.tblBook.Location = new System.Drawing.Point(0, 0);
            this.tblBook.MultiSelect = false;
            this.tblBook.Name = "tblBook";
            this.tblBook.Padding = new System.Windows.Forms.Padding(5);
            this.tblBook.ShowFooter = true;
            this.tblBook.ShowHeader = false;
            this.tblBook.ShowSearch = false;
            this.tblBook.Size = new System.Drawing.Size(872, 476);
            this.tblBook.TabIndex = 0;
            this.tblBook.CellClick += new KimTools.WinForms.KtTable.KtTableRowCellEventArgs(this.tblBook_CellClick);
            this.tblBook.RowSelected += new KimTools.WinForms.KtTable.KtTableRowEventArgs(this.tblBook_RowSelected);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Transparent;
            this.TopPanel.Controls.Add(this.TopLeftPanel);
            this.TopPanel.Controls.Add(this.txtSearch);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(872, 56);
            this.TopPanel.TabIndex = 1;
            // 
            // TopLeftPanel
            // 
            this.TopLeftPanel.Controls.Add(this.btnDelete);
            this.TopLeftPanel.Controls.Add(this.btnEdit);
            this.TopLeftPanel.Controls.Add(this.btnAdd);
            this.TopLeftPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.TopLeftPanel.Location = new System.Drawing.Point(624, 0);
            this.TopLeftPanel.Name = "TopLeftPanel";
            this.TopLeftPanel.Size = new System.Drawing.Size(248, 56);
            this.TopLeftPanel.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Empty;
            this.btnDelete.BorderShape = KimTools.WinForms.KtSize.Default;
            this.btnDelete.BorderSize = KimTools.WinForms.KtSize.Default;
            this.btnDelete.CustomColors = new System.Drawing.Color[0];
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.IconName = "Tabler.outline.trash";
            this.btnDelete.IconSize = 18;
            this.btnDelete.IconStroke = 2.5D;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Location = new System.Drawing.Point(64, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(46, 39);
            this.btnDelete.Style = KimTools.WinForms.KtStyle.Outline;
            this.btnDelete.TabIndex = 3;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Empty;
            this.btnEdit.BorderShape = KimTools.WinForms.KtSize.Default;
            this.btnEdit.BorderSize = KimTools.WinForms.KtSize.Default;
            this.btnEdit.CustomColors = new System.Drawing.Color[0];
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEdit.IconName = "Tabler.outline.edit";
            this.btnEdit.IconSize = 18;
            this.btnEdit.IconStroke = 2.5D;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEdit.Location = new System.Drawing.Point(128, 7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(46, 39);
            this.btnEdit.Style = KimTools.WinForms.KtStyle.Outline;
            this.btnEdit.TabIndex = 2;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Location = new System.Drawing.Point(190, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(46, 39);
            this.btnAdd.Style = KimTools.WinForms.KtStyle.Outline;
            this.btnAdd.TabIndex = 1;
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
            this.txtSearch.Size = new System.Drawing.Size(282, 39);
            this.txtSearch.Style = KimTools.WinForms.KtTextBox.KtTextBoxStyle.Tailwind;
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextMarginBottom = 0;
            this.txtSearch.TextPlaceholder = "";
            this.txtSearch.TextChange += new System.EventHandler(this.txtSearch_TextChange);
            // 
            // centerpanel
            // 
            this.centerpanel.Controls.Add(this.tblBook);
            this.centerpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerpanel.Location = new System.Drawing.Point(0, 56);
            this.centerpanel.Name = "centerpanel";
            this.centerpanel.Size = new System.Drawing.Size(872, 476);
            this.centerpanel.TabIndex = 2;
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
            // FrmBooksView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(872, 532);
            this.Controls.Add(this.centerpanel);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBooksView";
            this.Opacity = 1D;
            this.Text = "FrmGenresView";
            this.Load += new System.EventHandler(this.FrmBooksView_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopLeftPanel.ResumeLayout(false);
            this.centerpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private KimTools.WinForms.KtTable tblBook;
        private System.Windows.Forms.Panel TopPanel;
        private KimTools.WinForms.KtTextBox txtSearch;
        private System.Windows.Forms.Panel centerpanel;
        private KimTools.WinForms.KtButton btnAdd;
        private System.Windows.Forms.Panel TopLeftPanel;
        private KimTools.WinForms.KtButton btnDelete;
        private KimTools.WinForms.KtButton btnEdit;
    }
}
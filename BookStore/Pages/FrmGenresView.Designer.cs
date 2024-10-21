namespace BookStore.Pages
{
    partial class FrmGenresView
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
            KimTools.WinForms.KtTableColumn ktTableColumn1 = new KimTools.WinForms.KtTableColumn();
            KimTools.WinForms.KtTableColumn ktTableColumn2 = new KimTools.WinForms.KtTableColumn();
            KimTools.WinForms.KtTableColumn ktTableColumn3 = new KimTools.WinForms.KtTableColumn();
            KimTools.WinForms.KtTableColumn ktTableColumn4 = new KimTools.WinForms.KtTableColumn();
            this.tblGenres = new KimTools.WinForms.KtTable();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.TopLeftPanel = new System.Windows.Forms.Panel();
            this.centerpanel = new System.Windows.Forms.Panel();
            this.btnDelete = new KimTools.WinForms.KtButton();
            this.btnEdit = new KimTools.WinForms.KtButton();
            this.btnAdd = new KimTools.WinForms.KtButton();
            this.txtSearch = new KimTools.WinForms.KtTextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.TopPanel.SuspendLayout();
            this.TopLeftPanel.SuspendLayout();
            this.centerpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblGenres
            // 
            this.tblGenres.AutoScroll = true;
            this.tblGenres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(22)))), ((int)(((byte)(51)))));
            ktTableColumn1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            ktTableColumn1.Fill = "";
            ktTableColumn1.Format = "";
            ktTableColumn1.Group = "";
            ktTableColumn1.IsPrimaryKey = true;
            ktTableColumn1.Key = "tblID";
            ktTableColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.NotSet;
            ktTableColumn1.Search = false;
            ktTableColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            ktTableColumn1.Template = "";
            ktTableColumn1.Title = "ID";
            ktTableColumn1.ToolTip = "";
            ktTableColumn1.Type = KimTools.WinForms.KtTableColumnTypes.Text;
            ktTableColumn1.Value = "tblId";
            ktTableColumn1.Visible = true;
            ktTableColumn1.Width = 70;
            ktTableColumn1.Width_ = "70";
            ktTableColumn2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            ktTableColumn2.Fill = "";
            ktTableColumn2.Format = "";
            ktTableColumn2.Group = "";
            ktTableColumn2.IsPrimaryKey = false;
            ktTableColumn2.Key = "tblName";
            ktTableColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.NotSet;
            ktTableColumn2.Search = true;
            ktTableColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            ktTableColumn2.Template = "";
            ktTableColumn2.Title = "Genres";
            ktTableColumn2.ToolTip = "";
            ktTableColumn2.Type = KimTools.WinForms.KtTableColumnTypes.Text;
            ktTableColumn2.Value = "";
            ktTableColumn2.Visible = true;
            ktTableColumn2.Width = 0;
            ktTableColumn2.Width_ = "";
            ktTableColumn3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            ktTableColumn3.Fill = "";
            ktTableColumn3.Format = "";
            ktTableColumn3.Group = "";
            ktTableColumn3.IsPrimaryKey = false;
            ktTableColumn3.Key = "tblCreated";
            ktTableColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.NotSet;
            ktTableColumn3.Search = true;
            ktTableColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            ktTableColumn3.Template = "";
            ktTableColumn3.Title = "Created";
            ktTableColumn3.ToolTip = "";
            ktTableColumn3.Type = KimTools.WinForms.KtTableColumnTypes.Text;
            ktTableColumn3.Value = "";
            ktTableColumn3.Visible = true;
            ktTableColumn3.Width = 0;
            ktTableColumn3.Width_ = "";
            ktTableColumn4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            ktTableColumn4.Fill = "";
            ktTableColumn4.Format = "";
            ktTableColumn4.Group = "";
            ktTableColumn4.IsPrimaryKey = false;
            ktTableColumn4.Key = "tblUpdated";
            ktTableColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.NotSet;
            ktTableColumn4.Search = true;
            ktTableColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            ktTableColumn4.Template = "";
            ktTableColumn4.Title = "Updated";
            ktTableColumn4.ToolTip = "";
            ktTableColumn4.Type = KimTools.WinForms.KtTableColumnTypes.Text;
            ktTableColumn4.Value = "";
            ktTableColumn4.Visible = true;
            ktTableColumn4.Width = 0;
            ktTableColumn4.Width_ = "";
            this.tblGenres.Columns = new KimTools.WinForms.KtTableColumn[] {
        ktTableColumn1,
        ktTableColumn2,
        ktTableColumn3,
        ktTableColumn4};
            this.tblGenres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblGenres.KeyCaseSensitive = false;
            this.tblGenres.Latency = 500;
            this.tblGenres.Location = new System.Drawing.Point(0, 0);
            this.tblGenres.MultiSelect = false;
            this.tblGenres.Name = "tblGenres";
            this.tblGenres.Padding = new System.Windows.Forms.Padding(5);
            this.tblGenres.ShowFooter = true;
            this.tblGenres.ShowHeader = false;
            this.tblGenres.ShowSearch = false;
            this.tblGenres.Size = new System.Drawing.Size(872, 476);
            this.tblGenres.TabIndex = 0;
            this.tblGenres.CellClick += new KimTools.WinForms.KtTable.KtTableRowCellEventArgs(this.tblGenres_CellClick);
            this.tblGenres.RowSelected += new KimTools.WinForms.KtTable.KtTableRowEventArgs(this.tblGenres_RowSelected);
            // 
            // TopPanel
            // 
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
            // centerpanel
            // 
            this.centerpanel.Controls.Add(this.tblGenres);
            this.centerpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerpanel.Location = new System.Drawing.Point(0, 56);
            this.centerpanel.Name = "centerpanel";
            this.centerpanel.Size = new System.Drawing.Size(872, 476);
            this.centerpanel.TabIndex = 2;
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
            // FrmGenresView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 532);
            this.Controls.Add(this.centerpanel);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGenresView";
            this.Opacity = 1D;
            this.Text = "FrmGenresView";
            this.Load += new System.EventHandler(this.FrmGenresView_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopLeftPanel.ResumeLayout(false);
            this.centerpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private KimTools.WinForms.KtTable tblGenres;
        private System.Windows.Forms.Panel TopPanel;
        private KimTools.WinForms.KtTextBox txtSearch;
        private System.Windows.Forms.Panel centerpanel;
        private KimTools.WinForms.KtButton btnAdd;
        private System.Windows.Forms.Panel TopLeftPanel;
        private KimTools.WinForms.KtButton btnDelete;
        private KimTools.WinForms.KtButton btnEdit;
    }
}
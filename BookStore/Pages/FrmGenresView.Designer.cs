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
            KimTools.WinForms.KtTableColumn ktTableColumn9 = new KimTools.WinForms.KtTableColumn();
            KimTools.WinForms.KtTableColumn ktTableColumn10 = new KimTools.WinForms.KtTableColumn();
            KimTools.WinForms.KtTableColumn ktTableColumn11 = new KimTools.WinForms.KtTableColumn();
            KimTools.WinForms.KtTableColumn ktTableColumn12 = new KimTools.WinForms.KtTableColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tblGenres = new KimTools.WinForms.KtTable();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.txtSearch = new KimTools.WinForms.KtTextBox();
            this.centerpanel = new System.Windows.Forms.Panel();
            this.TopPanel.SuspendLayout();
            this.centerpanel.SuspendLayout();
            this.SuspendLayout();
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
            // tblGenres
            // 
            this.tblGenres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(222)))), ((int)(((byte)(225)))));
            ktTableColumn9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            ktTableColumn9.Fill = "";
            ktTableColumn9.Format = "";
            ktTableColumn9.Group = "";
            ktTableColumn9.IsPrimaryKey = false;
            ktTableColumn9.Key = "tblID";
            ktTableColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.NotSet;
            ktTableColumn9.Search = true;
            ktTableColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            ktTableColumn9.Template = "";
            ktTableColumn9.Title = "ID";
            ktTableColumn9.ToolTip = "";
            ktTableColumn9.Type = KimTools.WinForms.KtTableColumnTypes.Text;
            ktTableColumn9.Value = "";
            ktTableColumn9.Visible = true;
            ktTableColumn9.Width = 70;
            ktTableColumn9.Width_ = "70";
            ktTableColumn10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            ktTableColumn10.Fill = "";
            ktTableColumn10.Format = "";
            ktTableColumn10.Group = "";
            ktTableColumn10.IsPrimaryKey = false;
            ktTableColumn10.Key = "tblName";
            ktTableColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.NotSet;
            ktTableColumn10.Search = true;
            ktTableColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            ktTableColumn10.Template = "";
            ktTableColumn10.Title = "Genres";
            ktTableColumn10.ToolTip = "";
            ktTableColumn10.Type = KimTools.WinForms.KtTableColumnTypes.Text;
            ktTableColumn10.Value = "";
            ktTableColumn10.Visible = true;
            ktTableColumn10.Width = 0;
            ktTableColumn10.Width_ = "";
            ktTableColumn11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            ktTableColumn11.Fill = "";
            ktTableColumn11.Format = "";
            ktTableColumn11.Group = "";
            ktTableColumn11.IsPrimaryKey = false;
            ktTableColumn11.Key = "tblCreated";
            ktTableColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.NotSet;
            ktTableColumn11.Search = true;
            ktTableColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            ktTableColumn11.Template = "";
            ktTableColumn11.Title = "Created";
            ktTableColumn11.ToolTip = "";
            ktTableColumn11.Type = KimTools.WinForms.KtTableColumnTypes.Text;
            ktTableColumn11.Value = "";
            ktTableColumn11.Visible = true;
            ktTableColumn11.Width = 0;
            ktTableColumn11.Width_ = "";
            ktTableColumn12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            ktTableColumn12.Fill = "";
            ktTableColumn12.Format = "";
            ktTableColumn12.Group = "";
            ktTableColumn12.IsPrimaryKey = false;
            ktTableColumn12.Key = "tblUpdated";
            ktTableColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.NotSet;
            ktTableColumn12.Search = true;
            ktTableColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            ktTableColumn12.Template = "";
            ktTableColumn12.Title = "Updated";
            ktTableColumn12.ToolTip = "";
            ktTableColumn12.Type = KimTools.WinForms.KtTableColumnTypes.Text;
            ktTableColumn12.Value = "";
            ktTableColumn12.Visible = true;
            ktTableColumn12.Width = 0;
            ktTableColumn12.Width_ = "";
            this.tblGenres.Columns = new KimTools.WinForms.KtTableColumn[] {
        ktTableColumn9,
        ktTableColumn10,
        ktTableColumn11,
        ktTableColumn12};
            this.tblGenres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblGenres.KeyCaseSensitive = false;
            this.tblGenres.Latency = 500;
            this.tblGenres.Location = new System.Drawing.Point(0, 0);
            this.tblGenres.MultiSelect = false;
            this.tblGenres.Name = "tblGenres";
            this.tblGenres.Padding = new System.Windows.Forms.Padding(5);
            this.tblGenres.ShowFooter = false;
            this.tblGenres.ShowHeader = false;
            this.tblGenres.ShowSearch = false;
            this.tblGenres.Size = new System.Drawing.Size(1241, 678);
            this.tblGenres.TabIndex = 0;
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.txtSearch);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(862, 56);
            this.TopPanel.TabIndex = 1;
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
            this.centerpanel.Controls.Add(this.tblGenres);
            this.centerpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerpanel.Location = new System.Drawing.Point(0, 67);
            this.centerpanel.Name = "centerpanel";
            this.centerpanel.Size = new System.Drawing.Size(1034, 565);
            this.centerpanel.TabIndex = 2;
            // 
            // FrmGenresView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 527);
            this.Controls.Add(this.centerpanel);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(66)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGenresView";
            this.Opacity = 1D;
            this.Text = "FrmGenresView";
            this.Load += new System.EventHandler(this.FrmGenresView_Load);
            this.TopPanel.ResumeLayout(false);
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
    }
}
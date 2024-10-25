namespace BookStore.Dialogs
{
    partial class AddAuthor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAuthor));
            this.btnSave = new KimTools.WinForms.KtButton();
            this.btnClose = new KimTools.WinForms.KtButton();
            this.txtName = new KimTools.WinForms.KtTextBox();
            this.ktLabel1 = new KimTools.WinForms.KtLabel();
            this.ktPictureBox1 = new KimTools.WinForms.KtPictureBox();
            this.lblAdd = new KimTools.WinForms.KtLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ktPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Empty;
            this.btnSave.BorderShape = KimTools.WinForms.KtSize.Default;
            this.btnSave.BorderSize = KimTools.WinForms.KtSize.Default;
            this.btnSave.CustomColors = new System.Drawing.Color[0];
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.IconName = "";
            this.btnSave.IconSize = 16;
            this.btnSave.IconStroke = 2.5D;
            this.btnSave.Location = new System.Drawing.Point(375, 366);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 48);
            this.btnSave.Style = KimTools.WinForms.KtStyle.Outline;
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnClose.Location = new System.Drawing.Point(38, 366);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 48);
            this.btnClose.Style = KimTools.WinForms.KtStyle.Outline;
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtName
            // 
            this.txtName.AcceptsReturn = false;
            this.txtName.AcceptsTab = false;
            this.txtName.AnimationSpeed = 200;
            this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtName.AutoSizeHeight = true;
            this.txtName.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.CustomBorderColor = System.Drawing.Color.Empty;
            this.txtName.CustomBorderColorActive = System.Drawing.Color.Empty;
            this.txtName.CustomBorderColorDisabled = System.Drawing.Color.Empty;
            this.txtName.CustomFillColor = System.Drawing.Color.Empty;
            this.txtName.CustomIconLeft = null;
            this.txtName.CustomIconRight = null;
            this.txtName.CustomPlaceholderColor = System.Drawing.Color.Empty;
            this.txtName.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Empty;
            this.txtName.HideSelection = true;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(38, 183);
            this.txtName.MaxLength = 32767;
            this.txtName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtName.Modified = false;
            this.txtName.Name = "txtName";
            this.txtName.Password = false;
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(457, 51);
            this.txtName.Style = KimTools.WinForms.KtTextBox.KtTextBoxStyle.Tailwind;
            this.txtName.TabIndex = 2;
            this.txtName.TextMarginBottom = 0;
            this.txtName.TextPlaceholder = "";
            this.txtName.TextChange += new System.EventHandler(this.txtName_TextChange);
            // 
            // ktLabel1
            // 
            this.ktLabel1.AutoSize = true;
            this.ktLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ktLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(66)))));
            this.ktLabel1.KtFontSize = KimTools.WinForms.KtFont.Default;
            this.ktLabel1.Location = new System.Drawing.Point(41, 155);
            this.ktLabel1.Name = "ktLabel1";
            this.ktLabel1.Size = new System.Drawing.Size(124, 25);
            this.ktLabel1.TabIndex = 3;
            this.ktLabel1.Text = "Author Name";
            // 
            // ktPictureBox1
            // 
            this.ktPictureBox1.AllowFocused = false;
            this.ktPictureBox1.AutoSizeHeight = true;
            this.ktPictureBox1.BorderRadius = 35;
            this.ktPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("ktPictureBox1.Image")));
            this.ktPictureBox1.IsCircle = true;
            this.ktPictureBox1.Location = new System.Drawing.Point(41, 60);
            this.ktPictureBox1.Name = "ktPictureBox1";
            this.ktPictureBox1.Size = new System.Drawing.Size(71, 71);
            this.ktPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ktPictureBox1.TabIndex = 4;
            this.ktPictureBox1.TabStop = false;
            this.ktPictureBox1.Type = KimTools.WinForms.KtPictureBox.Types.Circle;
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(66)))));
            this.lblAdd.KtFontSize = KimTools.WinForms.KtFont.H3;
            this.lblAdd.Location = new System.Drawing.Point(127, 80);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(141, 32);
            this.lblAdd.TabIndex = 5;
            this.lblAdd.Text = "Add Author";
            // 
            // AddAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 424);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.ktPictureBox1);
            this.Controls.Add(this.ktLabel1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAuthor";
            this.Text = "AddGenre";
            this.Load += new System.EventHandler(this.AddAuthor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ktPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KimTools.WinForms.KtButton btnSave;
        private KimTools.WinForms.KtButton btnClose;
        private KimTools.WinForms.KtTextBox txtName;
        private KimTools.WinForms.KtLabel ktLabel1;
        private KimTools.WinForms.KtPictureBox ktPictureBox1;
        public KimTools.WinForms.KtLabel lblAdd;
    }
}
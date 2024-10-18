namespace BookStore
{
    partial class FrmLogin
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
            this.components = new System.ComponentModel.Container();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.Profilepicture = new KimTools.WinForms.KtPictureBox();
            this.Themes = new KimTools.WinForms.KtTheme(this.components);
            this.lblusername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogin = new KimTools.WinForms.KtButton();
            this.txtPassword = new KimTools.WinForms.KtTextBox();
            this.txtUsername = new KimTools.WinForms.KtTextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnExit = new KimTools.WinForms.KtButton();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Profilepicture)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.Profilepicture);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(430, 286);
            this.TopPanel.TabIndex = 1;
            // 
            // Profilepicture
            // 
            this.Profilepicture.AllowFocused = false;
            this.Profilepicture.AutoSizeHeight = true;
            this.Profilepicture.BorderRadius = 92;
            this.Profilepicture.Image = global::BookStore.Properties.Resources.people;
            this.Profilepicture.IsCircle = true;
            this.Profilepicture.Location = new System.Drawing.Point(119, 35);
            this.Profilepicture.Name = "Profilepicture";
            this.Profilepicture.Size = new System.Drawing.Size(185, 185);
            this.Profilepicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Profilepicture.TabIndex = 0;
            this.Profilepicture.TabStop = false;
            this.Profilepicture.Type = KimTools.WinForms.KtPictureBox.Types.Circle;
            // 
            // Themes
            // 
            this.Themes.Accent = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.Themes.Contrast = 10D;
            this.Themes.Dark = false;
            this.Themes.Primary = System.Drawing.Color.SlateBlue;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Segoe UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.Color.Red;
            this.lblusername.Location = new System.Drawing.Point(46, 367);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(178, 21);
            this.lblusername.TabIndex = 5;
            this.lblusername.Text = "Username can not empty";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Red;
            this.lblPassword.Location = new System.Drawing.Point(45, 461);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(173, 21);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password can not empty";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Empty;
            this.btnLogin.BorderShape = KimTools.WinForms.KtSize.Default;
            this.btnLogin.BorderSize = KimTools.WinForms.KtSize.Default;
            this.btnLogin.CustomColors = new System.Drawing.Color[0];
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.IconName = "";
            this.btnLogin.IconSize = 11;
            this.btnLogin.IconStroke = 2.5D;
            this.btnLogin.Location = new System.Drawing.Point(259, 517);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 47);
            this.btnLogin.Style = KimTools.WinForms.KtStyle.Tailwind;
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsReturn = false;
            this.txtPassword.AcceptsTab = false;
            this.txtPassword.AnimationSpeed = 200;
            this.txtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPassword.AutoSizeHeight = true;
            this.txtPassword.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.txtPassword.Bg = KimTools.WinForms.KtColor.Light;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.CustomBorderColor = System.Drawing.Color.Empty;
            this.txtPassword.CustomBorderColorActive = System.Drawing.Color.Empty;
            this.txtPassword.CustomBorderColorDisabled = System.Drawing.Color.Empty;
            this.txtPassword.CustomFillColor = System.Drawing.Color.Empty;
            this.txtPassword.CustomIconLeft = null;
            this.txtPassword.CustomIconRight = null;
            this.txtPassword.CustomPlaceholderColor = System.Drawing.Color.DimGray;
            this.txtPassword.DefaultFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.HideSelection = true;
            this.txtPassword.IconLeft = "Hero.outline.lock-closed";
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(47, 406);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPassword.Modified = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(5);
            this.txtPassword.Password = false;
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(332, 56);
            this.txtPassword.Style = KimTools.WinForms.KtTextBox.KtTextBoxStyle.Custom;
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextMarginBottom = 0;
            this.txtPassword.TextPlaceholder = "Password";
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            this.txtPassword.TextChange += new System.EventHandler(this.txtPassword_TextChange);
            this.txtPassword.TextChanged += new System.EventHandler(this.ktTextBox2_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.AcceptsReturn = false;
            this.txtUsername.AcceptsTab = false;
            this.txtUsername.AnimationSpeed = 200;
            this.txtUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUsername.AutoSizeHeight = true;
            this.txtUsername.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.txtUsername.Bg = KimTools.WinForms.KtColor.Light;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.CustomBorderColor = System.Drawing.Color.Empty;
            this.txtUsername.CustomBorderColorActive = System.Drawing.Color.Empty;
            this.txtUsername.CustomBorderColorDisabled = System.Drawing.Color.Empty;
            this.txtUsername.CustomFillColor = System.Drawing.Color.Empty;
            this.txtUsername.CustomIconLeft = null;
            this.txtUsername.CustomIconRight = null;
            this.txtUsername.CustomPlaceholderColor = System.Drawing.Color.DimGray;
            this.txtUsername.DefaultFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.HideSelection = true;
            this.txtUsername.IconLeft = "Tabler.outline.user";
            this.txtUsername.Lines = new string[0];
            this.txtUsername.Location = new System.Drawing.Point(47, 312);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtUsername.Modified = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(5);
            this.txtUsername.Password = false;
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.ShortcutsEnabled = true;
            this.txtUsername.Size = new System.Drawing.Size(332, 56);
            this.txtUsername.Style = KimTools.WinForms.KtTextBox.KtTextBoxStyle.Custom;
            this.txtUsername.TabIndex = 2;
            this.txtUsername.TextMarginBottom = 0;
            this.txtUsername.TextPlaceholder = "Username";
            this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsername_KeyPress);
            this.txtUsername.TextChange += new System.EventHandler(this.txtUsername_TextChange);
            this.txtUsername.TextChanged += new System.EventHandler(this.ktTextBox1_TextChanged);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.Red;
            this.lblLogin.Location = new System.Drawing.Point(46, 463);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(219, 21);
            this.lblLogin.TabIndex = 7;
            this.lblLogin.Text = "Incorect Username or Password";
            this.lblLogin.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Empty;
            this.btnExit.BorderShape = KimTools.WinForms.KtSize.Default;
            this.btnExit.BorderSize = KimTools.WinForms.KtSize.Default;
            this.btnExit.CustomColors = new System.Drawing.Color[0];
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.IconName = "";
            this.btnExit.IconSize = 11;
            this.btnExit.IconStroke = 2.5D;
            this.btnExit.Location = new System.Drawing.Point(57, 517);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 47);
            this.btnExit.Style = KimTools.WinForms.KtStyle.Tailwind;
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmLogin
            // 
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(222)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(430, 647);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(66)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "FrmLogin";
            this.Opacity = 1D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Login";
            this.Theme = this.Themes;
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Profilepicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KimTools.WinForms.KtPictureBox Profilepicture;
        private System.Windows.Forms.Panel TopPanel;
        private KimTools.WinForms.KtTextBox txtUsername;
        private KimTools.WinForms.KtTextBox txtPassword;
        private KimTools.WinForms.KtButton btnLogin;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblPassword;
        public KimTools.WinForms.KtTheme Themes;
        private System.Windows.Forms.Label lblLogin;
        private KimTools.WinForms.KtButton btnExit;
    }
}


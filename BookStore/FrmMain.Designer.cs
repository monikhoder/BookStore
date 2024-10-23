namespace BookStore
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.MainFrmThemes = new KimTools.WinForms.KtTheme(this.components);
            this.TopPanel = new KimTools.WinForms.KtPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ktPictureBox1 = new KimTools.WinForms.KtPictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblWelcome = new KimTools.WinForms.KtLabel();
            this.LeftPanel = new KimTools.WinForms.KtPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ktButton6 = new KimTools.WinForms.KtButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDashboard = new KimTools.WinForms.KtButton();
            this.btnUser = new KimTools.WinForms.KtButton();
            this.btnGenres = new KimTools.WinForms.KtButton();
            this.btnOrder = new KimTools.WinForms.KtButton();
            this.btnBook = new KimTools.WinForms.KtButton();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CenterPanel = new System.Windows.Forms.Panel();
            this.TopPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ktPictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainFrmThemes
            // 
            this.MainFrmThemes.Accent = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.MainFrmThemes.Contrast = 10D;
            this.MainFrmThemes.Dark = false;
            this.MainFrmThemes.Primary = System.Drawing.Color.SlateBlue;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(216)))));
            this.TopPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(216)))));
            this.TopPanel.BgOpacity = 255;
            this.TopPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(193)))), ((int)(((byte)(201)))));
            this.TopPanel.BorderOpacity = 255;
            this.TopPanel.BorderRadiusSize = 15;
            this.TopPanel.BorderShape = KimTools.WinForms.KtSize.Default;
            this.TopPanel.BorderSize = KimTools.WinForms.KtSize.Default;
            this.TopPanel.BorderThickness = 1;
            this.TopPanel.Controls.Add(this.panel4);
            this.TopPanel.Controls.Add(this.panel3);
            this.TopPanel.CustomColors = new System.Drawing.Color[0];
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(66)))));
            this.TopPanel.Location = new System.Drawing.Point(247, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.ShowBorders = true;
            this.TopPanel.Size = new System.Drawing.Size(1018, 63);
            this.TopPanel.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ktPictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(911, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(107, 63);
            this.panel4.TabIndex = 3;
            // 
            // ktPictureBox1
            // 
            this.ktPictureBox1.AllowFocused = false;
            this.ktPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ktPictureBox1.AutoSizeHeight = true;
            this.ktPictureBox1.BorderRadius = 22;
            this.ktPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("ktPictureBox1.Image")));
            this.ktPictureBox1.IsCircle = true;
            this.ktPictureBox1.Location = new System.Drawing.Point(37, 8);
            this.ktPictureBox1.Name = "ktPictureBox1";
            this.ktPictureBox1.Size = new System.Drawing.Size(44, 44);
            this.ktPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ktPictureBox1.TabIndex = 2;
            this.ktPictureBox1.TabStop = false;
            this.ktPictureBox1.Type = KimTools.WinForms.KtPictureBox.Types.Circle;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblWelcome);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(169, 63);
            this.panel3.TabIndex = 1;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(60)))), ((int)(((byte)(81)))));
            this.lblWelcome.KtFontSize = KimTools.WinForms.KtFont.H3;
            this.lblWelcome.Location = new System.Drawing.Point(22, 21);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Shade = KimTools.WinForms.KtShade.Light_10;
            this.lblWelcome.Size = new System.Drawing.Size(120, 32);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Wellcome";
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(216)))));
            this.LeftPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(216)))));
            this.LeftPanel.BgOpacity = 255;
            this.LeftPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(193)))), ((int)(((byte)(201)))));
            this.LeftPanel.BorderOpacity = 255;
            this.LeftPanel.BorderRadiusSize = 15;
            this.LeftPanel.BorderShape = KimTools.WinForms.KtSize.Default;
            this.LeftPanel.BorderSize = KimTools.WinForms.KtSize.Default;
            this.LeftPanel.BorderThickness = 1;
            this.LeftPanel.Controls.Add(this.panel2);
            this.LeftPanel.Controls.Add(this.panel1);
            this.LeftPanel.Controls.Add(this.LogoPanel);
            this.LeftPanel.CustomColors = new System.Drawing.Color[0];
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(66)))));
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.ShowBorders = true;
            this.LeftPanel.Size = new System.Drawing.Size(247, 715);
            this.LeftPanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ktButton6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 637);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 78);
            this.panel2.TabIndex = 4;
            // 
            // ktButton6
            // 
            this.ktButton6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ktButton6.BackColor = System.Drawing.Color.Empty;
            this.ktButton6.Bg = KimTools.WinForms.KtColor.None;
            this.ktButton6.BorderShape = KimTools.WinForms.KtSize.Default;
            this.ktButton6.BorderSize = KimTools.WinForms.KtSize.Default;
            this.ktButton6.CustomColors = new System.Drawing.Color[0];
            this.ktButton6.FlatAppearance.BorderSize = 0;
            this.ktButton6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ktButton6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ktButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ktButton6.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktButton6.ForeColor = System.Drawing.Color.Black;
            this.ktButton6.IconName = "Tabler.outline.settings";
            this.ktButton6.IconSize = 22;
            this.ktButton6.IconStroke = 2D;
            this.ktButton6.LabelShade = KimTools.WinForms.KtShade.Light_60;
            this.ktButton6.Location = new System.Drawing.Point(9, 3);
            this.ktButton6.Name = "ktButton6";
            this.ktButton6.Size = new System.Drawing.Size(232, 67);
            this.ktButton6.Style = KimTools.WinForms.KtStyle.Ghost;
            this.ktButton6.TabIndex = 3;
            this.ktButton6.Text = "Setting        ";
            this.ktButton6.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.btnUser);
            this.panel1.Controls.Add(this.btnGenres);
            this.panel1.Controls.Add(this.btnOrder);
            this.panel1.Controls.Add(this.btnBook);
            this.panel1.Location = new System.Drawing.Point(0, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 511);
            this.panel1.TabIndex = 3;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDashboard.BackColor = System.Drawing.Color.Empty;
            this.btnDashboard.Bg = KimTools.WinForms.KtColor.None;
            this.btnDashboard.BorderShape = KimTools.WinForms.KtSize.Default;
            this.btnDashboard.BorderSize = KimTools.WinForms.KtSize.Default;
            this.btnDashboard.CustomColors = new System.Drawing.Color[0];
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.IconName = "Tabler.outline.layout_dashboard";
            this.btnDashboard.IconSize = 22;
            this.btnDashboard.IconStroke = 2D;
            this.btnDashboard.LabelShade = KimTools.WinForms.KtShade.Light_60;
            this.btnDashboard.Location = new System.Drawing.Point(12, 9);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(232, 67);
            this.btnDashboard.Style = KimTools.WinForms.KtStyle.Ghost;
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard  ";
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnUser
            // 
            this.btnUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUser.BackColor = System.Drawing.Color.Empty;
            this.btnUser.Bg = KimTools.WinForms.KtColor.None;
            this.btnUser.BorderShape = KimTools.WinForms.KtSize.Default;
            this.btnUser.BorderSize = KimTools.WinForms.KtSize.Default;
            this.btnUser.CustomColors = new System.Drawing.Color[0];
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.Black;
            this.btnUser.IconName = "Tabler.outline.users_group";
            this.btnUser.IconSize = 22;
            this.btnUser.IconStroke = 2D;
            this.btnUser.LabelShade = KimTools.WinForms.KtShade.Light_60;
            this.btnUser.Location = new System.Drawing.Point(12, 312);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(232, 67);
            this.btnUser.Style = KimTools.WinForms.KtStyle.Ghost;
            this.btnUser.TabIndex = 2;
            this.btnUser.Text = "User            ";
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnGenres
            // 
            this.btnGenres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGenres.BackColor = System.Drawing.Color.Empty;
            this.btnGenres.Bg = KimTools.WinForms.KtColor.None;
            this.btnGenres.BorderShape = KimTools.WinForms.KtSize.Default;
            this.btnGenres.BorderSize = KimTools.WinForms.KtSize.Default;
            this.btnGenres.CustomColors = new System.Drawing.Color[0];
            this.btnGenres.FlatAppearance.BorderSize = 0;
            this.btnGenres.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGenres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGenres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenres.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenres.ForeColor = System.Drawing.Color.Black;
            this.btnGenres.IconName = "Tabler.outline.category";
            this.btnGenres.IconSize = 22;
            this.btnGenres.IconStroke = 2D;
            this.btnGenres.LabelShade = KimTools.WinForms.KtShade.Light_60;
            this.btnGenres.Location = new System.Drawing.Point(12, 239);
            this.btnGenres.Name = "btnGenres";
            this.btnGenres.Size = new System.Drawing.Size(232, 67);
            this.btnGenres.Style = KimTools.WinForms.KtStyle.Ghost;
            this.btnGenres.TabIndex = 2;
            this.btnGenres.Text = "Genres         ";
            this.btnGenres.UseVisualStyleBackColor = false;
            this.btnGenres.Click += new System.EventHandler(this.btnGenres_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOrder.BackColor = System.Drawing.Color.Empty;
            this.btnOrder.Bg = KimTools.WinForms.KtColor.None;
            this.btnOrder.BorderShape = KimTools.WinForms.KtSize.Default;
            this.btnOrder.BorderSize = KimTools.WinForms.KtSize.Default;
            this.btnOrder.CustomColors = new System.Drawing.Color[0];
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.Black;
            this.btnOrder.IconName = "Tabler.outline.http_post";
            this.btnOrder.IconSize = 22;
            this.btnOrder.IconStroke = 2D;
            this.btnOrder.LabelShade = KimTools.WinForms.KtShade.Light_60;
            this.btnOrder.Location = new System.Drawing.Point(12, 82);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(232, 67);
            this.btnOrder.Style = KimTools.WinForms.KtStyle.Ghost;
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "Order         ";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnPH_Click);
            // 
            // btnBook
            // 
            this.btnBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBook.BackColor = System.Drawing.Color.Empty;
            this.btnBook.Bg = KimTools.WinForms.KtColor.None;
            this.btnBook.BorderShape = KimTools.WinForms.KtSize.Default;
            this.btnBook.BorderSize = KimTools.WinForms.KtSize.Default;
            this.btnBook.CustomColors = new System.Drawing.Color[0];
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.Color.Black;
            this.btnBook.IconName = "Tabler.outline.book";
            this.btnBook.IconSize = 22;
            this.btnBook.IconStroke = 2D;
            this.btnBook.LabelShade = KimTools.WinForms.KtShade.Light_60;
            this.btnBook.Location = new System.Drawing.Point(12, 155);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(232, 67);
            this.btnBook.Style = KimTools.WinForms.KtStyle.Ghost;
            this.btnBook.TabIndex = 2;
            this.btnBook.Text = "Book          ";
            this.btnBook.UseVisualStyleBackColor = false;
            // 
            // LogoPanel
            // 
            this.LogoPanel.Controls.Add(this.pictureBox1);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(247, 104);
            this.LogoPanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BookStore.Properties.Resources.book;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CenterPanel
            // 
            this.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPanel.Location = new System.Drawing.Point(247, 63);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(1018, 652);
            this.CenterPanel.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 715);
            this.Controls.Add(this.CenterPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.LeftPanel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(66)))));
            this.Name = "FrmMain";
            this.Opacity = 1D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Store";
            this.Theme = this.MainFrmThemes;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.TopPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ktPictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.LeftPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private KimTools.WinForms.KtTheme MainFrmThemes;
        private KimTools.WinForms.KtPanel LeftPanel;
        private KimTools.WinForms.KtPanel TopPanel;
        private System.Windows.Forms.Panel LogoPanel;
        private KimTools.WinForms.KtButton btnBook;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private KimTools.WinForms.KtButton btnDashboard;
        private KimTools.WinForms.KtButton btnUser;
        private KimTools.WinForms.KtButton btnGenres;
        private KimTools.WinForms.KtButton btnOrder;
        private KimTools.WinForms.KtButton ktButton6;
        private System.Windows.Forms.Panel panel2;
        private KimTools.WinForms.KtLabel lblWelcome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private KimTools.WinForms.KtPictureBox ktPictureBox1;
        private System.Windows.Forms.Panel CenterPanel;
    }
}
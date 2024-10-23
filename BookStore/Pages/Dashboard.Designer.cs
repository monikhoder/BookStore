namespace BookStore.Pages
{
    partial class Dashboard
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
            this.ktLabel1 = new KimTools.WinForms.KtLabel();
            this.SuspendLayout();
            // 
            // ktLabel1
            // 
            this.ktLabel1.AutoSize = true;
            this.ktLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ktLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(66)))));
            this.ktLabel1.KtFontSize = KimTools.WinForms.KtFont.Default;
            this.ktLabel1.Location = new System.Drawing.Point(346, 278);
            this.ktLabel1.Name = "ktLabel1";
            this.ktLabel1.Size = new System.Drawing.Size(149, 25);
            this.ktLabel1.TabIndex = 0;
            this.ktLabel1.Text = "Dashboard Form";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 540);
            this.Controls.Add(this.ktLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KimTools.WinForms.KtLabel ktLabel1;
    }
}
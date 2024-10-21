namespace BookStore.Component
{
    partial class DeleteDialog
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
            this.lblQ = new System.Windows.Forms.Label();
            this.btnyes = new KimTools.WinForms.KtButton();
            this.btnNo = new KimTools.WinForms.KtButton();
            this.SuspendLayout();
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ.ForeColor = System.Drawing.Color.Red;
            this.lblQ.Location = new System.Drawing.Point(44, 18);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(329, 28);
            this.lblQ.TabIndex = 0;
            this.lblQ.Text = "Are you want to delete this item?";
            // 
            // btnyes
            // 
            this.btnyes.BackColor = System.Drawing.Color.Empty;
            this.btnyes.BorderShape = KimTools.WinForms.KtSize.Default;
            this.btnyes.BorderSize = KimTools.WinForms.KtSize.Default;
            this.btnyes.CustomColors = new System.Drawing.Color[0];
            this.btnyes.FlatAppearance.BorderSize = 0;
            this.btnyes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnyes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnyes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnyes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnyes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnyes.IconName = "";
            this.btnyes.IconSize = 16;
            this.btnyes.IconStroke = 2.5D;
            this.btnyes.Location = new System.Drawing.Point(282, 90);
            this.btnyes.Name = "btnyes";
            this.btnyes.Size = new System.Drawing.Size(120, 48);
            this.btnyes.Style = KimTools.WinForms.KtStyle.Tailwind;
            this.btnyes.TabIndex = 1;
            this.btnyes.Text = "YES";
            this.btnyes.UseVisualStyleBackColor = false;
            this.btnyes.Click += new System.EventHandler(this.btnyes_Click);
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.Red;
            this.btnNo.Bg = KimTools.WinForms.KtColor.BackColor;
            this.btnNo.BorderShape = KimTools.WinForms.KtSize.Default;
            this.btnNo.BorderSize = KimTools.WinForms.KtSize.Default;
            this.btnNo.CustomColors = new System.Drawing.Color[0];
            this.btnNo.FlatAppearance.BorderSize = 0;
            this.btnNo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.Color.White;
            this.btnNo.IconName = "";
            this.btnNo.IconSize = 16;
            this.btnNo.IconStroke = 2.5D;
            this.btnNo.Location = new System.Drawing.Point(49, 90);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(120, 48);
            this.btnNo.Style = KimTools.WinForms.KtStyle.Tailwind;
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "NO";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.ktButton1_Click);
            // 
            // DeleteDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(22)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(425, 163);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnyes);
            this.Controls.Add(this.lblQ);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteDialog";
            this.Opacity = 1D;
            this.Role = KimTools.WinForms.KtColor.BackColor;
            this.Text = "DeleteDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private KimTools.WinForms.KtButton btnyes;
        private KimTools.WinForms.KtButton btnNo;
        public System.Windows.Forms.Label lblQ;
    }
}
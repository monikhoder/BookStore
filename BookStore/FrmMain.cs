using KimTools.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class FrmMain : KtWindow
    {
        public static string Username;
        public static bool Islogin = false;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (Islogin)
            {
                lblWelcome.Text = $"Welcome {Username}";
                AddControls(new View.FrmGenresView());
            }
            else
            {
                FrmLogin frmLogin = new FrmLogin();
                if (frmLogin.ShowDialog() == DialogResult.OK) // Show as modal
                {
                    lblWelcome.Text = $"Welcome {Username}";
                    AddControls(new View.FrmGenresView());
                }
                else
                {
                    this.Close();
                }
            }
        }
        private void AddControls(Form form)
        {
            CenterPanel.Controls.Clear();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            CenterPanel.Controls.Add(form);
            form.Show();
        }
    }
}

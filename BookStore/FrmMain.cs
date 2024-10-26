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
        CRUD db = new CRUD();
        public static string Username = "XXX";
        public static bool Islogin = false;
        public static int UserId = 0;
        private string Role = "XXX";
        private string Name = "XXX";
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (Islogin)
            {
                lblWelcome.Text = $"Dashboard";
                AddControls(new Pages.Dashboard());
            }
            else
            {
                FrmLogin frmLogin = new FrmLogin();
                if (frmLogin.ShowDialog() == DialogResult.OK) 
                {
                    
                    lblWelcome.Text = $"Dashboard";
                    AddControls(new Pages.Dashboard());
                    lblUser.Text = db.GetName(UserId);
                    Role = db.GetUserRole(UserId);
                    if (Role != "Admin" && Role != "Management") { btnUser.Visible = false; }
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

        private void btnGenres_Click(object sender, EventArgs e)
        {
            AddControls(new Pages.FrmGenresView());
        }

        private void btnPH_Click(object sender, EventArgs e)
        {
            AddControls(new Pages.FrmOrder());
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            AddControls(new Pages.FrmUsersView());
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            AddControls(new Pages.FrmBooksView());
        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            AddControls(new Pages.FrmAuthorView());
        }

        private void btnPublisher_Click(object sender, EventArgs e)
        {
            AddControls(new Pages.FrmPublisherView());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            AddControls(new Pages.Dashboard());
        }
    }
}

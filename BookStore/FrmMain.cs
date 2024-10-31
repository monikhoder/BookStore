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
        public static int UserId;
        private string Role = "XXX";
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Dashboard";
            AddControls(new Pages.Dashboard());
            lblUser.Text = db.GetName(UserId);
            Role = db.GetUserRole(UserId);
            if (Role != "Admin" && Role != "Management") { btnUser.Visible = false; }
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
            lblWelcome.Text = "Genres";
        }
       

        private void btnPH_Click(object sender, EventArgs e)
        {
            AddControls(new Pages.FrmOrder());
            lblWelcome.Text = "Order";
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            AddControls(new Pages.FrmUsersView());
            lblWelcome.Text = "Users";
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            AddControls(new Pages.FrmBooksView());
            lblWelcome.Text = "Books";
        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            AddControls(new Pages.FrmAuthorView());
            lblWelcome.Text = "Authors";
        }

        private void btnPublisher_Click(object sender, EventArgs e)
        {
            AddControls(new Pages.FrmPublisherView());
            lblWelcome.Text = "Publishers";
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            AddControls(new Pages.Dashboard());
            lblWelcome.Text = "Dashboard";
        }
    }
}

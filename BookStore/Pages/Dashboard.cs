using KimTools.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Pages
{
    public partial class Dashboard : Form
    {
        CRUD db = new CRUD();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            loadCount();
            loadnewbook();
        }
        private void loadCount()
        {
            lblBookCount.Text = db.GetBookCount().ToString();
            lblAuthorCount.Text = db.GetAuthorCount().ToString();
            lblGenresCount.Text = db.GetGenreCount().ToString();
            lblUser.Text = db.GetUserCount().ToString();
        }

        private void ktDivider2_Click(object sender, EventArgs e)
        {

        }
        private void loadnewbook()
        {
            tblnewbook.Clear();
            int count = 0;
            var dtbook = db.GetnewBookRelease();
            foreach (var item in dtbook)
            {               
                var tbl = tblnewbook.NewRow();
                tbl["tblNo"] = ++count;
                tbl["tblTitle"] = item.Name;
                tbl["tblAuthor"] = db.GetAuthorName(item.AuthorID);
                tbl["tblDateRelease"] = item.PublishingDate.ToShortDateString();
            }
        }
        private void loadbestseller()
        {
            tblbestSeller.Clear();
            int count = 0;
            var dtsale = db.GetbestSeller();
            foreach (var item in dtsale)
            {
                var tbl = tblbestSeller.NewRow();
                tbl["tblNo"] = ++count;
                tbl["tblName"] = db.GetUserName(item.UserId);
                tbl["tblAmount"] = $"{item.TotalSalesAmount} $";         
            }
        }

        private void btnNewBook_Click(object sender, EventArgs e)
        {
            loadnewbook();
            DasboardPage.SetPage(newbook);
        }

        private void ktButton1_Click(object sender, EventArgs e)
        {
            DasboardPage.SetPage(bestseller);
            loadbestseller();
        }
    }
}

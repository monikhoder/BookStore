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
        private void loadpopularAuthor()
        {
            tblAuthor.Clear();
            int count = 0;
            var dtauthor = db.GetPopularAuthors();
            foreach (var item in dtauthor)
            {
                var tbl = tblAuthor.NewRow();
                tbl["tblNo"] = ++count;
                tbl["tblName"] = db.GetAuthorName(item.AuthorId);
                tbl["tbltotalSale"] = item.TotalQuantitySold;
            }
        }
        private void loadpopularGenres()
        {
            tblGenres.Clear();
            int count = 0;
            var dtGenre = db.GetPopularGenres();
            foreach (var item in dtGenre)
            {
                var tbl = tblGenres.NewRow();
                tbl["No"] = ++count;
                tbl["tblName"] = db.GetGenreName(item.GenreId);
                tbl["tblTotal"] = item.TotalQuantitySold;
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

        private void btnPopularAuthor_Click(object sender, EventArgs e)
        {
            DasboardPage.SetPage(popularAuthor);
            loadpopularAuthor();
        }

        private void btnPopularGenres_Click(object sender, EventArgs e)
        {
            DasboardPage.SetPage(popularGenre);
            loadpopularGenres();
        }
    }
}

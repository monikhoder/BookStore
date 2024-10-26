using BookStore.Dialogs;
using KimTools.WinForms;
using System;
using System.Collections;
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
    public partial class FrmBooksView : KtWindow
    {

        private int Id = 0;
        private string BookTitle = string.Empty;
        CRUD db = new CRUD();
        public FrmBooksView()
        {
            InitializeComponent();
        }
        private void txtSearch_TextChange(object sender, EventArgs e)
        {
            Loadbooks();
        }
        private void Loadbooks()
        {
            tblBook.Clear();
            var dtbooks = db.GetBooks(txtSearch.Text);
            foreach (var book in dtbooks)
            {
                string sequal = "NO";
                if (book.IsSequel == true)
                { 
                    sequal = "YES";
                }
                var books = tblBook.NewRow();
                books["tblID"] = book.BookID;
                books["tblTitle"] = book.Name;
                books["tblGenre"] = db.GetGenreName(book.GenreID);
                books["tblAuthor"] = db.GetAuthorName(book.AuthorID);
                books["tblPublisher"] = db.GetPublisherName(book.PublisherID);
                books["tblPage"] = book.Pages;
                books["tblPublishingDate"] = book.PublishingDate.ToShortDateString();
                books["tblCostPrice"] = book.CostPrice;
                books["tblSalePrice"] = book.SalePrice;
                books["tblIsSequel"] = sequal;
                books["tblStock"] = book.Stock;
            }
            btnenable();
        }
        private void btnenable()
        {
            if (db.GetBookCount() == 0)
            {
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
            }
            

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           AddBook addBook = new AddBook();
            addBook.StartPosition = FormStartPosition.CenterScreen;
            addBook.ShowDialog();
            Loadbooks();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteDialog deleteDialog = new DeleteDialog();
            deleteDialog.lblQ.Text = $"Are you sure you want to delete {BookTitle} from book list?";
            deleteDialog.ShowDialog();
            if (deleteDialog.DialogResult == DialogResult.OK)
            {
                db.DeleteBook(Id);
                Loadbooks();
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var dtbook = db.GetBookById(Id);
            UpdateBook eb = new UpdateBook();
            foreach (var book in dtbook)
            {
                eb.txbId.Text = Id.ToString();
                 eb.txtTitle.Text = book.Name;
                eb.cmbGenre.Text = db.GetGenreName(book.GenreID);
                eb.cmbAuthor.Text = db.GetAuthorName(book.AuthorID);
                eb.cmbPublisher.Text = db.GetPublisherName(book.PublisherID);
                eb.txbPages.Text = book.Pages.ToString();
                eb.PublishingDatePicker.Value = book.PublishingDate;
                eb.txbCostPrice.Text = book.CostPrice.ToString();
                eb.txbSalePrice.Text = book.SalePrice.ToString();
                eb.IsSequelSwith.Checked = book.IsSequel;
                eb.txbStock.Text = book.Stock.ToString();
                eb.StartPosition = FormStartPosition.CenterScreen;
                eb.ShowDialog();
                Loadbooks();
            }
        }

        private void tblBook_CellClick(KtTable table, KtTableRow row, KtTableColumn column)
        {
            Id = Convert.ToInt32(row["tblID"]);
            BookTitle = row["tblTitle"].ToString();
            btnenable();
        }

        private void tblBook_RowSelected(KtTable table, KtTableRow row)
        {
            if (row != null)
            {
                Id = Convert.ToInt32(row["tblID"]);
                BookTitle = row["tblTitle"].ToString();
            }
            else
            {
                Id = db.GetBookFirstID();
                BookTitle = db.GetBookTitleById(Id);

            }           
        }

        private void FrmBooksView_Load(object sender, EventArgs e)
        {
            Loadbooks();
            btnenable();
        }
    }
}

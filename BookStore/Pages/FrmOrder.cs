using BookStore.Dialogs;
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
    public partial class FrmOrder : KtWindow
    {
        CRUD db = new CRUD();
        private int Id = 0;
        private string BookTitle = string.Empty;
        
        public FrmOrder()
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
               var books = tblBook.NewRow();
                books["tblId"] = book.BookID;
                books["tblTitle"] = book.Name;
                books["tblPrice"] = $"{book.SalePrice} $";
                books["tblStock"] = book.Stock;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


        }

        private void FrmOrder_Load(object sender, EventArgs e)
        {
            Loadbooks();
        }

        private void tblBook_CellClick(KtTable table, KtTableRow row, KtTableColumn column)
        {
            Id = Convert.ToInt32(row["tblId"]);
            BookTitle = row["tblTitle"].ToString();
            LoadBookDetail();
        }

        private void tblBook_RowSelected(KtTable table, KtTableRow row)
        {
            if (row != null)
            {
                Id = Convert.ToInt32(row["tblId"]);
                BookTitle = row["tblTitle"].ToString();
            }
            else
            {
                Id = db.GetBookFirstID();
                BookTitle = db.GetBookTitleById(Id);
               
            }
            LoadBookDetail();

        }
        private void LoadBookDetail()
        {
            lblTitle.Text = $"Title : {BookTitle}";
            lblPrice.Text = $"Price : {db.GetBookPriceByID(Id)} $";
            byte[] imageData = db.GetBookCoverById(Id);

            if (imageData != null)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    BookCover.Image = Image.FromStream(ms);
                }
            }
            else
            {
                BookCover.Image=null;
            }
        }

        private void txbDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys like Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Allow only numbers from 0 to 100
            TextBox textBox = sender as TextBox;

            // If the input is not a control key and the current input would result in a number greater than 100
            if (!char.IsControl(e.KeyChar))
            {
                string newValue = textBox.Text.Insert(textBox.SelectionStart, e.KeyChar.ToString());
                int enteredValue;

                // If the resulting value is more than 100, block it
                if (int.TryParse(newValue, out enteredValue) && (enteredValue < 0 || enteredValue > 100))
                {
                    e.Handled = true;
                }
            }

        }

        private void txbDiscount_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txbDiscount.Text))
            {
                txbDiscount.Text = "0";
            }
        }
    }
}

using BookStore.Dialogs;
using ExCSS;
using KimTools.WinForms;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;


namespace BookStore.Pages
{
    public partial class FrmOrder : KtWindow
    {
        CRUD db = new CRUD();
        private int BookId = 0;
        private string BookTitle = string.Empty;
        List<AddtoOrder> card = new List<AddtoOrder>();
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
            if (card.Count > 0) {
                int saleid = 1000;
                decimal price = GetTotalPrice();
                if (db.GetLastSaleId() != null && db.GetLastSaleId() > 0)
                {
                    saleid = db.GetLastSaleId() + 1;
                }
                db.AddSale(saleid, FrmMain.UserId, price);
                foreach (var item in card)
                {
                    db.AddSaleDetail(saleid, item.bookId, item.quantity, item.discountPercent, item.unitprice,item.totalprice);
                }
            }
            card.Clear();
            tblOrder.Clear();
            Loadbooks();
        }

        private void FrmOrder_Load(object sender, EventArgs e)
        {
            Loadbooks();
            NewOrderbtnEnable();
            btnAddToCardEnable();
        }

        private void tblBook_CellClick(KtTable table, KtTableRow row, KtTableColumn column)
        {
            BookId = Convert.ToInt32(row["tblId"]);
            BookTitle = row["tblTitle"].ToString();
            LoadBookDetail();
            btnAddToCardEnable();
        }

        private void tblBook_RowSelected(KtTable table, KtTableRow row)
        {
            if (row != null)
            {
                BookId = Convert.ToInt32(row["tblId"]);
                BookTitle = row["tblTitle"].ToString();
            }
            else
            {
                BookId = db.GetBookFirstID();
                BookTitle = db.GetBookTitleById(BookId);               
            }
            
            LoadBookDetail();
            btnAddToCardEnable();
        }
        private void LoadBookDetail()
        {
            lblTitle.Text = BookTitle;
            lblPrice.Text = db.GetBookPriceByID(BookId).ToString();
            byte[] imageData = db.GetBookCoverById(BookId);

            if (imageData != null)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        if (BookCover.Image != null)
                        {
                            BookCover.Image.Dispose();
                        }
                        BookCover.Image = System.Drawing.Image.FromStream(ms);
                    }
                }
                catch (Exception ex)
                {
                    BookCover.Image = BookCover.ErrorImage;
                }
            }
            else
            {
                BookCover.Image = null;
            }
          
        }

        private void txbDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsDigit(e.KeyChar))
            {
                string newText = txbDiscount.Text + e.KeyChar;
                if (int.TryParse(newText, out int result) && result > 100)
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

        private void txbQuntity_IconRightClick(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txbQuntity.Text);
            int stock = db.GetBookStockById(BookId);
            num++;
            if (stock > 0 && num <= stock) { txbQuntity.Text = num.ToString(); }
        }

        private void txbQuntity_IconLeftClick(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txbQuntity.Text);
            if (num <= 1) { } else { num--; txbQuntity.Text = num.ToString(); }

        }

        private void txbQuntity_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbQuntity.Text)) { txbQuntity.Text = "1"; }
            int num = Convert.ToInt32(txbQuntity.Text);
            int stock = db.GetBookStockById(BookId);
            if (num > stock) { txbQuntity.Text = stock.ToString(); }
        }

        private void btnAddtoCard_Click(object sender, EventArgs e)
        {
            addtocard();
            db.BookStockDecrease(BookId, Convert.ToInt32(txbQuntity.Text));
            btnAddToCardEnable();
            Loadbooks();
        }
        private void addtocard()
        {
            string total = GetTotalPriceAfterDiscount(lblPrice.Text, txbDiscount.Text, txbQuntity.Text);
            card.Add(new AddtoOrder
            {
                bookId = BookId,
                discountPercent = Convert.ToDecimal(txbDiscount.Text),
                quantity = Convert.ToInt32(txbQuntity.Text),
                unitprice = Convert.ToDecimal(lblPrice.Text),
                totalprice = Convert.ToDecimal(total)
            });

            var books = tblOrder.NewRow();
            books["tblTitle"] = lblTitle.Text;
            books["tblUnitPrice"] = $"{lblPrice.Text} $";
            books["tblDiscountPercent"] = $"{txbDiscount.Text} %";
            books["tblQTY"] = txbQuntity.Text;
            books["tblTotal"] = $"{total} $";

        }
        public string GetTotalPriceAfterDiscount(string originalPriceStr, string discountPercentageStr, string quantityStr)
        {
            if (!decimal.TryParse(originalPriceStr, out decimal originalPrice))
            {
                return "Invalid original price format";
            }
            if (!decimal.TryParse(discountPercentageStr, out decimal discountPercentage))
            {
                return "Invalid discount percentage format";
            }
            if (!int.TryParse(quantityStr, out int quantity))
            {
                return "Invalid quantity format";
            }
            decimal discountedPrice = originalPrice * (1 - discountPercentage / 100);
            decimal totalPrice = discountedPrice * quantity;
            return totalPrice.ToString("F2");
        }
        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
        private void btnAddToCardEnable()
        {
            if (db.GetBookCount() == 0) { btnAddtoCard.Enabled = false; }
            if (db.GetBookStockById(BookId) <= 0) { btnAddtoCard.Enabled = false; } else { btnAddtoCard.Enabled = true; }
            foreach (var item in card)
            {
                if (item.bookId == BookId) { btnAddtoCard.Enabled = false; }
            }
        }
        private decimal GetTotalPrice()
        {
            decimal totalPrice = 0;
           foreach(var item in card)
            {
                totalPrice += item.totalprice;
            }
            return totalPrice;
        }

        private void tblOrder_RowUpdated(KtTable table, KtTableRow row)
        {
            lblTotalPrice.Text = $"Total Price : {GetTotalPrice()} $";
            NewOrderbtnEnable();
        }

        private void txbQuntity_KeyPress(object sender, KeyPressEventArgs e)
        {
            int stock = db.GetBookStockById(BookId);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            else if (char.IsDigit(e.KeyChar))
            {
                string newText = txbQuntity.Text + e.KeyChar;
                if (int.TryParse(newText, out int result) && result > stock)
                {
                    e.Handled = true; 
                }
            }
        }
        private void NewOrderbtnEnable()
        {
            if (card.Count > 0) { btnAdd.Enabled = true; btnCancel.Enabled = true; } else { btnAdd.Enabled = false; btnCancel.Enabled = false; }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancelOrder();           
            tblOrder.Clear();
            lblTotalPrice.Text = "Total Price: 00.00 $";
            btnAddToCardEnable();
            NewOrderbtnEnable();
            Loadbooks();
        }
        private void cancelOrder()
        {
            foreach (var item in card)
            {
                db.BookStockIncrease(item.bookId, item.quantity);
            }
            card.Clear();
        }

        private void FrmOrder_Leave(object sender, EventArgs e)
        {
            cancelOrder();

        }
    }
    public class AddtoOrder
    {
        public int bookId { get; set; }
        public decimal discountPercent { get; set; }
        public int quantity { get; set; }
        public decimal unitprice { get; set; }
        public decimal totalprice { get; set; }
    }
}

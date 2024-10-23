using BookStore.Component;
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

namespace BookStore.Pages
{
    public partial class FrmBooksView : KtWindow
    {

        private int Id = 0;
        private string UName = string.Empty;
        private string URole = string.Empty;
        CRUD db = new CRUD();
        public FrmBooksView()
        {
            InitializeComponent();
        }
      

        private void txtSearch_TextChange(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           AddBook addBook = new AddBook();
            addBook.StartPosition = FormStartPosition.CenterScreen;
            addBook.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
           
        }

        private void tblBook_CellClick(KtTable table, KtTableRow row, KtTableColumn column)
        {

        }

        private void tblBook_RowSelected(KtTable table, KtTableRow row)
        {

        }

        private void FrmBooksView_Load(object sender, EventArgs e)
        {

        }
    }
}

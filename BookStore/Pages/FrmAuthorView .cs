using BookStore.Dialogs;
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
    public partial class FrmAuthorView : KtWindow
    {

        private int Id = 0;
        private string AuthorName = string.Empty;
        CRUD db = new CRUD();
        public FrmAuthorView()
        {
            InitializeComponent();
        }
        private void txtSearch_TextChange(object sender, EventArgs e)
        {
            LoadAuthors();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddAuthor addauthor = new AddAuthor();
            addauthor.StartPosition = FormStartPosition.CenterScreen;
            addauthor.ShowDialog();
            LoadAuthors();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteDialog deleteDialog = new DeleteDialog();
            deleteDialog.lblQ.Text = $"Are you sure you want to delete {AuthorName} from Author?";
            deleteDialog.ShowDialog();
            if (deleteDialog.DialogResult == DialogResult.OK)
            {

                db.DeleteAuthor(Id);
                LoadAuthors();
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdateAuthor updateauthor = new UpdateAuthor();
            updateauthor.txtId.Text = Id.ToString();
            updateauthor.txtName.Text = AuthorName.ToString();
            updateauthor.StartPosition = FormStartPosition.CenterParent;
            updateauthor.ShowDialog();
            LoadAuthors();

        }

        private void tblAuthor_RowSelected(KtTable table, KtTableRow row)
        {
            if (row != null)
            {
                Id = Convert.ToInt32(row["tblId"]);
                AuthorName = row["tblName"].ToString();
            }
            else
            {
                Id = db.GetAuthorFirstID();
                AuthorName = db.GetAuthorName(Id);
            }

        }

        private void tblAuthor_CellClick(KtTable table, KtTableRow row, KtTableColumn column)
        {
            if (row != null)
            {
                Id = Convert.ToInt32(row["tblId"]);
                AuthorName = row["tblName"].ToString();
            }

        }

        private void FrmAuthorView_Load(object sender, EventArgs e)
        {
            LoadAuthors();
        }
        private void LoadAuthors()
        {
            tblAuthor.Clear();
            var dtAuthors = db.GetAuthors(txtSearch.Text);

            foreach (var author in dtAuthors)
            {
                var authors = tblAuthor.NewRow();
                authors["tblId"] = author.AuthorID;
                authors["tblName"] = author.FullName;
                authors["tblBook"] = db.GetBookCountByAuthorID(author.AuthorID);
                authors["tblCreated"] = author.Created;
                authors["tblUpdated"] = author.Updated;

                tblAuthor.Rows.Add(authors);
            }

       
            if (db.GetAuthorCount() == 0)
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


    }
}

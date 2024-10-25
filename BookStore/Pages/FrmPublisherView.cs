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
    public partial class FrmPublisherView : KtWindow
    {

        private int Id = 0;
        private string PublisherName = string.Empty;
        CRUD db = new CRUD();
        public FrmPublisherView()
        {
            InitializeComponent();
        }

        private void txtSearch_TextChange(object sender, EventArgs e)
        {
            LoadPublishers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPublisher addPublisher = new AddPublisher();
            addPublisher.StartPosition = FormStartPosition.CenterScreen;
            addPublisher.ShowDialog();
            LoadPublishers();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteDialog deleteDialog = new DeleteDialog();
            deleteDialog.lblQ.Text = $"Are you sure you want to delete {PublisherName} from Publisher?";
            deleteDialog.ShowDialog();
            if (deleteDialog.DialogResult == DialogResult.OK)
            {

                db.DeletePublisher(Id);
                LoadPublishers();
            }
        }



        private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdatePublisher updatepublisher = new UpdatePublisher();
            updatepublisher.txtId.Text = Id.ToString();
            updatepublisher.txtName.Text = PublisherName.ToString();
            updatepublisher.StartPosition = FormStartPosition.CenterParent;
            updatepublisher.ShowDialog();
            LoadPublishers();
        }

        private void FrmPublisherView_Load(object sender, EventArgs e)
        {
            LoadPublishers();
        }

        private void tblPublisher_RowSelected(KtTable table, KtTableRow row)
        {
            if (row != null)
            {
                Id = Convert.ToInt32(row["tblId"]);
                PublisherName = row["tblName"].ToString();
            }
            else
            {
                Id = db.GetPublisherFirstID();
                PublisherName = db.GetPublisherName(Id);
            }
        }

        private void tblPublisher_CellClick(KtTable table, KtTableRow row, KtTableColumn column)
        {

            if (row != null)
            {
                Id = Convert.ToInt32(row["tblId"]);
                PublisherName = row["tblName"].ToString();
            }

        }
        private void LoadPublishers()
        {
            tblPublisher.Clear();
            var dtPublishers = db.GetPublishers(txtSearch.Text);  // Fetch the publishers based on search input

            foreach (var publisher in dtPublishers)
            {
                var publishers = tblPublisher.NewRow();
                publishers["tblId"] = publisher.PublisherID;
                publishers["tblName"] = publisher.PublisherName;
                publishers["tblBook"] = db.GetBookCountByPublisherID(publisher.PublisherID);  // Get book count by publisher
                publishers["tblCreated"] = publisher.Created;
                publishers["tblUpdated"] = publisher.Updated;

                tblPublisher.Rows.Add(publishers);  // Add the row to the publisher table
            }

            // Enable or disable buttons based on the number of publishers
            if (db.GetPublisherCount() == 0)
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

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
    public partial class FrmUsersView : KtWindow
    {

        private int Id = 0;
        private string UName = string.Empty;
        private string URole = string.Empty;
        CRUD db = new CRUD();
        public FrmUsersView()
        {
            InitializeComponent();
        }

        private void FrmGenresView_Load(object sender, EventArgs e)
        {
            LoadUsers();
            
           
        }
        private void LoadUsers()
        {
            tblUser.Clear();
            var dtUser = db.GetUser(txtSearch.Text);

            foreach (var user in dtUser)
            {
                var Users = tblUser.NewRow();
                Users["tblID"] = user.UserID;
                Users["tblProfile"] = user.ProfilePicture;
                Users["tblName"] = user.UName;
                Users["tblRole"] = user.Role;
                Users["tblCreated"] = user.Created;
                Users["tblUpdated"] = user.Updated;
            }
            if (db.GetUserCount() == 0)
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

        private void txtSearch_TextChange(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           AddUser addUser = new AddUser();
            addUser.StartPosition = FormStartPosition.CenterParent;
           addUser.ShowDialog();
            LoadUsers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteDialog deleteDialog = new DeleteDialog();
            deleteDialog.lblQ.Text = $"Are you sure you want to delete {UName} from User list?";
            deleteDialog.ShowDialog();
            if (deleteDialog.DialogResult == DialogResult.OK)
            {

                db.DeleteUser(Id);
                LoadUsers();
            }
        }

        private void tblGenres_CellClick(KtTable table, KtTableRow row, KtTableColumn column)
        {
            Id = Convert.ToInt32(row["tblID"]);
            UName = row["tblName"].ToString();
        }

        private void tblGenres_RowSelected(KtTable table, KtTableRow row)
        {
            if (row != null)
            {
                Id = Convert.ToInt32(row["tblID"]);
                UName = row["tblName"].ToString();
            }
            else
            {
                Id = db.GetUserFirstID();
                UName = db.GetUserName(Id);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdateUser updateUser = new UpdateUser();
            updateUser.txtId.Text = Id.ToString();
            updateUser.txtName.Text = UName.ToString();
            updateUser.StartPosition = FormStartPosition.CenterParent;
            updateUser.ShowDialog();
        }

    }
}

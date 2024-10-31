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
    public partial class FrmLogin : KtWindow
    {
        CRUD db = new CRUD();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void ktTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ktTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            lblusername.Visible = false;
            lblPassword.Visible = false;
            lblLogin.Visible = false;
        }

        private void txtUsername_TextChange(object sender, EventArgs e)
        {
            lblusername.Visible = false;
            lblLogin.Visible = false;
        }

        private void txtPassword_TextChange(object sender, EventArgs e)
        {
            lblPassword.Visible = false;
            lblLogin.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtUsername.Text == null)
            {
                lblusername.Visible=true;
            }else if (txtPassword.Text == "" || txtPassword.Text == null)
            {
                lblPassword.Visible=true;
            }else
            {
                if(db.IsValidUser(txtUsername.Text,txtPassword.Text) == true)
                {
                    FrmMain.Username = txtUsername.Text;
                    FrmMain.UserId = db.GetUserID(txtUsername.Text);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    lblLogin.Visible = true;
                }
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnLogin_Click(sender, e);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
           this.Close();
        }
    }
}

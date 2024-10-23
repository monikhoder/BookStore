﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Component
{
    public partial class UpdateUser : Form
    {
        CRUD db = new CRUD();
        public UpdateUser()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddGenre_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void txtName_TextChange(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            db.EditUser(Convert.ToInt32(txtId.Text), txtName.Text, cmbRole.Text);
            this.Close();
        }

        private void lblAdd_Click(object sender, EventArgs e)
        {

        }
    }
}

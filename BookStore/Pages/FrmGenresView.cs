﻿using BookStore.Component;
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
    public partial class FrmGenresView : KtWindow
    {

        private int Id = 0;
        private string name = string.Empty;
        public FrmGenresView()
        {
            InitializeComponent();
        }

        private void FrmGenresView_Load(object sender, EventArgs e)
        {
            LoadGenres();
            
           
        }
        private void LoadGenres()
        {
            tblGenres.Clear();
            var dtGenres = MainClass.GetGenres(txtSearch.Text);

            foreach (var genre in dtGenres) {
                var genres = tblGenres.NewRow();
                genres["tblID"] = genre.GenreID;
                genres["tblName"] = genre.GenreName;
                genres["tblCreated"] = DateTime.Now.ToString();
                genres["tblUpdated"] = DateTime.Now.ToString();
            }
            if (MainClass.GetGenreCount() == 0)
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
            LoadGenres();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddGenre addGenre = new AddGenre();
            addGenre.StartPosition = FormStartPosition.CenterScreen;
            addGenre.ShowDialog();
            LoadGenres();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteDialog deleteDialog = new DeleteDialog();
            deleteDialog.lblQ.Text = "Are you sure you want to delete this genre?";
            deleteDialog.ShowDialog();
            if (deleteDialog.DialogResult == DialogResult.OK)
            {
                
                MainClass.DeleteGenre(Id);
                LoadGenres();
            }
        }

        private void tblGenres_CellClick(KtTable table, KtTableRow row, KtTableColumn column)
        {
            Id = Convert.ToInt32(row["tblID"]);
        }

        private void tblGenres_RowSelected(KtTable table, KtTableRow row)
        {
            if (row != null)
            {
                Id = Convert.ToInt32(row["tblID"]);
                
            }
            else
            {
                Id = MainClass.GetGenreFirstID();
            }
            
        }
    }
}

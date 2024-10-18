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
        }

        private void txtSearch_TextChange(object sender, EventArgs e)
        {
            LoadGenres();
        }
    }
}

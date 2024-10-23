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
    public partial class Dashboard : Form
    {
        CRUD db = new CRUD();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            byte[] imageData = db.GetBookCoverById(8);

            if (imageData != null)
            {
                // Convert the byte array to an image and display it
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    bookCover.Image = Image.FromStream(ms);
                }
            }
            else
            {
                MessageBox.Show("No image found for the given ID.");
            }



        }
    }
}

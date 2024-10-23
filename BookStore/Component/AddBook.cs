using System;
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
    public partial class AddBook : Form
    {
        CRUD db = new CRUD();
        public AddBook()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            enableBtnAdd();
            LoadAuthor();
            LoadPublisher();
            LoadGenres();
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void LoadAuthor()
        {
            cmbAuthor.Items.Clear();
            var authors = db.GetAuthors();
            foreach(var author in authors)
            {
                cmbAuthor.Items.Add(author.FullName);
            }
        }
        private void LoadPublisher()
        {
            cmbPublisher.Items.Clear();
            var pubs = db.GetPublishers();
            foreach (var pub in pubs)
            {
                cmbPublisher.Items.Add(pub.PublisherName);
            }
        }
        private void LoadGenres()
        {
            cmbGenre.Items.Clear();
            var gens = db.GetGenres();
            foreach (var gen in gens)
            {
                cmbGenre.Items.Add(gen.GenreName);
            }
        }

        private void BookCover_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                ofd.Title = "Select a Book Cover";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                   
                    LoadAndFixImageRotation(ofd.FileName);
                }
            }
        }
        public void LoadAndFixImageRotation(string filePath)
        {
            Image img = Image.FromFile(filePath);
            RotateImageIfRequired(img);
            BookCover.Image = img;
        }
        private void RotateImageIfRequired(Image img)
        {
            const int orientationPropertyId = 0x112;

            if (img.PropertyIdList.Contains(orientationPropertyId))
            {
                var prop = img.GetPropertyItem(orientationPropertyId);
                int orientationValue = BitConverter.ToUInt16(prop.Value, 0);

                switch (orientationValue)
                {
                    case 3:
                        // Rotate 180 degrees
                        img.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        break;
                    case 6:
                        // Rotate 90 degrees clockwise
                        img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        break;
                    case 8:
                        // Rotate 90 degrees counterclockwise
                        img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                        break;
                }
            }
        }
        private void enableBtnAdd()
        {
            bool isSelectCombo = false;
            bool isTextNotnull = false;

            if(txtStock.Text.Length > 0 && txtTitle.Text.Length > 0 && txbCostPrice.Text.Length > 0 && txbSalePrice.Text.Length > 0)
            {
                isTextNotnull = true;
            }
            if (cmbAuthor.SelectedIndex != -1 && cmbGenre.SelectedIndex != -1 && cmbPublisher.SelectedIndex != -1)
            {
                isSelectCombo = true;
            }
            if (isTextNotnull && isSelectCombo) {
                btnAdd.Enabled = true;
            }else
            {
                btnAdd.Enabled = false;
            }

        }

        private void txtTitle_TextChange(object sender, EventArgs e)
        {
            enableBtnAdd();
        }

        private void txtStock_TextChange(object sender, EventArgs e)
        {
            enableBtnAdd();
        }

        private void txbSalePrice_TextChange(object sender, EventArgs e)
        {
            enableBtnAdd();
        }

        private void txbCostPrice_TextChange(object sender, EventArgs e)
        {
            enableBtnAdd();
        }

        private void txbCostPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Ignore the key press
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txbSalePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Ignore the key press
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void cmbAuthor_SelectedValueChanged(object sender, EventArgs e)
        {
            enableBtnAdd();
        }

        private void cmbPublisher_SelectedIndexChanged(object sender, EventArgs e)
        {
            enableBtnAdd();
        }

        private void cmbGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            enableBtnAdd();
        }

        private void cmbAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            enableBtnAdd();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BookStore.Dialogs
{
    public partial class UpdateBook : Form
    {
        CRUD db = new CRUD();
        private string selectedImagePath;
        public UpdateBook()
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
            LoadBookCover();
        }
        private void LoadBookCover()
        {
            int Id = Convert.ToInt32(txbId.Text);
            byte[] imageData = db.GetBookCoverById(Id);

            if (imageData != null)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    BookCover.Image = Image.FromStream(ms);
                }
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
            selectedImagePath = filePath;
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
            if(txbStock.Text.Length > 0 && txtTitle.Text.Length > 0 && txbCostPrice.Text.Length > 0 && txbSalePrice.Text.Length > 0)
            {
                isTextNotnull = true;
            }
            if (cmbAuthor.Text != null && cmbGenre.Text != null && cmbPublisher.Text != null)
            {
                isSelectCombo = true;
            }

            if (isTextNotnull && isSelectCombo) {
                btnUpdate.Enabled = true;
            }else
            {
                btnUpdate.Enabled = false;
            }

        }

        private void TextBook_TextChange(object sender, EventArgs e)
        {
            enableBtnAdd();
        }

        private void txbCostPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
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
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
        public byte[] ConvertImageToByteArray(string imagePath)
        {
            byte[] imageBytes = null;
            using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    imageBytes = br.ReadBytes((int)fs.Length);
                }
            }
            return imageBytes;
        }

        private void IsSequelSwith_CheckedChanged(object sender, KimTools.WinForms.KtSwitch.CheckedChangedEventArgs e)
        {
           
        }

        private void Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmbBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            enableBtnAdd();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(txbId.Text);
            if (selectedImagePath != null)
            {
                db.ChangeBookCover(Id, ConvertImageToByteArray(selectedImagePath));
            }
            int genreID = db.GetGenreIdByName(cmbGenre.Text);
            int authorID = db.GetAuthorIdByName(cmbAuthor.Text);
            int publisherID = db.GetPublisherIdByName(cmbPublisher.Text);
            DateTime publishDate = PublishingDatePicker.Value;
            bool isSequel = IsSequelSwith.Checked;
            float costPrice = float.Parse(txbCostPrice.Text);
            float salePrice = float.Parse(txbSalePrice.Text);
            int stock = int.Parse(txbStock.Text);
            int pages = int.Parse(txbPages.Text);
            db.EditBook(Id,txtTitle.Text,genreID,authorID,publisherID,publishDate,costPrice, salePrice,stock,pages,isSequel);
            this.Close();
        }
    }
}

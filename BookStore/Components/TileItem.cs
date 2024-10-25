using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace BookStore.Components
{
    public partial class TileItem : UserControl
    {
        public TileItem()
        {
            InitializeComponent();
        }

        [DisplayName ("Picture")]
        public Image Picture { get => bookpic.Image; set => bookpic.Image = value;  }

        [DisplayName("Title")]
        public string Title { get => lblTitle.Text; set => lblTitle.Text = value; }

        [DisplayName("Price")]
        public string Price { get => lblPrice.Text; set => lblPrice.Text = value; }
        [DisplayName ("Action")]
        public string Action
        {
            get => btnAdd.Text;
            set
            {
               btnAdd.Text = value;
               btnAdd.Visible = !string.IsNullOrEmpty (value);
            }

        }


        public event EventHandler AddToCartClick;
        private void btnAdd_Click(object sender, EventArgs e)
         => AddToCartClick?.Invoke(sender:this, EventArgs.Empty);
    }
}

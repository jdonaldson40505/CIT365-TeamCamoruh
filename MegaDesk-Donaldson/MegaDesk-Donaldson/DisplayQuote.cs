using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Donaldson
{
    public partial class DisplayQuote : Form
    {
        private DeskQuote deskQuote;
        public DisplayQuote(DeskQuote deskQuote)
        {
            this.deskQuote = deskQuote;
            InitializeComponent();
            int row = 0;
            foreach(int price in Enum.GetValues(typeof(Material)))
            {
                MaterialsTable.GetControlFromPosition(1,row).Text += price.ToString();
                row++;
            }
        }

        private void backMainMenu_Click(object sender, EventArgs e)
        {
            Form form = (MainMenu)Tag;
            form.Show();
            this.Close();
        }

        private void onLoad(object sender, EventArgs e)
        {
            NameLabel.Text = "Name: " + this.deskQuote.FirstName + " " + this.deskQuote.LastName;
            DateLabel.Text = "Date: " + this.deskQuote.Date.ToShortDateString();
            IdLabel.Text = "ID: " + this.deskQuote.QuoteId.ToString();
            Dictionary<String, float> dimensions = deskQuote.getDeskDetails();
            HeightTxtBox.Text = dimensions["Height"].ToString("n2");
            WidthTxtBox.Text = dimensions["Width"].ToString("n2");
            DepthTxtBox.Text = dimensions["Depth"].ToString("n2");
            DrawersTxtBox.Text = dimensions["Drawers"].ToString("n0");
            MaterialTxtBox.Text = deskQuote.getMaterial;
            ShippingTxtBox.Text = deskQuote.Shipping.ToString();
            QuantityTxtBox.Text = deskQuote.NumDesks.ToString();
            TotalTxtBox.Text = "$" + deskQuote.calculateTotal().ToString("n2");
        }

        private void backAddQuote_Click(object sender, EventArgs e)
        {
            Form form = new AddQuote();
            form.Tag = this.Tag;
            form.Show();
            this.Close();
        }
    }
}

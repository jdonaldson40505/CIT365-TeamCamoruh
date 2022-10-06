using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MegaDesk_Donaldson
{
    public partial class AddQuote : Form
    {
        private DeskQuote deskQuote = new DeskQuote();
        private float total = 0;
        public AddQuote()
        {
            InitializeComponent();
        }

        

        private void mainMenuButton_Click_1(object sender, EventArgs e)
        {
            Form form = (MainMenu)Tag;
            form.Show();
            Close();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            float height = float.Parse(HeightInput.Text.Trim());
            float width = float.Parse(WidthInput.Text.Trim());
            float depth = float.Parse(depthInput.Text.Trim());
            String firstName = firstNameTxtBox.Text.Trim();
            String lastName = lastNameTxtBox.Text.Trim();
            String material = MaterialDropDown.Text.Trim().ToLower();
            int numDrawers = int.Parse(numDrawersInput.Text.Trim());
            int shipping = int.Parse(ShippingInput.Text.Trim());
            int quantity = (int)QuantityInput.Value;


            deskQuote.addAttributes(firstName, lastName,height, width, depth, numDrawers, material, shipping, quantity);
            total = deskQuote.calculateTotal();
            TotalBox.Text = total.ToString("c2");
            Form displayQuote = new DisplayQuote(this.deskQuote);
            displayQuote.Tag = this.Tag;
            displayQuote.Show();
            this.Close();
        }

        private void onLoad(object sender, EventArgs e)
        {
            int secondColumn = 1;
            int row = 0;
            foreach (String str in Enum.GetNames(typeof(Material)))
            {
                MaterialDropDown.Items.Add(str);
            }
            foreach (int price in Enum.GetValues(typeof(Material)))
            {
                MaterialsTable.GetControlFromPosition(secondColumn, row).Text += price.ToString();
                row++;
            }
        }

        private void WidthInput_Validating(object sender, CancelEventArgs e)
        {
            String errorMsg;
            try
            {
                float width = float.Parse(WidthInput.Text.Trim());
                errorMsg = $"Please input a number between {deskQuote.minWidth} and {deskQuote.maxWidth}";
                if (!deskQuote.validWidth(width))
                {
                    e.Cancel = true;
                    WidthInput.Select(0, WidthInput.Text.Length);
                    this.AddQuoteErrorProvider.SetError(WidthInput, errorMsg);
                }
                else
                {
                    errorMsg = "";
                    e.Cancel = false;
                    this.AddQuoteErrorProvider.SetError(WidthInput, "");
                    updateTotal();
                }
            }
            catch(Exception ex)
            {
                // we want to fall through here.
                errorMsg = "Please input a valid number 24-96";
                WidthInput.Select(0, WidthInput.Text.Length);
                this.AddQuoteErrorProvider.SetError(WidthInput, errorMsg);
            }
        }

        private void depthInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            String errorMsg = "Please Input a valid number between 12-48";
            foreach (char c in depthInput.Text)
            {
                if (Char.IsDigit(c)) 
                {
                    if (Char.IsControl(c))
                    {
                        this.AddQuoteErrorProvider.SetError(depthInput, errorMsg);
                        depthInput.Select(0, depthInput.Text.Length);
                        break;
                    }
                    errorMsg = "";
                    this.AddQuoteErrorProvider.SetError(depthInput, errorMsg);
                    updateTotal();
                }
                else
                {
                    this.AddQuoteErrorProvider.SetError(depthInput, errorMsg);
                    depthInput.Select(0, depthInput.Text.Length);
                }
            }
        }

        private void ShippingInput_SelectedIndexChanged(object sender, EventArgs e)
        {
           updateTotal();
        }

        private void MaterialDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateTotal();
        }


        private void numDrawersInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            updateTotal();
        }

        private void HeightInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            updateTotal();

        }
        private void updateTotal()
        {
            try
            {
                float height = float.Parse(HeightInput.Text.Trim());
                float width = float.Parse(WidthInput.Text.Trim());
                float depth = float.Parse(depthInput.Text.Trim());
                String material = MaterialDropDown.Text.Trim().ToLower();
                int numDrawers = int.Parse(numDrawersInput.Text.Trim());
                int shipping = int.Parse(ShippingInput.Text.Trim());
                int quantity = (int)QuantityInput.Value;


                deskQuote.addAttributes(height, width, depth, numDrawers, material, shipping, quantity);
                total = deskQuote.calculateTotal();
                TotalBox.Text = total.ToString("c2");
            }
            catch
            {
                //intentionally blank
            }
        }
    }
}

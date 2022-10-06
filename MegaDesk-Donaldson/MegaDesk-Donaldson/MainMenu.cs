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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        /*
         * Navigate from one form to another.
         */
        private void AddQuote_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Form form;
            switch (btn.Name.ToString())
            {
                case "AddQuote":
                    form = new AddQuote();
                    form.Show();
                    form.Tag = this;
                    this.Hide();
                    break;

                case "ViewQuote":
                    form = new ViewAllQuotes();
                    form.Show();
                    form.Tag = this;
                    this.Hide();
                    break;

                case "SearchQuotes":
                    form = new SearchQuotes();
                    form.Show();
                    form.Tag = this;
                    this.Hide();
                    break;

                case "Exit":
                    Application.Exit();
                    break;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataRW dataRW = new dataRW("quotes.Json");
            dataRW.clearJson();
        }
    }
}

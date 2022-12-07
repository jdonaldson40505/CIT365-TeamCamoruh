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
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
        }

        private void backMainMenu_Click(object sender, EventArgs e)
        {
            Form form = (MainMenu)Tag;
            form.Show();
            Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var searchQuery = searchComboBox.Text.ToLower();
            
            dataRW JsonDataRW = new dataRW("quotes.json");
            List<DeskQuote> deskQuotes = findMatch(searchQuery, JsonDataRW.readJsonData());
            int count = 1;
            foreach(DeskQuote deskQuote in deskQuotes)
            {
                searchGridView.Rows.Add(deskQuote.FirstName, deskQuote.LastName, deskQuote.QuoteId, deskQuote.Desk.Material,
                    deskQuote.Desk.Height,deskQuote.Desk.Width, deskQuote.Desk.Depth,deskQuote.NumDesks,deskQuote.calculateTotal());
            }
           

        }

        private List<DeskQuote> findMatch(String Material, List<DeskQuote> deskQuotes)
        {
            List<DeskQuote> result = new List<DeskQuote>();
            foreach(DeskQuote deskQuote in deskQuotes)
            {
                if(deskQuote.getMaterial == Material)
                {
                    result.Add(deskQuote);
                }
            }
            return result;
        }
    }
}

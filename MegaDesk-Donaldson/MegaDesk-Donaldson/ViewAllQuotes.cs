using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MegaDesk_Donaldson
{
    public partial class ViewAllQuotes : Form
    {
        #region Constructor

        public ViewAllQuotes()
        {
            InitializeComponent();
            FillOutDataViewGrid();
        }

        #endregion

        #region Methods

        private void backToMainMenu_Click(object sender, EventArgs e)
        {
            Form form = (MainMenu)Tag;
            form.Show();
            Close();
        }

        /// <summary>
        /// Get the quotes history from the quotes.json
        /// file and create a list of DeskQuoteForDisplay
        /// Class. Bind the DataViewGrid with that list.
        /// </summary>
        private void FillOutDataViewGrid()
        {
            quotesList = quoteData.readJsonData();
            foreach (DeskQuote deskQuote in quotesList)
            {
                cost = deskQuote.calculateTotal();
                DeskQuoteForDisplay quoteView = new DeskQuoteForDisplay();
                quoteView.LastName = deskQuote.LastName;
                quoteView.FirstName = deskQuote.FirstName;
                quoteView.QuoteId = deskQuote.QuoteId;
                quoteView.Date = deskQuote.Date;
                quoteView.Cost = cost;
                quoteView.SurfaceMaterial = deskQuote.getMaterial;
                quoteView.Shipping = deskQuote.Shipping;
                quoteView.Depth = deskQuote.Desk.Depth;
                quoteView.Width = deskQuote.Desk.Width;
                quoteView.Height = deskQuote.Desk.Height;
                quoteView.Drawers = deskQuote.Desk.NumDrawers;
                quoteView.NumberOfDesks = deskQuote.NumDesks;
                deskQuoteViewList.Add(quoteView);
            }

            DeskQuoteDataView.DataSource = deskQuoteViewList;
        }

        #endregion

        #region Fields

        float cost;
        private dataRW quoteData = new dataRW("quotes.json");
        private List<DeskQuote> quotesList = new List<DeskQuote>();
        private List<DeskQuoteForDisplay> deskQuoteViewList = new List<DeskQuoteForDisplay>();

        #endregion
    }
}



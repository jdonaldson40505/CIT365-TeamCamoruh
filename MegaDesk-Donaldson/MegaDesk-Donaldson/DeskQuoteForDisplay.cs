using System;

namespace MegaDesk_Donaldson
{
    /// <summary>
    /// Class to hold information meant to be displayed
    /// in the ViewAllQuotes window.
    /// </summary>
    public class DeskQuoteForDisplay
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int QuoteId { get; set; }
        public DateTime Date { get; set; }
        public float Cost { get; set; }
        public string SurfaceMaterial { get; set; }
        public int Shipping { get; set; }
        public float Width { get; set; }
        public float Depth { get; set; }
        public float Height { get; set; }
        public int Drawers { get; set; }
        public int NumberOfDesks { get; set; }
    }

}

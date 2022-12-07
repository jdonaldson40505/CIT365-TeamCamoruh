using System.ComponentModel.DataAnnotations;

namespace SacramentPlanner.Models
{
    public class Meeting
    {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [Display(Name ="Conducting")]
        public String Conductor { get; set; }
        [Display(Name = "Opening Hymn")]
        public String OpeningHymn { get; set; }
        [Display(Name = "Sacrament Hymn")]
        public String SacramentHymn { get; set; }
        [Display(Name = "Intermediate Hymn")]
        public String IntermediateHymn { get; set; } = string.Empty;
        [Display(Name = "Opening Prayer")]
        public String OpeningPrayer { get; set; }
        [Display(Name = "Closing Prayer")]
        public String ClosingPrayer { get; set; }
        [Display(Name = "Speakers")]
        public List<Speaker> speakers { get; set; } = new List<Speaker>();
    }
}

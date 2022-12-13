using System.ComponentModel.DataAnnotations;

namespace SacramentPlanner.Models
{
    public class Meeting
    {
        public int Id { get; set; }


        [DataType(DataType.Date)]
        public DateTime Date { get; set; }


        [Display(Name ="Conducting")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public String Conductor { get; set; }


        [Required(ErrorMessage = "Opening Hymn is required"), Display(Name = "Opening Hymn")]
        public String OpeningHymn { get; set; }


        [Required(ErrorMessage = "Sacrament Hymn is required"), Display(Name = "Sacrament Hymn")]
        public String SacramentHymn { get; set; }


        [Display(Name = "Intermediate Hymn")]
        public String IntermediateHymn { get; set; } = string.Empty;
        [Display(Name = "Closing Hymn")]
        public String ClosingHymn { get; set; }


        [Required(ErrorMessage = "Opening Prayer is required"), Display(Name = "Opening Prayer")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public String OpeningPrayer { get; set; }


        [Required(ErrorMessage = "Closing Hymn is required"), Display(Name = "Closing Prayer")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public String ClosingPrayer { get; set; }


        [Display(Name = "Speakers")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public List<Speaker> speakers { get; set; } = new List<Speaker>();
    }
}

using System.ComponentModel.DataAnnotations;
using WebAPIDEMO.Models.Validations;

namespace WebAPIDEMO.Models
{
    public class Protein
    {
        public int ProteinId { get; set; }
        
        [Required]
        public string? ProteinName { get; set; }
        
        public string? ProteinSubCategory { get; set; }
        
        [Required]
        public string? ProteinSource { get; set; }
        
        public bool? Vegan { get; set;}
        
        public bool? Vegetarian { get; set;}

        //[Range(0,100, ErrorMessage = "Value for {0} must be between {1} and {2}")]
        
        public double ProteinPer100Grams { get; set;}
        
        public double PricePer100Grams { get; set;}
        
        [Required]
        public int CaloriesPer100Grams { get; set;}

        [Protein_EnsureBioavailability]
        public double ProteinBioavailability { get; set;}

    }
}

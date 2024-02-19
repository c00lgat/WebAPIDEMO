using System.ComponentModel.DataAnnotations;

namespace WebAPIDEMO.Models.Validations
{
    public class Protein_EnsureBioavailabilityAttribute:ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var protein = validationContext.ObjectInstance as Protein;

            if (protein != null && protein.ProteinSource != null)
            {
                if (protein.ProteinSource.Equals("Plant") && protein.ProteinBioavailability > 85)
                {
                    return new ValidationResult("Plant based protein cannot exceed 85 DIAAS.");
                }
                else if(protein.ProteinSource.Equals("Animal") && protein.ProteinBioavailability < 85)
                {
                    return new ValidationResult("Animal based protein cannot be under 85 DIAAS.");
                }
            }
            
            return ValidationResult.Success;

        }
    }
}

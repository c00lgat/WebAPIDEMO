using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using WebAPIDEMO.Models;

namespace WebAPIDEMO.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //RAW TEMPLATE - This can be used to replace [Route("/proteins")] on all functions
    //Now, the URL will have to contain the /api/ keyword while accessing the API end points
    public class ProteinsController:ControllerBase
    {
        private List<Protein> proteins = new List<Protein>()
        {
            new Protein {ProteinId = 1, ProteinName = "Chicken", ProteinSubCategory = "Breast",
            ProteinSource = "Animal", ProteinPer100Grams = 23.8, CaloriesPer100Grams = 120,
            ProteinBioavailability = 112},

            new Protein {ProteinId = 2, ProteinName = "Beef", ProteinSubCategory = "Steak",
            ProteinSource = "Animal", ProteinPer100Grams = 26, CaloriesPer100Grams = 148,
            ProteinBioavailability = 115},

            new Protein {ProteinId = 3, ProteinName = "Peas", ProteinSource = "Plant",
            ProteinPer100Grams = 5, CaloriesPer100Grams = 81, ProteinBioavailability = 58},

            new Protein {ProteinId = 4, ProteinName = "Chicken", ProteinSubCategory = "Thigh",
            ProteinSource = "Animal", ProteinPer100Grams = 24, CaloriesPer100Grams = 177,
            ProteinBioavailability = 118}
        };

        [HttpGet]
        //[Route("/proteins")]
        public string GetProteins()
        {
            return "Reading all the Proteins";
        }
        [HttpGet("{id}")] /*Usually [HttpGet], but since we used the [Route("[controller]")] attribute,
                   we have to add the ID to the [HttpGet]*/
        //[Route("/proteins/{id}")]
        public IActionResult GetProteinById(int id) /*We use IActionResult instead of Protein
                                                     * Data type since the function returns both
                                                     * HTTP status and a Protein datatype
            Usually used when our action method returns different types of data*/
        {
            var protein = proteins.FirstOrDefault(x => x.ProteinId == id);
            if (protein == null)
            {
                return NotFound();
            }
            return Ok(protein);
        }


        //[Route("/proteins")] - NO NEED
        [HttpPost]
        public string CreateProtein([FromBody]Protein protein)
        {
            return $"Creating a protein";
        }

        [HttpPut("{id}")]
        //[Route("/proteins/{id}")] - NO NEED
        public string UpdateProtein(int id)
        {
            return $"Reading protein: {id}";
        }

        [HttpDelete("{id}")]
        //[Route("/proteins/{id}")] - NO NEED75                         
        public string DeleteProtein(int id)
        {
            return $"Deleting protein with ID: {id}";
        }

    }
}

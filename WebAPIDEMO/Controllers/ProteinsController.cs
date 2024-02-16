using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

namespace WebAPIDEMO.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //RAW TEMPLATE - This can be used to replace [Route("/proteins")] on all functions
    //Now, the URL will have to contain the /api/ keyword while accessing the API end points
    public class ProteinsController:ControllerBase
    {
        [HttpGet]
        //[Route("/proteins")]
        public string GetProteins()
        {
            return "Reading all the Proteins";
        }
        [HttpGet("{id}")] /*Usually [HttpGet], but since we used the [Route("[controller]")] attribute,
                   we have to add the ID to the [HttpGet]*/
        //[Route("/proteins/{id}")]
        public string GetProteinById(int id)
        {
            return $"Reading Protein with ID: {id}";
        }

        [HttpPost]
        //[Route("/proteins")] - NO NEED
        public string CreateProteins()
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
        //[Route("/proteins/{id}")] - NO NEED
        public string DeleteProtein(int id)
        {
            return $"Deleting protein with ID: {id}";
        }

    }
}

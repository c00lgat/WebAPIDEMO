using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

namespace WebAPIDEMO.Controllers
{
    [ApiController]
    public class ProteinsController:ControllerBase
    {
        [HttpGet]
        public string GetProteins()
        {
            return "Reading all the Shirts";
        }
        [HttpGet]
        public string GetProteinById(int id)
        {
            return $"Reading Protein with ID: {id}";
        }

        [HttpPost]
        public string CreateProteins()
        {
            return $"Creating a protein";
        }

        [HttpPut]
        public string UpdateProtein(int id)
        {
            return $"Reading protein: {id}";
        }
        [HttpDelete]
        public string DeleteProtein(int id)
        {
            return $"Deleting protein with ID: {id}";
        }

    }
}

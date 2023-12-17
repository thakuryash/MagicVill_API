using MagicVilla_VillaAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controllers
{
    [Route("api/VillAPI")]
    [ApiController]
    public class VillaAPIController : Controller
    {
        [HttpGet]
       public IEnumerable<Villa> GetVillas()
        {
            return new List<Villa>
            {
                new Villa{Id=1, Name="Pool View"},
                new Villa{Id=2,Name="Beach View"}
            };

        }
    }
}

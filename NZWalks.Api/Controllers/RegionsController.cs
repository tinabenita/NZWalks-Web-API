using Microsoft.AspNetCore.Mvc;
using NZWalks.Api.Models.Domain;

namespace NZWalks.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetAll()
        {
            var regions = new List<Region>
            {
                new Region
                {
                    Id = new Guid(),
                    Name = "Auckland Region",
                    Code = "AKL",
                    RegionImageUrl = "https://th.bing.com/th/id/OIP.GrH5anEAE10XhX7Mzs9a2wHaE7?rs=1&pid=ImgDetMain"
                },
                new Region
                {
                    Id = new Guid(),
                    Name = "Wellington Region",
                    Code = "WLG",
                    RegionImageUrl = "https://th.bing.com/th/id/OIP.GrH5anEAE10XhX7Mzs9a2wHaE7?rs=1&pid=ImgDetMain"
                }
            };
            return Ok(regions);
        }
    }
}

using Cars.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cars.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarController : ControllerBase
    {
        private static readonly Car corolla = new();

        [HttpGet]
        public ActionResult<Car> Get()
        {
            return Ok(corolla);
        }
    }
}
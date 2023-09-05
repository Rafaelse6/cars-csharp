using Cars.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cars.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarController : ControllerBase
    {

        private static readonly List<Car> cars = new()
        {
            new(),
            new() {LicensePlate = "1111"}
        };

        [HttpGet("GetAll")]
        public ActionResult<Car> GetAll()
        {
            return Ok(cars);
        }

        [HttpGet]
        public ActionResult<Car> GetSingle()
        {
            return Ok(cars[0]);
        }
    }
}
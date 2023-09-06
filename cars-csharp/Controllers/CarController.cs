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
            new() {Id = 1, LicensePlate = "1111"}
        };

        [HttpGet("GetAll")]
        public ActionResult<Car> GetAll()
        {
            return Ok(cars);
        }

        [HttpGet("{id}")]
        public ActionResult<Car> GetSingle(int id)
        {
            return Ok(cars.FirstOrDefault(c => c.Id == id));
        }

        [HttpPost]
        public ActionResult<List<Car>> AddCar(Car newCar)
        {
            cars.Add(newCar);
            return Ok(cars);
        }
    }
}
using Cars.Models;
using Cars.Services.CarService;
using Microsoft.AspNetCore.Mvc;

namespace Cars.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarController : ControllerBase
    {

        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("GetAll")]
        public ActionResult<Car> GetAllCars()
        {
            return Ok(_carService.GetAllCars());
        }

        [HttpGet("{id}")]
        public ActionResult<Car> GetSingle(int id)
        {
            return Ok(_carService.GetCarById(id));
        }

        [HttpPost]
        public ActionResult<List<Car>> AddCar(Car newCar)
        {
            return Ok(_carService.AddCar(newCar));
        }
    }
}
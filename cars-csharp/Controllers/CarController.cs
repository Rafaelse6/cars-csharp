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
        public async Task<ActionResult<Car>> GetAllCars()
        {
            return Ok(await _carService.GetAllCars());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Car>> GetSingle(int id)
        {
            return Ok(await _carService.GetCarById(id));
        }

        [HttpPost]
        public async Task<ActionResult<List<Car>>> AddCar(Car newCar)
        {
            return Ok(await _carService.AddCar(newCar));
        }
    }
}
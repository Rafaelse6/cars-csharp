using Cars.DTO.Car;
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
        public async Task<ActionResult<ServiceResponse<List<GetCarDTO>>>> GetAllCars()
        {
            return Ok(await _carService.GetAllCars());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetCarDTO>>> GetSingle(int id)
        {
            return Ok(await _carService.GetCarById(id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<GetCarDTO>>>> AddCar(AddCarDTO newCar)
        {
            return Ok(await _carService.AddCar(newCar));
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<List<GetCarDTO>>>> UpdateCar(UpdateCarDTO updatedCar)
        {
            var response = await _carService.UpdateCar(updatedCar);

            if (response.Data is null)
            {
                return NotFound(response);
            }

            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<GetCarDTO>>> DeleteCar(int id)
        {
            var response = await _carService.DeleteCar(id);
            if (response.Data is null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
    }
}
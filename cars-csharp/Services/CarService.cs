using Cars.DTO.Car;
using Cars.Models;

namespace Cars.Services.CarService
{
    public class CarService : ICarService
    {
        private static readonly List<Car> cars = new()
        {
            new(),
            new() {Id = 1, LicensePlate = "1111"}
        };

        public async Task<ServiceResponse<List<GetCarDTO>>> AddCharacter(AddCarDTO newCharacter)
        {
            var serviceResponse = new ServiceResponse<List<GetCarDTO>>();
            cars.Add(newCar);
            serviceResponse.Data = cars;
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetCarDTO>>> GetAllCars()
        {
            var serviceResponse = new ServiceResponse<List<GetCarDTO>>();
            serviceResponse.Data = cars;
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetCarDTO>> GetCarById(int id)
        {
            var serviceResponse = new ServiceResponse<GetCarDTO>();
            var car = cars.FirstOrDefault(c => c.Id == id);
            serviceResponse.Data = car;
            return serviceResponse;
        }
    }
}
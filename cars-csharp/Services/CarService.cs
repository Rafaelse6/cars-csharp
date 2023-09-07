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

        public async Task<ServiceResponse<List<Car>>> AddCar(Car newCar)
        {
            var serviceResponse = new ServiceResponse<List<Car>>();
            cars.Add(newCar);
            serviceResponse.Data = cars;
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Car>>> GetAllCars()
        {
            var serviceResponse = new ServiceResponse<List<Car>>();
            serviceResponse.Data = cars;
            return serviceResponse;
        }

        public async Task<ServiceResponse<Car>> GetCarById(int id)
        {
            var serviceResponse = new ServiceResponse<Car>();
            var car = cars.FirstOrDefault(c => c.Id == id);
            serviceResponse.Data = car;
            return serviceResponse;
        }
    }
}
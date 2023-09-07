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

        public async Task<List<Car>> AddCar(Car newCar)
        {
            cars.Add(newCar);
            return cars;
        }

        public async Task<List<Car>> GetAllCars()
        {
            return cars;
        }

        public async Task<Car> GetCarById(int id)
        {
            var car = cars.FirstOrDefault(c => c.Id == id);
            if (car is not null)
                return car;

            throw new Exception("Car not found");
        }
    }
}
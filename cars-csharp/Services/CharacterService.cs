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

        public List<Car> AddCar(Car newCar)
        {
            cars.Add(newCar);
            return cars;
        }

        public List<Car> GetAllCars()
        {
            return cars;
        }

        public Car GetCarById(int id)
        {
            return cars.FirstOrDefault(c => c.Id == id);
        }
    }
}
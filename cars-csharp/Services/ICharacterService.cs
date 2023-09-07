using Cars.Models;

namespace Cars.Services.CarService
{
    public interface ICarService
    {
        List<Car> GetAllCars();
        Car GetCarById(int id);
        List<Car> AddCar(Car newCar);
    }
}
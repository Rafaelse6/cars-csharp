using Cars.Models;

namespace Cars.Services.CarService
{
    public interface ICarService
    {
        Task<List<Car>> GetAllCars();
        Task<Car> GetCarById(int id);
        Task<List<Car>> AddCar(Car newCar);
    }
}
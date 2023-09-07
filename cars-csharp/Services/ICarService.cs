using Cars.Models;

namespace Cars.Services.CarService
{
    public interface ICarService
    {
        Task<ServiceResponse<List<Car>>> GetAllCars();
        Task<ServiceResponse<Car>> GetCarById(int id);
        Task<ServiceResponse<List<Car>>> AddCar(Car newCar);
    }
}
using Cars.DTO.Car;
using Cars.Models;

namespace Cars.Services.CarService
{
    public interface ICarService
    {
        Task<ServiceResponse<List<GetCarDTO>>> GetAllCars();
        Task<ServiceResponse<GetCarDTO>> GetCarById(int id);
        Task<ServiceResponse<List<GetCarDTO>>> AddCar(AddCarDTO newCar);
        Task<ServiceResponse<GetCarDTO>> UpdateCar(UpdateCarDTO updatedCar);
    }
}
using AutoMapper;
using Cars.Data;
using Cars.DTO.Car;
using Cars.Models;
using Microsoft.EntityFrameworkCore;

namespace Cars.Services.CarService
{
    public class CarService : ICarService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public CarService(IMapper mapper, DataContext context)
        {
            _context = context;
            _mapper = mapper;
        }

        private static readonly List<Car> cars = new()
        {
            new(),
            new() {Id = 1, LicensePlate = "1111"}
        };

        public async Task<ServiceResponse<List<GetCarDTO>>> GetAllCars()
        {
            var serviceResponse = new ServiceResponse<List<GetCarDTO>>();
            var dbCar = await _context.Cars.ToListAsync();
            serviceResponse.Data = dbCar.Select(c => _mapper.Map<GetCarDTO>(c)).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetCarDTO>> GetCarById(int id)
        {
            var serviceResponse = new ServiceResponse<GetCarDTO>();
            var dbCar = await _context.Cars.FirstOrDefaultAsync(c => c.Id == id);
            serviceResponse.Data = _mapper.Map<GetCarDTO>(dbCar);
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetCarDTO>>> AddCar(AddCarDTO newCar)
        {
            var serviceResponse = new ServiceResponse<List<GetCarDTO>>();
            var car = _mapper.Map<Car>(newCar);
            car.Id = cars.Max(c => c.Id) + 1;
            cars.Add(car);
            serviceResponse.Data = cars.Select(c => _mapper.Map<GetCarDTO>(c)).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetCarDTO>> UpdateCar(UpdateCarDTO updatedCar)
        {
            var serviceResponse = new ServiceResponse<GetCarDTO>();

            try
            {
                var car = cars.FirstOrDefault(c => c.Id == updatedCar.Id) ?? throw new Exception($"Car with Id '{updatedCar.Id}' not found.");

                car.LicensePlate = updatedCar.LicensePlate;
                car.Year = updatedCar.Year;
                car.Brand = updatedCar.Brand;

                serviceResponse.Data = _mapper.Map<GetCarDTO>(car);
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetCarDTO>>> DeleteCar(int id)
        {
            var serviceResponse = new ServiceResponse<List<GetCarDTO>>();

            try
            {
                var car = cars.FirstOrDefault(c => c.Id == id) ?? throw new Exception($"Car with Id '{id}' not found.");

                cars.Remove(car);

                serviceResponse.Data = cars.Select(c => _mapper.Map<GetCarDTO>(c)).ToList();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }

            return serviceResponse;
        }
    }
}
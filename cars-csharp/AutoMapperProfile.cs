using AutoMapper;
using Cars.DTO.Car;
using Cars.Models;

namespace Cars
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Car, GetCarDTO>();
            CreateMap<AddCarDTO, Car>();
        }
    }
}
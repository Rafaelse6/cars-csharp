using Cars.Models.Enums;

namespace Cars.DTO.Car
{
    public class AddCarDTO
    {
        public string LicensePlate { get; set; } = "0000";
        public int Year { get; set; } = 2000;
        public BrandEnums Brand { get; set; }
    }
}
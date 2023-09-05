using Cars.Models.Enums;

namespace Cars.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string LicensePlate { get; set; } = "0000";
        public int Year { get; set; } = 2000;
        public BrandEnums Brand { get; set; }
    }
}
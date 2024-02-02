namespace Atyon.DTO
{
    public class ManufactureDTO
    {
        public int ManufactureId { get; set; }
        public string? ManufactureName { get; set; }
        public string? ProductName { get; set; }
        public string? CityName { get; set; }
        public string? TownName { get; set; }
        public DateTime? DateOfManufacture { get; set; }
        public DateTime? DateOfRecord { get; set; }
        public DateTime? DateOfUpdate { get; set; }


        public ProductDTO? ProductModel { get; set; }
        public CityDTO? CityModel { get; set; }
        public TownDTO? TownModel { get; set; }

        public virtual ICollection<ProductDTO> Products { get; set; }
    }
}

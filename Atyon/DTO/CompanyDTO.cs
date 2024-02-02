namespace Atyon.DTO
{
    public class CompanyDTO
    {
        public int CompanyId { get; set; }
        public string? CompanyName { get; set; }
        public string? TaxIdNumber { get; set; }
        public string? ManufactureName { get; set; }
        public string? ProductName { get; set; }
        public string? CityName { get; set; }
        public string? TownName { get; set; }
        public DateTime? DatOfRecord { get; set; }
        public DateTime? DateOfUpdate { get; set; }


        public ManufactureDTO? ManufactureModel { get; set; }
        public ProductDTO? ProductModel { get; set; }

        public virtual ICollection<ManufactureDTO> Manufactures { get; set; }

    }
}

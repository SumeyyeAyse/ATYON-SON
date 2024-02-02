namespace Atyon.DTO
{
    public class FacilityDTO
    {
        public int FacilityId { get; set; }
        public string? FacilityName { get; set; }
        public string? FacilityQualificationTypeName { get; set; }
        public string? FacilityTypeName { get; set; }
        public int ManufactureId { get; set; }
        public int WasteStockId { get; set; }
        public int? Amount { get; set; }
        public string? CityName { get; set; }
        public string? TownName { get; set; }
        public DateTime? DateOfRecord { get; set; }
        public DateTime? DateOfUpdate { get; set; }
        public string? CompanyName { get; set; }




        public FacilityQualificationTypeDTO? FacilityQualificationTypeModel { get; set; }
        public FacilityTypeDTO? FacilityTypeModel { get; set; }
        public ManufactureDTO? ManufactureModel { get; set; }
        public WasteStockDTO? WasteStockModel { get; set; }
        public CityDTO? CityModel { get; set; }
        public TownDTO? TownModel { get; set; }
        public CompanyDTO? CompanyModel { get; set; }

        public virtual ICollection<CompanyDTO> Companies { get; set; }
        public virtual ICollection<FacilityQualificationTypeDTO> FacilityQualificationTypes { get; set; }
        public virtual ICollection<ManufactureDTO> Manufactures { get; set; }
        public virtual ICollection<WasteStockDTO> WasteStocks { get; set; }

    }
}

namespace Atyon.DTO
{
    public class FacilityQualificationTypeDTO
    {
        public int FacilityQualificationTypeId { get; set; }
        public string? FacilityQualificationTypeName { get; set; }
        public string? FacilityTypeName { get; set; }
        public DateTime? DateOfRecord { get; set; }
        public DateTime? DateOfUpdate { get; set; }

        public FacilityTypeDTO? FacilityTypeModel { get; set; }
        public virtual ICollection<FacilityTypeDTO> FacilityTypes { get; set; }
    }
}

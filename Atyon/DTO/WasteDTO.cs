namespace Atyon.DTO
{
    public class WasteDTO
    {
        public int WasteId { get; set; }
        public string? WasteName { get; set; }
        public string? WasteTypeName { get; set; }
        public DateTime? DateOfRecord { get; set; }
        public DateTime? DateOfUpdate { get; set; }

        public WasteTypeDTO? WasteTypeModel { get; set; }

        public virtual ICollection<WasteTypeDTO> WasteTypes { get; set; }
    }
}

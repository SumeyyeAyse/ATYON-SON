namespace Atyon.DTO
{
    public class CityDTO
    {
        public int CityId { get; set; }
        public int CityCode { get; set; }
        public string? CityName { get; set; }
        public string? TownName { get; set; }
        public DateTime? Dateofrecord { get; set; }
        public DateTime? Dateofupdate { get; set; }

        public TownDTO? TownModel { get; set; }
    }
}

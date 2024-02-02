using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atyon.Core.Models
{
    public class FacilityModel
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




        public FacilityQualificationTypeModel? FacilityQualificationTypeModel { get; set; }
        public FacilityTypeModel? FacilityTypeModel { get; set; }
        public ManufactureModel? ManufactureModel { get; set; }
        public WasteStockModel? WasteStockModel { get; set; }
        public CityModel? CityModel { get; set; }
        public TownModel? TownModel { get; set; }
        public CompanyModel? CompanyModel { get; set; }

        public virtual ICollection<CompanyModel> Companies { get; set; }
        public virtual ICollection<FacilityQualificationTypeModel> FacilityQualificationTypes { get; set; }
        public virtual ICollection<ManufactureModel> Manufactures { get; set; }
        public virtual ICollection<WasteStockModel> WasteStocks { get; set; }

    }
}

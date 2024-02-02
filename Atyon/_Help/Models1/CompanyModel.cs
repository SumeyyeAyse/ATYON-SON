using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atyon.Core.Models
{
    public class CompanyModel
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


        public ManufactureModel? ManufactureModel { get; set; }
        public ProductModel? ProductModel { get; set; }

        public virtual ICollection<ManufactureModel> Manufactures { get; set; }

    }
}

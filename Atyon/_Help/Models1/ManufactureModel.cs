using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atyon.Core.Models
{
    public class ManufactureModel
    {
        public int ManufactureId { get; set; }
        public string? ManufactureName { get; set; }
        public string? ProductName { get; set; }
        public string? CityName { get; set; }
        public string? TownName { get; set; }
        public DateTime? DateOfManufacture { get; set; }
        public DateTime? DateOfRecord { get; set; }
        public DateTime? DateOfUpdate { get; set; }


        public ProductModel? ProductModel { get; set; }
        public CityModel? CityModel { get; set; }
        public TownModel? TownModel { get; set; }

        public virtual ICollection<ProductModel> Products { get; set; }
    }
}

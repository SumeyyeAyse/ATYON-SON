using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atyon.Core.Models
{
    public class CityModel
    {
        public int CityId { get; set; }
        public int CityCode { get; set; }
        public string? CityName { get; set; }
        public string? TownName { get; set; }
        public DateTime? Dateofrecord { get; set; }
        public DateTime? Dateofupdate { get; set; }

        public TownModel? TownModel { get; set; }
    }
}

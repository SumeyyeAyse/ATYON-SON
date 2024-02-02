using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atyon.Core.Models
{
    public class FacilityTypeModel
    {
        public int FacilityTypeId { get; set; }
        public string? FacilityTypeName { get; set; }
        public DateTime? DateOfRecord { get; set; }
        public DateTime? DateOfUpdate { get; set; }
    }
}

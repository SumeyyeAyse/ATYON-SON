using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atyon.Core.Models
{
    public class FacilityQualificationTypeModel
    {
        public int FacilityQualificationTypeId { get; set; }
        public string? FacilityQualificationTypeName { get; set; }
        public string? FacilityTypeName { get; set; }
        public DateTime? DateOfRecord { get; set; }
        public DateTime? DateOfUpdate { get; set; }

        public FacilityTypeModel? FacilityTypeModel { get; set; }
        public virtual ICollection<FacilityTypeModel> FacilityTypes { get; set; }
    }
}

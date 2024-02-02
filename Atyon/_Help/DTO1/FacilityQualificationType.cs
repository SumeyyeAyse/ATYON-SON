using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atyon.DTO
{
    [Table("facilityqualificationtype")]
    [Index("Facilityqualificationtypename", Name = "ix_facilityqualificationtype")]
    public partial class FacilityQualificationType
    {
        public FacilityQualificationType()
        {
            FacilityTypes = new HashSet<FacilityType>();
        }

        [Key]
        [Column("facilityqualificationtypeıd")]
        public int FacilityQualificationTypeId { get; set; }
        [Column("facilityqualificationtypecode")]
        public int FacilityQualificationTypeCode { get; set; }
        [Column("facilityqualificationtypename")]
        [StringLength(30)]
        [Unicode(false)]
        public string? FacilityQualificationTypeName { get; set; }
        [Column("dateofrecord", TypeName = "date")]
        public DateTime? DateOfRecord { get; set; }
        [Column("dateofupdate", TypeName = "date")]
        public DateTime? DateOfUpdate { get; set; }
        [Column("facilitytypecode")]
        public int FacilityTypeCode { get; set; }

        [ForeignKey("Facilityqualificationtypecode")]
        [InverseProperty("Facilityqualificationtypes")]
        public virtual Facility FacilityQualificationTypeCodeNavigation { get; set; } = null!;
        [InverseProperty("FacilitytypecodeNavigation")]
        public virtual ICollection<FacilityType> FacilityTypes { get; set; }
    }
}

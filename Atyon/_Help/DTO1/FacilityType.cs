using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atyon.DTO
{
    [Table("facilitytype")]
    [Index("Facilitytypename", Name = "ix_facilitytype")]
    public partial class FacilityType
    {
        [Key]
        [Column("facilitytypeıd")]
        public int FacilityTypeId { get; set; }
        [Column("facilitytypecode")]
        public int FacilityTypeCode { get; set; }
        [Column("facilitytypename")]
        [StringLength(50)]
        [Unicode(false)]
        public string? FacilityTypeName { get; set; }
        [Column("dateofrecord", TypeName = "date")]
        public DateTime? DateOfRecord { get; set; }
        [Column("dateofupdate", TypeName = "date")]
        public DateTime? DateOfUpdate { get; set; }

        [ForeignKey("Facilitytypecode")]
        [InverseProperty("Facilitytypes")]
        public virtual FacilityQualificationType FacilityTypeCodeNavigation { get; set; } = null!;
    }
}

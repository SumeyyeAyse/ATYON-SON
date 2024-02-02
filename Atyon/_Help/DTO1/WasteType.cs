using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atyon.DTO
{
    [Table("wastetype")]
    [Index("Wastetypename", Name = "ix_wastetype")]
    public partial class WasteType
    {
        [Key]
        [Column("wastetypeıd")]
        public int WasteTypeId { get; set; }
        [Column("wastetypecode")]
        public int WasteTypeCode { get; set; }
        [Column("wastetypename")]
        [StringLength(50)]
        [Unicode(false)]
        public string? WasteTypeName { get; set; }
        [Column("dateofrecord", TypeName = "date")]
        public DateTime? DateOfRecord { get; set; }
        [Column("dateofupdate", TypeName = "date")]
        public DateTime? DateOfUpdate { get; set; }

        [ForeignKey("Wastetypecode")]
        [InverseProperty("Wastetypes")]
        public virtual Waste WasteTypeCodeNavigation { get; set; } = null!;
    }
}

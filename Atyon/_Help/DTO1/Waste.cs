using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atyon.DTO
{
    [Table("waste")]
    [Index("Wastename", Name = "ix_waste")]
    public partial class Waste
    {
        public Waste()
        {
            WasteTypes = new HashSet<WasteType>();
        }

        [Key]
        [Column("wasteıd")]
        public int WasteId { get; set; }
        [Column("wastecode")]
        public int? WasteCode { get; set; }
        [Column("wastename")]
        [StringLength(50)]
        [Unicode(false)]
        public string? WasteName { get; set; }
        [Column("dateofrecord", TypeName = "date")]
        public DateTime? DateOfRecord { get; set; }
        [Column("dateofupdate", TypeName = "date")]
        public DateTime? DateOfUpdate { get; set; }
        [Column("wastetypecode")]
        public int? WasteTypeCode { get; set; }

        [ForeignKey("Wasteıd")]
        [InverseProperty("Waste")]
        public virtual WasteStock WasteIdNavigation { get; set; } = null!;
        [InverseProperty("WastetypecodeNavigation")]
        public virtual ICollection<WasteType> WasteTypes { get; set; }
    }
}

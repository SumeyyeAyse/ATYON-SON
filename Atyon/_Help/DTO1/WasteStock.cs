using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atyon.DTO
{
    [Table("wastestock")]
    [Index("Wastestocktype", Name = "ix_wastestock")]
    public partial class WasteStock
    {
        [Key]
        [Column("wastestockıd")]
        public int WasteStockId { get; set; }
        [Column("wastestockcode")]
        public int WasteStockCode { get; set; }
        [Column("wastestocktype")]
        public int? WasteStockType { get; set; }
        [Column("dateofrecord", TypeName = "date")]
        public DateTime? DateOfRecord { get; set; }
        [Column("dateofupdate", TypeName = "date")]
        public DateTime? DateOfUpdate { get; set; }
        [Column("amount")]
        public int? Amount { get; set; }
        [Column("wastecode")]
        public int? WasteCode { get; set; }
        [Column("wastetypecode")]
        public int WasteTypeCode { get; set; }

        [ForeignKey("Wastestockcode")]
        [InverseProperty("Wastestocks")]
        public virtual Facility WasteStockCodeNavigation { get; set; } = null!;
        [InverseProperty("WasteıdNavigation")]
        public virtual Waste Waste { get; set; } = null!;
    }
}

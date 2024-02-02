using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atyon.Core.Models
{
    [Table("product")]
    [Index("Productname", Name = "ix_product")]
    public partial class Product
    {
        [Key]
        [Column("productıd")]
        public int ProductId { get; set; }
        [Column("productcode")]
        public int ProductCode { get; set; }
        [Column("productname")]
        [StringLength(50)]
        [Unicode(false)]
        public string? ProductName { get; set; }
        [Column("dateofrecord", TypeName = "date")]
        public DateTime? DateOfRecord { get; set; }
        [Column("dateofupdate", TypeName = "date")]
        public DateTime? DateOfUpdate { get; set; }

        [ForeignKey("Productcode")]
        [InverseProperty("Products")]
        public virtual Manufacture ProductCodeNavigation { get; set; } = null!;
    }
}

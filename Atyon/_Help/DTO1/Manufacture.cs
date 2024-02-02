using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atyon.DTO
{
    [Table("manufacture")]
    [Index("Dateofmanufacture", Name = "un_manufacture", IsUnique = true)]
    public partial class Manufacture
    {
        public Manufacture()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        [Column("manufactureıd")]
        public int ManufactureId { get; set; }
        [Column("manufacturecode")]
        public int ManufactureCode { get; set; }
        [Column("manufacturename")]
        [StringLength(50)]
        [Unicode(false)]
        public string? ManufactureName { get; set; }
        [Column("dateofmanufacture", TypeName = "date")]
        public DateTime? DateOfManufacture { get; set; }
        [Column("dateofrecord", TypeName = "date")]
        public DateTime? DateOfRecord { get; set; }
        [Column("dateofupdate", TypeName = "date")]
        public DateTime? DateOfUpdate { get; set; }
        [Column("citycode")]
        public int? CityCode { get; set; }
        [Column("towncode")]
        public int? TownCode { get; set; }
        [Column("productcode")]
        public int? ProductCode { get; set; }

        [ForeignKey("Manufacturecode")]
        [InverseProperty("Manufactures")]
        public virtual Facility ManufactureCode1 { get; set; } = null!;
        [ForeignKey("Manufacturecode")]
        [InverseProperty("Manufactures")]
        public virtual Company ManufactureCodeNavigation { get; set; } = null!;
        [InverseProperty("Citycode2")]
        public virtual City City { get; set; } = null!;
        [InverseProperty("ProductcodeNavigation")]
        public virtual ICollection<Product> Products { get; set; }
    }
}

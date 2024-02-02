using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atyon.Core.Models
{
    [Table("city")]
    [Index("Cityname", Name = "ix_city")]
    [Index("Citycode", Name = "un_city", IsUnique = true)]
    public partial class City
    {
        [Key]
        [Column("cityıd")]
        public int CityId { get; set; }
        [Column("citycode")]
        public int CityCode { get; set; }
        [Column("cityname")]
        [StringLength(50)]
        [Unicode(false)]
        public string? CityName { get; set; }
        [Column("dateofrecord", TypeName = "date")]
        public DateTime? DateOfRecord { get; set; }
        [Column("dateofupdate", TypeName = "date")]
        public DateTime? DateOfUpdate { get; set; }
        [Column("towncode")]
        public int? TownCode { get; set; }

        [ForeignKey("Citycode")]
        [InverseProperty("City")]
        public virtual Facility CityCode1 { get; set; } = null!;
        [ForeignKey("Citycode")]
        [InverseProperty("City")]
        public virtual Manufacture CityCode2 { get; set; } = null!;
        [ForeignKey("Citycode")]
        [InverseProperty("City")]
        public virtual Company CityCodeNavigation { get; set; } = null!;
        public virtual Town Town { get; set; } = null!;
    }
}

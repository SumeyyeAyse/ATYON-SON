using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atyon.Core.Models
{
    [Table("town")]
    [Index("Townname", Name = "ix_town")]
    [Index("Towncode", Name = "un_town", IsUnique = true)]
    public partial class Town
    {
        [Key]
        [Column("townıd")]
        public int TownId { get; set; }
        [Column("towncode")]
        public int TownCode { get; set; }
        [Column("townname")]
        [StringLength(50)]
        [Unicode(false)]
        public string? TownName { get; set; }
        [Column("dateofrecord", TypeName = "date")]
        public DateTime? DateOfRecord { get; set; }
        [Column("dateofupdate", TypeName = "date")]
        public DateTime? DateOfUpdate { get; set; }

        public virtual City TownCodeNavigation { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atyon.Core.Models
{
    [Table("company")]
    [Index("Companyname", Name = "ix_company")]
    [Index("Taxıdnumber", Name = "un_company", IsUnique = true)]
    public partial class Company
    {
        public Company()
        {
            Manufactures = new HashSet<Manufacture>();
        }

        [Key]
        [Column("companyıd")]
        public int CompanyId { get; set; }
        [Column("companycode")]
        public int CompanyCode { get; set; }
        [Column("companyname")]
        [StringLength(100)]
        [Unicode(false)]
        public string? CompanyName { get; set; }
        [Column("taxıdnumber")]
        [StringLength(20)]
        [Unicode(false)]
        public string? TaxIdNumber { get; set; }
        [Column("datofrecord", TypeName = "date")]
        public DateTime? DatOfRecord { get; set; }
        [Column("dateofupdate", TypeName = "date")]
        public DateTime? DateOfUpdate { get; set; }
        [Column("citycode")]
        public int? CityCode { get; set; }
        [Column("towncode")]
        public int? TownCode { get; set; }

        [ForeignKey("Companycode")]
        [InverseProperty("Companies")]
        public virtual Facility CompanyCodeNavigation { get; set; } = null!;
        [InverseProperty("CitycodeNavigation")]
        public virtual City City { get; set; } = null!;
        [InverseProperty("ManufacturecodeNavigation")]
        public virtual ICollection<Manufacture> Manufactures { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atyon.Core.Models
{
    [Table("facility")]
    [Index("Facilityname", Name = "ix_facility")]
    public partial class Facility
    {
        public Facility()
        {
            Companies = new HashSet<Company>();
            FacilityQualificationTypes = new HashSet<FacilityQualificationType>();
            Manufactures = new HashSet<Manufacture>();
            WasteStocks = new HashSet<WasteStock>();
        }

        [Key]
        [Column("facilityıd")]
        public int FacilityId { get; set; }
        [Column("facilitycode")]
        public int? FacilityCode { get; set; }
        [Column("facilityname")]
        [StringLength(50)]
        [Unicode(false)]
        public string? FacilityName { get; set; }
        [Column("dateofrecord", TypeName = "date")]
        public DateTime? DateOfRecord { get; set; }
        [Column("dateofupdate", TypeName = "date")]
        public DateTime? DateOfUpdate { get; set; }
        [Column("citycode")]
        public int? CityCode { get; set; }
        [Column("towncode")]
        public int? TownCode { get; set; }
        [Column("facilityqualificationtypecode")]
        public int? FacilityQualificationTypeCode { get; set; }
        [Column("facilitytypecode")]
        public int? FacilityTypeCode { get; set; }
        [Column("wastestockcode")]
        public int? WasteStockCode { get; set; }
        [Column("companycode")]
        public int? CompanyCode { get; set; }
        [Column("manufacturecode")]
        public int? ManufactureCode { get; set; }

        [InverseProperty("Citycode1")]
        public virtual City City { get; set; } = null!;
        [InverseProperty("CompanycodeNavigation")]
        public virtual ICollection<Company> Companies { get; set; }
        [InverseProperty("FacilityqualificationtypecodeNavigation")]
        public virtual ICollection<FacilityQualificationType> FacilityQualificationTypes { get; set; }
        [InverseProperty("Manufacturecode1")]
        public virtual ICollection<Manufacture> Manufactures { get; set; }
        [InverseProperty("WastestockcodeNavigation")]
        public virtual ICollection<WasteStock> WasteStocks { get; set; }
    }
}

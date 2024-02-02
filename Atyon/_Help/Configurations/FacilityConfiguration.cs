using Atyon.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atyon.Data.Configurations
{
    public class FacilityConfiguration : IEntityTypeConfiguration<FacilityModel>
    {
        public void Configure(EntityTypeBuilder<FacilityModel> builder)
        {
            builder
                .HasKey(a => a.FacilityId);
            //builder
            //    .
        }
    }
}

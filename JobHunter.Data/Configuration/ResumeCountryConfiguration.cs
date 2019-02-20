using JobHunter.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobHunter.Data.Configuration
{
    class ResumeCountryConfiguration : IEntityTypeConfiguration<ResumeCountry>
    {
        public void Configure(EntityTypeBuilder<ResumeCountry> builder)
        {
            builder.HasKey(x => new { x.ResumeId, x.CountryId });

            builder.HasOne(c => c.Resume)
                .WithMany(s => s.ResumeCountries)
                .HasForeignKey(sc => sc.ResumeId);

            builder.HasOne(c => c.Country)
               .WithMany(s => s.ResumeCountries)
               .HasForeignKey(sc => sc.CountryId);
        }
    }
}

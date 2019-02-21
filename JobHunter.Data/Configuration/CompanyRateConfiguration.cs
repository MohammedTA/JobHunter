using JobHunter.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace JobHunter.Data.Configuration
{
   public class CompanyRateConfiguration : IEntityTypeConfiguration<CompanyRate>
    {
        public void Configure(EntityTypeBuilder<CompanyRate> builder)
        {
            builder.HasOne(x => x.User)
             .WithMany(x => x.CompanyRates)
             .HasForeignKey(x => x.UserId)
             .IsRequired(false);
             //.OnDelete(DeleteBehavior.Restrict);
        }
    }
}

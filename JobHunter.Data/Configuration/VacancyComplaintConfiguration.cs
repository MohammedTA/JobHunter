using JobHunter.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobHunter.Data.Configuration
{
    class VacancyComplaintConfiguration : IEntityTypeConfiguration<VacancyComplaint>
    {
        public void Configure(EntityTypeBuilder<VacancyComplaint> builder)
        {
            builder.HasOne(x => x.Vacancy)
            .WithMany(x => x.VacancyComplaints)
            .HasForeignKey(x => x.VacancyId)
            .IsRequired(false);
        }
    }
}

using JobHunter.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobHunter.Data.Configuration
{
    class FavoriteResumeConfiguration : IEntityTypeConfiguration<FavoriteResume>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<FavoriteResume> builder)
        {
            builder.HasOne(x => x.Resume)
             .WithMany(x => x.FavoriteResumes)
             .HasForeignKey(x => x.ResumeId)
             .IsRequired(false);
        }
    }
}

using JobHunter.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobHunter.Data.Configuration
{
    public class VacancyFeedbackConfiguration : IEntityTypeConfiguration<VacancyFeedback>
    {
        public void Configure(EntityTypeBuilder<VacancyFeedback> builder)
        {
            builder.HasOne(x => x.Vacancy)
            .WithMany(x => x.VacancyFeedbacks)
            .HasForeignKey(x => x.VacancyId)
            .IsRequired(false);
            //builder.HasKey(x => x.Id);
            //builder.HasOne(x => x.ParentFeedback).WithMany(x => x.VacancyFeedbacks).HasForeignKey(x => x.ParentFeedbackId).Metadata.DeleteBehavior = DeleteBehavior.SetNull;
        }
    }
}

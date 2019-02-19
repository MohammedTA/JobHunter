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
            //builder.HasKey(x => x.Id);
            //builder.HasOne(x => x.ParentFeedback).WithMany(x => x.VacancyFeedbacks).HasForeignKey(x => x.ParentFeedbackId).Metadata.DeleteBehavior = DeleteBehavior.SetNull;
        }
    }
}

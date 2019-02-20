using JobHunter.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobHunter.Data.Configuration.InitialDataConfiguration
{
    public class StatusInitialConfig : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            Status[] statuses = new Status[]
            {
                new Status { Id = 1, Name = "HOT"},
                new Status { Id = 2, Name = "VIP"}
            };

            builder.HasData(statuses);
        }


    }
}

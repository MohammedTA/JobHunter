using JobHunter.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobHunter.Data.Configuration.InitialDataConfiguration
{
    public class CountryInitialConfig : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            Country[] languages = new Country[]
            {
                new Country { Id = 1, Name = "UK"},
                new Country { Id = 2, Name = "Poland"},
                new Country { Id = 3, Name = "Russia" },
                new Country { Id = 4, Name = "Ukraine"},
                new Country { Id = 5, Name = "German"},
                new Country { Id = 6, Name = "Spain"},
                new Country { Id = 7, Name = "Italy"},
            };

            builder.HasData(languages);
        }

       
    }
}

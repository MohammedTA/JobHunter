using JobHunter.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobHunter.Data.Configuration.InitialDataConfiguration
{
    public class LanguageInitialConfig : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            Language[] languages = new Language[]
            {
                new Language { Id = 1, Name = "English"},
                new Language { Id = 2, Name = "Polish"},
                new Language { Id = 3, Name = "Russian" },
                new Language { Id = 4, Name = "Ukrainian"},
                new Language { Id = 5, Name = "German"},
                new Language { Id = 6, Name = "Spanish"}
            };

            builder.HasData(languages);
        }
    }
}

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
            int id = 1;
            Language[] languages = new Language[]
            {
                new Language { Id = id++, Name = "English"},
                new Language { Id = id++, Name = "Polish"},
                new Language { Id = id++, Name = "Russian" },
                new Language { Id = id++, Name = "Ukrainian"},
                new Language { Id = id++, Name = "German"},
                new Language { Id = id++, Name = "Spanish"}
            };

            builder.HasData(languages);
        }
    }
}

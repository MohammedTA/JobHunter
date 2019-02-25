using JobHunter.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobHunter.Data.Configuration.InitialDataConfiguration
{
    public class CountryInitConfig : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            int countryId = 0;
            Country[] countries = new Country[]
            {
                new Country
                {
                    Id=++countryId,
                    Name="Poland",
                },
                new Country
                {
                    Id=++countryId,
                    Name="Russian Federation",
                },
                new Country
                {
                    Id=++countryId,
                    Name="Germany",
                },
                new Country
                {
                    Id=++countryId,
                    Name="Ukraine",
                }
            };
            builder.HasData(countries);
        }
    }
}

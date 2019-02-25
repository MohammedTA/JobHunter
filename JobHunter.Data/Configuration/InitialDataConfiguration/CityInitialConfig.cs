using JobHunter.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobHunter.Data.Configuration.InitialDataConfiguration
{
    class CityInitialConfig : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            int cityId = 0;
            City[] cities = new City[]
            {
                new City
                        {
                            Id=++cityId,
                            CountryId=1,
                            Name="Warszawa"
                        },
                         new City
                        {
                            Id=++cityId,
                            CountryId=1,
                            Name="Krakow"
                        },
                         new City
                        {
                            Id=++cityId,
                            CountryId=1,
                            Name="Wroclaw"
                        },
                            new City
                        {
                            Id=++cityId,
                            CountryId=1,
                            Name="Poznan"
                        },
                             new City
                        {
                            Id=++cityId,
                            CountryId=1,
                            Name="Gdansk"
                        },
                               new City
                        {
                            Id=++cityId,
                            CountryId=1,
                            Name="Lublin"
                        },
                               new City
                        {
                            Id=++cityId,
                            CountryId=1,
                            Name="Gdynia"
                        },
                         new City
                        {
                            Id=++cityId,
                            CountryId=2,
                            Name="Moscow"
                        },
                         new City
                        {
                            Id=++cityId,
                            CountryId=2,
                            Name="Saint Petersburg"
                        },
                             new City
                        {
                            Id=++cityId,
                            CountryId=2,
                            Name="Novosibirsk"
                        },
                            new City
                        {
                            Id=++cityId,
                            CountryId=2,
                            Name="Yekaterinburg"
                        },
                             new City
                        {
                            Id=++cityId,
                            CountryId=2,
                            Name="Samara"
                        },
                             new City
                        {
                            Id=++cityId,
                            CountryId=2,
                            Name="Chelyabinsk"
                        },
                            new City
                        {
                            Id=++cityId,
                            CountryId=2,
                            Name="Rostov-on-Don"
                        },
                            new City
                        {
                            Id=++cityId,
                            CountryId=2,
                            Name="Voronezh"
                        },
                        new City
                        {
                            Id=++cityId,
                            CountryId=3,
                            Name="Berlin"
                        },
                         new City
                        {
                            Id=++cityId,
                            CountryId=3,
                            Name="Hamburg"
                        },
                         new City
                        {
                            Id=++cityId,
                            CountryId=3,
                            Name="Munchen"
                        },
                         new City
                        {
                            Id=++cityId,
                            CountryId=3,
                            Name="Koln"
                        },
                         new City
                        {
                            Id=++cityId,
                            CountryId=3,
                            Name="Frankfurt"
                        },
                         new City
                        {
                            Id=++cityId,
                            CountryId=3,
                            Name="Essen"
                        },
                         new City
                        {
                            Id=++cityId,
                            CountryId=3,
                            Name="Dortmund"
                        },
                         new City
                        {
                            Id=++cityId,
                            CountryId=3,
                            Name="Dusseldorf"
                        },
                         new City
                        {
                            Id=++cityId,
                            CountryId=3,
                            Name="Bremen"
                        },
                          new City
                        {
                            Id=++cityId,
                            CountryId=4,
                            Name="Kyiv"
                        },
                        new City
                        {
                            Id=++cityId,
                            CountryId=4,
                            Name="Lviv"
                        },
                        new City
                        {
                            Id=++cityId,
                            CountryId=4,
                            Name="Rivne"
                        },
                        new City
                        {
                            Id=++cityId,
                            CountryId=4,
                            Name="Kharkiv"
                        },
                        new City
                        {
                            Id=++cityId,
                            CountryId=4,
                            Name="Dnipro"
                        },
                        new City
                        {
                            Id=++cityId,
                            CountryId=4,
                            Name="Poltava"
                        },
                        new City
                        {
                            Id=++cityId,
                            CountryId=4,
                            Name="Chernihiv"
                        }
            };
            builder.HasData(cities);
        }
    }
}

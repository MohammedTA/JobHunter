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
            int cityId = 0;
            Country[] countries = new Country[]
            {
                new Country
                {
                    Id=++countryId,
                    Name="Poland",
                    Cities=new City[]
                    {
                        new City
                        {
                            Id=++cityId,
                            CountryId=countryId,
                            Name="Warszawa"
                        },
                         new City
                        {
                            Id=++cityId,
                            CountryId=countryId,
                            Name="Krakow"
                        },
                         new City
                        {
                            Id=++cityId,
                            CountryId=countryId,
                            Name="Wroclaw"
                        },
                            new City
                        {
                            Id=++cityId,
                            CountryId=countryId,
                            Name="Poznan"
                        },
                             new City
                        {
                            Id=++cityId,
                            CountryId=countryId,
                            Name="Gdansk"
                        },
                               new City
                        {
                            Id=++cityId,
                            CountryId=countryId,
                            Name="Lublin"
                        },
                               new City
                        {
                            Id=++cityId,
                            CountryId=countryId,
                            Name="Gdynia"
                        },
                    }
                },
                new Country
                {
                    Id=++countryId,
                    Name="Russian Federation",
                    Cities=new City[]
                    {
                        new City
                        {
                            Id=++cityId,
                            CountryId=countryId,
                            Name="Moscow"
                        },
                         new City
                        {
                            Id=++cityId,
                            CountryId=countryId,
                            Name="Saint Petersburg"
                        },
                             new City
                        {
                            Id=++cityId,
                            CountryId=countryId,
                            Name="Novosibirsk"
                        },
                            new City
                        {
                            Id=++cityId,
                            CountryId=countryId,
                            Name="Yekaterinburg"
                        },
                             new City
                        {
                            Id=++cityId,
                            CountryId=countryId,
                            Name="Samara"
                        },
                             new City
                        {
                            Id=++cityId,
                            CountryId=countryId,
                            Name="Chelyabinsk"
                        },
                            new City
                        {
                            Id=++cityId,
                            CountryId=countryId,
                            Name="Rostov-on-Don"
                        },
                            new City
                        {
                            Id=++cityId,
                            CountryId=countryId,
                            Name="Voronezh"
                        }
                    }
                },
                new Country
                {
                    Id=++countryId,
                    Name="Germany",
                    Cities=new City[]
                    {
                        new City
                        {
                            Id=++cityId,
                            CountryId=countryId,
                            Name="Berlin"
                        },
                         new City
                        {
                            Id=++cityId,
                            CountryId=countryId,
                            Name="Hamburg"
                        },
                         new City
                        {
                            Id=++cityId,
                            CountryId=countryId,
                            Name="Munchen"
                        },
                         new City
                        {
                            Id=++cityId,
                            CountryId=countryId,
                            Name="Koln"
                        },
                         new City
                        {
                            Id=++cityId,
                            CountryId=countryId,
                            Name="Frankfurt"
                        },
                         new City
                        {
                            Id=++cityId,
                            CountryId=countryId,
                            Name="Essen"
                        },
                         new City
                        {
                            Id=++cityId,
                            CountryId=countryId,
                            Name="Dortmund"
                        },
                         new City
                        {
                            Id=++cityId,
                            CountryId=countryId,
                            Name="Dusseldorf"
                        },
                         new City
                        {
                            Id=++cityId,
                            CountryId=countryId,
                            Name="Bremen"
                        }
                    }
                },
                new Country
                {
                    Id=++countryId,
                    Name="Ukraine",
                    Cities=new City[]
                    {
                        new City
                        {
                            Id=++cityId,
                            CountryId=countryId,
                            Name="Kyiv"
                        },
                        new City
                        {
                            Id=++cityId,
                            CountryId=countryId,
                            Name="Lviv"
                        },
                        new City
                        {
                            Id=++cityId,
                            CountryId=countryId,
                            Name="Rivne"
                        },
                        new City
                        {
                            Id=++cityId,
                            CountryId=countryId,
                            Name="Kharkiv"
                        },
                        new City
                        {
                            Id=++cityId,
                            CountryId=countryId,
                            Name="Dnipro"
                        },
                        new City
                        {
                            Id=++cityId,
                            CountryId=countryId,
                            Name="Poltava"
                        },
                        new City
                        {
                            Id=++cityId,
                            CountryId=countryId,
                            Name="Chernihiv"
                        }
                    }
                }
            };
            builder.HasData(countries);
        }
    }
}

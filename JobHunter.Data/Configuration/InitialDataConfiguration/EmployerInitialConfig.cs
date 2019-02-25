using JobHunter.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobHunter.Data.Configuration.InitialDataConfiguration
{
    class EmployerInitialConfig : IEntityTypeConfiguration<Employer>
    {
        public void Configure(EntityTypeBuilder<Employer> builder)
        {
            int employerId = 0;
            Employer[] employers = new Employer[]
            {
                new Employer
                {
                    Id=++employerId,
                    CompanyName="SoftServe",
                    CityId=27,
                    Address="Slovatskoho, 4",
                    Description="IT-company"
                },
                 new Employer
                {
                    Id=++employerId,
                    CompanyName="Boro",
                    CityId=27,
                    Address="Soborna, 102",
                    Description="Sales-company"
                },
                 new Employer
                {
                    Id=++employerId,
                    CompanyName="Toro",
                    CityId=27,
                    Address="Soborna, 255",
                    Description="Sales-company"
                },
                  new Employer
                {
                    Id=++employerId,
                    CompanyName="Solo",
                    CityId=27,
                    Address="Soborna, 177",
                    Description="Sales-company"
                },
                   new Employer
                {
                    Id=++employerId,
                    CompanyName="AB Games",
                    CityId=27,
                    Address="Slovatskoho, 4",
                    Description="IT-company"
                },
                   new Employer
                {
                    Id=++employerId,
                    CompanyName="Bodo",
                    CityId=26,
                    Address="Slovatskoho, 4",
                    Description="Sales-company"
                },
                     new Employer
                {
                    Id=++employerId,
                    CompanyName="SoftServe",
                    CityId=26,
                    Address="Sadova, 4",
                    Description="IT-company"
                },
                     new Employer
                {
                    Id=++employerId,
                    CompanyName="Ocean Galaxy Marine",
                    CityId=2,
                    Description="Factory"
                },
                      new Employer
                {
                    Id=++employerId,
                    CompanyName="Get JOB LTD",
                    CityId=1,
                    Description="Factory"
                },
                      new Employer
                {
                    Id=++employerId,
                    CompanyName="Get JOB LTD",
                    CityId=3,
                    Description="Factory"
                },
                new Employer
                {
                    Id=++employerId,
                    CompanyName="Get JOB LTD",
                    CityId=4,
                    Description="Factory"
                },
                 new Employer
                {
                    Id=++employerId,
                    CompanyName="NORIU DIRBTI Recruitment Agency",
                    CityId=23,
                    Description="Factory"
                },
                  new Employer
                {
                    Id=++employerId,
                    CompanyName="NORIU DIRBTI Recruitment Agency",
                    CityId=18,
                    Description="Factory"
                }
            };
            builder.HasData(employers);
        }
    }
}

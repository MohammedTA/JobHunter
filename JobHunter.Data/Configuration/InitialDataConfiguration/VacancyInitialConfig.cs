using JobHunter.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobHunter.Data.Configuration.InitialDataConfiguration
{
    public class VacancyInitialConfig : IEntityTypeConfiguration<Vacancy>
    {
        public void Configure(EntityTypeBuilder<Vacancy> builder)
        {
            int vacancyId = 1;
            var vacancies = new Vacancy[]
            {
                new Vacancy
                {
                    Id=vacancyId++,
                    Name="FrontEnd developer",
                    Description="work with HTML5, Sass, angular7",
                    CreationDate=new System.DateTime(2019, 1, 18),
                    AgreementSpam=true,
                    ExpirationDate= new System.DateTime(2019,3, 21 ),
                    Salary=15000,
                    Gender=1,
                    Visa=false
                },
                    new Vacancy
                {
                    Id=vacancyId++,
                    Name="FrontEnd developer",
                    Description="work with HTML5, Sass, angular7",
                    CreationDate=new System.DateTime(2019, 2, 18),
                    AgreementSpam=true,
                    ExpirationDate= new System.DateTime(2019,3, 21 ),
                    Salary=16000,
                    Gender=1,
                    Visa=false
                }
            };
            builder.HasData(vacancies);
        }
    }
}

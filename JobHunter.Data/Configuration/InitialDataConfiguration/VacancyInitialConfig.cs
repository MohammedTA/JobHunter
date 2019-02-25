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
                    EmployerId=1,
                    Salary=15000,
                    Gender=1,
                    Visa=false
                },    
                new Vacancy
                {
                    Id=vacancyId++,
                    Name=".NET developer",
                    Description="work with .NET, SQL",
                    CreationDate=new System.DateTime(2019, 2, 18),
                    AgreementSpam=true,
                    ExpirationDate= new System.DateTime(2019,3, 21 ),
                    EmployerId=1,
                    Salary=16000,
                    Gender=1,
                    Visa=false
                },
                   new Vacancy
                {
                    Id=vacancyId++,
                    Name="FrontEnd developer",
                    Description="work with HTML5, Sass, angular7",
                    CreationDate=new System.DateTime(2019, 1, 18),
                    AgreementSpam=true,
                    ExpirationDate= new System.DateTime(2019,3, 21 ),
                    EmployerId=7,
                    Salary=15000,
                    Gender=1,
                    Visa=false
                },
                new Vacancy
                {
                    Id=vacancyId++,
                    Name=".NET developer",
                    Description="work with .NET, SQL",
                    CreationDate=new System.DateTime(2019, 2, 18),
                    AgreementSpam=true,
                    ExpirationDate= new System.DateTime(2019,3, 21 ),
                    EmployerId=7,
                    Salary=16000,
                    Gender=0,
                    Visa=false
                },
                 new Vacancy
                {
                    Id=vacancyId++,
                    Name="New business manager",
                    Description="work with clients, gave them full info about products and support",
                    CreationDate=new System.DateTime(2019, 2, 18),
                    AgreementSpam=true,
                    ExpirationDate= new System.DateTime(2019,3, 21 ),
                    EmployerId=2,
                    Salary=12000,
                    Gender=1,
                    Visa=false
                },
                 new Vacancy
                {
                    Id=vacancyId++,
                    Name="New business manager",
                    Description="work with clients, gave them full info about products and support",
                    CreationDate=new System.DateTime(2019, 2, 18),
                    AgreementSpam=true,
                    ExpirationDate= new System.DateTime(2019,3, 21 ),
                    EmployerId=2,
                    Salary=12000,
                    Gender=2,
                    Visa=false
                },
                 new Vacancy
                {
                    Id=vacancyId++,
                    Name="New business manager",
                    Description="work with clients, gave them full info about products and support",
                    CreationDate=new System.DateTime(2019, 2, 18),
                    AgreementSpam=true,
                    ExpirationDate= new System.DateTime(2019,3, 21 ),
                    EmployerId=3,
                    Salary=12000,
                    Gender=1,
                    Visa=false
                },
                 new Vacancy
                {
                    Id=vacancyId++,
                    Name="New business manager",
                    Description="work with clients, gave them full info about products and support",
                    CreationDate=new System.DateTime(2019, 2, 18),
                    AgreementSpam=true,
                    ExpirationDate= new System.DateTime(2019,3, 21 ),
                    EmployerId=3,
                    Salary=11000,
                    Gender=2,
                    Visa=false
                },
                 new Vacancy
                {
                    Id=vacancyId++,
                    Name="New business manager",
                    Description="work with clients, gave them full info about products and support",
                    CreationDate=new System.DateTime(2019, 2, 18),
                    AgreementSpam=true,
                    ExpirationDate= new System.DateTime(2019,3, 21 ),
                    EmployerId=4,
                    Salary=9000,
                    Gender=1,
                    Visa=false
                },
                 new Vacancy
                {
                    Id=vacancyId++,
                    Name="New business manager",
                    Description="work with clients, gave them full info about products and support",
                    CreationDate=new System.DateTime(2019, 2, 18),
                    AgreementSpam=true,
                    ExpirationDate= new System.DateTime(2019,3, 21 ),
                    EmployerId=4,
                    Salary=10000,
                    Gender=1,
                    Visa=false
                },
                 new Vacancy
                {
                    Id=vacancyId++,
                    Name="Unity3D Game developer",
                    Description="create modern apps with Unity 3D game engine",
                    CreationDate=new System.DateTime(2019, 2, 18),
                    AgreementSpam=true,
                    ExpirationDate= new System.DateTime(2019,3, 21 ),
                    EmployerId=5,
                    Salary=12000,
                    Gender=1,
                    Visa=false
                },
                 new Vacancy
                {
                    Id=vacancyId++,
                    Name="Unity3D Game developer",
                    Description="create modern apps with Unity 3D game engine",
                    CreationDate=new System.DateTime(2019, 2, 18),
                    AgreementSpam=true,
                    ExpirationDate= new System.DateTime(2019,3, 21 ),
                    EmployerId=5,
                    Salary=16000,
                    Gender=2,
                    Visa=false
                },
                 new Vacancy
                {
                    Id=vacancyId++,
                    Name="Masters",
                    Description="Rough laying blocks, brick Concreting of armopoyas, crossing points",
                    CreationDate=new System.DateTime(2019, 2, 18),
                    AgreementSpam=true,
                    ExpirationDate= new System.DateTime(2019,3, 21 ),
                    EmployerId=9,
                    Salary=20000,
                    Gender=1,
                    Visa=true
                },
                  new Vacancy
                {
                    Id=vacancyId++,
                    Name="Masters",
                    Description="Rough laying blocks, brick Concreting of armopoyas, crossing points",
                    CreationDate=new System.DateTime(2019, 2, 18),
                    AgreementSpam=true,
                    ExpirationDate= new System.DateTime(2019, 3, 21 ),
                    EmployerId=8,
                    Salary=15000,
                    Gender=1,
                    Visa=true
                },
                   new Vacancy
                {
                    Id=vacancyId++,
                    Name="Masters",
                    Description="Rough laying blocks, brick Concreting of armopoyas, crossing points",
                    CreationDate=new System.DateTime(2019, 2, 18),
                    AgreementSpam=true,
                    ExpirationDate= new System.DateTime(2019, 5, 21 ),
                    EmployerId=8,
                    Salary=18000,
                    Gender=2,
                    Visa=true
                },
                    new Vacancy
                {
                    Id=vacancyId++,
                    Name="Masters",
                    Description="Rough laying blocks, brick Concreting of armopoyas, crossing points",
                    CreationDate=new System.DateTime(2019, 2, 18),
                    AgreementSpam=true,
                    ExpirationDate= new System.DateTime(2019, 5, 21 ),
                    EmployerId=9,
                    Salary=17000,
                    Gender=2,
                    Visa=true
                },
                      new Vacancy
                {
                    Id=vacancyId++,
                    Name="Masters",
                    Description="Rough laying blocks, brick Concreting of armopoyas, crossing points",
                    CreationDate=new System.DateTime(2019, 1, 18),
                    AgreementSpam=true,
                    ExpirationDate= new System.DateTime(2019, 4, 21 ),
                    EmployerId=9,
                    Salary=22000,
                    Gender=1,
                    Visa=true
                },
                        new Vacancy
                {
                    Id=vacancyId++,
                    Name="Masters",
                    Description="Rough laying blocks, brick Concreting of armopoyas, crossing points",
                    CreationDate=new System.DateTime(2019, 1, 18),
                    AgreementSpam=true,
                    ExpirationDate= new System.DateTime(2019, 4, 21 ),
                    EmployerId=9,
                    Salary=24000,
                    Gender=1,
                    Visa=true
                },
                      new Vacancy
                {
                    Id=vacancyId++,
                    Name="Masters",
                    Description="Rough laying blocks, brick Concreting of armopoyas, crossing points",
                    CreationDate=new System.DateTime(2019, 1, 18),
                    AgreementSpam=true,
                    ExpirationDate= new System.DateTime(2019, 4, 21 ),
                    EmployerId=9,
                    Salary=23000,
                    Gender=1,
                    Visa=true
                },
                       new Vacancy
                {
                    Id=vacancyId++,
                    Name="Masters",
                    Description="Rough laying blocks, brick Concreting of armopoyas, crossing points",
                    CreationDate=new System.DateTime(2019, 2, 18),
                    AgreementSpam=true,
                    ExpirationDate= new System.DateTime(2019, 5, 21 ),
                    EmployerId=7,
                    Salary=19000,
                    Gender=1,
                    Visa=true
                },
                        new Vacancy
                {
                    Id=vacancyId++,
                    Name="Masters",
                    Description="Rough laying blocks, brick Concreting of armopoyas, crossing points",
                    CreationDate=new System.DateTime(2019, 2, 18),
                    AgreementSpam=true,
                    ExpirationDate= new System.DateTime(2019, 5, 21 ),
                    EmployerId=7,
                    Salary=16000,
                    Gender=2,
                    Visa=true
                },
                      new Vacancy
                {
                    Id=vacancyId++,
                    Name="New business manager",
                    Description="work with clients, gave them full info about products and support",
                    CreationDate=new System.DateTime(2019, 2, 18),
                    AgreementSpam=true,
                    ExpirationDate= new System.DateTime(2019,4, 21 ),
                    EmployerId=4,
                    Salary=13000,
                    Gender=1,
                    Visa=false
                },
                       new Vacancy
                {
                    Id=vacancyId++,
                    Name="New business manager",
                    Description="work with clients, gave them full info about products and support",
                    CreationDate=new System.DateTime(2019, 1, 18),
                    AgreementSpam=true,
                    ExpirationDate= new System.DateTime(2019,5, 21 ),
                    EmployerId=4,
                    Salary=11000,
                    Gender=2,
                    Visa=false
                },
                        new Vacancy
                {
                    Id=vacancyId++,
                    Name="New business manager",
                    Description="work with clients, gave them full info about products and support",
                    CreationDate=new System.DateTime(2019, 2, 18),
                    AgreementSpam=true,
                    ExpirationDate= new System.DateTime(2019,3, 21 ),
                    EmployerId=4,
                    Salary=10000,
                    Gender=1,
                    Visa=false
                },
                         new Vacancy
                {
                    Id=vacancyId++,
                    Name="New business manager",
                    Description="work with clients, gave them full info about products and support",
                    CreationDate=new System.DateTime(2019, 2, 18),
                    AgreementSpam=true,
                    ExpirationDate= new System.DateTime(2019,3, 21 ),
                    EmployerId=2,
                    Salary=8000,
                    Gender=1,
                    Visa=false
                },
            };
            builder.HasData(vacancies);
        }
    }
}

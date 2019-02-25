using JobHunter.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobHunter.Data.Configuration.InitialDataConfiguration
{
    class VacancyStatusInitialConfig : IEntityTypeConfiguration<VacancyStatus>
    {
        public void Configure(EntityTypeBuilder<VacancyStatus> builder)
        {
            VacancyStatus[] statuses = new VacancyStatus[]
            {
                new VacancyStatus
                {
                    VacancyId=1,
                    StatusId=1,
                },
                 new VacancyStatus
                {
                    VacancyId=1,
                    StatusId=2,
                },
                new VacancyStatus
                {
                    VacancyId=2,
                    StatusId=1,
                },
                new VacancyStatus
                {
                    VacancyId=3,
                    StatusId=1,
                },
                new VacancyStatus
                {
                    VacancyId=4,
                    StatusId=1,
                },
                new VacancyStatus
                {
                    VacancyId=5,
                    StatusId=1,
                },
                new VacancyStatus
                {
                    VacancyId=6,
                    StatusId=1,
                },
                 new VacancyStatus
                {
                    VacancyId=6,
                    StatusId=2,
                },
                  new VacancyStatus
                {
                    VacancyId=8,
                    StatusId=1,
                },
                new VacancyStatus
                {
                    VacancyId=9,
                    StatusId=1,
                },
                  new VacancyStatus
                {
                    VacancyId=13,
                    StatusId=1,
                },
                   new VacancyStatus
                {
                    VacancyId=13,
                    StatusId=2,
                },
                new VacancyStatus
                {
                    VacancyId=14,
                    StatusId=1,
                },
                  new VacancyStatus
                {
                    VacancyId=18,
                    StatusId=1,
                },
                new VacancyStatus
                {
                    VacancyId=19,
                    StatusId=1,
                },
                new VacancyStatus
                {
                    VacancyId=19,
                    StatusId=2,
                },
                  new VacancyStatus
                {
                    VacancyId=23,
                    StatusId=1,
                },
                new VacancyStatus
                {
                    VacancyId=24,
                    StatusId=1,
                },
            };
            builder.HasData(statuses);
        }
    }
}

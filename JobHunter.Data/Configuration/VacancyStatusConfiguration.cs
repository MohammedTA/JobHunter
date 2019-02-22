using JobHunter.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobHunter.Data.Configuration
{
    public class VacancyStatusConfiguration : IEntityTypeConfiguration<VacancyStatus>
    {
        public void Configure(EntityTypeBuilder<VacancyStatus> builder)
        {
            builder.HasKey(x => new { x.VacancyId, x.StatusId });
            builder.HasOne(x => x.Vacancy).WithMany(x => x.VacancyStatuses).HasForeignKey(x=>x.VacancyId);
            builder.HasOne(x => x.Status).WithMany(x => x.VacancyStatuses).HasForeignKey(x => x.StatusId);
        }
    }
}

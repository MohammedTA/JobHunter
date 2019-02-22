
namespace JobHunter.Data.Entities
{
    public class VacancyStatus
    {
        public int VacancyId { get; set; }
        public int StatusId { get; set; }
        public virtual Vacancy Vacancy { get; set; }
        public virtual Status Status { get; set; }
    }
}

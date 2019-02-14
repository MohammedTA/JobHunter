namespace JobHunter.Domain.Models.PaginationModels
{
    public class PaginationModel
    {
        public int CurrentPage { get; set; } = 1;
        public int PageSize { get; set; } = 5;
    }
}

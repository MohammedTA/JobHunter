namespace JobHunter.Domain.Models.PaginationModels
{
    public class PaginationParamsModel
    {
        private const int DEFAULT_PAGE = 1;
        private const int PAGE_SIZE = 5;
        public int CurrentPage { get; set; } = DEFAULT_PAGE;
        public int PageSize { get; set; } = PAGE_SIZE;
    }
}

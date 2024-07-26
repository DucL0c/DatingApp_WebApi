namespace api.Helper
{
    public class PaginationHeader
    {
        public PaginationHeader(int currentPage, int pageSize, int totalCounts, int totalPages)
        {
            CurrentPage = currentPage;
            PageSize = pageSize;
            TotalCounts = totalCounts;
            TotalPages = totalPages;
        }

        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalCounts { get; set; }
        public int TotalPages {  get ; set; }
    }
}

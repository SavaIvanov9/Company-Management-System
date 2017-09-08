namespace CompanyManagementSystem.Services.Models
{
    using System.Linq;

    public class PagingModel<T>
    {
        public IQueryable<T> Page { get; set; }
        public int ItemsPerPage { get; set; }
        public int PageNumber { get; set; }
        public int TotalPagesCount { get; set; }
        public int TotalItemsCount { get; set; }
    }
}

namespace CompanyManagementSystem.Services
{
    using Abstraction;
    using Models;
    using System.Linq;

    public class PagingService : IPagingService
    {
        public PagingModel<T> ApplyPaging<T>(IQueryable<T> collection, int itemsPerPage, int pageNumber)
        {
            var page = collection
                .Skip((pageNumber - 1) * itemsPerPage)
                .Take(itemsPerPage);

            var result = new PagingModel<T>()
            {
                Page = page,
                ItemsPerPage = itemsPerPage,
                PageNumber = pageNumber,
                TotalPagesCount = collection.Count() / itemsPerPage,
                TotalItemsCount = collection.Count()
            };

            return result;
        }
    }
}

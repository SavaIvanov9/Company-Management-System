namespace CompanyManagementSystem.Services.Abstraction
{
    using Models;
    using System.Linq;

    public interface IPagingService
    {
        PagingModel<T> ApplyPaging<T>(IQueryable<T> collection, int itemsPerPage, int pageNumber);
    }
}

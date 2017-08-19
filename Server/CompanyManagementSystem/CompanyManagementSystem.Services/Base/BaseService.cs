namespace CompanyManagementSystem.Services.Base
{
    using Data.Abstraction;

    public abstract class BaseService
    {
        protected internal readonly IUnitOfWork data;

        protected BaseService(IUnitOfWork data)
        {
            this.data = data;
        }
    }
}

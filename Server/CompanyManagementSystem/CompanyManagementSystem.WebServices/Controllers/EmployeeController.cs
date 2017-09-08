namespace CompanyManagementSystem.WebServices.Controllers
{
    using System.Linq;
    using Abstraction;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Routing;
    using Services.Abstraction;

    public class EmployeeController : BaseController
    {
        private readonly IEmployeeService service;
        private readonly IPagingService pager;
        
        public EmployeeController(IEmployeeService service, IPagingService pager)
        {
            this.service = service;
            this.pager = pager;
        }

        [HttpGet]
        public IActionResult Get(int itemsPerPage, int pageNumber)
        {
            var data = this.service.GetAll();
            var result = this.pager.ApplyPaging(data, itemsPerPage, pageNumber);

            return this.Ok(result);
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = this.service
                .GetAll()
                .ToList();

            return this.Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var result = this.service.GetById(id);

            return this.Ok(result);
        }
    }
}

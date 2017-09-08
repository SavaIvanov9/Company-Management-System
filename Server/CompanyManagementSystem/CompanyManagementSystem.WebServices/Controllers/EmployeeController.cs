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

        public EmployeeController(IEmployeeService service)
        {
            this.service = service;
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

namespace CompanyManagementSystem.WebServices.Controllers
{
    using Abstraction;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Routing;
    using Services.Abstraction;

    [Route("api/[controller]")]
    public class EmployeeController : Controller//: BaseController
    {
        private readonly IEmployeeService service;

        public EmployeeController(IEmployeeService service)
        {
            this.service = service;
        }

        [HttpGet]
        //[Route("api/Employee/GetAll")]
        public IActionResult Get()
        {
            var result = this.service.GetAll();

            return this.Ok(result);
        }
    }
}

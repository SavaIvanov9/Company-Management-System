namespace CompanyManagementSystem.WebServices.Controllers
{
    using Abstraction;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;
    using Services.Abstraction;
    using System.Linq;

    [EnableCors("MyPolicy")]
    [Route("api/[controller]")]
    public class EmployeeController : BaseController
    {
        private readonly IEmployeeService service;
        private readonly IPagingService pager;

        public EmployeeController(IEmployeeService service, IPagingService pager, ICookieService cookieService)
            : base(cookieService)
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
            var coockieVallidationResult = this.ValidateCoockie();

            if (coockieVallidationResult != null)
            {
                return coockieVallidationResult;
            }

            var result = this.service.GetById(id);

            return this.Ok(result);
        }

        [HttpGet("GetEmployeesByTeam")]
        public IActionResult GetEmployeesByTeam(long id)
        {
            var result = this.service.GetEmployeesByTeam(id).ToList();

            return this.Ok(result);
        }

        [HttpGet("GetEmployeesByDepartment")]
        public IActionResult GetEmployeesByDepartment(long id)
        {
            var result = this.service.GetEmployeesByDepartment(id).ToList();

            return this.Ok(result);
        }
    }
}

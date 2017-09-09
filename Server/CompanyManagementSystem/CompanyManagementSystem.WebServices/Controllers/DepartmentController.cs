namespace CompanyManagementSystem.WebServices.Controllers
{
    using Abstraction;
    using Microsoft.AspNetCore.Mvc;
    using Services.Abstraction;
    using System.Linq;
    using Microsoft.AspNetCore.Cors;

    [EnableCors("MyPolicy")]
    [Route("api/[controller]")]
    public class DepartmentController : BaseController
    {
        private readonly IDepartmentService service;
        private readonly IPagingService pager;

        public DepartmentController(IDepartmentService service, IPagingService pager)
        {
            this.service = service;
            this.pager = pager;
        }

        [HttpGet("Page")]
        public IActionResult Get(int itemsPerPage, int pageNumber)
        {
            var data = this.service.GetAll();
            var result = this.pager.ApplyPaging(data, itemsPerPage, pageNumber);

            return this.Ok(result);
        }

        //[HttpGet("GetAll")]
        [HttpGet]
        public IActionResult Get()
        {
            var result = this.service
                .GetAll()
                //.Select(x => new
                //{
                //    a = 1
                //})
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

namespace CompanyManagementSystem.WebServices.Controllers
{
    using Abstraction;
    using Microsoft.AspNetCore.Mvc;
    using Services.Abstraction;
    using System.Linq;

    public class TeamController : BaseController
    {
        private readonly ITeamService service;
        private readonly IPagingService pager;

        public TeamController(ITeamService service, IPagingService pager)
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
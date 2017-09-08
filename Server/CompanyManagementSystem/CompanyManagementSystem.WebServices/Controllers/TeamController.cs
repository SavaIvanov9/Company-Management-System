namespace CompanyManagementSystem.WebServices.Controllers
{
    using Abstraction;
    using Microsoft.AspNetCore.Mvc;
    using Services.Abstraction;
    using System.Linq;

    public class TeamController : BaseController
    {
        private readonly ITeamService service;

        public TeamController(ITeamService service)
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
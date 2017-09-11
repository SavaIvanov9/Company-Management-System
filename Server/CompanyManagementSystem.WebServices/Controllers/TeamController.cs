namespace CompanyManagementSystem.WebServices.Controllers
{
    using Abstraction;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;
    using Services.Abstraction;
    using System.Linq;
    using System.Net.Http;
    using Data.Abstraction;
    using Newtonsoft.Json;
    using Services.Models;

    [EnableCors("MyPolicy")]
    [Route("api/[controller]")]
    public class TeamController : BaseController
    {
        private readonly ITeamService service;
        private readonly IPagingService pager;

        public TeamController(ITeamService service, IPagingService pager,
            IEncryptionService encryptor, IUnitOfWork data) : base(data, encryptor)
        {
            this.service = service;
            this.pager = pager;
        }

        [HttpGet("GetPage")]
        public IActionResult Get(int itemsPerPage, int pageNumber)
        {
            var authResult = this.IsAuthorized();
            if (authResult != null)
            {
                return this.IsAuthorized();
            }

            var data = this.service.GetAll();
            var result = this.pager.ApplyPaging(data, itemsPerPage, pageNumber);

            return this.Ok(result);
        }

        [HttpGet]
        public IActionResult Get()
        {
            var authResult = this.IsAuthorized();
            if (authResult != null)
            {
                return this.IsAuthorized();
            }

            var result = this.service
                .GetAll()
                .ToList();

            return this.Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var authResult = this.IsAuthorized();
            if (authResult != null)
            {
                return this.IsAuthorized();
            }

            var result = this.service.GetById(id);

            return this.Ok(result);
        }

        [HttpGet("GetByDepartment")]
        public IActionResult Get(int departmentId)
        {
            var authResult = this.IsAuthorized();
            if (authResult != null)
            {
                return this.IsAuthorized();
            }

            var result = this.service.GetTeamsByDepartment(departmentId);

            return this.Ok(result);
        }

        [HttpPost()]
        public IActionResult Post([FromBody] TeamCreateModel teamData)
        {
            var authResult = this.IsAuthorized();
            if (authResult != null)
            {
                return this.IsAuthorized();
            }

            var id = this.service.CreateTeam(teamData);

            return this.Ok(id);
        }
    }
}
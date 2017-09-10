namespace CompanyManagementSystem.WebServices.Controllers
{
    using Abstraction;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;
    using Services.Abstraction;
    using System.Linq;
    using System.Net.Http;
    using Newtonsoft.Json;
    using Services.Models;

    [EnableCors("MyPolicy")]
    [Route("api/[controller]")]
    public class TeamController : BaseController
    {
        private readonly ITeamService service;
        private readonly IPagingService pager;

        public TeamController(ITeamService service, IPagingService pager, ICookieService cookieService)
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
            var result = this.service.GetById(id);

            return this.Ok(result);
        }

        [HttpGet("GetByDepartment")]
        public IActionResult Get(int departmentId )
        {
            var result = this.service.GetTeamsByDepartment(departmentId);

            return this.Ok(result);
        }

        //[HttpPost()]
        ////public IActionResult Post(TeamCreateModel teamData)
        //public IActionResult Post(HttpRequestMessage teamData)
        //{
        //    var data = teamData.Content.ReadAsStringAsync().Result;
        //    var r = JsonConvert.DeserializeObject<TeamCreateModel>(data);
        //    var id = this.service.CreateTeam(r);

        //    return this.Ok(id);
        //}

        [HttpPost()]
        public IActionResult Post([FromBody] TeamCreateModel teamData)
        {
            var id = this.service.CreateTeam(teamData);

            return this.Ok(id);
        }

        //[HttpPost()]
        ////public IActionResult Post([FromBody] dynamic teamData)
        //public IActionResult Post([FromBody]TeamCreateModel teamData)
        //{
        //    var name = teamData;

        //    return this.Ok(name);
        //}
    }
}
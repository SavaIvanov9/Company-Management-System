using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyManagementSystem.WebServicesApi.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Services.Abstraction;
    using Services.Models;

    [Route("api/[controller]")]
    public class TeamController : Controller
    {
        private readonly ITeamService service;
        private readonly IPagingService pager;

        public TeamController(ITeamService service, IPagingService pager)
        {
            this.service = service;
            this.pager = pager;
        }

        [HttpPost("Create")]
        public IActionResult Post(TeamCreateModel teamData)
        {
            var id = this.service.CreateTeam(teamData);

            return this.Ok(id);
        }
    }
}

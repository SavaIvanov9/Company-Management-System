namespace CompanyManagementSystem.WebServices.Controllers
{
    using System.Linq;
    using Abstraction;
    using Microsoft.AspNetCore.Mvc;
    using Services.Abstraction;

    public class PermissionController : BaseController
    {
        private readonly IPermissionService service;

        public PermissionController(IPermissionService service)
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
    }
}
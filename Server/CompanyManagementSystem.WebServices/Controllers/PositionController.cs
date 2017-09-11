namespace CompanyManagementSystem.WebServices.Controllers
{
    using Abstraction;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;
    using Services.Abstraction;
    using System.Linq;
    using Data.Abstraction;

    [EnableCors("MyPolicy")]
    [Route("api/[controller]")]
    public class PositionController : BaseController
    {
        private readonly IPositionService service;

        public PositionController(IPositionService service,
            IEncryptionService encryptor, IUnitOfWork data) : base(data, encryptor)
        {
            this.service = service;
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
    }
}
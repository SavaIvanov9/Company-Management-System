namespace CompanyManagementSystem.WebServices.Controllers.Abstraction
{
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using Services.Abstraction;

    [Route("api/[controller]")]
    public abstract class BaseController : Controller
    {
        protected readonly ICookieService cookieService;

        protected BaseController(ICookieService cookieService)
        {
            this.cookieService = cookieService;
        }

        protected IActionResult ValidateCoockie()
        {
            var cookie = this.Request.Headers.FirstOrDefault(x => x.Key == "Authorization").Value;

            if (!this.cookieService.ValidateCookie(cookie))
            {
                return this.BadRequest("Invalid cookie!");
            }

            this.cookieService.ExtendCookie(cookie);

            return null;
        }
    }
}

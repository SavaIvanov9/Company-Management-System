﻿namespace CompanyManagementSystem.WebServices.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Abstraction;
    using Data.Abstraction;
    using DbModels;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;
    using Models;
    using Services.Abstraction;
    using Services.Models;

    [EnableCors("MyPolicy")]
    [Route("api/Auth")]
    public class AuthorizationController : BaseController
    {
        //private readonly ICookieService cookieService;
        private readonly IEmployeeService employeeService;

        public AuthorizationController(/*ICookieService cookieService,*/ IEmployeeService employeeService,
            IEncryptionService encryptor, IUnitOfWork data) : base(data, encryptor)
        {
            //this.cookieService = cookieService;
            this.employeeService = employeeService;
        }

        [HttpPost("Register")]
        public IActionResult Register([FromBody]RegisterModel registerData)
        {
            var newEmployee = new Employee()
            {
                Username = registerData.Username,
                Password = registerData.Password,
                FirstName = registerData.FirstName,
                LastName = registerData.LastName,
                Age = registerData.Age,
                Email = registerData.Email,
                ManagerId = registerData.ManagerId,
                PositionId = registerData.PositionId,
                CreatedBy = "S",
            };

            var employee = this.employeeService.CreateEmployee(newEmployee, registerData.TeamIds);
            //var cookie = this.cookieService.CreateCookie(newEmployee.Username, newEmployee.Password, id);
            var cookie = this.CreateCookie(newEmployee.Username, newEmployee.Password, employee.Id);
            return this.Ok(cookie);
        }

        [HttpPost("LogIn")]
        public IActionResult LogIn([FromBody]LogInModel loginData)
        {
            var id = this.employeeService.DoesEmployeeExists(loginData.Username, loginData.Password);

            if (id <= 0)
            {
                return this.BadRequest("Incorrect username or password");
            }

            var cookie = this.CreateCookie(loginData.Username, loginData.Password, id);
            return this.Ok(cookie);
        }

        [HttpGet]
        public IActionResult GetCurrentUser()
        {
            var id = this.GetCurrentUserId();
            var user = this.employeeService.GetById(id);

            return this.Ok(user);
        }
    }
}

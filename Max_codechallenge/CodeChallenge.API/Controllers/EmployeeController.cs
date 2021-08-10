using CodeChallenge.API.Models;
using CodeChallenge.API.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeChallenge.API.Controllers
{
    [Route("api")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public EmployeeController(
            IEmployeeService employeeService)
        {
            EmployeeService = employeeService ?? throw new ArgumentNullException(nameof(employeeService));
        }

        public IEmployeeService EmployeeService { get; }

        [HttpGet]
        [Route("employees")]
        public ActionResult<IEnumerable<Employee>> GetAll()
        {
            var employees = EmployeeService.GetAll();

            return Ok(employees);
        }

        [HttpGet]
        [Route("employees/department/{departmentId}")]
        public ActionResult<IEnumerable<Employee>> GetByDepartmentId(
            Guid departmentId)
        {
            if (departmentId == Guid.Empty)
                return BadRequest("Invalid departmentId");

            var employees = EmployeeService.ListAll();

            var filteredEmployees = employees.Where(e => e.DepartmentId == departmentId);

            return Ok(filteredEmployees);
        }
    }
}
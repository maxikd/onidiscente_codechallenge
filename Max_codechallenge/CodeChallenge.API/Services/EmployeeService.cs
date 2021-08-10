using CodeChallenge.API.Repositories.Abstractions;
using CodeChallenge.API.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeChallenge.API.Services
{
    public class EmployeeService : IEmployeeService
    {
        public EmployeeService(
            IEmployeeRepository employeeRepository)
        {
            EmployeeRepository = employeeRepository ?? throw new ArgumentNullException(nameof(employeeRepository));
        }

        public IEmployeeRepository EmployeeRepository { get; }

        public IEnumerable<Models.Employee> GetAll()
        {
            return EmployeeRepository.GetAll()
                .Select(e => MapEmployee(e));
        }

        public IList<Models.Employee> ListAll()
        {
            return EmployeeRepository.ListAll()
                .Select(e => MapEmployee(e))
                .ToList();
        }

        private Models.Employee MapEmployee(
            Entities.Employee employee)
        {
            return new Models.Employee
            {
                Address = employee.Address,
                DepartmentId = employee.DepartmentId,
                FirstName = employee.FirstName,
                JobTitle = employee.JobTitle,
                LastName = employee.LastName
            };
        }
    }
}
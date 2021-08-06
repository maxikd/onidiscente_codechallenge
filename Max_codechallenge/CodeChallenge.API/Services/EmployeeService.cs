using CodeChallenge.API.Models;
using CodeChallenge.API.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeChallenge.API.Services
{
    public class EmployeeService : IEmployeeService
    {
        private List<Department> _departments;

        public EmployeeService()
        {
            _departments = new List<Department>();
            MockData();
        }

        public IEnumerable<Employee> GetAll()
        {
            return _departments.SelectMany(d => d.Employees);
        }

        public IList<Employee> ListAll()
        {
            var employees = new List<Employee>(GetAll());

            return employees;
        }

        private void MockData()
        {
            Guid admId = Guid.NewGuid(),
                 nutriId = Guid.NewGuid(),
                 techId = Guid.NewGuid();

            var ricardo = MockEmployee("Ricardo", "Valle", "CEO", "Petrópolis, RJ", admId);
            var livia = MockEmployee("Livia", "Nutri", "Nutricionista", "São Paulo, SP", nutriId);
            var caio = MockEmployee("Caio", "Bulgarelli", "CTO", "Vancouver, BC", techId);
            var erika = MockEmployee("Erika", "Lobo", "Dev", "Rio de Janeiro, RJ", techId);
            var max = MockEmployee("Maximilian", "Deister", "Dev", "Rio de Janeiro, RJ", techId);

            var adm = MockDepartment(admId, "Administração", ricardo);
            var nutri = MockDepartment(nutriId, "Nutrição", livia);
            var tech = MockDepartment(techId, "Tecnologia", caio, erika, max);

            _departments.Add(adm);
            _departments.Add(nutri);
            _departments.Add(tech);
        }

        private Department MockDepartment(
            Guid id,
            string name,
            params Employee[] employees)
        {
            var department = new Department
            {
                Id = id,
                Name = name,
                Employees = employees
            };

            return department;
        }

        private Employee MockEmployee(
            string firstName,
            string lastName,
            string job,
            string address,
            Guid departmentId)
        {
            var employee = new Employee
            {
                Address = address,
                FirstName = firstName,
                JobTitle = job,
                LastName = lastName,
                DepartmentId = departmentId
            };

            return employee;
        }
    }
}
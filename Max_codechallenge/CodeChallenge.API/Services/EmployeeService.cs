using CodeChallenge.API.Models;
using CodeChallenge.API.Services.Abstractions;
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
            var ricardo = MockEmployee("Ricardo", "Valle", "CEO", "Petrópolis, RJ");
            var livia = MockEmployee("Livia", "Nutri", "Nutricionista", "São Paulo, SP");
            var caio = MockEmployee("Caio", "Bulgarelli", "CTO", "Vancouver, BC");
            var erika = MockEmployee("Erika", "Lobo", "Dev", "Rio de Janeiro, RJ");
            var max = MockEmployee("Maximilian", "Deister", "Dev", "Rio de Janeiro, RJ");

            var adm = MockDepartment("Administração", ricardo);
            var nutri = MockDepartment("Nutrição", livia);
            var tech = MockDepartment("Tecnologia", caio, erika, max);

            _departments.Add(adm);
            _departments.Add(nutri);
            _departments.Add(tech);
        }

        private Department MockDepartment(
            string name,
            params Employee[] employees)
        {
            var department = new Department
            {
                Name = name,
                Employees = employees
            };

            return department;
        }

        private Employee MockEmployee(
            string firstName,
            string lastName,
            string job,
            string address)
        {
            var employee = new Employee
            {
                Address = address,
                FirstName = firstName,
                JobTitle = job,
                LastName = lastName
            };

            return employee;
        }
    }
}
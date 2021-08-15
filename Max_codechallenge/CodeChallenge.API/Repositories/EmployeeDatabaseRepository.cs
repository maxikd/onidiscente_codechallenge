using CodeChallenge.API.Entities;
using CodeChallenge.API.Repositories.Abstractions;
using System.Collections.Generic;
using System.Linq;

namespace CodeChallenge.API.Repositories
{
    public class EmployeeDatabaseRepository : IEmployeeRepository
    {
        public IEnumerable<Employee> GetAll()
        {
            return Enumerable.Empty<Employee>();
        }

        public IList<Employee> ListAll()
        {
            return new List<Employee>();
        }
    }
}
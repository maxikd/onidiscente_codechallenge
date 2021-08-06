using CodeChallenge.API.Entities;
using System.Collections.Generic;

namespace CodeChallenge.API.Repositories.Abstractions
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        IList<Employee> ListAll();
    }
}
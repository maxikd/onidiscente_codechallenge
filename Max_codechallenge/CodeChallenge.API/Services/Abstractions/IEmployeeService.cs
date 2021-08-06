using CodeChallenge.API.Models;
using System.Collections.Generic;

namespace CodeChallenge.API.Services.Abstractions
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAll();
        IList<Employee> ListAll();
    }
}
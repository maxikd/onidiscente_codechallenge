using CodeChallenge.API.Entities;
using CodeChallenge.API.Repositories.Abstractions;
using System;
using System.Collections.Generic;

namespace CodeChallenge.API.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public IEnumerable<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public IList<Employee> ListAll()
        {
            throw new NotImplementedException();
        }
    }
}
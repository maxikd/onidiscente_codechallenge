using System;
using System.Collections.Generic;

namespace CodeChallenge.API.Entities
{
    public class Department
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
    }
}
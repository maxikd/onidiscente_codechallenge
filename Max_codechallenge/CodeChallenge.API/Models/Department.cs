using System.Collections.Generic;

namespace CodeChallenge.API.Models
{
    public class Department
    {
        public string Name { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
    }
}
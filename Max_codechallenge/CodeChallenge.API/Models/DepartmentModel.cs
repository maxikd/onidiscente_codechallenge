using System.Collections.Generic;

namespace CodeChallenge.API.Models
{
    public class DepartmentModel
    {
        public string Name { get; set; }
        public IEnumerable<EmployeeModel> Employees { get; set; }
    }
}
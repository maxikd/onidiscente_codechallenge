using System;

namespace CodeChallenge.API.Entities
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string Address { get; set; }

        public Guid DepartmentId { get; set; }
    }
}
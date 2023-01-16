using System;
using System.Collections.Generic;

#nullable disable

namespace EmployeeManagerMVC.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Password { get; set; }
        public int? Deptid { get; set; }
        public int? Jobid { get; set; }

        public virtual Department Dept { get; set; }
        public virtual Job Job { get; set; }
    }
}

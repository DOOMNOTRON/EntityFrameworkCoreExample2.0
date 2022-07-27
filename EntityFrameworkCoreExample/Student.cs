using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCoreExample
{
    public class Student // Student model
    {

        [Key] // Primary Key attribute for EF Core
        public int StudentID { get; set; } // constructor


        public string FullName { get; set; }


        public int Age { get; set; }


        public DateTime DateOfBirth { get; set; }

        public string EmailAddress { get; set; }
    }
}

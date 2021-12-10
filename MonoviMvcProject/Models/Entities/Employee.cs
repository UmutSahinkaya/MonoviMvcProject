using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonoviMvcProject.Models.Entities
{
    public class Employee
    {
        public long id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Identity_Number { get; set; }
        public string Phone_Number { get; set; }

    }
}
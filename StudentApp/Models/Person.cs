using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using StudentApp.Models;

namespace StudentApp.Models
{
    public class Person : BaseClass
    {
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public string Surname { get; set; }
    }
}

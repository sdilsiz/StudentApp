using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Models
{
 

    public class Student : Person
    {
        public string SchoolNumber { get; set; }
    }


}

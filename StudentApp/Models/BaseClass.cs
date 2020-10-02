using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Models
{
    public class BaseClass
    {
        public int Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool IsDeleted { get; set; }

        //softdelete
    }

   

}

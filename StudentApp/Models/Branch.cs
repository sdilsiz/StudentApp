using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Models
{
    public class Branch : BaseClass
    {
        public string Name { get; set; }
        public bool IsRemotely { get; set; }

        public string Code { get; set; }

        public int Credit { get; set; }

        public decimal Price { 
            get { 
                return Credit * 3;
            }   

            //set

        }

        //
        //hocasi fiyati
    }
}

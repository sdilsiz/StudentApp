using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Models
{
    public class Tutor : Person
    {
        public TutorType TutorType { get; set; }


        public bool IsNative { get; set; }


        public string Branch  { get; set; }

    }

    public enum TutorType
    {
        Native, NonNative
    }




}

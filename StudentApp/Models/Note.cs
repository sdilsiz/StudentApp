using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Models
{

    [Table("NOteTablosu")]
    public class Note : BaseClass
    {


        //ogrenci ve dersin birlesmii olan bir tablo

        [ForeignKey("FK_StudentId")]
        public int StudentId { get; set; }
        public Student Student { get; set; }

        //public int StudentId { get; set; }

        //[ForeignKey(Student.Id)]


        [ForeignKey("FK_BranchId")]
        public int BranchId { get; set; }

        public Branch Branch { get; set; }

        public decimal? NoteValue { get; set; }

        //public int? NoteValue { get; set; }

        //public decimal get { get; set; }

    }
}

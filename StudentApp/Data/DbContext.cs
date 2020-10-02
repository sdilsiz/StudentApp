using Microsoft.EntityFrameworkCore;
using StudentApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Data
{
    public class MvcStudentContext : DbContext
    {
        public MvcStudentContext(DbContextOptions<MvcStudentContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Tutor> Tutor { get; set; }

        public DbSet<Note> Note { get; set; }
        public DbSet<Lesson> Lesson { get; set; }

        public DbSet<Branch> Branch { get; set; }

    }
}

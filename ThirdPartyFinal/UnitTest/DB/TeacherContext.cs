using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DB
{
   public class TeacherContext:DbContext
    {

        public DbSet<Teacher>  Teachers { get; set; }



        public TeacherContext()
        {


        }


        public TeacherContext(DbContextOptions options):base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                 optionsBuilder.UseSqlServer("Data Source=.;initial catalog=TeacherDB;integrated security=true;");
        }
    }


    public class TeacherDB : ITeacherDB
    {
        private readonly TeacherContext context;

        public TeacherDB(TeacherContext context)
        {
            this.context = context;
        }
        public void Add(Teacher teacher)
        {
            context.Teachers.Add(teacher);
            context.SaveChanges();
        }

        public Teacher GetFirst()
        {
            return context.Teachers.FirstOrDefault();
        }
    }
}

using DB;
using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Test
{
  public  class IntegrationTest
    {
        TeacherContext teacherContext;
        public IntegrationTest()
        {
            var optionBuilder = new DbContextOptionsBuilder();
            var option = optionBuilder.UseSqlServer("Data Source=.;initial catalog=TeacherDB_IntegrationTest;integrated security=true;");
            teacherContext = new TeacherContext(option.Options);
            teacherContext.Database.EnsureDeleted();
            teacherContext.Database.EnsureCreated();
        }

        [Fact]
        public void Test()
        {

            
            ITeacherDB repo = new TeacherDB(teacherContext);

            repo.Add(new Teacher { FirstName = "Ali", LastName = "Nouri" });

            var teacher = repo.GetFirst();

            Assert.Equal(teacher.FirstName, "Ali");
        }
    }
}

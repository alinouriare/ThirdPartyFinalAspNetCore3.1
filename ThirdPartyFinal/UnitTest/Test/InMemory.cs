using DB;
using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Test
{
  public  class InMemory
    {
        [Fact]
        public void Test()
        {

            var optionBuilder = new DbContextOptionsBuilder();
           
            var option = optionBuilder.UseInMemoryDatabase("UnitTest1");
            ITeacherDB repo = new TeacherDB(new TeacherContext(option.Options));

            repo.Add(new Teacher { FirstName="Ali",LastName="Nouri"});

            var teacher = repo.GetFirst();

            Assert.Equal(teacher.FirstName, "Ali");
        }
    }
}

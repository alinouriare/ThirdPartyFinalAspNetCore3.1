using System;
using System.Collections.Generic;

namespace Model
{
  public class Teacher
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }


    }

    public interface ITeacherDB
    {
        void Add(Teacher teacher);
        Teacher GetFirst();
    }
}

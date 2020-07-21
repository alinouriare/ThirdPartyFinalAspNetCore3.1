using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Performance
{

    public class Person
    {
        public int Id { get; set; }

        public string FullNmae { get; set; }
    }

    public class PersonContext:DbContext
    {
        public DbSet<Person> People { get; set; }

    }
    class Program
    {

        private static Func<PersonContext, int, Person> _compliedQuerySimple = EF.CompileQuery((PersonContext contex, int i) => contex.People.Skip(i).First());


       
        static void Main(string[] args)
        {
            var dbcontext = new PersonContext();

            for (int i = 0; i < 1000; i++)
            {
                Person p = new Person { 
                
                FullNmae=i.ToString()
                };

                dbcontext.Add(p);
               // dbcontext.SaveChanges();
            }

            dbcontext.SaveChanges();

        }
    }
}

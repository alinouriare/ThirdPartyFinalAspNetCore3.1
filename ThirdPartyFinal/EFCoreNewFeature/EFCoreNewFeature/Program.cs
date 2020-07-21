using EFCoreNewFeature.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EFCoreNewFeature
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PersonContext();

            //var person = new Person
            //{

            //    Addresses = new System.Collections.Generic.List<Address> {

            //new Address{PhoneNumber="09359504672"},
            //new Address{ PhoneNumber="4585966833"}
            //},
            //    FirstName = "Ali",
            //    LastName = "Nouri"
            //};

            //context.People.Add(person);
            //context.SaveChanges();

            var address1= context.People.ToList();
            //var aaa = context.Entry(Address).

            var address = context.People.Include(p => p.Addresses).ToList();

  //ctx.People.FromSqlRaw("")
            //ctx.People.FromSqlInterpolated("");

            var adddress = ctx.Address.Include(c => c.Person).AsNoTracking().ToList();
            bool result = ReferenceEquals(adddress[0]?.Person, adddress[1]?.Person);
            Console.WriteLine("Hello World!");
        }
    }
}

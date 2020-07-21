using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace DappersUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Showlist();

            List<Person> people = new List<Person>();

            //upadte();

            //Insert();
            //Showlist();


            //Insert_All();
            var connection = new SqlConnection("Data Source =.; Initial Catalog = Dapper; Integrated Security = true;");

            var repository = new PersonRepository(connection);
            var ShowPersonandAddress= repository.ShowPersonandAddress();

            foreach (var item in ShowPersonandAddress)
            {
                Console.WriteLine($"id: {item.PersonId} \t FirstName: {item.FirstName} \t LastName: {item.LastName} \t addressId: {item.Address.AddressId} addressLine: {item.Address.AddressLine}");
            }

            Console.WriteLine("Press any key...");
            Console.ReadLine();
        }

        private static void Insert_All()
        {
            //var file = System.IO.File.ReadAllLines(@"C:\Users\AliNouri\Desktop\Core\ThirdPartyFinal\Dapper\DappersUI\PersonImport.txt");
            var files = System.IO.File.ReadAllLines(@"C:\Users\AliNouri\Desktop\Core\ThirdPartyFinal\Dapper\DappersUI\PersonImport.txt")
                .Select(c =>
                {
                    var tes = c.Split(',');
                    var pe = new Person { FirstName = tes[0], LastName = tes[1] };
                    return pe;
                }).ToList();


            var connection = new SqlConnection("Data Source =.; Initial Catalog = Dapper; Integrated Security = true;");

            var repository = new PersonRepository(connection);
            var people = repository.Insert_All(files);


            //List<Person> people = new List<Person>();
            //foreach (var item in file)
            //{
            //  var Te=  item.Split(',');
            //    people.Add(new Person
            //    {
            //        FirstName= Te[0],
            //        LastName= Te[1]
            //    });
            //}
        }

        private static void Insert()
        {
            Console.WriteLine("FirstName: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("LastName: ");
            string lastName = Console.ReadLine();
            var sqlConnection = new System.Data.SqlClient.SqlConnection("Data Source =.; Initial Catalog = Dapper; Integrated Security = true;");
            var personRepo = new PersonRepository(sqlConnection);

            personRepo.Insert(firstName, lastName);
        }

        private static void upadte()
        {
            Console.WriteLine("PersonId: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("FirstName: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("LastName: ");
            string lastName = Console.ReadLine();
            var sqlConnection = new System.Data.SqlClient.SqlConnection("Data Source =.; Initial Catalog = Dapper; Integrated Security = true;");
            var personRepo = new PersonRepository(sqlConnection);
            personRepo.Update(id, firstName, lastName);
            Showlist();
        }

        private static void Showlist()
        {
            var connection = new SqlConnection("Data Source =.; Initial Catalog = Dapper; Integrated Security = true;");

            var repository = new PersonRepository(connection);
            var people = repository.GetPeople();
            foreach (var item in people)
            {
                Console.WriteLine($"id: {item.PersonId} \t FirstName: {item.FirstName} \t LastName: {item.LastName}");


            }
        }
    }
}

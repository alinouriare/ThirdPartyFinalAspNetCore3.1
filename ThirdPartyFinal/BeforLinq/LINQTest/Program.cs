using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LINQTest
{

    public class Person
    {
        //private string firstName;
        //public string FirstName
        //{
        //    get
        //    {
        //        //throw new Exception();
        //        Console.WriteLine($"\t {firstName} {LastName}");
        //        return firstName;

        //    }
        //    set { firstName = value; }
        //}

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Program
    {




        static void Main(string[] args)
        {

            List<Person> developers = new List<Person>() {
            new Person{FirstName="Ali",LastName="Nouri"},
               new Person{FirstName="Reza",LastName="Akbari"},
                  //new Person{FirstName="Ali",LastName="Niazi"},
            };

            //foreach (var item in developers.Where(delegate (Person person) { return person.FirstName == "Ali"; }))
            //{
            //    Console.WriteLine(item.LastName);
            //}

            //var MyResult = developers.MyWhere(c => c.FirstName == "Ali");


            //foreach (var item in MyResult)
            //{
            //    Console.WriteLine($"FirtName: {item.FirstName} LastName: {item.LastName}");
            //}



            //var MyResult1 = developers.MyWhere1(c => c.FirstName == "Ali");


            //foreach (var item in MyResult1)
            //{
            //    Console.WriteLine($"FirtName: {item.FirstName} LastName: {item.LastName}");
            //}



            //Console.WriteLine("".PadLeft(100, '*'));
            //developers.Add(new Person { FirstName = "Ali", LastName = "Saberi" });


            //foreach (var item in MyResult)
            //{
            //    Console.WriteLine($"FirtName: {item.FirstName} LastName: {item.LastName}");
            //}





            var LinqResult = developers.Where(c => c.FirstName == "Ali");
            foreach (var item in LinqResult)
            {
                Console.WriteLine($"FirtName: {item.FirstName} LastName: {item.LastName}");
            }
            Console.WriteLine("".PadLeft(100, '*'));


            developers.Add(new Person { FirstName = "Ali", LastName = "Saberi" });

            foreach (var item in LinqResult)
            {
                Console.WriteLine($"FirtName: {item.FirstName} LastName: {item.LastName}");
            }


            Console.ReadKey();

        }

//public static bool Condition(Person person)
//{
//    return person.FirstName == "Ali";
//}

private static void ShowByLinq(string path)
{
    var Files = Directory.GetFiles(path);

    Console.WriteLine($"Count: {Files.Count()}");



}
    }
}

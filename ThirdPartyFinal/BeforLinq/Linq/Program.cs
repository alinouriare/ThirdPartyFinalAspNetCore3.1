using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    public class JoinResult
    {
        public string FullName { get; set; }
        public string CarName { get; set; }
    }
    public class Person
    {
        public int   id { get; set; }

        public string firstname { get; set; }

        public string lastname { get; set; }

        public int age { get; set; }
    }

    public class Car
    {

        public int OwnerId { get; set; }

        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            var people = System.IO.File.ReadAllLines(@"C:\Users\AliNouri\Desktop\Core\ThirdPartyFinal\BeforLinq\Linq\People.txt");
            List<Person> list = new List<Person>();

            List<Car> cars = new List<Car>() {
            new Car{OwnerId=1,Name="206" },
           new Car{OwnerId=1,Name="207" },
            new Car{OwnerId=1,Name="405" },
              new Car{OwnerId=1,Name="L90" },
            };
            foreach (var item in people)
            {
                var atr = item.Split(',');

                Person person = new Person
                {
                    id = int.Parse(atr[0]),
                    firstname=atr[1],
                    lastname=atr[2],
                    age= int.Parse(atr[3]),
                };
                list.Add(person);
            }

            var linqResult = System.IO.File.ReadAllLines(@"C:\Users\AliNouri\Desktop\Core\ThirdPartyFinal\BeforLinq\Linq\People.txt").
                Select(str => {
                    var atr = str.Split(',');

                    Person person = new Person
                    {
                        id = int.Parse(atr[0]),
                        firstname = atr[1],
                        lastname = atr[2],
                        age = int.Parse(atr[3]),
                    };
                    return person;
                }).ToList();

            var orderDEC = linqResult.OrderByDescending(c => c.age).ThenByDescending(p=>p.id).ToList();
            var order = linqResult.OrderBy(c => c.age).ThenBy(c=>c.id).ToList();

            var whereResult = linqResult.Where(c => c.id > 1 && c.firstname.Contains("h")).ToList();

            var top = linqResult.Take(2);
            var page1 = linqResult.Skip(1).Take(1);
            //true
            if (linqResult.Any(c=>c.firstname=="ali"))
            {

            }
            //false

            if (linqResult.All(c => c.firstname == "ali"))
            {

            }

            var joinResult = linqResult.Join(cars, c => c.id, car => car.OwnerId, (Person, Car) => {

                return new JoinResult
                {
                    FullName = $"{Person.firstname}, {Person.lastname}",
                    CarName = Car.Name
                };
            }).ToList();


            var resultGroupCount = linqResult.GroupBy(c => c.firstname).Count();

            var groupResult = linqResult.GroupBy(c => c.firstname, (key, g) => new { PersonId = key, Cars = g.ToList() });
            foreach (var item in groupResult)
            {

            }
            Console.WriteLine("Hello World!");
        }
    }
}

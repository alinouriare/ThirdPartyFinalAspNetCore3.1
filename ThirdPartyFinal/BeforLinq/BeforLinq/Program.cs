using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BeforLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows";

            //ShowDirectory(path);

            ShowByLinq(path);

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        private static void ShowByLinq(string path)
        {
            //var Files = Directory.GetFiles(path);

            
            //var enumrator = Files.GetEnumerator();

            List<string> s = new List<string>();
            s.Add("a");
            s.Add("b");
            s.Add("c");
            s.Add("d");

            var ww = s.GetEnumerator();

            while (ww.MoveNext())
            {
                Console.WriteLine(ww.Current);
            }


            //while (enumrator.MoveNext())
            //{
            //    Console.WriteLine(enumrator.Current) ;
            //}
            //foreach (var item in Files.OrderByDescending(c=>c.Length))
            //{
            //    Console.WriteLine(item);
            //}
        }

        private static void ShowDirectory(string path)
        {
            var Files = Directory.GetFiles(path);

            Array.Sort(Files, new StringComper());
            foreach (var item in Files)
            {
                Console.WriteLine(item);
            }
        }

        public class StringComper : IComparer
        {
            public int Compare(object x, object y)
            {
                return 1;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Linq_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Anil", "Sharma", "Abdulla", "Imran", "Siva", "Naresh", "Suresh", "Suman" };

            //Using LINQ Queries
            UsingLinqExtensions(names);
        }
        private static void UsingLinqExtensions(string[] names)
        {
            IEnumerable<string> query = names.Where(s => s.Length == 5)
                                               .OrderBy(s => s)
                                               .Select(s => s.ToUpper());

            //Select * from
            foreach (string item in query)
                Console.WriteLine(item);
            Console.Read();
        }
    }
}

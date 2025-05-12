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
            UsingAnonymousMethods(names);
        }
        private static void UsingAnonymousMethods(string[] names)
        {
            Func<string, bool> filter = delegate (string s)
            {
                //More lines of codes
                return s.Length == 5;
            };
            Func<string, string> extract = delegate (string s)
            {
                //More lines of codes
                return s;
            };
            Func<string, string> project = delegate (string s)
            {
                //More lines of codes
                return s.ToUpper();
            };
            IEnumerable<string> query = names.Where(filter)
                                             .OrderBy(extract)
                                             .Select(project);

            foreach (string item in query)
            {
                Console.WriteLine(item);
                Console.Read();
            }
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    delegate void CustomDel(string s);

    class TestClass
    {
        static void Hello(string s)
        {
            Console.WriteLine($"Hello, {s}!");
        }
    static void Goodbye(string s)
    {
        Console.WriteLine($"Goodbye, {s}!");
    }

        static void Main()
        {
        //Declare instances of the custom delegate.
        CustomDel hiDel, byeDel, multiDel,multiMinusHiDel;
            hiDel = Hello;

        //create the delegate object byeDel that references the
        //method Goodbye.
        byeDel = Goodbye;

        //The two delegates,hiDel and byeDel are combined to form multiDel.
        //MultiCast delegate- simple invocation
        multiDel = hiDel + byeDel;

        //Remove hiDel from the multicast delegate,leaving byeDel,//which calls only the method Goodbye.
        multiMinusHiDel = multiDel - hiDel;
            Console.WriteLine("Invoking delegate hiDel:");
            hiDel("A");
        Console.WriteLine("Invoking delegate byeDel:");
        byeDel("B");
        Console.WriteLine("Invoking delegate multiDel:");
        multiDel("C");
        Console.WriteLine("Invoking delegate multiMinusHiDel:");
        multiMinusHiDel("D");
    }
    }

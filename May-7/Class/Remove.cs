using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList list = new ArrayList();
        list.Add("Apple");
        list.Add(42);
        list.Add(3.14);

        list.Remove(42);  //Remove the element with 
        list.Remove(0);//Removes the element at index 0
        Console.WriteLine("Count after removal: " + list.count)


        foreach(var item in list)
        {
            Console.WriteLine(item);
        }
        Console.Read();
    }
}
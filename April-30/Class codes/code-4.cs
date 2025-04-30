//While loop

using System;

public class whileloop
{
    public static void Main(string[] args)
    {
        int i=5;
        while(i>=1) //(if we give true it will print infinite loop which is like a virus 5,4,3,2,1,0,-1,-2……)
        {
            Console.WriteLine(i);
            i--;
        }
    }
    
}
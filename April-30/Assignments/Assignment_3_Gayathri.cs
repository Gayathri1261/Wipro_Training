//Reverse a number(ex.123->321)

using System;

public class sumofdigits
{
    public static void Main(string[] args)
    {
            int num,revNum=0;
            Console.WriteLine("Enter a Number : ");
            num = int.Parse(Console.ReadLine());
            while(num>0)
            {
                int digit=num%10;
                revNum = revNum * 10 + digit;
                num = num / 10;
            }
             Console.WriteLine("Reverse of a number:"+revNum);
    }
}


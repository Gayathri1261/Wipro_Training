// See https://aka.ms/new-console-template for more information

class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        int sum = SumOfDigits(number);
        Console.WriteLine("Output: " + sum);
    }
    static int SumOfDigits(int num)
    {
        int sum = 0;
        while (num != 0) 
        {
            sum += num % 10;
            num/= 10;
        }
        return sum;

    }
}
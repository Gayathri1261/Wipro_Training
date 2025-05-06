// See https://aka.ms/new-console-template for more information

class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a number of rows:");
        int n = int.Parse(Console.ReadLine());

        for(int i=1;i<=n;i++)
        {
            for(int j=1;j<=i;j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

    }
}
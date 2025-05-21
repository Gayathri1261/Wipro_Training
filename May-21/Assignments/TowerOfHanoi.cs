using System;

class TowerOfHanoiSolver
{
    // Recursive method
    static void TowerOfHanoi(int n, char from, char to, char aux)
    {
        if (n == 1)
        {
            Console.WriteLine($"Move disk 1 from {from} to {to}");
            return;
        }
        TowerOfHanoi(n - 1, from, aux, to);
        Console.WriteLine($"Move disk {n} from {from} to {to}");

        TowerOfHanoi(n - 1, aux, to, from);
    }
    static void Main()
    {
        Console.Write("Enter the number of disks: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("\nSteps to solve Tower of Hanoi:");
        TowerOfHanoi(n, 'A', 'C', 'B'); // A = source, C = destination, B = auxiliary
    }
}

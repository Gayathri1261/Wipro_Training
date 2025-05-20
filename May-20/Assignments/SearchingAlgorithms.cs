using System;

class Program
{
    static int LinearSearch(int[] array, int key, out int comparisons)
    {
        comparisons = 0;
        for (int i = 0; i < array.Length; i++)
        {
            comparisons++;
            if (array[i] == key)
                return i;
        }
        return -1;
    }

    static int BinarySearch(int[] array, int key, out int comparisons)
    {
        int left = 0;
        int right = array.Length - 1;
        comparisons = 0;

        while (left <= right)
        {
            comparisons++;
            int mid = (left + right) / 2;

            if (array[mid] == key)
                return mid;
            else if (array[mid] < key)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1;
    }

    static void Main()
    {
        Random rand = new Random();
        int[] numbers = new int[50];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rand.Next(1, 201);
        }

        Array.Sort(numbers);
        int key = numbers[rand.Next(numbers.Length)];

        Console.WriteLine("Sorted Array:");
        Console.WriteLine(string.Join(", ", numbers));
        Console.WriteLine("Search Key: " + key);
        Console.WriteLine();

        int linearComparisons;
        int linearResult = LinearSearch(numbers, key, out linearComparisons);
        Console.WriteLine("Linear Search Result:");
        Console.WriteLine("Position: " + linearResult);
        Console.WriteLine("Comparisons: " + linearComparisons);
        Console.WriteLine();

        int binaryComparisons;
        int binaryResult = BinarySearch(numbers, key, out binaryComparisons);
        Console.WriteLine("Binary Search Result:");
        Console.WriteLine("Position: " + binaryResult);
        Console.WriteLine("Comparisons: " + binaryComparisons);
    }
}

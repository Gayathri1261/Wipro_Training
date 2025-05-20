using System;

class SearchingComparison
{
    // Linear Search
    static int LinearSearch(int[] arr, int key, out int comparisons)
    {
        comparisons = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            comparisons++;
            if (arr[i] == key)
                return i;
        }
        return -1;
    }
    // Binary Search
    static int BinarySearch(int[] arr, int key, out int comparisons)
    {
        int left = 0;
        int right = arr.Length - 1;
        comparisons = 0;

        while (left <= right)
        {
            comparisons++;
            int mid = left + (right - left) / 2;

            if (arr[mid] == key)
                return mid;
            else if (arr[mid] < key)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1;
    }

    // Main Method
    static void Main()
    {
        Random rand = new Random();
        int[] sortedArray = new int[50];
        for (int i = 0; i < sortedArray.Length; i++)
        {
            sortedArray[i] = rand.Next(1, 201);
        }

        Array.Sort(sortedArray); // Ensure the array is sorted
        int searchKey = sortedArray[rand.Next(0, sortedArray.Length)]; // Pick a random element to search for

        Console.WriteLine("Sorted Array: " + string.Join(", ", sortedArray));
        Console.WriteLine("Search Key: " + searchKey);
        Console.WriteLine();

        // Linear Search
        int linearComparisons;
        int linearIndex = LinearSearch(sortedArray, searchKey, out linearComparisons);
        Console.WriteLine($"Linear Search: Position = {linearIndex}, Comparisons = {linearComparisons}");

        // Binary Search
        int binaryComparisons;
        int binaryIndex = BinarySearch(sortedArray, searchKey, out binaryComparisons);
        Console.WriteLine($"Binary Search: Position = {binaryIndex}, Comparisons = {binaryComparisons}");
    }
}

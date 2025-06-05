
	//2. Count frequency of each element
	//->For {1,2,1,3,2,1}
	//Output:
	//1 occurs 3 times
	//2 occurs 2 times
    //3 occurs 1 time


using System;

public class FrequencyCount
{
    static void Main()
    {
        int[] numbers = { 1, 2, 1, 3, 2, 1 };

        for (int i = 0; i < numbers.Length; i++)
        {
            int count = 0;
            int alreadyCounted = 0;

            // Check if the number has already been printed
            for (int k = 0; k < i; k++)
            {
                if (numbers[i] == numbers[k])
                {
                    alreadyCounted = 1;
                    break;
                }
            }

            if (alreadyCounted == 1)
                continue;

            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[i] == numbers[j])
                {
                    count++;
                }
            }

            Console.WriteLine($"{numbers[i]} occurs {count} time{(count > 1 ? "s" : "")}");
        }
    }
}

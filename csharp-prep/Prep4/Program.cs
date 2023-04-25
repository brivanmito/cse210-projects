using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize the variable called number in -1, so
        // we can use the while loop.
        int number = -1;
        List<int> numbers = new List<int>();
        float sum = 0;
        float average = 0;
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        // Asking the user for a series 
        // of numbers until the user enter
        // 0 (zero)
        while(number != 0)
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            // Append the numbers in the List only if the number
            // is different than 0 (zero)
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        // Adding the number contained in numbers list
        foreach(int num in numbers)
        {
            sum += num;
        }
        //Computing the average
        average = sum / numbers.Count;
        // ------Strecth Challenges ----
        //Find the largest number
        int majorNumber = numbers[0];
        for(int num = 0; num < numbers.Count; num++)
        {
            if(numbers[num] > majorNumber)
            {
                majorNumber = numbers[num];
            }
        }
        //Find the smallest positive number
        int minorNumber = numbers[0];
        for(int num = 0; num < numbers.Count; num++)
        {
            // I added an opcional condition that checks if a number in a list is major than 0
            if((numbers[num] < majorNumber) & numbers[num] > 0)
            {
                minorNumber = numbers[num];
            }
        }
        //Sorting list
        numbers.Sort();
        //Printing the results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {majorNumber}");
        Console.WriteLine($"The smallest positive number is: {minorNumber}");
        Console.WriteLine($"The sorted list is: ");
        foreach(int num in numbers)
        {
            Console.WriteLine(num);
        }

    }
}
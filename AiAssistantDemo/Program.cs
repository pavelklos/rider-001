// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, Dometrain!");

/// <summary>
/// A class that prints numbers from 1 to 100 following the FizzBuzz rules:
/// - Print "FizzBuzz" if number is divisible by both 3 and 5
/// - Print "Fizz" if number is divisible by 3
/// - Print "Buzz" if number is divisible by 5  
/// - Print the number itself otherwise
/// </summary>
public class FizzBuzzPrinter
{
    /// <summary>
    /// Prints FizzBuzz sequence from 1 to 100
    /// </summary>
    public void Print()
    {
        for (var i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0) // Check if divisible by both 3 and 5
                Console.WriteLine("FizzBuzz");
            else if (i % 3 == 0) // Check if divisible by 3
                Console.WriteLine("Fizz");
            else if (i % 5 == 0) // Check if divisible by 5
                Console.WriteLine("Buzz");
            else // If not divisible by 3 or 5, print the number
                Console.WriteLine(i);
        }
    }
}

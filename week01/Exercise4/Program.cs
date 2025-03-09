using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
    List <int> numbers = new List<int>();
    int total = 0;
    int number = -1;
    Console.WriteLine("Enter a list of numbers, type 0 when finished.");
    while (number != 0)
    {
      Console.Write("Enter a number: ");
      number = int.Parse(Console.ReadLine());
      if (number != 0)
      {
          numbers.Add(number);
          total += number;
      }
    }
    float avarage = ((float)total) / numbers.Count;
    // find the maximum number
    int max = numbers[0];
    for (int i = 1; i < numbers.Count; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
    }
    Console.WriteLine($"The sum is: {total}");
    Console.WriteLine($"The avarage is: {avarage}");
    Console.WriteLine($"The largest number is: {max}");

    }
}
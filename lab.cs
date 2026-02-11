using System;

class Program
{
  static void Main()
  {
    Console.Write("Enter base: ");
    string baseInput = Console.ReadLine();
    if (!int.TryParse(baseInput, out int baseNumber) || baseNumber <= 0)
    {
      Console.WriteLine("Error: Base must be a natural number (positive integer).");
      return;
    }

    Console.Write("Enter exponent: ");
    string exponentInput = Console.ReadLine();
    if (!int.TryParse(exponentInput, out int exponent) || exponent <= 0)
    {
      Console.WriteLine("Error: Exponent must be a natural number (positive integer).");
      return;
    }

    int powerResult = 1;
    for (int index = 0; index < exponent; ++index)
    {
      powerResult *= baseNumber;
    }

    Console.WriteLine($"Result: {powerResult}");

    Console.Write("\nEnter a number (x >= 100): ");
    string inputNumber = Console.ReadLine();

    if (inputNumber.Length < 3)
    {
      Console.WriteLine("Error: Number must be at least 100 (3 digits or more).");
      return;
    }

    const int secondDigitIndex = 1;
    char secondDigit = inputNumber[secondDigitIndex];
    string modifiedNumber = inputNumber.Remove(secondDigitIndex, 1) + secondDigit;

    Console.WriteLine($"Result: {modifiedNumber}");
  }
}
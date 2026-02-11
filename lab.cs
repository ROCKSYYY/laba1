using System;

class Program
{
    static void Main()
    {
        //задача 1
        Console.Write("Введите a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());
        int result = 1;
        
        for (int i = 0; i < n; i++)
        {
            result *= a;
        }

        Console.WriteLine($"a^n = {result}");


        //задача 2
        Console.Write("\nВведите x (x >= 100): ");
        string x = Console.ReadLine();

        char second = x[1];
        string nResult = x.Remove(1, 1) + second;
        Console.WriteLine($"n = {nResult}");
    }
}

using System;

class MultiplicationTable
{
    static void Main()
    {
        Console.Write("Ingrese un número: ");
        int number = int.Parse(Console.ReadLine());

        PrintMultiplicationTable(number);
    }

    static void PrintMultiplicationTable(int number)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} x {i} = {number * i}");
        }
    }
}

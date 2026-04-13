using System;

class TaxCalculator
{
    static void Main()
    {
        Console.WriteLine("Налоговый калькулятор v2.0");
        Console.Write("Введите доход: ");
        decimal income = decimal.Parse(Console.ReadLine());

        decimal tax = income * 0.13m;
        Console.WriteLine($"Налог: {tax} руб.");
    }
}
using System;

class TaxCalculator
{
    static void Main()
    {
        Console.WriteLine(""Калькулятор налогов v1.0"");
        Console.Write("Введите доход: ");
        decimal income = decimal.Parse(Console.ReadLine());

        decimal tax = income * 0.13m;
        Console.WriteLine($"Налог: {tax} руб.");
    }
}
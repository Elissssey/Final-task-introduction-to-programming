//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение M: ");
        int m = int.Parse(Console.ReadLine());
        
        Console.Write("Введите значение N: ");
        int n = int.Parse(Console.ReadLine());
        
        int sum = 0;
        for (int i = m; i <= n; i++)
        {
            sum += i;
        }
        
        Console.WriteLine($"Сумма натуральных элементов от {m} до {n} равна {sum}");
    }
}
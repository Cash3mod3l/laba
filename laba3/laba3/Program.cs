using System;

namespace laba3;

public class Calculator
{
    private readonly int action;
    private double num1;
    private double num2;
    private double result;
    
    public Calculator()
    {
        
        Console.Write("Введите первое число: ");
        num1 = double.Parse(Console.ReadLine());
            
        Console.Write("Введите второе число: ");
        num2 = double.Parse(Console.ReadLine());
        
        while (true)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1.Сложение");
            Console.WriteLine("2.Вычитание");
            Console.WriteLine("3.Умножение");
            Console.WriteLine("4.Деление");

            action = int.Parse(Console.ReadLine());
            
            if (action == 1)
            {
                Console.WriteLine($"{num1} + {num2} = {Plus()}");
            } else if (action == 2)
            {
                Console.WriteLine($"{num1} - {num2} = {Minus()}");
            } else if (action == 3)
            {
                Console.WriteLine($"{num1} * {num2} = {Multi()}");
            } else if (action == 4)
            {
                Console.WriteLine($"{num1} / {num2} = {Del()}");
            }
            else
            {
                Console.WriteLine("Выберите корректное действие!");
                continue;
            }
            
            
            return;
        }
    }

    private double Plus()
    {
        result = num1 + num2;
        return result;
    }

    private double Minus()
    {
        result = num1 - num2;
        return result;
    }

    private double Multi()
    {
        result = num1 * num2;
        return result;
    }

    private double Del()
    {
        result = num1 / num2;
        return result;
    }
}

public static class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Выберите действие: ");
            Console.WriteLine("1.Войти в калькулятор");
            Console.WriteLine("2.Выход");   
            int action = int.Parse(Console.ReadLine());

            if (action == 1)
            {
                Calculator calculator = new Calculator();
            } else if (action == 2)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Выберите корректное действие!");
                continue;
            }
            
            return;
        }
    }
}
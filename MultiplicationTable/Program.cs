using System;
namespace Table


{
    class Program
    {
        static void ClasicMultiplicationTable(int number)
        {
            for (var i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }
        }
        static void CastomMultiplicationTable(int number, int multiplier)
        {
            for (var i = 1; i <= multiplier; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }
        }
        static void ChoiseTable(int choice, int number)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Clasic multiplication table for a given number: ");
                    ClasicMultiplicationTable(number);
                    break;
                case 2:
                    Console.WriteLine("Please, enter multiplier:");
                    var multiplier = 0;
                    var isMultiplier = int.TryParse(Console.ReadLine(), out multiplier);
                    if (isMultiplier && multiplier > 0)
                    {
                        Console.WriteLine($"Multiplication table for a given number - {number} with multiplier - {multiplier}: ");
                        CastomMultiplicationTable(number, multiplier);
                    }
                    else
                    {
                        Console.WriteLine("Please, enter a positive integer multiplier and try again");
                    }
                    break;
                default:
                    Console.WriteLine("Please, make the correct choice and try again");
                    break;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Please, enter the number:");
            var number = 0;
            var isNumber = int.TryParse(Console.ReadLine(), out number);
            if (isNumber)
            {
                Console.WriteLine($"You entered a number: {number}");
                Console.WriteLine("What multiplication table do you want to use? \n 1.Clasic \n 2.Castom, with multiplier");
            }
            else
            {
                Console.WriteLine("Please, enter an integer and try again");
                return;
            }
            var choice = 0;
            var isChoice = int.TryParse(Console.ReadLine(), out choice);
            if (isChoice)
            {
                ChoiseTable(choice, number);
            }
            else
            {
                Console.WriteLine("Please, enter an integer and try again");
                return;
            }
        }
    }
}
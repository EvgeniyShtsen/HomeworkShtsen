using System;
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
    static void Operations(int choice, int number)
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
        }
    }
    static int EnterNumber()
    {
        Console.WriteLine("Hello! Please, enter the number:");
        var number = 0;
        var isNumber = int.TryParse(Console.ReadLine(), out number);
        if (isNumber)
        {
            Console.WriteLine($"You entered a number: {number}");
            return number;
        }
        else
        {
            Console.WriteLine("Please, enter an integer and try again");
        }
        return number;
    }
    static int ChoiceTable()
    {
        Console.WriteLine("What multiplication table do you want to use? \n 1.Clasic \n 2.Castom, with multiplier");
        var choice = 0;
        var isChoice = int.TryParse(Console.ReadLine(), out choice);
        if (isChoice && choice == 1)
        {
            Console.WriteLine("Great, you select a classic math table");
            return choice;
        }
        else if (isChoice && choice == 2) 
        {
            Console.WriteLine("Great, you select a castom math table");
            return choice;
        }
        else
        {
            Console.WriteLine("Please, choose the correct item");
        }
        return choice;
    }
    static void Main(string[] args)
    {
        string ultima = "y";
        while (ultima == "y")
        {
            var number = EnterNumber();
            if (number != 0)
            {
                var choice = ChoiceTable();
                if (choice != 0)
                {
                    Operations(choice, number);
                }
            }
            Console.WriteLine("Do you try again? \n 1) Press 'y' button if YES \n 2) Press anything if NO");
            ultima = Convert.ToString(Console.ReadLine());
            if (ultima != "y")
            {
                Console.WriteLine("Have a good day!");
            }
        }
    }
}
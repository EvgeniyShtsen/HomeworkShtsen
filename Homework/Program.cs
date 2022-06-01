using System;

namespace Days
{
    class Program
    {
        static void OperationNumber(int number)
        {
            switch (number)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Enter a value from 1 to 7");
                    break;
            }

        }

        static void Main(string[] args)
        { 
            
             
            var ultima = ("y");
            while (ultima == "y")
            {
                if (ultima == "y")
                {
                    Console.WriteLine("Hello! Please, enter a day number (1 to 7)");
                    var number = 0;
                    var isNumber = int.TryParse(Console.ReadLine(), out number);
                    if (isNumber)
                    {
                        OperationNumber(number);
                    }
                    else
                    {
                        Console.WriteLine("Please, enter an integer and try again");
                    }
                    Console.WriteLine("Do you want to continue? \n 1) Press 'y' if YES \n 2) Press anything if NO");
                    ultima = Console.ReadLine();
                    if (ultima != "y")
                    {
                        Console.WriteLine("Have a good day!");
                    }
                }
            }
        }
    }
}
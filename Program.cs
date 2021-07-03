using System;

namespace Assignment02
{
    class Program
    {
        static void Main(string[] args)
        {
            TriangleSolver triangle = new TriangleSolver();

            int input = 0;
            bool success;
            int choice = 0;

            do
            {
                Console.WriteLine("\nPlease select an option from below mentioned list : ");
                Console.WriteLine("1. Please enter the dimesions of triangle: ");
                Console.WriteLine("2. Exit \n");

                //user choice inpiut
                try
                {
                    do
                    {
                        success = int.TryParse(Console.ReadLine(), out choice);
                        if (!success)
                        {
                            Console.WriteLine("Invalid input ");
                            Console.WriteLine("Please try another input !! ");
                            continue;
                        }

                    }

                    while (!success);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                switch (choice)
                {

                    case 1:

                        //Side 1
                        Console.Write("\n");
                        Console.Write("Please enter a value greater than zero for side 1 of the triangle: ");

                        try
                        {
                            do
                            {
                                success = int.TryParse(Console.ReadLine(), out input);
                                if (!success)
                                {
                                    Console.WriteLine("Invalid input ");
                                    Console.WriteLine("Please try another input !! ");
                                    continue;
                                }
                                if (input <= 0)
                                {
                                    success = false;
                                    Console.WriteLine("Value should be greater than zero (0) ");
                                    Console.WriteLine("Please try another input !! ");
                                }

                            }

                            while (!success);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        triangle.SetSide1(input);

                        //Side 2
                        Console.Write("Please enter a value greater than zero for Side 2 of the triangle: ");
                        try
                        {
                            do
                            {
                                success = int.TryParse(Console.ReadLine(), out input);
                                if (!success)
                                {
                                    Console.WriteLine("Invalid input ");
                                    Console.WriteLine("Please try another input !! ");
                                    continue;
                                }
                                if (input <= 0)
                                {
                                    success = false;
                                    Console.WriteLine("Value should be greater than zero (0) ");
                                    Console.WriteLine("Please try another input !! ");
                                }

                            }

                            while (!success);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        triangle.SetSide2(input);

                        //Side 3
                        Console.Write("Please enter a value greater than zero for Side 3 of the triangle: ");
                        try
                        {
                            do
                            {
                                success = int.TryParse(Console.ReadLine(), out input);
                                if (!success)
                                {
                                    Console.WriteLine("Invalid input ");
                                    Console.WriteLine("Please try another input !! ");
                                    continue;
                                }
                                if (input <= 0)
                                {
                                    success = false;
                                    Console.WriteLine("Value should be greater than zero (0) ");
                                    Console.WriteLine("Please try another input !! ");
                                }

                            }

                            while (!success);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        triangle.SetSide3(input);

                        Console.WriteLine(" {0} \n ", triangle.Analyze);
                        break;

                    case 2:
                        Console.WriteLine("Exitting ");
                        break;

                    default:
                        Console.WriteLine("Enter valid value from menu options (1/2): ");
                        continue;
                }
            }
            while (choice != 2);
        }
    }
}

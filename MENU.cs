using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Idf;

namespace Idf
{
    public class MENU
    {
        public static void Menu()
        {
            bool flag = true;
            while (flag)
            {
                PrintRed("Welcome to the military system");
                Console.WriteLine("For the Operations Department, click 1 \r\nFor the update data, click 2 \r\nfor the exit, click 3");
                switch (Console.ReadLine())

                {
                    case "1":
                        ShowMainMenu();
                        break;
                    case "2":
                        Console.WriteLine("press 1 to Intelligence Department \npress 2 To the Attack Units Department");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                ShowIntelligenceDepartmentMenu();
                                break;
                            case "2":
                                Console.WriteLine("Enter the name of the unit you want to add or change.");
                                string unit = Console.ReadLine();
                                Manager.IDF.ChanegingAttackUnit(unit);
                                break;
                        }
                        break;
                    case "3":
                        flag = false;
                        break;
                    default:
                        Menu();
                        break;
                }
            }
        }

        public static void ShowIntelligenceDepartmentMenu()
        {
            Console.WriteLine();
            Manager.IntelligenceDepartmentt.UpdateMessage(Manager.hamas);
        }

        public static void ChangingAttackUnitAttributes()
        {


        }

        static void ShowMainMenu()
        {
            PrintRed("========== IDF Strategic Operations Menu ==========");

            Console.WriteLine("Welcome, Commander. Prepare to lead your team with precision.");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose an operation to begin:");

                Console.WriteLine("1. Intelligence Analysis");

                Console.WriteLine("2. Attack Readiness");

                Console.WriteLine("3. Target Prioritization");

                Console.WriteLine("4. Attack Execution");

                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice (1-5): ");

                string input = CheckIfNUmber(1, 5);

                switch (input)
                {
                    case "1":
                        IntelligenceDepartment.TheMostMessages();
                        break;
                    case "2":
                        IdfMain.PrepareUnits();
                        break;
                    case "3":
                        IntelligenceDepartment.TheMostDangerous();
                        break;
                    case "4":
                        IdfMain.ExecuteStrike();
                        break;
                    case "5":
                        Console.WriteLine("Exiting. Stay sharp, Commander.");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");

                        Console.ReadKey();
                        Console.Clear();
                        Menu();
                        break;
                       

                }


            }
        }
        public static string CheckIfNUmber(int limit1, int limit2)
        {
            string input;
            bool check = true;
            int value;

            do
            {
                input = Console.ReadLine();

                if (input.Length == 1 && char.IsDigit(input[0]))
                {
                    value = int.Parse(input);
                    if (value >= limit1 && value <= limit2)
                    {
                        check = false; // valid input
                    }
                    else
                    {
                        Console.WriteLine($"Please enter a number between {limit1} and {limit2}.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a single digit number.");
                }

            } while (check);

            return input;
        }

        public static void PrintRed(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor(); 
        }
    }
}

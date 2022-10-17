using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            string choice = "";
            string result = "";
            string input1 = "";
            string input2 = "";

            while (!choice.Equals("6"))
            {
                Console.WriteLine("\t\t\tWCF Assignment 1");
                Console.WriteLine("1. Prime Number");
                Console.WriteLine("2. Sum of digits");
                Console.WriteLine("3. Reverse a string");
                Console.WriteLine("4. Print HTML tags");
                Console.WriteLine("5. Sort 5 numbers");
                Console.WriteLine("6. Exit");
                Console.WriteLine("");
                Console.WriteLine("\t\tEnter your choice:_");
                choice = Console.ReadLine().Trim();


                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Please enter the number to check: ");
                        input1 = Console.ReadLine().Trim();
                        result = client.FindPrime(int.Parse(input1));
                        Console.WriteLine("The answer is " + result);

                        break;
                    case "2":
                        Console.WriteLine("Please enter the number: ");
                        input1 = Console.ReadLine().Trim();
                        result = client.SumDigits(input1);
                        Console.WriteLine("The sum is " + result);
                        break;
                    case "3":
                        Console.WriteLine("Please enter the string: ");

                        input1 = Console.ReadLine().Trim();
                        result = client.ReverseString(input1);
                        Console.WriteLine("The reversed string is " + result);
                        break;
                    case "4":

                        Console.WriteLine("Tag: ");
                        input1 = Console.ReadLine().Trim();
                        Console.WriteLine("Data: ");
                        input2 = Console.ReadLine().Trim();
                        result = client.PrintHTMLTAG(input1, input2);
                        Console.WriteLine("The output is " + result);
                        break;
                    case "5":
                        Console.WriteLine("Please select from 'Ascending' or 'Descending' :");
                        input1 = Console.ReadLine().Trim();
                        Console.WriteLine("Please enter 5 numbers seperate by comma: ");
                        input2 = Console.ReadLine().Trim();
                        result = client.SortNumbers(input1, input2);
                        Console.WriteLine("The sorted numbers: " + result);
                        break;
                    case "6":

                        break;
                    default:
                        Console.WriteLine("Please enter number between 1 to 6");
                        break;
                }
            }


        }
    }
}

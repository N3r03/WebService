using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select operation:");
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Multiplication");
            Console.WriteLine("3.Division");
            Console.WriteLine("4.Substraction");

            localhost.CalculatorWebService obj = new localhost.CalculatorWebService();

            int choice;
            choice = Convert.ToInt32(Console.ReadLine());
            int num1,num2;
            switch (choice)
            {
            
                case 1:
                    Console.WriteLine("Addition");
                    Console.Write("Number 1:"); num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Number 2:"); num2 = Convert.ToInt32(Console.ReadLine());
                    int result0 = obj.Add(num1, num2);
                    Console.WriteLine("Result:" + result0);
                    Console.ReadKey();
                    break;

                case 2:
                    Console.WriteLine("Multiplication");
                    Console.Write("Number 1:"); num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Number 2:"); num2 = Convert.ToInt32(Console.ReadLine());
                    
                    int result1 = obj.Multiply(num1, num2);
                    Console.WriteLine("Result:" +result1);
                    Console.ReadKey();
                    break;
                
                case 3:
                    Console.WriteLine("Division");
                    Console.Write("Number 1:"); num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Number 2:"); num2 = Convert.ToInt32(Console.ReadLine());
                    int result2 = obj.Divide(num1, num2);
                    Console.WriteLine("Result:" + result2);
                    Console.ReadKey();
                    break;
                
                case 4:
                    Console.WriteLine("Substraction");
                    Console.Write("Number 1:"); num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Number 2:"); num2 = Convert.ToInt32(Console.ReadLine());
                    int result3 = obj.Substract(num1, num2);
                    Console.WriteLine("Result:" + result3);
                    Console.ReadKey();
                    break;
                 default:
                    Console.WriteLine("Invalid choice");
                    Console.ReadKey();
                 break;
            }


        }
    }
}


using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************CALCULATOR**************");
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Substraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");
            Console.Write("Enter Choice(1-4):");
            int ch = Int32.Parse(Console.ReadLine());
            int a, b, c;
            switch (ch)
            {
                case 1:
                    Console.Write("Enter A:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter B:");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a + b;
                    Console.WriteLine("Sum ={0}", c);
                    break;
                case 2:
                    Console.Write("Enter A:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter B:");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a - b;
                    Console.WriteLine("Difference = {0}", c);
                    break;
                case 3:
                    Console.Write("Enter A:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter B:");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a * b;
                    Console.WriteLine("Product = {0}", c);
                    break;
                case 4:
                    Console.Write("Enter A:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter B:");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a / b;
                    Console.WriteLine("Quotient = {0}", c);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
            Console.ReadKey();
        }
    }
}

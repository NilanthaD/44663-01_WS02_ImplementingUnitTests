using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnitDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello XUnit Demo..!");
            Console.WriteLine("Adding two numbers ");
            Console.Write("Number 1  :");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number 2  :");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double sum = Calculator.Add(num1, num2);
            Console.WriteLine($"{num1} + {num2} = {sum}");
            Console.ReadKey();
        }
    }
}

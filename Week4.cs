using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    delegate int Calc(int a, int b);
    internal class Program
    {
        static void Main(string[] args)
        {
            Calc Add = (a,b) => a + b;
            Calc Sub = (a,b) => a - b;
            Calc Mul = (a,b) => a * b;
            Calc Div = (a,b) => a / b;

            Console.Write("Enter Two Values Respectively.\nV1: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("V2: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine($"Addition: {Add(x,y)}");
            Console.WriteLine($"Subtraction: {Sub(x, y)}");
            Console.WriteLine($"Multiplication: {Mul(x, y)}");
            Console.WriteLine($"Division Without Fractions: {Div(x, y)}");

        }
}
}

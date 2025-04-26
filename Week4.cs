using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    #region Task1
    //delegate int Calc(int a, int b);
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Calc Add = (a, b) => a + b;
    //        Calc Sub = (a, b) => a - b;
    //        Calc Mul = (a, b) => a * b;
    //        Calc Div = (a, b) => a / b;

    //        Console.Write("Enter Two Values Respectively.\nV1: ");
    //        int x = int.Parse(Console.ReadLine());
    //        Console.Write("V2: ");
    //        int y = int.Parse(Console.ReadLine());

    //        Console.WriteLine($"Addition: {Add(x, y)}");
    //        Console.WriteLine($"Subtraction: {Sub(x, y)}");
    //        Console.WriteLine($"Multiplication: {Mul(x, y)}");
    //        Console.WriteLine($"Division Without Fractions: {Div(x, y)}");

    //    }
    //}
    #endregion
    #region Task2


    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        DataProcessor processor = new DataProcessor();
    //        processor.OnDataReceived += () => Console.WriteLine("Data Received successfully.");
    //        processor.ReceiveData();

    //    }
    //}
    //class DataProcessor {
    //    public event Action OnDataReceived;
    //    public void ReceiveData() {
    //        Console.WriteLine("Data Receiving ..");
    //        OnDataReceived?.Invoke();
    //    }
    //}
    #endregion

    #region Task3
    internal class Program
    {
        delegate int Sum(int[] arr);
        static void Main(string[] args)
        {
            Sum del1 = delegate (int[] arr) {

                int sum=0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];

                }

                return sum;
            };

            Console.Write("Enter the size of the array: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter {n} values:");
            int[] arr1 = new int[n];
            for (int i = 0; i < n; i++) {
                arr1[i] = int.Parse(Console.ReadLine());
            }

            int SumOfArray = del1(arr1);

            Console.WriteLine($"The Summation of the array is: {SumOfArray}");


        }

    }


    #endregion

}

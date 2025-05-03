using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    internal class Program
    {

        #region Task One


        //    static async Task Main(string[] args)
        //    {
        //        Console.WriteLine("Fetching data...");
        //        string result = await FetchData();
        //        Console.WriteLine($"Data fetched: {result}");
        //    }

        //    static async Task<string> FetchData()
        //    {

        //        await Task.Delay(2000);
        //        return "Any Data ...";
        //    }

        #endregion

        #region Task2

        
        static async Task Main()
        {
            Console.WriteLine("How many numbers do you want to enter?");
            int count = int.Parse(Console.ReadLine());

            var numbers = new List<int>();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Enter number {i + 1}:");
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Fetching even numbers");
            var evenNumbers = await GetEvenNumbers(numbers);
            Console.WriteLine("Even numbers: " + string.Join(", ", evenNumbers));
        }

        static async Task<List<int>> GetEvenNumbers(List<int> numbers)
        {
            await Task.Delay(2000); 
            return numbers.Where(n => n % 2 == 0).ToList();
        }
        #endregion
    }
}




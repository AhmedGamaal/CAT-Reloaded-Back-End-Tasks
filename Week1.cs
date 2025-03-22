using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAT_Reloaded_Week1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1-Prompts the user to enter 10 numbers and stores them in an array. Finds and prints the largest number in the array using a loop.

            //Console.WriteLine("Enter 10 Numbers: ");
            //int[] nums = new int[10];
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] = int.Parse(Console.ReadLine());
            //}
            //int largest = nums[0];
            //for (int i = 0; i < nums.Length; i++) {
            //    if (nums[i] > largest) {
            //        largest = nums[i];
            //    }

            //}
            //Console.WriteLine($"Largest value is: {largest}.");

            #endregion


            #region 2-Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            //Console.WriteLine("Enter a character: ");
            //char c = char.Parse(Console.ReadLine().ToLower());

            //if ( c == 'a' || c== 'e'|| c=='o' || c== 'i' || c== 'u')
            //{ Console.WriteLine("vowel"); }
            //else
            //{ Console.WriteLine("consonant");}
            #endregion



            #region 3- Write a program that allows the user to insert an integer then print a multiplication table up to 12.

            //Console.WriteLine("Enter an Integer: ");
            //int x = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine(x * i);
            //}

            #endregion

            #region 4-Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.

            //Console.WriteLine("Enter a number: ");
            //int numToBeDivided= int.Parse(Console.ReadLine());
            //if (numToBeDivided % 3 == 0 && numToBeDivided % 4 == 0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else { Console.WriteLine("No"); }

            #endregion

            #region 5- Write a program in C# Sharp to convert a decimal number into binary without using an array.

            //Console.Write("Enter a decimal number: ");
            //int decimalNumber = int.Parse(Console.ReadLine());
            //string binaryNumber = "";
            //while (decimalNumber > 0)
            //{
            //    int rem = decimalNumber % 2; 
            //    binaryNumber = rem + binaryNumber;
            //    decimalNumber = decimalNumber / 2; 
            //}
            //if (binaryNumber == "")
            //{
            //    binaryNumber = "0";
            //}
            //Console.WriteLine($"Binary number: {binaryNumber}");
            #endregion

            #region 6-Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //int[] arr = new int[5];
            //int[] arr1 = new int[5];
            //Console.WriteLine("Enter Five Integers for Array number one: ");
            //for (int i = 0; i<arr.Length;i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Enter Five Integers for Array Number Two: ");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr1[i] = int.Parse(Console.ReadLine());
            //}
            //int[] mergedArr = new int[10];
            //for (int i = 0, k = 9; i < arr.Length; i++, k--) { 
            //mergedArr[i] = arr[i];
            //    mergedArr[k] = arr1[k-5];
            //}
            //Array.Sort(mergedArr);
            //Console.Write("Sorted Array: ");
            //for (int i = 0; i < mergedArr.Length; i++) {
            //    Console.Write(mergedArr[i] +" ");
            //}

            #endregion

            #region 7- Write a program in C# Sharp to find the second largest element in an array.
            //Console.WriteLine("Enter 10 Numbers: ");
            //int[] nums = new int[10];
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] = int.Parse(Console.ReadLine());
            //}
            //int largest = int.MinValue;
            //int secondLargest = int.MinValue;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] > largest)
            //    {
            //        secondLargest = largest; 
            //        largest = nums[i];
            //    }

            //}
            //Console.WriteLine($"Second Largest value is: {secondLargest}.");

            #endregion

            #region 8- Write a Program to Print One Dimensional Array in Reverse Order
            int[] arrRev = new int[10];
            Console.WriteLine("Enter 10 integers: ");
            for (int i = 0; i < arrRev.Length; i++) { 
            arrRev[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Reversed Array: ");
            for (int i = 9; i >= 0; i--) { Console.Write(arrRev[i]+" "); }


            #endregion


        }
    }
}

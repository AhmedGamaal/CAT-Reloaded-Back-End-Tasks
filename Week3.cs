using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CAT_Week3
{
    #region 1-Create a generic method Swap<T> that swaps two variables of any type.
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Write two integer values respectively.");
    //        Console.Write("First Value: ");
    //        int x = int.Parse(Console.ReadLine());
    //        Console.Write("Second Value: "); 
    //        int y = int.Parse(Console.ReadLine());

    //        Swap(x, y);
    //        Console.WriteLine("---------------------------------------------------");
    //        Console.WriteLine("Write two strings respectively.");
    //        Console.Write("First Value: ");
    //        string xx = Console.ReadLine();
    //        Console.Write("Second Value: ");
    //        string yy =Console.ReadLine();
    //        Swap(xx, yy);

    //    }

    //    public static void Swap<T>(T x1, T x2)
    //    {
    //        Console.WriteLine($"Before swapping the values where:\nP1: {x1}, P2: {x2}");

    //        T x = x1;
    //        x1 = x2;
    //        x2 = x;

    //        Console.WriteLine($"Values after swapping\nP1: {x1}, P2: {x2}");


    //    }
    //}
    #endregion
    #region 2-Create a Dictionary<string, int> to store student names and their grades.



    //internal class Program
    //{
    //    static Dictionary<string, int> Students = new Dictionary<string, int>();
    //    static void Main(string[] args)
    //    {

    //            Students.Add("Ahmed Gamal", 97);
    //            Students.Add("Yousef Ahmed", 94);
    //            Students.Add("Salma Ahmed", 98);
    //            Students.Add("Faisal Mohamed", 88);
    //            Students.Add("Menna Ashraf", 100);

    //        while (true)
    //        {
    //            Console.Write("Enter a name to get his/her grade: ");
    //            string name = Console.ReadLine();

    //            FindGrades(name);
    //            Console.WriteLine("Exit? (Yes/No)");
    //            string inp =Console.ReadLine();
    //            if (inp.ToLower() == "yes")
    //            {
    //                break;
    //            }
    //        }

    //    }
    //    public static void FindGrades(string sName)
    //    {
    //        if (Students.ContainsKey(sName))
    //        {
    //            Console.WriteLine($"{sName}'s grade: {Students[sName]}%");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Invalid name try again.");
    //        }

    //    } 
    //}


    #endregion
    #region 3-Implement a Queue<string> to simulate a customer service line.
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Queue<string> customers = new Queue<string>();
    //        customers.Enqueue("Ahmed Gamal");
    //        customers.Enqueue("Yousef Ahmed");
    //        customers.Enqueue("Mohammed Ali");
    //        customers.Enqueue("Malak Ahmed");
    //        customers.Enqueue("Eslam Ashraf");
    //        customers.Enqueue("Mariam Ibrahim");
            
    //        while (true) {
    //            Console.WriteLine("--------------------------------------------------------------");
    //            if (customers.Count > 0)
    //                Console.WriteLine($"Customer Being Served Right Now: {customers.Peek()}");
               
    //            Console.WriteLine("Choose number:-" +
    //                "\n1.Add Customer" +
    //                "\n2.Service completed for current customer" +
    //                "\n3.Remaining Customers" +
    //                "\n4.Exit"
    //                );
    //            int n = int.Parse( Console.ReadLine() );
    //            switch (n)
    //            {
    //                case 1:
    //                    Console.Write("Enter Customer Name: ");
    //                    string name = Console.ReadLine();
    //                    if (string.IsNullOrEmpty(name)) {
    //                        Console.WriteLine("Invalid Input, Try Again later.");
    //                        break;
    //                    }
    //                    customers.Enqueue(name);
    //                    Console.WriteLine("A customer has been successfully added to the queue.");
    //                    break;
                    
    //                case 2:

    //                    if (customers.Count != 0)
    //                    {
    //                        Console.WriteLine($"{customers.Dequeue()} has been served successfully.");
    //                        if (customers.Count != 0)
    //                        {

    //                            Console.WriteLine($"and next customer is: {customers.Peek()}.");
    //                        }
    //                        else { Console.WriteLine("The Queue is Empty Now!"); }
    //                        break;
    //                    }
    //                    else {
    //                        Console.WriteLine("There is no customers to serve.");
    //                        break;
    //                    }
                        
                     
    //                case 3: 
    //                    Console.WriteLine($"There are {customers.Count()} customers remaining.");
    //                    break;
    //                case 4:
    //                    return;
                        
    //                default:
    //                    Console.WriteLine("Invalid choice. Please try again.");
    //                    break;
    //            }
    //            Console.WriteLine("--------------------------------------------------------------");
    //        }
    //    }
        #endregion
    }
}

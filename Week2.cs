using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2___CAT_Reloaded
{
    internal class Program
    {
        static void Main(string[] args)
        {//For Task One
         /*   Student s1 = new Student("Ahmed Gamal", 20, 100.0);
            s1.PrintDetails();*/
         //---------------------------------------------------------
         //For Task Two.
            Employee e1 = new Employee(1,"Ahmed Gamal",SecurityPrivileges.Developer, 10000,"2023/11/1","M");
            Console.WriteLine(e1.ToString());

        }
    }
    #region Create Student class with some properties and PostGraduate that inherits from Student class.


    //class Student
    //{
    //    string name { get; set; }
    //    int age { get; set; }
    //    double grade { get; set; }

    //    public Student(string name, int age, double grade)
    //    {
    //        this.name = name;
    //        this.age = age;
    //        this.grade = grade;
    //    }
    //    public void PrintDetails()
    //    {
    //        Console.WriteLine($@"Student Details:- 
    //Name: {this.name}
    //Age: {this.age} years 
    //Grade: {this.grade}.");

    //    }
    //}

    //class PostGraduate : Student
    //{
    //    string ThisIsTopic;
    //    public PostGraduate(string ThisIsTopic, string name, int age, double grade) : base(name, age, grade) { 
    //    this.ThisIsTopic = ThisIsTopic;
    //    }

    //}
    #endregion

    #region 2-Design and implement a Class for the employees in a company:

    class Employee {
        int id {  get; set; }
        string name { get; set; }

        SecurityPrivileges SecurityLevel { get; set; } 

        decimal salary { get; set; }

        string hireDate { get; set; } // as in DBMS like MS SQL date is a string. and we can choose DateTime. 

        private string _gender;
        string Gender {
            get { return _gender; } 
            
            set {
                if (value == "M")
                {
                    _gender= "Male";
                }
                else if (value == "F") {
                    _gender = "Female";
                }
                else
                {
                    Console.WriteLine("Invalid Input for Gender.");
                    _gender = "Unknown";
                }
            } 
        
        }
        public Employee(int id, string name, SecurityPrivileges s, decimal salary, string hireDate, string Gender) {
        this.id = id;
            this.name = name;
            this.SecurityLevel = s;
            this.salary = salary;
            this.hireDate = hireDate;
            this.Gender = Gender;
        }
        public override string ToString()
        {
            string Details = $"Employee Details:-\nID: {this.id}\nName: {this.name}\nSecurity Level: {this.SecurityLevel}\nSalary: {this.salary.ToString("C")}\nHire Date: {this.hireDate}\nGender: {this.Gender}.";
            return Details;

        }





    }
    public enum SecurityPrivileges
    {
        Guest,
        Developer,
        Secretary,
        DBA
    }

    #endregion
}

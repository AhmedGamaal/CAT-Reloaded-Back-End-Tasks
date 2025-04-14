using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Examination_System
{

    internal class Program
    {
        static List<Subject> subjects = new List<Subject>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===========------ Examination System ------===========");
                Console.WriteLine("1. Create New Subject and Exam");
                Console.WriteLine("2. Start an Exam");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        CreateSubjectAndExam();
                        break;
                    case "2":
                        StartExam();
                        break;
                    case "3":
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid Input, Try again!");
                        Console.ReadKey();
                        break;


                }

            }
        }
        #region Create subject and exam 
        static void CreateSubjectAndExam()
        {
            Console.WriteLine("===================================\n=== Create New Subject and Exam ===\n===================================");
            Console.Write("Enter Subject ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Subject Name: ");
            string name = Console.ReadLine();

            Subject sub = new Subject(id, name);
            sub.CreateExam();
            subjects.Add(sub);

            Console.WriteLine("\nSubject and Exam created successfully!");
            Console.ReadKey();
        }
        #endregion

        #region start exam 
        static void StartExam()
        {
            Console.WriteLine("============================\n===== Available Exams ======\n============================");
            if (subjects.Count == 0)
            {
                Console.WriteLine("No Exams Available. Please create an exam first. :)");
                Console.ReadKey();
                return;
            }
            for (int i = 0; i < subjects.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {subjects[i].SubjectName} (ID: {subjects[i].SubjectID})");
            }
            Console.Write("\nSelect Exam to start or just write 0 to cancel: ");
            int choice = int.Parse(Console.ReadLine());
            if (choice > 0 && choice <= subjects.Count)
            {
                Console.WriteLine($"Starting Exam for: {subjects[choice - 1].SubjectName}");
                subjects[subjects.Count - 1].SubjectExam.ShowExam();


            }
            #endregion
        }

        #region Answer Class
        public class Answer : ICloneable, IComparable<Answer>
        {
            public int AnswerID { get; set; }
            public string AnswerText { get; set; }

            public Answer(int id, string text)
            {
                AnswerID = id;
                AnswerText = text;

            }
            public object Clone() // First time using this Interface BTW. so if there is anything could be better while using it please tell me. After searching I knew it takes a copy of object.
            {
                return new Answer(this.AnswerID, this.AnswerText);
            }

            public int CompareTo(Answer other) // first time also using this interface / function - > but after searching I knew it is used for comparing two objects.
            {
                return this.AnswerID.CompareTo(other.AnswerID);

            }
            public override string ToString()
            {
                return $"{AnswerID}. {AnswerText}";
            }
        }


        #endregion


        #region Questions Classes 
         
        public class Question
        { 
            public string Header { get; set; }
            public string Body { get; set; }
            public double Mark { get; set; }
            public Answer[] AnswerList { get; set; }
            public Answer correctAnswer { get; set; }


            public Question(string header, string body, double mark)
            {
                Header = header;
                Body = body;
                Mark = mark;
            }

            public virtual void Display() { }




        }
        // Types of question ...
        public class MCQQuestion : Question
        {
            public MCQQuestion(string header, string body, double mark) : base(header, body, mark) { }

            public override void Display()
            {
                Console.WriteLine($"{Header}: {Body} ({Mark} marks)");
                foreach (var answer in AnswerList)
                {
                    Console.WriteLine(answer);

                }
            }

        }

        public class TrueFalseQuestion : Question
        {

            public TrueFalseQuestion(string header, string body, double mark) : base(header, body, mark) { }
            public override void Display()
            {
                Console.WriteLine($" True/False {Header}: {Body} ({Mark} marks)");
                foreach (var answer in AnswerList)
                {
                    Console.WriteLine(answer);
                }


            }


        }




        #endregion

        #region Exam Classes

        public abstract class Exam
        {
            public int Time { get; set; }
            public int NumberOfQuestions { get; set; }
            public Question[] Questions { get; set; }

            public Exam(int time, int numberOfQuestions)
            {
                Time = time;
                NumberOfQuestions = numberOfQuestions;
                Questions = new Question[NumberOfQuestions];
            }
            public abstract void ShowExam();



        }


        class FinalExam : Exam
        {
            public FinalExam(int time, int num) : base(time, num) { }
            public override void ShowExam()
            {
                double totalGrades = 0, studentGrades = 0;
                Console.WriteLine($"\nFinal Exam - Time: {Time} minutes\n");
                for (int i = 0; i < Questions.Length; i++)
                {
                    Console.WriteLine($"\nQuestion {i + 1}:");
                    Questions[i].Display();

                    int ans;
                    while (true)
                    {
                        Console.Write("Your Answer: ");
                        if (int.TryParse(Console.ReadLine(), out ans) && ans > 0 && ans <= Questions[i].AnswerList.Length)
                            break;
                        Console.WriteLine($"Invalid input. Please enter 1-{Questions[i].AnswerList.Length}");
                    }

                    totalGrades += Questions[i].Mark;
                    if (Questions[i].correctAnswer.AnswerID == ans)
                        studentGrades += Questions[i].Mark;
                }

                Console.WriteLine($"\nExam Results:");
                Console.WriteLine($"Your Grade: {studentGrades}/{totalGrades}");
                Console.WriteLine($"Percentage: {(studentGrades / totalGrades) * 100}%");
                Console.ReadKey();
            }


            }

            class PracticalExam : Exam
        {


            public PracticalExam(int time, int num) : base(time, num) { }

            

            public override void ShowExam()
            {
                double totalGrades = 0, studentGrades = 0;
                Console.WriteLine($"\nPractical Exam - Time: {Time} minutes\n");

                for (int i = 0; i < Questions.Length; i++)
                {
                    Console.WriteLine($"\nQuestion {i + 1}:");
                    Questions[i].Display();

                    int ans;
                    while (true)
                    {
                        Console.Write("Your Answer: ");
                        if (int.TryParse(Console.ReadLine(), out ans) && ans > 0 && ans <= Questions[i].AnswerList.Length)
                            break;
                        Console.WriteLine($"Invalid input. Please enter 1-{Questions[i].AnswerList.Length}");
                    }

                    totalGrades += Questions[i].Mark;
                    if (Questions[i].correctAnswer.AnswerID == ans)
                        studentGrades += Questions[i].Mark;
                }

                Console.WriteLine($"\nExam Results:");
                Console.WriteLine($"Your Grade: {studentGrades}/{totalGrades}");
                Console.WriteLine($"Percentage: {(studentGrades / totalGrades) * 100}%");
                Console.ReadKey();

            }
        }

        #endregion

        #region Subject class

        public class Subject
        {
            public int SubjectID { get; set; }
            public string SubjectName { get; set; }
            public Exam SubjectExam { get; set; }
            public Subject(int id, string name)
            {
                SubjectName = name;
                SubjectID = id;

            }
            public void CreateExam()
            {

                Question que;
                while (true)
                {
                    
                    
                        Console.Write("\nEnter Exam type (F -> Final, P -> Practical): ");
                        char type = char.Parse(Console.ReadLine());
                        Console.WriteLine();

                        if (type != 'F' && type != 'P')
                        {
                            Console.WriteLine("Invalid exam type. Please enter F or P.");
                            continue;
                        }

                        Console.Write("Enter Number of Questions: ");
                        int num = int.Parse(Console.ReadLine());
                        if (num<= 0)
                        {
                            Console.WriteLine("Invalid number. Must be positive integer.");
                            continue;
                        }

                        Console.Write("Enter Duration (minutes): ");
                        int time = int.Parse(Console.ReadLine());
                        if (time <= 0)
                        {
                            Console.WriteLine("Invalid duration. Must be positive integer.");
                            continue;
                        }
                        if (type == 'F' || type == 'f')
                            SubjectExam = new FinalExam(time, num);
                        else 
                            SubjectExam = new PracticalExam(time, num);

                        for (int i = 0; i < num; i++)
                        {
                            Console.WriteLine($"\nCreating Question {i + 1}/{num}");

                            int questionType;
                            
                                Console.Write("Question Type (1 -> MCQ, 2 -> T/F): ");
                                questionType = int.Parse(Console.ReadLine());
                                
                                
                            

                            Console.Write("Question Header: ");
                            string header = Console.ReadLine();

                            Console.Write("Question Body: ");
                            string body = Console.ReadLine();

                            double mark;
                            while (true)
                            {
                                Console.Write("Marks for this question: ");
                                mark = double.Parse(Console.ReadLine());
                                if (mark > 0)
                                    break;
                                Console.WriteLine("Invalid marks. Must be positive number.");
                            }
                            if (questionType == 1)
                                 que = new MCQQuestion(header, body, mark);
                            else
                                que = new TrueFalseQuestion(header, body, mark);
                            int numOfAns;
                            if (questionType == 1)
                                
                            numOfAns = 4; else numOfAns =  2;
                            que.AnswerList = new Answer[numOfAns];

                            for (int j = 0; j < numOfAns; j++)
                            {
                                Console.Write($"Answer {j + 1} Text: ");
                                que.AnswerList[j] = new Answer(j + 1, Console.ReadLine());
                            }

                            int correctId;
                            while (true)
                            {
                                Console.Write("Correct Answer ID: ");
                                correctId = int.Parse(Console.ReadLine());
                                if (correctId > 0 && correctId <= numOfAns)
                                {
                                    que.correctAnswer = (Answer)que.AnswerList[correctId - 1].Clone();
                                    break;
                                }
                                Console.WriteLine($"Invalid ID. Must be 1-{numOfAns}");
                            }

                            SubjectExam.Questions[i] = que;
                        }
                        break;
                    }
                   
                
            }



        }
        #endregion


    }
}


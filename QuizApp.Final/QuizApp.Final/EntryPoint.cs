using QuizApp.DomainModels.Users;
using QuizApp.Services;
using System;
using System.Threading;

namespace QuizApp.Final
{
    class Program
    {
        private static HelperServices _helperService = new HelperServices();
        private static QuestionsService _questionsService = new QuestionsService();
        private static StudentServices _studentServices = new StudentServices();
        private static TeacherServices _teacherServices = new TeacherServices();
        private static Teacher _teacher = new Teacher();
        private static Student _student = new Student();
        private static Student loggedStudent = null;
        private static Teacher loggedTeacher = null;


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!");

            while (true)
            {
                int maxAttempts = 0;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Quiz App");
                Console.ResetColor();
                Console.WriteLine("1.Student\n2.Teacher");
                int login = _helperService.ValidatePositiveNumber(Console.ReadLine(), 2);
                if (login == 1)
                {
                    Console.Clear();
                    StudentStart:
                    Console.WriteLine("Enter Username");
                    string username = Console.ReadLine();
                    Console.WriteLine("Enter Password");
                    string password = Console.ReadLine();
                    loggedStudent = _studentServices.LogIn(username, password);
                    if (loggedStudent == null)
                    {
                        _helperService.ErrorMessage("Wrong username or password!");
                        maxAttempts++;
                        if (maxAttempts >= 3)
                        {
                            break;
                        }
                        Console.ReadLine();
                        Console.Clear();
                        goto StudentStart;
                    }
                    else if (loggedStudent.AnsweredQuestions == true)
                    {
                        Console.Clear();
                        Console.WriteLine("You did the test!");
                        goto StudentStart;
                    }
                    else
                    {
                        _studentServices.WelcomeStudent(username);
                        _questionsService.GetQuestions(loggedStudent);
                    }
            
                }
                else if (login == 2)
                {
                    Console.Clear();
                    TeacherStart:
                    Console.WriteLine("Enter Username");
                    string username = Console.ReadLine();
                    Console.WriteLine("Enter Password");
                    string password = Console.ReadLine();
                    loggedTeacher = _teacherServices.Login(username, password);
                    if (loggedTeacher == null)
                    {
                        _helperService.ErrorMessage("Wrong username or password!");
                        maxAttempts++;
                        if (maxAttempts >= 3)
                        {
                            break;
                        }
                        Console.ReadLine();
                        Console.Clear();
                        goto TeacherStart;
                    }
                    else
                    {
                        Console.Clear();
                        _teacherServices.WelcomeTeacher(username);
                        Console.WriteLine("Press 1 to show Students that did the quiz and have a grade");
                        int showStudents = Convert.ToInt32(Console.ReadLine());
                        if (showStudents == 1)
                        {
                            _studentServices.PrintStudents();
                            Console.WriteLine();
                        }
                    }
                }
                else
                {
                    continue;
                }
            }








            Console.ReadLine();
        }
    }
}

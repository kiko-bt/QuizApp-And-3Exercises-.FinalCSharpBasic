using QuizApp.DomainModels.Enums;
using QuizApp.DomainModels.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApp.Services
{
    public class StudentServices
    {
        public List<Student> Students { get; set; }

        public StudentServices()
        {
            Students = new List<Student>()
            {
                new Student
                {
                    Username = "Kiko",
                    Password = "kikobt",
                    Occupation = Role.Student,
                    Id = 20
                },
                new Student
                {
                    Username = "Ackata",
                    Password = "aceee",
                    Occupation = Role.Student,
                    Id = 25
                },
                new Student
                {
                    Username = "Gjore",
                    Password = "dzordz",
                    Occupation = Role.Student,
                    Id = 35
                },
                new Student
                {
                    Username = "Petar",
                    Password = "pecko",
                    Occupation = Role.Student,
                    Id = 10
                }
            };
        }


        public void WelcomeStudent(string user)
        {
            foreach (Student student in Students)
            {
                if (student.Username == user)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{student.Id}. Welcome {student.Username}");
                    Console.ResetColor(); 
                }
            }
        }


        public void PrintStudents()
        {
            foreach (Student student in Students)
            {
                if (student.Grade == null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{student.Username}");
                }
                else
                {
                    Console.Clear();
                    if (student.Grade == 5 && student.AnsweredQuestions == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{student.Username} has Grade: {student.Grade} - Excellent");
                    }
                    if (student.Grade == 3 && student.AnsweredQuestions == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{student.Username} has Grade: {student.Grade} - Very Good");
                    }
                    if (student.Grade == 1 && student.AnsweredQuestions == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{student.Username} has Grade: {student.Grade} - Good");
                    }
                    if (student.Grade == 0 && student.AnsweredQuestions == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{student.Username} has Grade: {student.Grade} - Bad");
                    }
                }
            }
            Console.ResetColor();
        }

        public Student LogIn(string username, string password)
        {
            foreach (Student student in Students)
            {
                if (student.Username == username && student.Password == password)
                    return student;
            }
            return null;
        }
    }
}

using QuizApp.DomainModels.Enums;
using QuizApp.DomainModels.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApp.Services
{
    public class TeacherServices
    {
        public List<Teacher> Teachers { get; set; }

        public TeacherServices()
        {
            Teachers = new List<Teacher>()
            {
                new Teacher
                {
                    Username = "Martin",
                    Password = "Panovski",
                    Id = 1,
                    Occupation = Role.Teacher
                },
                new Teacher
                {
                    Username = "Dejan",
                    Password = "Jovanov",
                    Id = 2,
                    Occupation = Role.Teacher
                }
            };
        }

        public void WelcomeTeacher(string user)
        {
            foreach (Teacher teacher in Teachers)
            {
                if(teacher.Username == user)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{teacher.Id}. Welcome {teacher.Username}");
                    Console.ResetColor();
                }
            }
        }

        public Teacher Login(string username, string password)
        {
            foreach (Teacher teacher in Teachers)
            {
                if (teacher.Username == username && teacher.Password == password)
                {
                    return teacher;
                }
            }
                return null;
        }
    }
}

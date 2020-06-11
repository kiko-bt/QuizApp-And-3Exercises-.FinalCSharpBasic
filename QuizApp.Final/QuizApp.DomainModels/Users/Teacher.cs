using QuizApp.DomainModels.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApp.DomainModels.Users
{
    public class Teacher : User
    {
        public Teacher()
        {

        }
        public Teacher(string username, string password, int id)
            : base (username, password, id)
        {
            Occupation = Role.Teacher;
        }
    }
}

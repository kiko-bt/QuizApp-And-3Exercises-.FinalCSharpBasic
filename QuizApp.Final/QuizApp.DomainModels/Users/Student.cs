using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApp.DomainModels.Users
{
    public class Student : User
    {
        public int? Grade { get; set; }
        public bool AnsweredQuestions { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApp.DomainModels.Users
{
    public class Questions
    {
        public string Question { get; set; }
        public string Answer { get; set; }

        public Questions()
        {

        }

        public Questions(string question, string answer)
        {
            this.Question = question;
            this.Answer = answer;
        }
    }
}

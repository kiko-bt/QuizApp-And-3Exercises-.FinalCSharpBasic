using QuizApp.DomainModels.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApp.DomainModels.Users
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }
        public Role Occupation { get; set; }

        public User()
        {

        }

        public User(string username, string password, int id)
        {
            this.Username = username;
            this.Password = password;
            this.Id = id;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysClassLibrary.Classes
{
   public class Login
    {

        private string username;
        private string password;
        People people;


        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public void GetUser()
        {
            this.Username = people.Username;
            this.Password = people.Password;

        }
    }
}

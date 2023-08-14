using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DuelSysClassLibrary.Classes
{
   public class People
    {
        private int id;
        private string name;
        private string username;
        private string password;
        private string email;

        [Required]
        public int ID
        {
            get { return id; }
            set { id = value; }
        }


        [Required]
        [DataType(DataType.Text)]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [Required]
        [DataType(DataType.Text)]
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        [Required]
        [DataType(DataType.Password)]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public People() { }

        public People(string name, string username, string password, string email)
        {
            this.name = name;
            this.username = username;
            this.password = password;
            this.email = email;
        }
        public People(int id, string name, string username, string password, string email)
        {
            this.id = id;
            this.name = name;
            this.username = username;
            this.password = password;
            this.email = email;
        }
        public People(int id)
        {
            this.id = id;
        }
        public People(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}

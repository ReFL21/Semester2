using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysClassLibrary.Classes
{
    public class Staff:People
    {
        public Staff() : base() { }
        public Staff(string name, string username, string password, string email) : base(name, username, password, email) { }

        public Staff(int id, string name, string username, string password, string email) : base(id, name, username, password, email) { }
    }
}

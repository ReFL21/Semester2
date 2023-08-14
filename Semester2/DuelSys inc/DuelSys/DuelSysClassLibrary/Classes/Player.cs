using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysClassLibrary.Classes
{
   public class Player:People
    {
        public Player(int id) : base(id) { }
        public Player(int id, string name): base(id, name)
        { }
        public Player() : base() { }
        public Player(string name, string username, string password, string email) : base(name, username, password, email) { }
        public Player(int id,string name, string username, string password, string email) : base(id,name, username, password, email) { }

    }
}

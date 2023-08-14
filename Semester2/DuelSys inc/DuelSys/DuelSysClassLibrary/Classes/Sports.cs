using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysClassLibrary.Classes
{
    public class Sports
    {
        private int id;
        private string name;
        private int winningPoints;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public int WinningPoints
        {
            get { return winningPoints; }
            set { winningPoints = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Sports(string name, int winningPoint)
        {
            this.name = name;
            this.winningPoints = winningPoint;
        }
        public Sports(int id,string name, int winningPoint)
        {
            this.id = id;
            this.name = name;
            this.winningPoints = winningPoint;
        }

        public override string ToString()
        {
            return $"Id:{id}, Name:{name}";
        }

    }
}

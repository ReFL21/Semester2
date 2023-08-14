using DuelSysClassLibrary.Classes;
using DuelSysClassLibrary.Interfaces;
using System;
using System.Collections.Generic;

namespace DuelSysClassLibrary
{
    public class Tournament
    {
        private int id;
        private string description;
        private DateTime startdate;
        private DateTime enddate;
        private string city;
        private string address;
        private int minplayers;
        private int maxplayers;
        private Sports sport;
        private Status status;
        public ISystem systemOfPlay;
        private List<Player> players;

        public int ID
       {
            get { return id; }
            set { id = value; }
       }
        public int Minplayers
        {
            get { return minplayers; }
            set { minplayers = value; }
        }
   
        public int Maxplayers
        {
            get { return maxplayers; }
            set { maxplayers = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public DateTime Startdate
        {
            get { return startdate; }
            set { startdate = value; }
        }
        public DateTime Enddate
        {
            get { return enddate; }
            set { enddate = value; }
        }
        public Sports Sport
        {
            get { return sport; }
            set { sport = value; }
        }
        public Status Status
        {
            get { return status; }
            set { status = value; }
        }


        public List<Player> Players
        {
            get { return players; }
            set { players = value; }
        }


        public Tournament(string description, DateTime startdate, DateTime enddate, string city, string address, int minplayers, int maxplayers, Sports sports, Status status)
        {
            this.description = description;
            this.startdate = startdate;
            this.enddate = enddate;
            this.city = city;
            this.address = address;
            this.minplayers = minplayers;
            this.maxplayers = maxplayers;
            this.sport = sports;
            this.status = status;
            systemOfPlay = new SystemOfPlay();
        }
        public Tournament(int id, string description, DateTime startdate, DateTime enddate, string city, string address, int minplayers, int maxplayers, Sports sports, Status status)
        {
            this.id = id;
            this.description = description;
            this.startdate = startdate;
            this.enddate = enddate;
            this.city = city;
            this.address = address;
            this.minplayers = minplayers;
            this.maxplayers = maxplayers;
            this.sport = sports;
            this.status = status;
            players = new List<Player>();
            systemOfPlay = new SystemOfPlay();
        }

        public Tournament(int id)
        {
            this.id = id;
            players = new List<Player>();
            systemOfPlay = new SystemOfPlay();
        }

        public Tournament()
        {
        }

        public void CreateSchedule(Tournament tournament)
        {
            systemOfPlay.CreateSchedule(tournament);
        }
    }
}

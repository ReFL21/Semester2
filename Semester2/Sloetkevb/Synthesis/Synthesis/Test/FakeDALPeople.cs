using Synthesis.DALBoats;
using SynthesisAssignment.classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Synthesis.Test
{
    public class FakeDALPeople : IPeople
    {
        public int ExecutionAddCount { get; set; }
        public int ExecutionDeleteCount { get; set; }
        public int ExecutionCheckCount { get; set; }
        public int ExecutionGetUserCount { get; set; }
        public int ExecutionViewAllPCount { get; set; }
        public void AddPeople(People people)
        {
            ExecutionAddCount++;
        }

        public int CheckUser(string user, string pass)
        {
            ExecutionCheckCount++;
            return 1;
        }

        public void DeleteWorker(Worker worker)
        {
            ExecutionDeleteCount++;
        }

        public People GetUserByID(int id)
        {
            ExecutionGetUserCount++;
            People people = new People();
            return people;
        }

        public List<People> ViewAllPeople()
        {
            ExecutionViewAllPCount++;
            List<People> peoples = new List<People>();
            return peoples;
        }
    }
}

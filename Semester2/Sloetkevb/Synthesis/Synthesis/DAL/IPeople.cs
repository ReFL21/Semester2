using SynthesisAssignment.classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Synthesis.DALBoats
{
    public interface IPeople
    {
        public int CheckUser(string user, string pass);

        public People GetUserByID(int id);

        public void AddPeople(People people);

        public void DeleteWorker(Worker worker);

        public List<People> ViewAllPeople();
    }
}

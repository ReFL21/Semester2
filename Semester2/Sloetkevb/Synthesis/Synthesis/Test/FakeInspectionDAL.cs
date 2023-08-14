using Synthesis.DALBoats;
using SynthesisAssignment.classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Synthesis.Test
{
    public class FakeInspectionDAL : IInspection
    {
        public int ExecutionAddCount { get; set; }
        public int ExecutionViewAllICount { get; set; }
        public void AddInspection(Inspection inspection)
        {
            ExecutionAddCount++;
        }

        public List<Inspection> ViewAllInspections()
        {
            ExecutionViewAllICount++;
            List<Inspection> inspections = new List<Inspection>();
            return inspections;
        }
    }
}

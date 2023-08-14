using SynthesisAssignment.classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Synthesis.DALBoats
{
    public interface IInspection
    {
        public void AddInspection(Inspection inspection);

        public List<Inspection> ViewAllInspections();
    }
}

using Synthesis.DALBoats;
using SynthesisAssignment.classes;
using SynthesisAssignment.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SynthesisAssignment.Manager
{
   public class InspectionManager
    {
        IInspection inspectionDAL;

        public InspectionManager()
        {
        }

        public InspectionManager(IInspection inspection)
        {
            this.inspectionDAL = inspection;
        }

        public void CreateInspection(Inspection inspeciton)
        {
            inspectionDAL.AddInspection(inspeciton);
        }


        public List<Inspection> Viewinspection()
        {
            List<Inspection> inspections = inspectionDAL.ViewAllInspections();
        return inspections;
        
        }

        public List<Inspection> ViewInspectionsForRent(int id)
        {
            List<Inspection> inspections = new List<Inspection>();
            foreach (Inspection i in inspectionDAL.ViewAllInspections())
            {
                if (i.Rent.ID == id)
                {
                    inspections.Add(i);
                }
            }
            return inspections;
        }


        //public DataTable ViewAllInspections()
        //{ 
        
        
        //}
    }
}

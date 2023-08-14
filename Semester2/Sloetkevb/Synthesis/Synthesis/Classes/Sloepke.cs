using SynthesisAssignment.DAL;
using SynthesisAssignment.Manager;
using System;
using System.Collections.Generic;
using System.Text;

namespace Synthesis.Classes
{
   public class Sloepke
    {
        BoatManager boatManger = new BoatManager(new DALBoat());
        ItemsManger itemsManger = new ItemsManger(new DALItems());
        LocationManager locationManager = new LocationManager(new DALLocation());
        PeopleManager peopleManager = new PeopleManager(new DALPeople());
        RentManager rentManager = new RentManager(new DALRent());
        InspectionManager inspectionManager = new InspectionManager(new DALInspection());

        public BoatManager BoatManager
        {
            get { return boatManger; }
            set { boatManger = value; }
        }

        public ItemsManger ItemsManger
        {
            get { return itemsManger; }
            set { itemsManger = value; }
        }
        public LocationManager LocationManager
        {
            get { return locationManager; }
            set { locationManager = value; }
        }
        public PeopleManager PeopleManager
        {
            get { return peopleManager; }
            set { peopleManager = value; }
        }
        public RentManager RentManager
        {
            get { return rentManager; }
            set { rentManager = value; }
        }
        public InspectionManager InspectionManager
        {
            get { return inspectionManager; }
            set { inspectionManager = value; }
        }
    }
}

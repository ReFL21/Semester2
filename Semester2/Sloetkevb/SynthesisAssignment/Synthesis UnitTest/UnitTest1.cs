using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Synthesis.Classes;
using Synthesis.DALBoats;
using Synthesis.Test;
using SynthesisAssignment;
using SynthesisAssignment.classes;
using SynthesisAssignment.Manager;

namespace Synthesis_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
      

        [TestMethod]
        public void AddBoat()
        {
            var stub = new FakeDALBoat();
            var boatmanager = new BoatManager(stub);
            Location location = new Location(1, "test","test", "test");
            Boat boat = new Boat(1,"canue",1,1,"test",1,1,location);
            boatmanager.AddBoat(boat);
            Assert.AreEqual(boat.ID,1);
        }
        [TestMethod]
        public void AddItem()
        {
            var stub = new FakeDALItmes();
            var itemsManger = new ItemsManger(stub);
            Location location = new Location(1, "test", "test", "test");
            Items items = new Items(1,"nav", 1, 1, 1, "test", location);
            itemsManger.AddItems(items);
            Assert.AreEqual(items.ID,1);
        }

        [TestMethod]
        public void Addlocaiton()
        {
            var stub = new FakeLocationDAL();
            var locationManager = new LocationManager(stub);
            Location location = new Location(1, "test", "test", "test");
            locationManager.AddLocation(location);
            Assert.AreEqual(location.ID, 1);
        }
        [TestMethod]
        public void AddRent()
        {
            var stub = new FakeDALRent();
            var rentManager = new RentManager(stub);
            Location location = new Location(1, "test", "test", "test");
            Customer customer = new Customer(1,"asd","asda","asd", "asd", "asd", "asd",4268465);
            Rent rent = new Rent(System.DateTime.Now, System.DateTime.Now, System.DateTime.Now,customer,"test",location);
            rentManager.AddRent(rent);
            Assert.AreEqual(rent.Note,"test");
            Assert.AreEqual(rent.Location.ID, 1);
        }

        [TestMethod]
        public void AddPeople()
        {
            var stub = new FakeDALPeople();
            var peopleManager = new PeopleManager(stub);
            Location location = new Location(1, "test", "test", "test");
            Worker worker = new Worker(2,"ivan","asdad", "asdad", "asdad", "asdad", "asdasd", location);
            Customer customer = new Customer(1, "asd", "asda", "asd", "asd", "asd", "asd", 4268465);
            peopleManager.AddPeople(worker);
            peopleManager.AddPeople(customer);
            Assert.AreEqual(worker.ID, 2);
            Assert.AreEqual(customer.ID, 1);
        }

        [TestMethod]
        public void EditLocation()
        {
            var stub = new FakeLocationDAL();
            var locationManager = new LocationManager(stub);
            Location location = new Location(1, "test", "test", "test");
            locationManager.AddLocation(location);
            locationManager.EditLocation(1,"Varna", "Varna", "asdad");
            Assert.IsNotNull(stub.ExecutionEditCount);
        }
        [TestMethod]
        public void EditRent()
        {
            var stub = new FakeDALRent();
            var rentManager = new RentManager(stub);
            Location location = new Location(1, "test", "test", "test");
            Customer customer = new Customer(1, "asd", "asda", "asd", "asd", "asd", "asd", 4268465);
            Rent rent = new Rent(System.DateTime.Now, System.DateTime.Now, System.DateTime.Now, customer, "test", location);
            rentManager.AddRent(rent);
            rentManager.UpdateRent(1,System.DateTime.Now, System.DateTime.Now, System.DateTime.Now,location);
            Assert.IsNotNull(stub.ExecutionEditCount);
        }
        [TestMethod]
        public void DeleteBoat()
        {

            var stub = new FakeDALBoat();
            var boatmanager = new BoatManager(stub);
            Location location = new Location(1, "test", "test", "test");
            Boat boat = new Boat(1, "canue", 1, 1, "test", 1, 1, location);
            boatmanager.DeleteBoat(boat);
            Assert.IsNotNull(stub.ExecutionDeleteCount);
        }
        [TestMethod]
        public void DeleteLocation()
        {
            var stub = new FakeLocationDAL();
            var locationManager = new LocationManager(stub);
            Location location = new Location(1, "test", "test", "test");
            locationManager.DeleteLocation(location);
            Assert.IsNotNull(stub.ExecutionDeleteCount);
        }

        [TestMethod]
        public void DeleteItems()
        {
            var stub = new FakeDALItmes();
            var itemsManger = new ItemsManger(stub);
            Location location = new Location(1, "test", "test", "test");
            Items items = new Items(1, "nav", 1, 1, 1, "test", location);
            Assert.IsNotNull(stub.ExecutionDeleteCount);
        }
        [TestMethod]
        public void DeleteWorker()
        {
            var stub = new FakeDALPeople();
            var peopleManager = new PeopleManager(stub);
            Location location = new Location(1, "test", "test", "test");
            Worker worker = new Worker(2, "ivan", "asdad", "asdad", "asdad", "asdad", "asdasd", location);
            peopleManager.DeleteWorker(worker);
            Assert.IsNotNull(stub.ExecutionDeleteCount);
        }

        [TestMethod]
        public void ShowBoats()
        {

            var stub = new FakeDALBoat();
            var boatmanager = new BoatManager(stub);
            Location location = new Location(1, "test", "test", "test");
            Boat boat = new Boat(1, "canue", 1, 1, "test", 1, 1, location);
            boatmanager.ViewAllBoats();
            Assert.IsNotNull(stub.ExecutionViewAllBoatsCount);
        }

        [TestMethod]
        public void CheckUser()
        {
            var stub = new FakeDALPeople();
            var peopleManager = new PeopleManager(stub);
            Location location = new Location(1, "test", "test", "test");
            Worker worker = new Worker(2, "ivan", "asdad", "asdad", "asdad", "asdad", "asdasd", location);
            peopleManager.CheckUser(worker.Username, worker.Password);
            Assert.IsNotNull(stub.ExecutionCheckCount);
        }

        [TestMethod]
        public void GetUserByID()
        {
            var stub = new FakeDALPeople();
            var peopleManager = new PeopleManager(stub);
            Location location = new Location(1, "test", "test", "test");
            Worker worker = new Worker(2, "ivan", "asdad", "asdad", "asdad", "asdad", "asdasd", location);
            peopleManager.GetUser(2);
            Assert.IsNotNull(stub.ExecutionGetUserCount);

        }

        [TestMethod]
        public void AddItemsTORent()
        {
            var stub = new FakeDALItmes();
            var stubrent = new FakeDALRent();
            var itemsManger = new ItemsManger(stub);
            Location location = new Location(1, "test", "test", "test");
            Items items = new Items(1, "nav", 1, 1, 1, "test", location);
            Customer customer = new Customer(1, "asd", "asda", "asd", "asd", "asd", "asd", 4268465);
            Rent rents = new Rent(System.DateTime.Now, System.DateTime.Now, System.DateTime.Now, customer, "test", location);
            var rent = new RentManager(stubrent);
            RentedProduct rentedProducts = new RentedProduct(rents,items,1,50);
            rent.AddItemsToRent(rentedProducts);
            Assert.IsNotNull(stubrent.ExecutionAddIRCount);
        }




    }
}

using Synthesis.Classes;
using SynthesisAssignment.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SynthesisAssignment
{
    public partial class MainForm : Form
    {
        Sloepke sloepke = new Sloepke();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ContentGrid.DataSource = sloepke.BoatManager.ViewBoats();
            LocationGrid.DataSource = sloepke.LocationManager.ViewLocations();
            ItemsGrid.DataSource = sloepke.ItemsManger.ViewItems();
            EmployeeGrid.DataSource = sloepke.PeopleManager.ViewAllPeople();
            RentGrid.DataSource = sloepke.RentManager.ViewAllRent();
            
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.ShowDialog();
            
        }

        private void btnAddBoatForm_Click(object sender, EventArgs e)
        {
            AddBoat addBoat = new AddBoat();
            addBoat.ShowDialog();
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            AddLocation location = new AddLocation();
            location.ShowDialog();
        }

        private void btnDeleteLocation_Click(object sender, EventArgs e)
        {
            foreach (Location location in sloepke.LocationManager.ViewAllLocations())
            {
                if (location.ID == (int)LocationGrid.SelectedRows[0].Cells[0].Value)
                {
                  sloepke.LocationManager.DeleteLocation(location);
                    MessageBox.Show("The Location is deleted!");
                }
            }
            
        }

        private void btnDeleteEmp_Click(object sender, EventArgs e)
        {
            foreach (People worker in sloepke.PeopleManager.ViewPeople())
            {
                if (worker is Worker)
                {
                    if (worker.ID == (int)EmployeeGrid.SelectedRows[0].Cells[0].Value)
                    {
                        sloepke.PeopleManager.DeleteWorker((Worker)worker);
                        MessageBox.Show("the worker is delete successfully!");
                    }
                }
              
            }
            
           
        }

        private void btnDeleteBoat_Click(object sender, EventArgs e)
        {
            foreach (Boat boat in sloepke.BoatManager.ViewAllBoats())
            {
                if (boat.ID == (int)ContentGrid.SelectedRows[0].Cells[0].Value)
                {
                    sloepke.BoatManager.DeleteBoat(boat);
                    MessageBox.Show("The boat is deleted!");
                }
            }
      
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddItem addItem = new AddItem();
            addItem.ShowDialog();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            foreach (Items item in sloepke.ItemsManger.ViewAllItmes())
            {
                if (item.ID == (int)ItemsGrid.SelectedRows[0].Cells[0].Value)
                {
                    sloepke.ItemsManger.Deleteitem(item);
                }
            }
      
        }

        private void btnEditLocation_Click(object sender, EventArgs e)
        {
            EditLocation editLocation = new EditLocation();
            editLocation.ShowDialog();
        }

        private void btnEmpGridRefresh_Click(object sender, EventArgs e)
        {
            EmployeeGrid.DataSource = null;
            EmployeeGrid.Rows.Clear();
            EmployeeGrid.DataSource = sloepke.PeopleManager.ViewAllPeople();
        }

        private void btnLocationGridRefresh_Click(object sender, EventArgs e)
        {
            LocationGrid.DataSource = null;
            LocationGrid.Rows.Clear();
            LocationGrid.DataSource = sloepke.LocationManager.ViewLocations();

        }

        private void btnRefreshGrid_Click(object sender, EventArgs e)
        {

            ContentGrid.DataSource = null;
            ContentGrid.Rows.Clear();
            ContentGrid.DataSource = sloepke.BoatManager.ViewBoats();
        }

        private void btnRefreshItemsGrid_Click(object sender, EventArgs e)
        {
            ItemsGrid.DataSource = null;
            ItemsGrid.Rows.Clear();
            ItemsGrid.DataSource = sloepke.ItemsManger.ViewItems();
        }

        private void btnInspection_Click(object sender, EventArgs e)
        {
         
            foreach (Rent rent in sloepke.RentManager.ViewRents())
            {
                if (rent.ID == (int) RentGrid.Rows[0].Cells[0].Value)
                {
                    Inspections inspection = new Inspections();
                    inspection.lblRentDocID.Text = rent.ToString();
                    inspection.ShowDialog();
                   
                }
                
            }

        }

        private void RentGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RentedProducts byRent = new RentedProducts();
            
            foreach (Rent item in sloepke.RentManager.ViewRents())
            {
                if (item.ID == (int)RentGrid.Rows[0].Cells[0].Value)
                {
                    byRent.RentedProductsGrid.DataSource = sloepke.RentManager.ViewProductsByRent(item); 
                }
            }
        }

        private void btnFinishrent_Click(object sender, EventArgs e)
        {
            foreach (Rent item in sloepke.RentManager.ViewRents())
            {
                if (item.ID == (int)RentGrid.Rows[0].Cells[0].Value)
                {
                    
                    sloepke.RentManager.EndRent(item,(RentalStatus)2);
                }
            }
        }

        private void btnRefreshrentGrid_Click(object sender, EventArgs e)
        {
            RentGrid.DataSource = null;
            RentGrid.Rows.Clear();
            RentGrid.DataSource = sloepke.RentManager.ViewAllRent();
        }

        private void btnViewAllInspections_Click(object sender, EventArgs e)
        {
            ViewInspections inspections = new ViewInspections();
            inspections.InspectionsGrid.DataSource = sloepke.InspectionManager.Viewinspection();
        }
    }
}

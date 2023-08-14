using Synthesis.Classes;
using SynthesisAssignment.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SynthesisAssignment
{
    public partial class AddEmployee : Form
    {
        Sloepke sloepke = new Sloepke();
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            foreach (Location locations in sloepke.LocationManager.ViewAllLocations())
            {
                if (locations.ToString() == cbLocation.SelectedItem.ToString())
                {
                    sloepke.PeopleManager.AddPeople(new Worker(tbEName.Text, tbEUsername.Text, tbEPassword.Text, tbEAddress.Text, tbECity.Text, tbEEmail.Text, locations));
                    MessageBox.Show("The Worker is added successfully!");
                }
            }
           
        }

        private void cbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            foreach (Location locations in sloepke.LocationManager.ViewAllLocations())
            {
                cbLocation.Items.Add(locations.ToString());
            }
            
        }
    }
}

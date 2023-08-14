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
    public partial class AddBoat : Form
    {
        Sloepke sloepke = new Sloepke();
        public AddBoat()
        {
            InitializeComponent();
        }

        private void btnAddBoat_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(tbBQuantity.Text);
            int capacity = Convert.ToInt32(tbBCapacity.Text);
            int deposit = Convert.ToInt32(tbBDeposit.Text);
            int costper2hours = Convert.ToInt32(tbCostPer2Hours.Text);
            foreach (Location locations in sloepke.LocationManager.ViewAllLocations())
            {
                if (locations.ToString() == cbLocation.SelectedItem.ToString())
                {
                    sloepke.BoatManager.AddBoat(new Boat(cbBType.SelectedItem.ToString(), quantity, costper2hours, rtbBRemark.Text, deposit, capacity, locations));
                    MessageBox.Show("The boat was created successfully!");
                }
            }
        }

        private void AddBoat_Load(object sender, EventArgs e)
        {
            foreach (Location locations in sloepke.LocationManager.ViewAllLocations())
            {
                cbLocation.Items.Add(locations.ToString());
            }
            cbBType.Items.Add("Kayak");
            cbBType.Items.Add("Canoe");
            cbBType.Items.Add("Sailboat Laser");
            cbBType.Items.Add("Sailboat Valkf");
        }
    }
}

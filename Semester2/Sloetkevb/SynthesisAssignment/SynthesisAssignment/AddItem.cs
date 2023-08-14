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
    public partial class AddItem : Form
    {
        Sloepke sloepke = new Sloepke();
        public AddItem()
        {
            InitializeComponent();
        }


        private void btnAddItem_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(tbIQuantity.Text);
            int deposit = Convert.ToInt32(tbIDeposit.Text);
            int costper2Hour = Convert.ToInt32(tbICostPer2Hours.Text);
            foreach (Location locations in sloepke.LocationManager.ViewAllLocations())
            {
                if (locations.ToString() == cbILocation.SelectedItem.ToString())
                {
                    sloepke.ItemsManger.AddItems(new classes.Items(tbIName.Text, deposit, costper2Hour, quantity, rtbIRemark.Text, locations));
                    MessageBox.Show("The Items was created succesfully!");
                }
            }
          
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            foreach (Location locations in sloepke.LocationManager.ViewAllLocations())
            {
                cbILocation.Items.Add(locations.ToString());
            }
        }
    }
}

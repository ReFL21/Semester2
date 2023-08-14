using Synthesis.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SynthesisAssignment
{
    public partial class AddLocation : Form
    {
        Sloepke sloepke = new Sloepke();
        public AddLocation()
        {
            InitializeComponent();
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            sloepke.LocationManager.AddLocation(new classes.Location(tbLName.Text, tbLCity.Text, tbLAddress.Text));
            MessageBox.Show("The Location was created syccessfully!");
        }
    }
}

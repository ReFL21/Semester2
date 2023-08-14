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
    public partial class EditLocation : Form
    {
        Sloepke sloepke = new Sloepke();
        public EditLocation()
        {
            InitializeComponent();
        }

        private void btnEditLocation_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbLID.Text);

            sloepke.LocationManager.EditLocation(id, tbLName.Text, tbCity.Text,tbLAddress.Text);
            MessageBox.Show("Location was edited!");
        }
    }
}

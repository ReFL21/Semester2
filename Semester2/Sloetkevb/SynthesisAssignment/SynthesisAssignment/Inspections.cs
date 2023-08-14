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
    public partial class Inspections : Form
    {
        Sloepke slopke = new Sloepke();
        public Inspections()
        {
            InitializeComponent();
        }
        public void CalculatePrice()
        {
            if (rbtnDamaged.Checked)
            {
                int damage = Convert.ToInt32(tbDamage.Text);
                foreach (Rent item in slopke.RentManager.ViewRents())
                {
                    if (item.ToString() == lblRentDocID.Text)
                    {
                        
                    }
                }

            }
        
        }
        private void btnCreateInspection_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rtbNote.Text))
            {
                MessageBox.Show("Please type your notes for the conditiion of the boat!");
            }
            else
            {
               

                foreach (Worker worker in slopke.PeopleManager.ViewLoggedPerson())
                {
                    foreach (Rent item in slopke.RentManager.ViewRents())
                    {
                        if (item.ToString() == lblRentDocID.Text)
                        {
                             slopke.InspectionManager.CreateInspection(new Inspection(DateTime.Now, item, worker, rtbNote.Text));
                             MessageBox.Show("Inspection created successfully!");   

                        }
                    }
                }
               
               
            }
        }
    }
}

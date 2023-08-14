using DuelSysClassLibrary.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DuelSys
{
    public partial class AddStaff : Form
    {

        DuelSysInc duelSys = new DuelSysInc();
        public AddStaff()
        {
            InitializeComponent();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            try
            {
                duelSys.PeopleManager.Register(new Staff(tbSName.Text, tbSUsername.Text, tbSPass.Text, tbSEmail.Text));
                MessageBox.Show("The staff is added!");
            }
            catch (FormatException)
            {

                MessageBox.Show("Please follow the correct format!");
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
            
        }
    }
}

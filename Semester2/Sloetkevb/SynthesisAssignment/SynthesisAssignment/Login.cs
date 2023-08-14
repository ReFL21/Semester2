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
    public partial class Login : Form
    {
        Sloepke sloepke = new Sloepke();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUsername.Text)||string.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("Please type your username/password");
            }
            else
            {
               int check = sloepke.PeopleManager.CheckUser(tbUsername.Text, tbPassword.Text);
                if (check!= -1)
                {
                   var person= sloepke.PeopleManager.GetUser(check);
                   
                            if (person is Worker)
                            {
                                sloepke.PeopleManager.AddLoggedWInList((Worker)person);
                                if (((Worker)person).Location.ID != 1)
                                {
                                    MainForm mainForm1 = new MainForm();

                                    mainForm1.tPBoats.Hide();
                                    mainForm1.tPEmployee.Hide();
                                    mainForm1.tPItems.Hide();
                                    mainForm1.tPLocation.Hide();
                                    mainForm1.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MainForm mainForm = new MainForm();
                                    this.Hide();
                                    mainForm.Show();     
                                }
                               
                            }
                            else
                            {
                                MessageBox.Show("Please login as Worker!");
                            }
                        
                    
                   
                }
            }
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.ShowDialog();
        }
    }
}

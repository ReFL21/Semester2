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
    public partial class Login : Form
    {
        DuelSysInc duelSys = new DuelSysInc();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
          int result=  duelSys.PeopleManager.CheckUser(tbUsername.Text, tbPass.Text);
            if (result != -1)
            {
                People people = duelSys.PeopleManager.GetPerson(result);
                if (people is Staff)
                {
                    Form1 form1 = new Form1();
                    this.Hide();
                    form1.Show();
                }
                else
                {
                    MessageBox.Show("Only Staff members have access to this application!");
                }
            }
            else
            {
                MessageBox.Show("Please change you Username/Password!");
            }
        }
    }
}

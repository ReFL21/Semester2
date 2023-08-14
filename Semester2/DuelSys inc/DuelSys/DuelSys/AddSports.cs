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
    public partial class AddSports : Form
    {
        DuelSysInc duelSys = new DuelSysInc();
        public AddSports()
        {
            InitializeComponent();
        }


        private void btnAddSport_Click(object sender, EventArgs e)
        {
            duelSys.SportManager.AddSport(new Sports(tbSName.Text, Convert.ToInt32(tbSWinningP.Text)));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}

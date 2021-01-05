using System;
using System.Windows.Forms;
using WarQuest.WinFormMVC.Models;

namespace WarQuest.WinFormMVC
{
    public partial class frmUniversSelector : Form
    {
        public frmUniversSelector()
        {
            InitializeComponent();
        }
   
        private void picbxHuman_Click(object sender, EventArgs e)
        {
            MainForm myForm = new MainForm();
            myForm.UnitType = Unit.UnitType.Human;
            myForm.Show();
        }

        private void picbxMonster_Click(object sender, EventArgs e)
        {
            MainForm myForm = new MainForm();
            myForm.UnitType = Unit.UnitType.Monster;
            myForm.Show();
        }

        private void picbxVehicle_Click(object sender, EventArgs e)
        {
            MainForm myForm = new MainForm();
            myForm.UnitType = Unit.UnitType.Vehicle;
            myForm.Show();
        }

    }
}

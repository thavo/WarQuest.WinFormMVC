using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarQuest.WinFormMVC
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Text += string.Format(" Size {0} x {1} ", Models.Board.WIDTH_SIZE, Models.Board.HEIGHT_SIZE);

        }

        private void butStart_Click(object sender, EventArgs e)
        {
            Models.UnitCollection myUnits = new Models.UnitCollection();
            myUnits.AddRandomDifferentUnitTypes(22, 120);

            for (int i=0; i < myUnits.Count(); i++)
            {
                var myItem = myUnits.Units()[i];

                // speedPower, int jumpPower, int lifeLevel, int attackLevel, int cost
                lstBxUnits.Items.Add( String.Format("Unit type {0}, Speed={1}, Jump={2}, Life={3}, Attack={4}, Cost {5}", 
                    myItem.GetType().ToString().Replace("WarQuest.WinFormMVC.Models.", ""),
                    myItem.SpeedPower,
                    myItem.JumpPower,
                    myItem.LifeLevel,
                    myItem.AttackLevel,
                    myItem.Cost

                    )
                 );

            }
        }

        private void lstBxUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
                            
            var myForm = new frmBoard();
            myForm.ChosenUnit = lstBxUnits.SelectedItem.ToString();

            // MessageBox.Show("Vous avez choisi : " + myForm.ChosenUnit);

            myForm.Show();
        }
    }
}

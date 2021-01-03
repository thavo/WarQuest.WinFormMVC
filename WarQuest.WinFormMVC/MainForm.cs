using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarQuest.WinFormMVC.Models;
using WarQuest.WinFormMVC.Presenters;

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
            UnitCollection myUnits = new UnitCollection();
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

            myForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UnitCollection myUnits = new UnitCollection();
            myUnits.CreateRandomUnits(imageListUnits);

            int index = 0;
            foreach (Unit unit in myUnits.Units())
            {
                // speedPower, int jumpPower, int lifeLevel, int attackLevel, int cost
                lstViewAvailableUnits.Items.Add(
                    String.Format("{0}_{1}: S={2}, Jmp={3}, PV={4}, Attack={5}, ${6}",
                    unit.Index,
                    unit.GetType().ToString().Replace("WarQuest.WinFormMVC.Models.Unit", String.Empty),
                    unit.SpeedPower,
                    unit.JumpPower,
                    unit.LifeLevel,
                    unit.AttackLevel,
                    unit.Cost
                    ), 
                    index++
                 );
            }
        }

        private void lstViewAvailableUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayIntoListTheChosenUnits();
        }

        private void DisplayIntoListTheChosenUnits()
        {
            lstBxUnits.Items.Clear();

            if (lstViewAvailableUnits.SelectedItems.Count >= 1)
            {
                string str = "";
                lblChosen.Text = "";

                ListViewItem item = lstViewAvailableUnits.SelectedItems[lstViewAvailableUnits.SelectedItems.Count - 1];
                if (item != null)
                {
                    foreach (ListViewItem lv in lstViewAvailableUnits.SelectedItems)
                    {
                        lstBxUnits.Items.Add(lv.SubItems[0].Text);
                        str += lv.SubItems[0].Text;

                        lblChosen.Text += lv.Index + " ";
                    }
                }
                else if (lstViewAvailableUnits.SelectedItems.Count > 1)
                {

                }
                else
                {
                    throw (new Exception("Impossible case"));
                }
                this.Text = "";
            }
        }
    }
}

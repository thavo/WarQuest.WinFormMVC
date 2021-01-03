using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WarQuest.WinFormMVC.Models;
using WarQuest.WinFormMVC.Presenters;

namespace WarQuest.WinFormMVC
{
    public partial class MainForm : Form
    {
        UnitCollection _myUnits = new UnitCollection();

        public MainForm()
        {
            InitializeComponent();
            this.Text = string.Format("{0} ; Board size {1} x {2} ", Models.Board.GAME_CODE_NAME, Models.Board.WIDTH_SIZE, Models.Board.HEIGHT_SIZE);

            this._myUnits.CreateRandomUnits(imageListUnits);
            lblCheckMaxSpendingMoney.Text = String.Empty;
        }

        private void butStart_Click(object sender, EventArgs e)
        {
            var myForm = new frmBoard();
            myForm.UnitsWithChoices = _myUnits.GetSelectedUnits();
            myForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DisplayListOfAllUnits();
        }

        private void DisplayListOfAllUnits()
        {
            int index = 0;
            foreach (Unit unit in this._myUnits.Units())
            {
                // Retrieves the various Unit's properties to the list view
                lstViewAvailableUnits.Items.Add(
                    String.Format("{0}_{1}: S={2}, Jmp={3}, PV={4}, Attack={5}, ${6}",
                    unit.Index,
                    // Retrieves the FileName, via Keys[]
                    this.imageListUnits.Images.Keys[index],
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
            string listOfChosenIndex = String.Empty;
            lblTotalMoneySpent.Text = String.Empty;
            lblCheckMaxSpendingMoney.Text = String.Empty;

            int totalMoneySpent = 0;
            this._myUnits.ClearAllSelectedUnits();

            lblChosen.Text = listOfChosenIndex = DisplayIntoListTheChosenUnits(lstBxUnits);
            // totalMoneySpent = 

            TagChosenUnitAsSelected(listOfChosenIndex, totalMoneySpent);

            int totalSelectedMoney = this._myUnits.GetTotalMoneySelected();
            lblTotalMoneySpent.Text += "; Total=" + totalSelectedMoney.ToString();

            if (totalSelectedMoney > Models.PlayerOneGame.MAX_SPENDING_MONEY)
            {
                lblCheckMaxSpendingMoney.Text = String.Format(
                    "NOT ENOUGH MONEY ({0} MAX = {1})",
                    totalSelectedMoney.ToString(),
                    Models.PlayerOneGame.MAX_SPENDING_MONEY.ToString()
                    );
            }
        }

        private void TagChosenUnitAsSelected(string listOfChosenIndex, int totalMoneySpent)
        {
            // From the list of chosen Items, extract the Index and find the corresponding Money of the corresponding Units
            Array arr = listOfChosenIndex.Split(' ');
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int chosenIndex = 0;
                int.TryParse(arr.GetValue(i).ToString(), out chosenIndex);

                var unitSelected = this._myUnits.Units()[chosenIndex];
                unitSelected.IsSelected = true;

                lblTotalMoneySpent.Text += "+" + unitSelected.Cost.ToString();
            }
        }

        private String DisplayIntoListTheChosenUnits(ListBox mylstBxUnits)
        {
            string strChosenIndex = "";

            mylstBxUnits.Items.Clear();

            if (lstViewAvailableUnits.SelectedItems.Count >= 1)
            {
                lblChosen.Text = "";

                ListViewItem item = lstViewAvailableUnits.SelectedItems[lstViewAvailableUnits.SelectedItems.Count - 1];
                if (item != null)
                {
                    foreach (ListViewItem lv in lstViewAvailableUnits.SelectedItems)
                    {
                        mylstBxUnits.Items.Add(lv.SubItems[0].Text);
                        strChosenIndex += lv.Index + " ";
                    }
                }
                else
                {
                    throw (new Exception("Impossible case"));
                }
            }

            return strChosenIndex;
        }

        private void menuStripMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Open a Web Browser
            string url = "https://github.com/thavo/WarQuest.WinFormMVC";

            try
            {
                Process.Start(url);
            }
            catch
            {
                // hack because of this: https://github.com/dotnet/corefx/issues/10361
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }
    }
}

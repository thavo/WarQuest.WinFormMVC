/// /////////////////////////////////////////////////////////////////////////////////////////////////////
/// FileName: MainForm.cs
/// FileType: Visual C# Source file
/// Author : Sanouche
/// Application codename : WarQuest
/// Audience : Dev by Kids, for Kids !
/// Created On : 01/01/2021
/// Copy Rights : MIT License
/// Description : Class for defining database related functions
/// License : MIT License, https://opensource.org/licenses/MIT
/// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
/// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR 
/// PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, 
/// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
/// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
/// ////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WarQuest.WinFormMVC.Models;

namespace WarQuest.WinFormMVC
{
    public partial class MainForm : Form
    {
        private System.Drawing.Color BUILDER_COLOR = System.Drawing.Color.FromArgb(133, 220, 123);
        private System.Drawing.Color DESTROYER_COLOR = System.Drawing.Color.FromArgb(200, 255, 153);
        private System.Drawing.Color HUMAN_COLOR = System.Drawing.Color.FromArgb(223, 100, 223);
        private System.Drawing.Color MONSTER_COLOR = System.Drawing.Color.FromArgb(100, 210, 223);
        private System.Drawing.Color VEHICLE_COLOR = System.Drawing.Color.FromArgb(223, 200, 123);

        private const int FIRST_FOUR_CHARS = 4;

        const string IMPOSSIBLECASE = "Impossible case";
        UnitCollection _myUnits = null;
        public Unit.UnitType UnitType { get; internal set; }

        public MainForm()
        {
            this.InitializeComponent();
            this.Text = string.Format(CultureInfo.InvariantCulture, "{0} ; Board size {1} x {2} ", Models.Board.GAME_CODE_NAME, Models.Board.WIDTH_SIZE, Models.Board.HEIGHT_SIZE);

            
            // Create ALL UNITS of ALL TYPES (thavo will be filtered out one the player chooses a unit type
            _myUnits = new UnitCollection();
            this._myUnits.CreateRandomUnits(this.imageListUnits, Unit.UnitType.NotDefined);

            lblCheckMaxSpendingMoney.Text = string.Empty;
        }

        private void butStart_Click(object sender, EventArgs e)
        {
            var myForm = new frmBoard();
            myForm.UnitsWithChoices = this._myUnits.GetSelectedUnits();
            myForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.DisplayListOfAllUnits(this.UnitType);
        }

        /// <summary>
        /// Displays ONLY the Unit of type the one that was selected previously.
        /// </summary>
        /// <param name="myUnitType"></param>
        private void DisplayListOfAllUnits(Unit.UnitType myUnitType)
        {
            int index = 0;

            foreach (Unit unit in this._myUnits.Units())
            {
                // Retrieves the FileName, via Keys[], and assign to Unit
                unit.FileName = this.imageListUnits.Images.Keys[index];

                // Build the text to display
                string itemText = string.Format(
                    CultureInfo.InvariantCulture,
                    "{0}_{1}: S={2}, Jmp={3}, PV={4}, Attack={5}, ${6}",
                    unit.Index,
                    unit.FileName,
                    unit.SpeedPower,
                    unit.JumpPower,
                    unit.LifeLevel,
                    unit.AttackLevel,
                    unit.Cost);

                // Retrieves the various Unit's properties to the list view
                lstViewAvailableUnits.Items.Add(itemText, index);

                // Take first x chars
                string prefixFileName = unit.FileName.Substring(0, FIRST_FOUR_CHARS);

                // check prefix fileName
                if (prefixFileName == "Buil" && myUnitType == Unit.UnitType.Builder)
                {
                    this.lstViewAvailableUnits.Items[index].BackColor = this.BUILDER_COLOR;
                }
                else if (prefixFileName == "Dest" && myUnitType == Unit.UnitType.Destroyer)
                {
                    this.lstViewAvailableUnits.Items[index].BackColor = this.DESTROYER_COLOR;
                }
                else if (prefixFileName == "Hum-" && myUnitType == Unit.UnitType.Human)
                {
                    this.lstViewAvailableUnits.Items[index].BackColor = this.HUMAN_COLOR;
                }
                else if (prefixFileName == "Mon-" && myUnitType == Unit.UnitType.Monster)
                {
                    this.lstViewAvailableUnits.Items[index].BackColor = this.MONSTER_COLOR;
                }
                else if (prefixFileName == "Veh-" && myUnitType == Unit.UnitType.Vehicle)
                {
                    this.lstViewAvailableUnits.Items[index].BackColor = this.VEHICLE_COLOR;
                }
                index++;
            }
        }

        private void lstViewAvailableUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            string listOfChosenIndex = string.Empty;
            this.lblTotalMoneySpent.Text = string.Empty;
            this.lblCheckMaxSpendingMoney.Text = string.Empty;

            this._myUnits.ClearAllSelectedUnits();

            this.lblChosen.Text = listOfChosenIndex = this.DisplayIntoListTheChosenUnits(this.lstBxUnits);

            this.TagChosenUnitAsSelected(listOfChosenIndex);

            int totalSelectedMoney = this._myUnits.GetTotalMoneySelected();
            this.lblTotalMoneySpent.Text += "; Total=" + totalSelectedMoney.ToString(CultureInfo.InvariantCulture);

            if (totalSelectedMoney > Models.PlayerOneGame.MAXSPENDINGMONEY)
            {
                this.lblCheckMaxSpendingMoney.Text = string.Format(
                    CultureInfo.InvariantCulture,
                    "NOT ENOUGH MONEY ({0} MAX = {1})",
                    totalSelectedMoney.ToString(CultureInfo.InvariantCulture),
                    Models.PlayerOneGame.MAXSPENDINGMONEY.ToString(CultureInfo.InvariantCulture));
            }
        }

        private void TagChosenUnitAsSelected(string listOfChosenIndex)
        {
            // From the list of chosen Items, extract the Index and find the corresponding Money of the corresponding Units
            Array arr = listOfChosenIndex.Split(' ');
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int chosenIndex = 0;
                bool success = int.TryParse(arr.GetValue(i).ToString(), out chosenIndex);

                if (success)
                {
                    var unitSelected = this._myUnits.Units()[chosenIndex];
                    unitSelected.IsSelected = true;

                    lblTotalMoneySpent.Text += "+" + unitSelected.Cost.ToString(CultureInfo.InvariantCulture);
                }
            }
        }

        private string DisplayIntoListTheChosenUnits(ListBox mylstBxUnits)
        {
            string strChosenIndex = string.Empty;

            mylstBxUnits.Items.Clear();

            if (lstViewAvailableUnits.SelectedItems.Count >= 1)
            {
                lblChosen.Text = string.Empty;

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
                    throw new Exception(IMPOSSIBLECASE);
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

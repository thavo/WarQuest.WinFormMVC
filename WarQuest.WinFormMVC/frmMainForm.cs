/// /////////////////////////////////////////////////////////////////////////////////////////////////////
/// FileName: frmainForm.cs
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
    public partial class frmMainForm : Form
    {
        private System.Drawing.Color BUILDER_COLOR = System.Drawing.Color.FromArgb(133, 220, 123);
        private System.Drawing.Color DESTROYER_COLOR = System.Drawing.Color.FromArgb(200, 255, 153);
        private System.Drawing.Color HUMAN_COLOR = System.Drawing.Color.FromArgb(223, 100, 223);
        private System.Drawing.Color MONSTER_COLOR = System.Drawing.Color.FromArgb(100, 210, 223);
        private System.Drawing.Color VEHICLE_COLOR = System.Drawing.Color.FromArgb(223, 200, 123);

        private const int FIRST_FOUR_CHARS = 4;

        const string IMPOSSIBLECASE = "Impossible case";
        internal UnitCollection _myUnits = null;
        public Unit.UnitTypeEnum UnitType { get; internal set; }

        public frmMainForm()
        {
            this.InitializeComponent();
            this.Text = string.Format(CultureInfo.InvariantCulture, "{0} ; Board size {1} x {2} ", Models.Board.GAME_CODE_NAME, Models.Board.WIDTH_SIZE, Models.Board.HEIGHT_SIZE);
            _myUnits = new UnitCollection();
        }

        private void butStart_Click(object sender, EventArgs e)
        {
            var myForm = new frmBoard();
            myForm.UnitsWithChoices = this._myUnits.GetSelectedUnits();
            myForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this._myUnits.CreateRandomUnits(this.imageListUnits, UnitType);
            this.DisplayListOfAllUnits(this.UnitType);
        }

        private void RemoveUnselectedItemsFromList()
        {
            this._myUnits.DeleteUnselectedUnits();
        }

        private void ExtractImageFileNameToUnit()
        {
            int index = 0;

            foreach (Unit unit in this._myUnits.Units())
            {
                // Retrieves the FileName, via Keys[], and assign to Unit
                unit.FileName = this.imageListUnits.Images.Keys[index++];
            }
        }

            /// <summary>
            /// Displays ONLY the Unit of type the one that was selected previously.
            /// </summary>
            /// <param name="myUnitType"></param>
            private void DisplayListOfAllUnits(Unit.UnitTypeEnum myUnitType)
        {
            // int index = 0;

            foreach (Unit unit in this._myUnits.Units())
            {
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

                // Take first x chars
                string prefixFileName = unit.FileName.Substring(0, FIRST_FOUR_CHARS);

                // check prefix fileName and if corresponding UnitType
                if (prefixFileName == "Buil" && myUnitType == Unit.UnitTypeEnum.Builder)
                {
                    unit.IsSelected = true;
                }
                else if (prefixFileName == "Dest" && myUnitType == Unit.UnitTypeEnum.Destroyer)
                {
                    unit.IsSelected = true;
                }
                else if (prefixFileName == "Hum-" && myUnitType == Unit.UnitTypeEnum.Human)
                {
                    unit.IsSelected = true;
                }
                else if (prefixFileName == "Mon-" && myUnitType == Unit.UnitTypeEnum.Monster)
                {
                    unit.IsSelected = true;
                }
                else if (prefixFileName == "Veh-" && myUnitType == Unit.UnitTypeEnum.Vehicle)
                {
                    unit.IsSelected = true;
                }

                // Add the unit ONLY if it was selected as a corresponding Universe
                if (unit.IsSelected)
                {
                    this.lstViewAvailableUnits.Items.Add(itemText, unit.Index);
                    this.lstViewAvailableUnits.Items[this.lstViewAvailableUnits.Items.Count-1].BackColor = System.Drawing.Color.FromArgb(133, 220, 123);
                }
            }
        }

        private string DisplayIntoListTheChosenUnits(ListBox mylstBxUnits)
        {
            string strChosenIndex = string.Empty;

            mylstBxUnits.Items.Clear();

            if (lstViewAvailableUnits.SelectedItems.Count >= 1)
            {
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

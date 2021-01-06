/// /////////////////////////////////////////////////////////////////////////////////////////////////////
/// FileName: frmBoard.cs
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
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using WarQuest.WinFormMVC.Models;

namespace WarQuest.WinFormMVC
{
    public partial class frmBoard : Form
    {
        // Internal, so that the main form FROM WITHIN THE SAME PROJECT could access it
        internal UnitCollection UnitsWithChoices { get; set; }
        public Unit.UnitTypeEnum UnitType { get; internal set; }

        public frmBoard()
        {
            this.InitializeComponent();
        }

        private void frmBoard_Load(object sender, EventArgs e)
        {
            this.Text += this.UnitsWithChoices.Count().ToString(CultureInfo.InvariantCulture) + " ; total cost" + this.UnitsWithChoices.TotalCost().ToString(CultureInfo.InvariantCulture);
            this.lblTotalCostInitialUnits.Text = this.UnitsWithChoices.TotalCostOfSelectedUnits().ToString(CultureInfo.InvariantCulture);
            this.lblInitialSpendingMoney.Text = Models.PlayerOneGame.INTIALLYSPENDINGMONEY.ToString(CultureInfo.InvariantCulture);

            // FillInWithImagesDynamic();
            this.FillInWithImagesStatic();
        }

        /// <summary>
        /// We have 20 static images place holder. Not great for evolutions, but easier to code !
        /// </summary>
        private void FillInWithImagesStatic()
        {
            // UnitsWithChoices.DeleteUnselectedUnits();
            UnitCollection myChosenUnits = new UnitCollection();
            myChosenUnits = this.UnitsWithChoices.GetSelectedUnits();

            int countSelectedUnits = myChosenUnits.Count();

            // Ugly but : Fills in the 20 static picture boxes
            if (countSelectedUnits >= 20) { this.pxBxUnit20.Image = myChosenUnits.Units()[19].Image; }
            if (countSelectedUnits >= 19) { this.pxBxUnit19.Image = myChosenUnits.Units()[18].Image; }
            if (countSelectedUnits >= 18) { this.pxBxUnit18.Image = myChosenUnits.Units()[17].Image; }
            if (countSelectedUnits >= 17) { this.pxBxUnit17.Image = myChosenUnits.Units()[16].Image; }
            if (countSelectedUnits >= 16) { this.pxBxUnit16.Image = myChosenUnits.Units()[15].Image; }
            if (countSelectedUnits >= 15) { this.pxBxUnit15.Image = myChosenUnits.Units()[14].Image; }
            if (countSelectedUnits >= 14) { this.pxBxUnit14.Image = myChosenUnits.Units()[13].Image; }
            if (countSelectedUnits >= 13) { this.pxBxUnit13.Image = myChosenUnits.Units()[12].Image; }
            if (countSelectedUnits >= 12) { this.pxBxUnit12.Image = myChosenUnits.Units()[11].Image; }
            if (countSelectedUnits >= 11) { this.pxBxUnit11.Image = myChosenUnits.Units()[10].Image; }
            if (countSelectedUnits >= 10) { this.pxBxUnit10.Image = myChosenUnits.Units()[9].Image; }
            if (countSelectedUnits >= 9) { this.pxBxUnit09.Image = myChosenUnits.Units()[8].Image; }
            if (countSelectedUnits >= 8) { this.pxBxUnit08.Image = myChosenUnits.Units()[7].Image; }
            if (countSelectedUnits >= 7) { this.pxBxUnit07.Image = myChosenUnits.Units()[6].Image; }
            if (countSelectedUnits >= 6) { this.pxBxUnit06.Image = myChosenUnits.Units()[5].Image; }
            if (countSelectedUnits >= 5) { this.pxBxUnit05.Image = myChosenUnits.Units()[4].Image; }
            if (countSelectedUnits >= 4) { this.pxBxUnit04.Image = myChosenUnits.Units()[3].Image; }
            if (countSelectedUnits >= 3) { this.pxBxUnit03.Image = myChosenUnits.Units()[2].Image; }
            if (countSelectedUnits >= 2) { this.pxBxUnit02.Image = myChosenUnits.Units()[1].Image; }
            if (countSelectedUnits >= 1) { this.pxBxUnit01.Image = myChosenUnits.Units()[0].Image; }
        }

        private void FillInWithImagesDynamic()
        {
            PictureBox picbxTest = null;
            int HIEGHT_ICON_SIZE = 100;

            for (int i = 0; i < 19; i++)
            {
                picbxTest = new PictureBox();
                picbxTest.Image = this.UnitsWithChoices.Units()[i].Image;
                picbxTest.Name = "Name_" + i.ToString(CultureInfo.InvariantCulture);
                picbxTest.Height = HIEGHT_ICON_SIZE;

                picbxTest.Dispose();
            }
        }

        private void panelBoard_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            for (int i = 0; i < Models.Board.SQUARE_SIZE * Models.Board.HEIGHT_SIZE; i = i + Models.Board.SQUARE_SIZE)
            {
                for (int j = 0; j < Models.Board.SQUARE_SIZE * Models.Board.WIDTH_SIZE; j = j + Models.Board.SQUARE_SIZE)
                {
                    int PointX1 = i;
                    int PointX2 = j;

                    g.DrawRectangle(Pens.Red, PointX1, PointX2, Models.Board.SQUARE_SIZE, Models.Board.SQUARE_SIZE);
                }
            }
        }

        private void btnPlace_Click(object sender, EventArgs e)
        {

        }

        private void panelBoard_MouseMove(object sender, MouseEventArgs e)
        {
            const int POS_SHIFT = 10;

            this.picBxToPlace.Visible = true;
            this.picBxToPlace.Location = new Point(POS_SHIFT + e.X, POS_SHIFT + e.Y);

        }

        private void panelBoard_MouseClick(object sender, MouseEventArgs e)
        {
            this.picBxToPlace.Location = new Point(e.X, e.Y);

            // unregister this.panelBoard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBoard_MouseMove);
            this.panelBoard.MouseMove -= this.panelBoard_MouseMove;
        }

        private void pxBxUnit01_DragEnter(object sender, DragEventArgs e)
        {
        }

        private void pxBxUnit01_Click(object sender, EventArgs e) { this.SetPictureBoxWithChosenUnit(0); }

        private void SetPictureBoxWithChosenUnit(int index)
        {
            int CostOfChosenUnit = this.UnitsWithChoices.Units()[index].Cost;
            int InitialSpendingMoney = Models.PlayerOneGame.INTIALLYSPENDINGMONEY;

            Bitmap imgCloned = (Bitmap)this.UnitsWithChoices.Units()[index].Image.Clone();
            Bitmap imgClonedIllustration = (Bitmap)this.UnitsWithChoices.Units()[index].Image.Clone();

            this.picBxToPlace.Image = imgCloned;
            this.lblCostOfSelected.Text = CostOfChosenUnit.ToString(CultureInfo.InvariantCulture);
            this.lblPotentialRemainingMoney.Text = (InitialSpendingMoney - CostOfChosenUnit).ToString(CultureInfo.InvariantCulture);
            this.picbxHuman.Image = imgClonedIllustration;

            this.lblMovementDocumentation.Text = this.UnitsWithChoices.Units()[index].MovementDocumentation;

            this.lblUnitProperties.Text = string.Format(
                CultureInfo.InvariantCulture,
                "{0} \n\r Cost {1}, Jump {2} \n\r Life {3}, AttackLevel {4} \n\r Speed {5}", 
                this.UnitsWithChoices.Units()[index].FileName,
                this.UnitsWithChoices.Units()[index].Cost,
                this.UnitsWithChoices.Units()[index].JumpPower,
                this.UnitsWithChoices.Units()[index].LifeLevel,
                this.UnitsWithChoices.Units()[index].AttackLevel,
                this.UnitsWithChoices.Units()[index].SpeedPower);
        }

        private void pxBxUnit02_Click(object sender, EventArgs e) { this.SetPictureBoxWithChosenUnit(1); }
                                                                    
        private void pxBxUnit03_Click(object sender, EventArgs e) { this.SetPictureBoxWithChosenUnit(2); }
                                                                    
        private void pxBxUnit04_Click(object sender, EventArgs e) { this.SetPictureBoxWithChosenUnit(3); }
                                                                   
        private void pxBxUnit05_Click(object sender, EventArgs e) { this.SetPictureBoxWithChosenUnit(4); }
                                                                   
        private void pxBxUnit06_Click(object sender, EventArgs e) { this.SetPictureBoxWithChosenUnit(5); }
                                                                    
        private void pxBxUnit07_Click(object sender, EventArgs e) { this.SetPictureBoxWithChosenUnit(6); }
                                                                   
        private void pxBxUnit08_Click(object sender, EventArgs e) { this.SetPictureBoxWithChosenUnit(7); }
                                                                    
        private void pxBxUnit09_Click(object sender, EventArgs e) { this.SetPictureBoxWithChosenUnit(8); }
                                                                    
        private void pxBxUnit10_Click(object sender, EventArgs e) { this.SetPictureBoxWithChosenUnit(9); }
                                                                   
        private void pxBxUnit11_Click(object sender, EventArgs e) { this.SetPictureBoxWithChosenUnit(10); }
                                                                  
        private void pxBxUnit12_Click(object sender, EventArgs e) { this.SetPictureBoxWithChosenUnit(11); }
                                                                   
        private void pxBxUnit13_Click(object sender, EventArgs e) { this.SetPictureBoxWithChosenUnit(12); }
                                                                   
        private void pxBxUnit14_Click(object sender, EventArgs e) { this.SetPictureBoxWithChosenUnit(13); }
                                                                    
        private void pxBxUnit15_Click(object sender, EventArgs e) { this.SetPictureBoxWithChosenUnit(14); }
                                                                   
        private void pxBxUnit16_Click(object sender, EventArgs e) { this.SetPictureBoxWithChosenUnit(15); }
                                                                   
        private void pxBxUnit17_Click(object sender, EventArgs e) { this.SetPictureBoxWithChosenUnit(16); }
                                                                   
        private void pxBxUnit18_Click(object sender, EventArgs e) { this.SetPictureBoxWithChosenUnit(17); }
                                                                   
        private void pxBxUnit19_Click(object sender, EventArgs e) { this.SetPictureBoxWithChosenUnit(18); }
                                                                    
        private void pxBxUnit20_Click(object sender, EventArgs e) { this.SetPictureBoxWithChosenUnit(19); }

        private void picBxToPlace_Click(object sender, EventArgs e)
        {

        }
    }
}

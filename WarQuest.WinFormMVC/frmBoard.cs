using System;
using System.Drawing;
using System.Windows.Forms;
using WarQuest.WinFormMVC.Presenters;

namespace WarQuest.WinFormMVC
{
    public partial class frmBoard : Form
    {
        public UnitCollection UnitsWithChoices { get; internal set; }

        public frmBoard()
        {
            InitializeComponent();
        }

        private void frmBoard_Load(object sender, EventArgs e)
        {
            this.Text = UnitsWithChoices.Count().ToString() + " ; total cost" + UnitsWithChoices.TotalCost();
            lblSummary.Text = UnitsWithChoices.GetTotalMoneySelected().ToString();

            // FillInWithImagesDynamic();
            FillInWithImagesStatic();
        }

        /// <summary>
        /// We have 20 static images place holder. Not great for evolutions, but easier to code !
        /// </summary>
        private void FillInWithImagesStatic()
        {
            UnitsWithChoices.DeleteUnselectedUnits();
            int countSelectedUnits = UnitsWithChoices.GetTotalUnitSelected();

            // Ugly but : Fills in the 20 static picture boxes
            if (countSelectedUnits>= 20) { pxBxUnit20.Image = UnitsWithChoices.Units()[19].Image; }
            if (countSelectedUnits>= 19) { pxBxUnit19.Image = UnitsWithChoices.Units()[18].Image; }
            if (countSelectedUnits>= 18) { pxBxUnit18.Image = UnitsWithChoices.Units()[17].Image; }
            if (countSelectedUnits>= 17) { pxBxUnit17.Image = UnitsWithChoices.Units()[16].Image; }
            if (countSelectedUnits>= 16) { pxBxUnit16.Image = UnitsWithChoices.Units()[15].Image; }
            if (countSelectedUnits>= 15) { pxBxUnit15.Image = UnitsWithChoices.Units()[14].Image; }
            if (countSelectedUnits>= 14) { pxBxUnit14.Image = UnitsWithChoices.Units()[13].Image; }
            if (countSelectedUnits>= 13) { pxBxUnit13.Image = UnitsWithChoices.Units()[12].Image; }
            if (countSelectedUnits>= 12) { pxBxUnit12.Image = UnitsWithChoices.Units()[11].Image; }
            if (countSelectedUnits>= 11) { pxBxUnit11.Image = UnitsWithChoices.Units()[10].Image; }
            if (countSelectedUnits>= 10) { pxBxUnit10.Image = UnitsWithChoices.Units()[ 9].Image; }
            if (countSelectedUnits>=  9) { pxBxUnit09.Image = UnitsWithChoices.Units()[ 8].Image; }
            if (countSelectedUnits>=  8) { pxBxUnit08.Image = UnitsWithChoices.Units()[ 7].Image; }
            if (countSelectedUnits>=  7) { pxBxUnit07.Image = UnitsWithChoices.Units()[ 6].Image; }
            if (countSelectedUnits>=  6) { pxBxUnit06.Image = UnitsWithChoices.Units()[ 5].Image; }
            if (countSelectedUnits>=  5) { pxBxUnit05.Image = UnitsWithChoices.Units()[ 4].Image; }
            if (countSelectedUnits>=  4) { pxBxUnit04.Image = UnitsWithChoices.Units()[ 3].Image; }
            if (countSelectedUnits>=  3) { pxBxUnit03.Image = UnitsWithChoices.Units()[ 2].Image; }
            if (countSelectedUnits>=  2) { pxBxUnit02.Image = UnitsWithChoices.Units()[ 1].Image; }
            if (countSelectedUnits>=  1) { pxBxUnit01.Image = UnitsWithChoices.Units()[ 0].Image; }
        }

        private void FillInWithImagesDynamic()
        {
            PictureBox picbxTest = null;
            int HIEGHT_ICON_SIZE = 100;

            for (int i = 0; i < 19; i++)
            {
                picbxTest = new PictureBox();
                picbxTest.Image = UnitsWithChoices.Units()[i].Image;
                picbxTest.Name = "Name_" + i.ToString();
                picbxTest.Height = HIEGHT_ICON_SIZE;
//                 flLayPanChosenUnits.Controls.Add(picbxTest);
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

            picBxToPlace.Visible = true;
            picBxToPlace.Location = new Point(POS_SHIFT + e.X, POS_SHIFT + e.Y);

        }

        private void panelBoard_MouseClick(object sender, MouseEventArgs e)
        {
            picBxToPlace.Location = new Point(e.X, e.Y);

            // unregister this.panelBoard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBoard_MouseMove);
            this.panelBoard.MouseMove -= this.panelBoard_MouseMove;
        }

        private void pxBxUnit01_DragEnter(object sender, DragEventArgs e)
        {
        }

        private void pxBxUnit01_Click(object sender, EventArgs e) { SetPictureBoxWithChosenUnit(0); }

        private void SetPictureBoxWithChosenUnit(int index)
        {
            picBxToPlace.Image = UnitsWithChoices.Units()[index].Image;
        }

        private void pxBxUnit02_Click(object sender, EventArgs e) { SetPictureBoxWithChosenUnit(1); }

        private void pxBxUnit03_Click(object sender, EventArgs e) { SetPictureBoxWithChosenUnit(2); }

        private void pxBxUnit04_Click(object sender, EventArgs e) { SetPictureBoxWithChosenUnit(3); }

        private void pxBxUnit05_Click(object sender, EventArgs e) { SetPictureBoxWithChosenUnit(4); }

        private void pxBxUnit06_Click(object sender, EventArgs e) { SetPictureBoxWithChosenUnit(5); }

        private void pxBxUnit07_Click(object sender, EventArgs e) { SetPictureBoxWithChosenUnit(6); }

        private void pxBxUnit08_Click(object sender, EventArgs e) { SetPictureBoxWithChosenUnit(7); }

        private void pxBxUnit09_Click(object sender, EventArgs e) { SetPictureBoxWithChosenUnit(8); }

        private void pxBxUnit10_Click(object sender, EventArgs e) { SetPictureBoxWithChosenUnit(9); }

        private void pxBxUnit11_Click(object sender, EventArgs e) { SetPictureBoxWithChosenUnit(10); }

        private void pxBxUnit12_Click(object sender, EventArgs e) { SetPictureBoxWithChosenUnit(11); }

        private void pxBxUnit13_Click(object sender, EventArgs e) { SetPictureBoxWithChosenUnit(12); }

        private void pxBxUnit14_Click(object sender, EventArgs e) { SetPictureBoxWithChosenUnit(13); }

        private void pxBxUnit15_Click(object sender, EventArgs e) { SetPictureBoxWithChosenUnit(14); }

        private void pxBxUnit16_Click(object sender, EventArgs e) { SetPictureBoxWithChosenUnit(15); }

        private void pxBxUnit17_Click(object sender, EventArgs e) { SetPictureBoxWithChosenUnit(16); }

        private void pxBxUnit18_Click(object sender, EventArgs e) { SetPictureBoxWithChosenUnit(17); }

        private void pxBxUnit19_Click(object sender, EventArgs e) { SetPictureBoxWithChosenUnit(18); }

        private void pxBxUnit20_Click(object sender, EventArgs e) { SetPictureBoxWithChosenUnit(19); }

        //private void flLayPanChosenUnits_MouseDoubleClick(object sender, MouseEventArgs e)
        //{
        //    var element = sender;
        //    int count =  ((System.Windows.Forms.Control)sender).Controls.Count;

        //    var img = ((System.Windows.Forms.Control)sender).Controls[count-2];

        //    panelDebug.Controls.Add(img);

        //    lblSummary.Text += "";
        //}
    }
}

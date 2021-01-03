using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            PictureBox picbxTest = null;
            // picbxTarget.Image = 
            // flLayPanChosenUnits.Controls.Add(picbxTarget);

            for (int i = 0; i < 19; i++)
            {
                picbxTest = new PictureBox();
                picbxTest.Image = UnitsWithChoices.Units()[i].Image;
                picbxTest.Name = "Name_" + i.ToString();
                picbxTest.Height = 150;
                flLayPanChosenUnits.Controls.Add(picbxTest);
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
            picBxToPlace.Location = new Point(POS_SHIFT+e.X, POS_SHIFT+e.Y);

        }

        private void panelBoard_MouseClick(object sender, MouseEventArgs e)
        {
            picBxToPlace.Location = new Point(e.X, e.Y);

            // unregister this.panelBoard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBoard_MouseMove);
            this.panelBoard.MouseMove -= this.panelBoard_MouseMove;
        }
    }
}

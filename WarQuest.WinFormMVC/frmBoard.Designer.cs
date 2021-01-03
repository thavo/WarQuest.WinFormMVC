namespace WarQuest.WinFormMVC
{
    partial class frmBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBoard));
            this.panelBoard = new System.Windows.Forms.Panel();
            this.picBxToPlace = new System.Windows.Forms.PictureBox();
            this.picbxHuman = new System.Windows.Forms.PictureBox();
            this.picbxTarget = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSummary = new System.Windows.Forms.Label();
            this.flLayPanChosenUnits = new System.Windows.Forms.FlowLayoutPanel();
            this.panelBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxToPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxHuman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxTarget)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBoard
            // 
            this.panelBoard.Controls.Add(this.picBxToPlace);
            this.panelBoard.Location = new System.Drawing.Point(248, 269);
            this.panelBoard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelBoard.Name = "panelBoard";
            this.panelBoard.Size = new System.Drawing.Size(719, 288);
            this.panelBoard.TabIndex = 0;
            this.panelBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBoard_Paint);
            this.panelBoard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelBoard_MouseClick);
            this.panelBoard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBoard_MouseMove);
            // 
            // picBxToPlace
            // 
            this.picBxToPlace.Image = ((System.Drawing.Image)(resources.GetObject("picBxToPlace.Image")));
            this.picBxToPlace.Location = new System.Drawing.Point(0, 0);
            this.picBxToPlace.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picBxToPlace.Name = "picBxToPlace";
            this.picBxToPlace.Size = new System.Drawing.Size(121, 119);
            this.picBxToPlace.TabIndex = 5;
            this.picBxToPlace.TabStop = false;
            this.picBxToPlace.Visible = false;
            // 
            // picbxHuman
            // 
            this.picbxHuman.Image = ((System.Drawing.Image)(resources.GetObject("picbxHuman.Image")));
            this.picbxHuman.Location = new System.Drawing.Point(975, 818);
            this.picbxHuman.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picbxHuman.Name = "picbxHuman";
            this.picbxHuman.Size = new System.Drawing.Size(230, 265);
            this.picbxHuman.TabIndex = 5;
            this.picbxHuman.TabStop = false;
            // 
            // picbxTarget
            // 
            this.picbxTarget.Image = ((System.Drawing.Image)(resources.GetObject("picbxTarget.Image")));
            this.picbxTarget.Location = new System.Drawing.Point(510, -3);
            this.picbxTarget.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picbxTarget.Name = "picbxTarget";
            this.picbxTarget.Size = new System.Drawing.Size(230, 265);
            this.picbxTarget.TabIndex = 6;
            this.picbxTarget.TabStop = false;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(252, 144);
            this.flowLayoutPanel.TabIndex = 7;
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Location = new System.Drawing.Point(793, 51);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(38, 15);
            this.lblSummary.TabIndex = 8;
            this.lblSummary.Text = "label1";
            // 
            // flLayPanChosenUnits
            // 
            this.flLayPanChosenUnits.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.flLayPanChosenUnits.Location = new System.Drawing.Point(75, 581);
            this.flLayPanChosenUnits.Name = "flLayPanChosenUnits";
            this.flLayPanChosenUnits.Size = new System.Drawing.Size(875, 468);
            this.flLayPanChosenUnits.TabIndex = 9;
            // 
            // frmBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1452, 1061);
            this.Controls.Add(this.flLayPanChosenUnits);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.picbxHuman);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.picbxTarget);
            this.Controls.Add(this.panelBoard);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmBoard";
            this.Text = "War Quest - by Sanouch (C)2021 - ";
            this.Load += new System.EventHandler(this.frmBoard_Load);
            this.panelBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBxToPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxHuman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxTarget)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBoard;
        private System.Windows.Forms.PictureBox picbxHuman;
        private System.Windows.Forms.PictureBox picBxToPlace;
        private System.Windows.Forms.PictureBox picbxTarget;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.FlowLayoutPanel flLayPanChosenUnits;
    }
}
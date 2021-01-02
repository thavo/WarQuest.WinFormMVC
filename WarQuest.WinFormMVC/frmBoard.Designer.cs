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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picBxToPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxHuman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBoard
            // 
            this.panelBoard.Location = new System.Drawing.Point(248, 269);
            this.panelBoard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelBoard.Name = "panelBoard";
            this.panelBoard.Size = new System.Drawing.Size(719, 713);
            this.panelBoard.TabIndex = 0;
            this.panelBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBoard_Paint);
            this.panelBoard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelBoard_MouseClick);
            this.panelBoard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBoard_MouseMove);
            // 
            // picBxToPlace
            // 
            this.picBxToPlace.Image = ((System.Drawing.Image)(resources.GetObject("picBxToPlace.Image")));
            this.picBxToPlace.Location = new System.Drawing.Point(101, 178);
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
            this.picbxHuman.Location = new System.Drawing.Point(510, 988);
            this.picbxHuman.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picbxHuman.Name = "picbxHuman";
            this.picbxHuman.Size = new System.Drawing.Size(230, 265);
            this.picbxHuman.TabIndex = 5;
            this.picbxHuman.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(510, -3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 265);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(252, 144);
            this.flowLayoutPanel.TabIndex = 7;
            // 
            // frmBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1452, 1061);
            this.Controls.Add(this.picbxHuman);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.picBxToPlace);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelBoard);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmBoard";
            this.Text = "War Quest - by Sanouch (C)2021 - ";
            this.Load += new System.EventHandler(this.frmBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBxToPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxHuman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBoard;
        private System.Windows.Forms.PictureBox picbxHuman;
        private System.Windows.Forms.PictureBox picBxToPlace;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
    }
}
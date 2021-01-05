namespace WarQuest.WinFormMVC
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.butStart = new System.Windows.Forms.Button();
            this.lstViewAvailableUnits = new System.Windows.Forms.ListView();
            this.imageListUnits = new System.Windows.Forms.ImageList(this.components);
            this.lblChosen = new System.Windows.Forms.Label();
            this.lblTotalMoneySpent = new System.Windows.Forms.Label();
            this.lblCheckMaxSpendingMoney = new System.Windows.Forms.Label();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // butStart
            // 
            this.butStart.Location = new System.Drawing.Point(1202, 329);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(222, 23);
            this.butStart.TabIndex = 0;
            this.butStart.Text = "Validate choice";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.butStart_Click);
            // 
            // lstViewAvailableUnits
            // 
            this.lstViewAvailableUnits.HideSelection = false;
            this.lstViewAvailableUnits.LargeImageList = this.imageListUnits;
            this.lstViewAvailableUnits.Location = new System.Drawing.Point(54, 407);
            this.lstViewAvailableUnits.Name = "lstViewAvailableUnits";
            this.lstViewAvailableUnits.Size = new System.Drawing.Size(1370, 423);
            this.lstViewAvailableUnits.TabIndex = 2;
            this.lstViewAvailableUnits.UseCompatibleStateImageBehavior = false;
            // 
            // imageListUnits
            // 
            this.imageListUnits.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListUnits.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListUnits.ImageStream")));
            this.imageListUnits.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListUnits.Images.SetKeyName(0, "Builder.jpg");
            this.imageListUnits.Images.SetKeyName(1, "Destroyer.jpg");
            this.imageListUnits.Images.SetKeyName(2, "Hum-Arches.jpg");
            this.imageListUnits.Images.SetKeyName(3, "Hum-Boss.jpg");
            this.imageListUnits.Images.SetKeyName(4, "Hum-GunArches.jpg");
            this.imageListUnits.Images.SetKeyName(5, "Hum-Knight.jpg");
            this.imageListUnits.Images.SetKeyName(6, "Hum-Magician.jpg");
            this.imageListUnits.Images.SetKeyName(7, "Hum-Sword.jpg");
            this.imageListUnits.Images.SetKeyName(8, "Mon-2Ceratops.jpg");
            this.imageListUnits.Images.SetKeyName(9, "Mon-DraculaFace.jpg");
            this.imageListUnits.Images.SetKeyName(10, "Mon-DragonBoss.jpg");
            this.imageListUnits.Images.SetKeyName(11, "Mon-Fog.jpg");
            this.imageListUnits.Images.SetKeyName(12, "Mon-NoFace.jpg");
            this.imageListUnits.Images.SetKeyName(13, "Veh-BigSpider.jpg");
            this.imageListUnits.Images.SetKeyName(14, "Veh-BigTank.jpg");
            this.imageListUnits.Images.SetKeyName(15, "Veh-Gun.jpg");
            this.imageListUnits.Images.SetKeyName(16, "Veh-GunBullet.jpg");
            this.imageListUnits.Images.SetKeyName(17, "Veh-GunFog.jpg");
            this.imageListUnits.Images.SetKeyName(18, "Veh-SmallSpider.jpg");
            this.imageListUnits.Images.SetKeyName(19, "Veh-SmallTank.jpg");
            this.imageListUnits.Images.SetKeyName(20, "Veh-SpaceTowerBoss.jpg");
            // 
            // lblChosen
            // 
            this.lblChosen.AutoSize = true;
            this.lblChosen.Location = new System.Drawing.Point(54, 359);
            this.lblChosen.Name = "lblChosen";
            this.lblChosen.Size = new System.Drawing.Size(66, 15);
            this.lblChosen.TabIndex = 3;
            this.lblChosen.Text = "Chosen IDs";
            // 
            // lblTotalMoneySpent
            // 
            this.lblTotalMoneySpent.AutoSize = true;
            this.lblTotalMoneySpent.Location = new System.Drawing.Point(54, 374);
            this.lblTotalMoneySpent.Name = "lblTotalMoneySpent";
            this.lblTotalMoneySpent.Size = new System.Drawing.Size(105, 15);
            this.lblTotalMoneySpent.TabIndex = 4;
            this.lblTotalMoneySpent.Text = "Total Money Spent";
            // 
            // lblCheckMaxSpendingMoney
            // 
            this.lblCheckMaxSpendingMoney.AutoSize = true;
            this.lblCheckMaxSpendingMoney.ForeColor = System.Drawing.Color.Red;
            this.lblCheckMaxSpendingMoney.Location = new System.Drawing.Point(54, 389);
            this.lblCheckMaxSpendingMoney.Name = "lblCheckMaxSpendingMoney";
            this.lblCheckMaxSpendingMoney.Size = new System.Drawing.Size(38, 15);
            this.lblCheckMaxSpendingMoney.TabIndex = 5;
            this.lblCheckMaxSpendingMoney.Text = "label1";
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripComboBox2});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1453, 27);
            this.menuStripMain.TabIndex = 6;
            this.menuStripMain.Text = "Menu";
            this.menuStripMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStripMain_ItemClicked);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(99, 23);
            this.toolStripMenuItem2.Text = "About (Github)";
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.Items.AddRange(new object[] {
            "Board Size 16 x 16 (Default)",
            "Other (not yet implemented)"});
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(221, 23);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Board size 16x16 (Default)"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.toolStripMenuItem1.Text = "Open Github";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 830);
            this.Controls.Add(this.lblCheckMaxSpendingMoney);
            this.Controls.Add(this.lblTotalMoneySpent);
            this.Controls.Add(this.lblChosen);
            this.Controls.Add(this.lstViewAvailableUnits);
            this.Controls.Add(this.butStart);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "WarQuest (C) 2021 CC by Sanouche";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.ListView lstViewAvailableUnits;
        private System.Windows.Forms.ImageList imageListUnits;
        private System.Windows.Forms.Label lblChosen;
        private System.Windows.Forms.Label lblTotalMoneySpent;
        private System.Windows.Forms.Label lblCheckMaxSpendingMoney;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}


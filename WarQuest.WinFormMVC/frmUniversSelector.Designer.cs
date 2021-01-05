namespace WarQuest.WinFormMVC
{
    partial class frmUniversSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUniversSelector));
            this.picbxHuman = new System.Windows.Forms.PictureBox();
            this.picbxMonster = new System.Windows.Forms.PictureBox();
            this.picbxVehicle = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbxHuman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxMonster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxVehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // picbxHuman
            // 
            this.picbxHuman.Image = ((System.Drawing.Image)(resources.GetObject("picbxHuman.Image")));
            this.picbxHuman.Location = new System.Drawing.Point(79, 134);
            this.picbxHuman.Name = "picbxHuman";
            this.picbxHuman.Size = new System.Drawing.Size(230, 100);
            this.picbxHuman.TabIndex = 0;
            this.picbxHuman.TabStop = false;
            this.picbxHuman.Click += new System.EventHandler(this.picbxHuman_Click);
            // 
            // picbxMonster
            // 
            this.picbxMonster.Image = ((System.Drawing.Image)(resources.GetObject("picbxMonster.Image")));
            this.picbxMonster.Location = new System.Drawing.Point(359, 134);
            this.picbxMonster.Name = "picbxMonster";
            this.picbxMonster.Size = new System.Drawing.Size(230, 100);
            this.picbxMonster.TabIndex = 0;
            this.picbxMonster.TabStop = false;
            this.picbxMonster.Click += new System.EventHandler(this.picbxMonster_Click);
            // 
            // picbxVehicle
            // 
            this.picbxVehicle.Image = ((System.Drawing.Image)(resources.GetObject("picbxVehicle.Image")));
            this.picbxVehicle.Location = new System.Drawing.Point(630, 134);
            this.picbxVehicle.Name = "picbxVehicle";
            this.picbxVehicle.Size = new System.Drawing.Size(230, 100);
            this.picbxVehicle.TabIndex = 0;
            this.picbxVehicle.TabStop = false;
            this.picbxVehicle.Click += new System.EventHandler(this.picbxVehicle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(79, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELCOME to WarQuest ! Please select the univers :";
            // 
            // frmUniversSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 323);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picbxVehicle);
            this.Controls.Add(this.picbxMonster);
            this.Controls.Add(this.picbxHuman);
            this.Name = "frmUniversSelector";
            this.Text = "WarQuest";
            ((System.ComponentModel.ISupportInitialize)(this.picbxHuman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxMonster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxVehicle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbxHuman;
        private System.Windows.Forms.PictureBox picbxMonster;
        private System.Windows.Forms.PictureBox picbxVehicle;
        private System.Windows.Forms.Label label1;
    }
}
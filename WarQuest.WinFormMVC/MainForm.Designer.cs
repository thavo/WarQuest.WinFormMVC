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
            this.butStart = new System.Windows.Forms.Button();
            this.lstBxUnits = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // butStart
            // 
            this.butStart.Location = new System.Drawing.Point(54, 39);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(222, 23);
            this.butStart.TabIndex = 0;
            this.butStart.Text = "Generate 20 Random Units";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.butStart_Click);
            // 
            // lstBxUnits
            // 
            this.lstBxUnits.FormattingEnabled = true;
            this.lstBxUnits.ItemHeight = 15;
            this.lstBxUnits.Location = new System.Drawing.Point(54, 91);
            this.lstBxUnits.Name = "lstBxUnits";
            this.lstBxUnits.Size = new System.Drawing.Size(608, 349);
            this.lstBxUnits.TabIndex = 1;
            this.lstBxUnits.SelectedIndexChanged += new System.EventHandler(this.lstBxUnits_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstBxUnits);
            this.Controls.Add(this.butStart);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.ListBox lstBxUnits;
    }
}


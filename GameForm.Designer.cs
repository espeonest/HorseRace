namespace HorseRace
{
    partial class GameForm
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
            this.txtNumberOfHorses = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnResults = new System.Windows.Forms.Button();
            this.pbFinishLine = new System.Windows.Forms.PictureBox();
            this.btnNewRace = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFinishLine)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumberOfHorses
            // 
            this.txtNumberOfHorses.Location = new System.Drawing.Point(682, 37);
            this.txtNumberOfHorses.Name = "txtNumberOfHorses";
            this.txtNumberOfHorses.Size = new System.Drawing.Size(322, 38);
            this.txtNumberOfHorses.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(1034, 29);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(257, 53);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start Race";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnResults
            // 
            this.btnResults.Location = new System.Drawing.Point(1312, 29);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(172, 53);
            this.btnResults.TabIndex = 2;
            this.btnResults.Text = "Results";
            this.btnResults.UseVisualStyleBackColor = true;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // pbFinishLine
            // 
            this.pbFinishLine.BackColor = System.Drawing.Color.IndianRed;
            this.pbFinishLine.Location = new System.Drawing.Point(616, 98);
            this.pbFinishLine.Name = "pbFinishLine";
            this.pbFinishLine.Size = new System.Drawing.Size(27, 851);
            this.pbFinishLine.TabIndex = 3;
            this.pbFinishLine.TabStop = false;
            // 
            // btnNewRace
            // 
            this.btnNewRace.Location = new System.Drawing.Point(1211, 855);
            this.btnNewRace.Name = "btnNewRace";
            this.btnNewRace.Size = new System.Drawing.Size(273, 74);
            this.btnNewRace.TabIndex = 4;
            this.btnNewRace.Text = "New Race";
            this.btnNewRace.UseVisualStyleBackColor = true;
            this.btnNewRace.Click += new System.EventHandler(this.btnNewRace_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1529, 961);
            this.Controls.Add(this.btnNewRace);
            this.Controls.Add(this.pbFinishLine);
            this.Controls.Add(this.btnResults);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtNumberOfHorses);
            this.Name = "GameForm";
            this.Text = "Horse Race";
            ((System.ComponentModel.ISupportInitialize)(this.pbFinishLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumberOfHorses;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnResults;
        private System.Windows.Forms.Button btnNewRace;
        public System.Windows.Forms.PictureBox pbFinishLine;
    }
}


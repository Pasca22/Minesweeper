
namespace Minesweeper
{
    partial class SetDifficulty
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.easy = new System.Windows.Forms.RadioButton();
            this.medium = new System.Windows.Forms.RadioButton();
            this.hard = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(230, 74);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 32);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // easy
            // 
            this.easy.AutoSize = true;
            this.easy.Location = new System.Drawing.Point(45, 31);
            this.easy.Name = "easy";
            this.easy.Size = new System.Drawing.Size(60, 21);
            this.easy.TabIndex = 1;
            this.easy.TabStop = true;
            this.easy.Text = "Easy";
            this.easy.UseVisualStyleBackColor = true;
            // 
            // medium
            // 
            this.medium.AutoSize = true;
            this.medium.Location = new System.Drawing.Point(45, 74);
            this.medium.Name = "medium";
            this.medium.Size = new System.Drawing.Size(78, 21);
            this.medium.TabIndex = 2;
            this.medium.TabStop = true;
            this.medium.Text = "Medium";
            this.medium.UseVisualStyleBackColor = true;
            // 
            // hard
            // 
            this.hard.AutoSize = true;
            this.hard.Location = new System.Drawing.Point(45, 112);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(60, 21);
            this.hard.TabIndex = 3;
            this.hard.TabStop = true;
            this.hard.Text = "Hard";
            this.hard.UseVisualStyleBackColor = true;
            // 
            // SetDifficulty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 166);
            this.Controls.Add(this.hard);
            this.Controls.Add(this.medium);
            this.Controls.Add(this.easy);
            this.Controls.Add(this.buttonStart);
            this.Name = "SetDifficulty";
            this.Text = "SetDifficulty";
            this.Load += new System.EventHandler(this.SetDifficulty_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.RadioButton easy;
        private System.Windows.Forms.RadioButton medium;
        private System.Windows.Forms.RadioButton hard;
    }
}
﻿
namespace Minesweeper
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBomb = new System.Windows.Forms.PictureBox();
            this.pictureTimer = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBomb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 0;
            // 
            // pictureBomb
            // 
            this.pictureBomb.Image = global::Minesweeper.Properties.Resources.countbomb;
            this.pictureBomb.Location = new System.Drawing.Point(104, 12);
            this.pictureBomb.Name = "pictureBomb";
            this.pictureBomb.Size = new System.Drawing.Size(38, 33);
            this.pictureBomb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBomb.TabIndex = 2;
            this.pictureBomb.TabStop = false;
            // 
            // pictureTimer
            // 
            this.pictureTimer.Image = global::Minesweeper.Properties.Resources.timer;
            this.pictureTimer.Location = new System.Drawing.Point(12, 12);
            this.pictureTimer.Name = "pictureTimer";
            this.pictureTimer.Size = new System.Drawing.Size(48, 33);
            this.pictureTimer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTimer.TabIndex = 1;
            this.pictureTimer.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.Location = new System.Drawing.Point(148, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 467);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBomb);
            this.Controls.Add(this.pictureTimer);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minesweeper";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBomb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTimer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureTimer;
        private System.Windows.Forms.PictureBox pictureBomb;
        private System.Windows.Forms.Label label2;
    }
}


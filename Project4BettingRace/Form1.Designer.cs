﻿namespace Project4BettingRace
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Project4BettingRace.Resource1.track;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(91, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb1.Location = new System.Drawing.Point(243, 1);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(89, 89);
            this.pb1.TabIndex = 1;
            this.pb1.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb3.Location = new System.Drawing.Point(243, 493);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(89, 89);
            this.pb3.TabIndex = 2;
            this.pb3.TabStop = false;
            // 
            // pb4
            // 
            this.pb4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb4.Location = new System.Drawing.Point(2, 247);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(89, 89);
            this.pb4.TabIndex = 3;
            this.pb4.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb2.Location = new System.Drawing.Point(492, 247);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(89, 89);
            this.pb2.TabIndex = 4;
            this.pb2.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(2, 1);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(108, 47);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Race!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(278, 284);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(20, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 586);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox textBox1;
    }
}


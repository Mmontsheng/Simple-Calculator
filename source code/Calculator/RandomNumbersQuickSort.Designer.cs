﻿namespace Calculator {
    partial class Random_Numbers {
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
            this.generateBtn = new System.Windows.Forms.Button();
            this.sortBtn = new System.Windows.Forms.Button();
            this.arrayTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // generateBtn
            // 
            this.generateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateBtn.Location = new System.Drawing.Point(12, 12);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(128, 45);
            this.generateBtn.TabIndex = 15;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // sortBtn
            // 
            this.sortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortBtn.Location = new System.Drawing.Point(150, 12);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(128, 45);
            this.sortBtn.TabIndex = 16;
            this.sortBtn.Text = "Sort";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // arrayTextBox
            // 
            this.arrayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrayTextBox.Location = new System.Drawing.Point(12, 64);
            this.arrayTextBox.Multiline = true;
            this.arrayTextBox.Name = "arrayTextBox";
            this.arrayTextBox.ReadOnly = true;
            this.arrayTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.arrayTextBox.Size = new System.Drawing.Size(266, 374);
            this.arrayTextBox.TabIndex = 17;
            // 
            // Random_Numbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 450);
            this.Controls.Add(this.arrayTextBox);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.generateBtn);
            this.MaximizeBox = false;
            this.Name = "Random_Numbers";
            this.Text = "Random Numbers Quick Sort";
            this.Load += new System.EventHandler(this.Random_Numbers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.TextBox arrayTextBox;
    }
}
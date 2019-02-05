namespace Calculator {
    partial class Form1 {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.equation = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonPercent = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scientificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomArrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomArrayBubbleSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.massCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.equation);
            this.panel1.Controls.Add(this.buttonDel);
            this.panel1.Controls.Add(this.buttonEqual);
            this.panel1.Controls.Add(this.buttonMinus);
            this.panel1.Controls.Add(this.buttonMultiply);
            this.panel1.Controls.Add(this.buttonDivide);
            this.panel1.Controls.Add(this.buttonPlus);
            this.panel1.Controls.Add(this.buttonPercent);
            this.panel1.Controls.Add(this.buttonDot);
            this.panel1.Controls.Add(this.button0);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.answerTextBox);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 326);
            this.panel1.TabIndex = 0;
            // 
            // equation
            // 
            this.equation.AutoSize = true;
            this.equation.BackColor = System.Drawing.SystemColors.Control;
            this.equation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equation.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.equation.Location = new System.Drawing.Point(8, 25);
            this.equation.Name = "equation";
            this.equation.Size = new System.Drawing.Size(0, 20);
            this.equation.TabIndex = 21;
            // 
            // buttonDel
            // 
            this.buttonDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDel.Location = new System.Drawing.Point(80, 276);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(70, 45);
            this.buttonDel.TabIndex = 19;
            this.buttonDel.Text = "CE";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEqual
            // 
            this.buttonEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEqual.Location = new System.Drawing.Point(156, 276);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(146, 45);
            this.buttonEqual.TabIndex = 18;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = true;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinus.Location = new System.Drawing.Point(232, 225);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(70, 45);
            this.buttonMinus.TabIndex = 17;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.operator_click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiply.Location = new System.Drawing.Point(232, 174);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(70, 45);
            this.buttonMultiply.TabIndex = 16;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.operator_click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivide.Location = new System.Drawing.Point(232, 123);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(70, 45);
            this.buttonDivide.TabIndex = 15;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.operator_click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlus.Location = new System.Drawing.Point(232, 72);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(70, 45);
            this.buttonPlus.TabIndex = 14;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.operator_click);
            // 
            // buttonPercent
            // 
            this.buttonPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPercent.Location = new System.Drawing.Point(156, 225);
            this.buttonPercent.Name = "buttonPercent";
            this.buttonPercent.Size = new System.Drawing.Size(70, 45);
            this.buttonPercent.TabIndex = 13;
            this.buttonPercent.Text = "%";
            this.buttonPercent.UseVisualStyleBackColor = true;
            this.buttonPercent.Click += new System.EventHandler(this.buttonPercent_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDot.Location = new System.Drawing.Point(4, 225);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(70, 45);
            this.buttonDot.TabIndex = 12;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = true;
            this.buttonDot.Click += new System.EventHandler(this.buttonDot_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(80, 225);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(70, 45);
            this.button0.TabIndex = 11;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(156, 174);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(70, 45);
            this.button9.TabIndex = 10;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(80, 174);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(70, 45);
            this.button8.TabIndex = 9;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(4, 174);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(70, 45);
            this.button7.TabIndex = 8;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(156, 123);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 45);
            this.button6.TabIndex = 7;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(4, 276);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(70, 45);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.clear_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(80, 123);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 45);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(4, 123);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 45);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(156, 72);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 45);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(80, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(4, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // answerTextBox
            // 
            this.answerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerTextBox.Location = new System.Drawing.Point(4, 22);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.ReadOnly = true;
            this.answerTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.answerTextBox.Size = new System.Drawing.Size(298, 44);
            this.answerTextBox.TabIndex = 0;
            this.answerTextBox.Text = "0";
            this.answerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(306, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scientificToolStripMenuItem,
            this.randomArrayToolStripMenuItem,
            this.randomArrayBubbleSortToolStripMenuItem,
            this.massCalculatorToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.fileToolStripMenuItem.Text = "Features";
            // 
            // scientificToolStripMenuItem
            // 
            this.scientificToolStripMenuItem.Name = "scientificToolStripMenuItem";
            this.scientificToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.scientificToolStripMenuItem.Text = "Scientific";
            // 
            // randomArrayToolStripMenuItem
            // 
            this.randomArrayToolStripMenuItem.Name = "randomArrayToolStripMenuItem";
            this.randomArrayToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.randomArrayToolStripMenuItem.Text = "Random Array- Quick Sort";
            this.randomArrayToolStripMenuItem.Click += new System.EventHandler(this.randomArrayToolStripMenuItem_Click);
            // 
            // randomArrayBubbleSortToolStripMenuItem
            // 
            this.randomArrayBubbleSortToolStripMenuItem.Name = "randomArrayBubbleSortToolStripMenuItem";
            this.randomArrayBubbleSortToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.randomArrayBubbleSortToolStripMenuItem.Text = "Random Array- Bubble Sort";
            this.randomArrayBubbleSortToolStripMenuItem.Click += new System.EventHandler(this.randomArrayBubbleSortToolStripMenuItem_Click);
            // 
            // massCalculatorToolStripMenuItem
            // 
            this.massCalculatorToolStripMenuItem.Name = "massCalculatorToolStripMenuItem";
            this.massCalculatorToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.massCalculatorToolStripMenuItem.Text = "Mass Calculator";
            this.massCalculatorToolStripMenuItem.Click += new System.EventHandler(this.massCalculatorToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 326);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "DimensionCalculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonPercent;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scientificToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label equation;
        private System.Windows.Forms.ToolStripMenuItem randomArrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomArrayBubbleSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem massCalculatorToolStripMenuItem;
    }
}


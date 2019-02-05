namespace Calculator {
    partial class Mass_Calculator {
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
            this.label1 = new System.Windows.Forms.Label();
            this.radioKg1 = new System.Windows.Forms.RadioButton();
            this.radioPound1 = new System.Windows.Forms.RadioButton();
            this.radioGram1 = new System.Windows.Forms.RadioButton();
            this.radioTon1 = new System.Windows.Forms.RadioButton();
            this.convertAnswer1 = new System.Windows.Forms.TextBox();
            this.convertAnswer2 = new System.Windows.Forms.TextBox();
            this.radioTon2 = new System.Windows.Forms.RadioButton();
            this.radioGram2 = new System.Windows.Forms.RadioButton();
            this.radioPound2 = new System.Windows.Forms.RadioButton();
            this.radioKg2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.unit1 = new System.Windows.Forms.Label();
            this.unit2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mass Calculator";
            // 
            // radioKg1
            // 
            this.radioKg1.AutoSize = true;
            this.radioKg1.Checked = true;
            this.radioKg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioKg1.Location = new System.Drawing.Point(5, 12);
            this.radioKg1.Name = "radioKg1";
            this.radioKg1.Size = new System.Drawing.Size(48, 24);
            this.radioKg1.TabIndex = 1;
            this.radioKg1.TabStop = true;
            this.radioKg1.Text = "Kg";
            this.radioKg1.UseVisualStyleBackColor = true;
            this.radioKg1.CheckedChanged += new System.EventHandler(this.radioKg1_CheckedChanged);
            // 
            // radioPound1
            // 
            this.radioPound1.AutoSize = true;
            this.radioPound1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPound1.Location = new System.Drawing.Point(58, 12);
            this.radioPound1.Name = "radioPound1";
            this.radioPound1.Size = new System.Drawing.Size(78, 24);
            this.radioPound1.TabIndex = 2;
            this.radioPound1.Text = "Pound";
            this.radioPound1.UseVisualStyleBackColor = true;
            this.radioPound1.CheckedChanged += new System.EventHandler(this.radioPound1_CheckedChanged);
            // 
            // radioGram1
            // 
            this.radioGram1.AutoSize = true;
            this.radioGram1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGram1.Location = new System.Drawing.Point(143, 12);
            this.radioGram1.Name = "radioGram1";
            this.radioGram1.Size = new System.Drawing.Size(71, 24);
            this.radioGram1.TabIndex = 3;
            this.radioGram1.Text = "Gram";
            this.radioGram1.UseVisualStyleBackColor = true;
            this.radioGram1.CheckedChanged += new System.EventHandler(this.radioGram1_CheckedChanged);
            // 
            // radioTon1
            // 
            this.radioTon1.AutoSize = true;
            this.radioTon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioTon1.Location = new System.Drawing.Point(227, 12);
            this.radioTon1.Name = "radioTon1";
            this.radioTon1.Size = new System.Drawing.Size(57, 24);
            this.radioTon1.TabIndex = 4;
            this.radioTon1.Text = "Ton";
            this.radioTon1.UseVisualStyleBackColor = true;
            this.radioTon1.CheckedChanged += new System.EventHandler(this.radioTon1_CheckedChanged);
            // 
            // convertAnswer1
            // 
            this.convertAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertAnswer1.Location = new System.Drawing.Point(306, 82);
            this.convertAnswer1.Name = "convertAnswer1";
            this.convertAnswer1.Size = new System.Drawing.Size(133, 26);
            this.convertAnswer1.TabIndex = 5;
            this.convertAnswer1.TextChanged += new System.EventHandler(this.convertAnswer1_TextChanged);
            this.convertAnswer1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.convertAnswer1_KeyPress);
            // 
            // convertAnswer2
            // 
            this.convertAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertAnswer2.Location = new System.Drawing.Point(306, 139);
            this.convertAnswer2.Name = "convertAnswer2";
            this.convertAnswer2.Size = new System.Drawing.Size(133, 26);
            this.convertAnswer2.TabIndex = 10;
            this.convertAnswer2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.convertAnswer2_KeyPress);
            // 
            // radioTon2
            // 
            this.radioTon2.AutoSize = true;
            this.radioTon2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioTon2.Location = new System.Drawing.Point(227, 14);
            this.radioTon2.Name = "radioTon2";
            this.radioTon2.Size = new System.Drawing.Size(57, 24);
            this.radioTon2.TabIndex = 9;
            this.radioTon2.Text = "Ton";
            this.radioTon2.UseVisualStyleBackColor = true;
            this.radioTon2.CheckedChanged += new System.EventHandler(this.radioTon2_CheckedChanged);
            // 
            // radioGram2
            // 
            this.radioGram2.AutoSize = true;
            this.radioGram2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGram2.Location = new System.Drawing.Point(143, 14);
            this.radioGram2.Name = "radioGram2";
            this.radioGram2.Size = new System.Drawing.Size(71, 24);
            this.radioGram2.TabIndex = 8;
            this.radioGram2.Text = "Gram";
            this.radioGram2.UseVisualStyleBackColor = true;
            this.radioGram2.CheckedChanged += new System.EventHandler(this.radioGram2_CheckedChanged);
            // 
            // radioPound2
            // 
            this.radioPound2.AutoSize = true;
            this.radioPound2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPound2.Location = new System.Drawing.Point(58, 14);
            this.radioPound2.Name = "radioPound2";
            this.radioPound2.Size = new System.Drawing.Size(78, 24);
            this.radioPound2.TabIndex = 7;
            this.radioPound2.Text = "Pound";
            this.radioPound2.UseVisualStyleBackColor = true;
            this.radioPound2.CheckedChanged += new System.EventHandler(this.radioPound2_CheckedChanged);
            // 
            // radioKg2
            // 
            this.radioKg2.AutoSize = true;
            this.radioKg2.Checked = true;
            this.radioKg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioKg2.Location = new System.Drawing.Point(5, 14);
            this.radioKg2.Name = "radioKg2";
            this.radioKg2.Size = new System.Drawing.Size(48, 24);
            this.radioKg2.TabIndex = 6;
            this.radioKg2.TabStop = true;
            this.radioKg2.Text = "Kg";
            this.radioKg2.UseVisualStyleBackColor = true;
            this.radioKg2.CheckedChanged += new System.EventHandler(this.radioKg2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(184, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioKg1);
            this.groupBox1.Controls.Add(this.radioGram1);
            this.groupBox1.Controls.Add(this.radioTon1);
            this.groupBox1.Controls.Add(this.radioPound1);
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 44);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioGram2);
            this.groupBox2.Controls.Add(this.radioKg2);
            this.groupBox2.Controls.Add(this.radioPound2);
            this.groupBox2.Controls.Add(this.radioTon2);
            this.groupBox2.Location = new System.Drawing.Point(12, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 44);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // unit1
            // 
            this.unit1.AutoSize = true;
            this.unit1.BackColor = System.Drawing.SystemColors.Window;
            this.unit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.unit1.Location = new System.Drawing.Point(412, 90);
            this.unit1.Name = "unit1";
            this.unit1.Size = new System.Drawing.Size(23, 16);
            this.unit1.TabIndex = 14;
            this.unit1.Text = "kg";
            this.unit1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // unit2
            // 
            this.unit2.AutoSize = true;
            this.unit2.BackColor = System.Drawing.SystemColors.Window;
            this.unit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit2.Location = new System.Drawing.Point(412, 146);
            this.unit2.Name = "unit2";
            this.unit2.Size = new System.Drawing.Size(23, 16);
            this.unit2.TabIndex = 15;
            this.unit2.Text = "kg";
            this.unit2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Mass_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 247);
            this.Controls.Add(this.unit2);
            this.Controls.Add(this.unit1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.convertAnswer2);
            this.Controls.Add(this.convertAnswer1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Mass_Calculator";
            this.Text = "Mass_Calculator";
            this.Load += new System.EventHandler(this.Mass_Calculator_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioKg1;
        private System.Windows.Forms.RadioButton radioPound1;
        private System.Windows.Forms.RadioButton radioGram1;
        private System.Windows.Forms.RadioButton radioTon1;
        private System.Windows.Forms.TextBox convertAnswer1;
        private System.Windows.Forms.TextBox convertAnswer2;
        private System.Windows.Forms.RadioButton radioTon2;
        private System.Windows.Forms.RadioButton radioGram2;
        private System.Windows.Forms.RadioButton radioPound2;
        private System.Windows.Forms.RadioButton radioKg2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label unit1;
        private System.Windows.Forms.Label unit2;
    }
}
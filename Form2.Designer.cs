namespace Week3LabActivity
{
    partial class Form2
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
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            panel3 = new Panel();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox8 = new CheckBox();
            label2 = new Label();
            checkBox9 = new CheckBox();
            checkBox10 = new CheckBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 13);
            label1.Name = "label1";
            label1.Size = new Size(119, 37);
            label1.TabIndex = 2;
            label1.Text = "Medical";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(687, 1500);
            panel1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(229, 19);
            label3.TabIndex = 4;
            label3.Text = "Do you have any of the following?";
            // 
            // panel2
            // 
            panel2.Controls.Add(checkBox4);
            panel2.Controls.Add(checkBox3);
            panel2.Controls.Add(checkBox2);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(15, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(594, 116);
            panel2.TabIndex = 5;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(18, 34);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(133, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "High Blood Pressure";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(18, 65);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(107, 19);
            checkBox2.TabIndex = 6;
            checkBox2.Text = "Diabetes Type 2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(296, 65);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(52, 19);
            checkBox3.TabIndex = 7;
            checkBox3.Text = "Gout";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(296, 34);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(107, 19);
            checkBox4.TabIndex = 8;
            checkBox4.Text = "Diabetes Type 1";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(checkBox9);
            panel3.Controls.Add(checkBox10);
            panel3.Controls.Add(checkBox5);
            panel3.Controls.Add(checkBox6);
            panel3.Controls.Add(checkBox7);
            panel3.Controls.Add(checkBox8);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(15, 210);
            panel3.Name = "panel3";
            panel3.Size = new Size(594, 147);
            panel3.TabIndex = 9;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(296, 34);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(66, 19);
            checkBox5.TabIndex = 8;
            checkBox5.Text = "Thyroid";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(296, 59);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(67, 19);
            checkBox6.TabIndex = 7;
            checkBox6.Text = "Lithium";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(18, 59);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(133, 19);
            checkBox7.TabIndex = 6;
            checkBox7.Text = "High blood pressure";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(18, 34);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(71, 19);
            checkBox8.TabIndex = 5;
            checkBox8.Text = "Diabetes";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(234, 19);
            label2.TabIndex = 4;
            label2.Text = "Are you taking any medications for";
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.Location = new Point(296, 90);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(138, 19);
            checkBox9.TabIndex = 10;
            checkBox9.Text = "Coumadin (Warfarin)";
            checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            checkBox10.AutoSize = true;
            checkBox10.Location = new Point(18, 84);
            checkBox10.Name = "checkBox10";
            checkBox10.Size = new Size(113, 19);
            checkBox10.TabIndex = 9;
            checkBox10.Text = "High cholesterol";
            checkBox10.UseVisualStyleBackColor = true;
            checkBox10.CheckedChanged += checkBox10_CheckedChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(714, 561);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label3;
        private Panel panel3;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private CheckBox checkBox8;
        private Label label2;
        private Panel panel2;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private CheckBox checkBox9;
        private CheckBox checkBox10;
    }
}
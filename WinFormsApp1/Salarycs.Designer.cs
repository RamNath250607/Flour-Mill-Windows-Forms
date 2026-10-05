namespace WinFormsApp1
{
    partial class Salarycs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salarycs));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumSeaGreen;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(296, 23);
            label1.Name = "label1";
            label1.Size = new Size(176, 37);
            label1.TabIndex = 0;
            label1.Text = "Salary Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MediumSeaGreen;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(49, 98);
            label2.Name = "label2";
            label2.Size = new Size(122, 28);
            label2.TabIndex = 1;
            label2.Text = "Employee ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MediumSeaGreen;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(49, 147);
            label3.Name = "label3";
            label3.Size = new Size(155, 28);
            label3.TabIndex = 2;
            label3.Text = "Employee Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.MediumSeaGreen;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(49, 198);
            label4.Name = "label4";
            label4.Size = new Size(117, 28);
            label4.TabIndex = 3;
            label4.Text = "Designation";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.MediumSeaGreen;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(49, 254);
            label5.Name = "label5";
            label5.Size = new Size(90, 28);
            label5.TabIndex = 4;
            label5.Text = "Basic Pay";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.MediumSeaGreen;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(49, 302);
            label6.Name = "label6";
            label6.Size = new Size(101, 28);
            label6.TabIndex = 5;
            label6.Text = "Allowance";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.MediumSeaGreen;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(49, 351);
            label7.Name = "label7";
            label7.Size = new Size(103, 28);
            label7.TabIndex = 6;
            label7.Text = "Deduction";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.MediumSeaGreen;
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(50, 406);
            label8.Name = "label8";
            label8.Size = new Size(102, 28);
            label8.TabIndex = 7;
            label8.Text = "Net Salary";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.MediumSeaGreen;
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(49, 468);
            label9.Name = "label9";
            label9.Size = new Size(115, 28);
            label9.TabIndex = 8;
            label9.Text = "Month/Year";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(305, 103);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(268, 23);
            comboBox1.TabIndex = 9;
            comboBox1.Text = "Select";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(305, 152);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(268, 23);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(305, 198);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(268, 23);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(305, 256);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(268, 23);
            textBox3.TabIndex = 12;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(305, 302);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(268, 23);
            textBox4.TabIndex = 13;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(305, 354);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(268, 23);
            textBox5.TabIndex = 14;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(305, 408);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(268, 23);
            textBox6.TabIndex = 15;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(305, 469);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(268, 23);
            textBox7.TabIndex = 16;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSeaGreen;
            button1.Font = new Font("Segoe UI", 20F);
            button1.Location = new Point(296, 537);
            button1.Name = "button1";
            button1.Size = new Size(176, 52);
            button1.TabIndex = 17;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Salarycs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 611);
            Controls.Add(button1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Salarycs";
            Text = "Salarycs";
            Load += Salarycs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button button1;
    }
}
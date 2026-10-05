namespace WinFormsApp1
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            label1 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            label6 = new Label();
            comboBox1 = new ComboBox();
            label7 = new Label();
            comboBox2 = new ComboBox();
            label8 = new Label();
            textBox4 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            button1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumSeaGreen;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(339, 22);
            label1.Name = "label1";
            label1.Size = new Size(144, 37);
            label1.TabIndex = 0;
            label1.Text = "EMPLOYEE";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(316, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(270, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MediumSeaGreen;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(39, 135);
            label3.Name = "label3";
            label3.Size = new Size(155, 28);
            label3.TabIndex = 3;
            label3.Text = "Employee Name";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(316, 135);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(270, 23);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.MediumSeaGreen;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(39, 201);
            label4.Name = "label4";
            label4.Size = new Size(47, 28);
            label4.TabIndex = 5;
            label4.Text = "Age";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(316, 206);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(270, 23);
            textBox3.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.MediumSeaGreen;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(39, 258);
            label5.Name = "label5";
            label5.Size = new Size(76, 28);
            label5.TabIndex = 7;
            label5.Text = "Gender";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = SystemColors.ControlLight;
            radioButton1.Font = new Font("Segoe UI", 15F);
            radioButton1.Location = new Point(316, 258);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(73, 32);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = SystemColors.ControlLight;
            radioButton2.Font = new Font("Segoe UI", 15F);
            radioButton2.Location = new Point(430, 258);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(92, 32);
            radioButton2.TabIndex = 9;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.BackColor = SystemColors.ControlLight;
            radioButton3.Font = new Font("Segoe UI", 15F);
            radioButton3.Location = new Point(555, 258);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(88, 32);
            radioButton3.TabIndex = 10;
            radioButton3.TabStop = true;
            radioButton3.Text = "Others";
            radioButton3.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.MediumSeaGreen;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(39, 312);
            label6.Name = "label6";
            label6.Size = new Size(123, 28);
            label6.TabIndex = 11;
            label6.Text = "Qualification";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 9F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "UG", "PG", "Others" });
            comboBox1.Location = new Point(316, 317);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(270, 23);
            comboBox1.TabIndex = 12;
            comboBox1.Text = "Select";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.MediumSeaGreen;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(39, 364);
            label7.Name = "label7";
            label7.Size = new Size(117, 28);
            label7.TabIndex = 13;
            label7.Text = "Designation";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Manager", "Sales Person", "Sales Representative", "Machine Person", "Helper", "Driver" });
            comboBox2.Location = new Point(316, 369);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(270, 23);
            comboBox2.TabIndex = 14;
            comboBox2.Text = "Select";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.MediumSeaGreen;
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(39, 419);
            label8.Name = "label8";
            label8.Size = new Size(90, 28);
            label8.TabIndex = 15;
            label8.Text = "Basic Pay";
            label8.Click += label8_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(316, 419);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(270, 23);
            textBox4.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(316, 480);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(270, 23);
            dateTimePicker1.TabIndex = 19;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(316, 521);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(270, 23);
            textBox5.TabIndex = 21;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(316, 567);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(270, 23);
            textBox6.TabIndex = 23;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(316, 624);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(258, 23);
            textBox7.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.MediumSeaGreen;
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(39, 475);
            label9.Name = "label9";
            label9.Size = new Size(144, 28);
            label9.TabIndex = 26;
            label9.Text = "Date of Joining";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.MediumSeaGreen;
            label10.Font = new Font("Segoe UI", 15F);
            label10.Location = new Point(39, 516);
            label10.Name = "label10";
            label10.Size = new Size(80, 28);
            label10.TabIndex = 27;
            label10.Text = "Contact";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.MediumSeaGreen;
            label11.Font = new Font("Segoe UI", 15F);
            label11.Location = new Point(38, 562);
            label11.Name = "label11";
            label11.Size = new Size(83, 28);
            label11.TabIndex = 28;
            label11.Text = "Email ID";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.MediumSeaGreen;
            label12.Font = new Font("Segoe UI", 15F);
            label12.Location = new Point(38, 619);
            label12.Name = "label12";
            label12.Size = new Size(82, 28);
            label12.TabIndex = 29;
            label12.Text = "Address";
            label12.Click += label12_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSeaGreen;
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(785, 25);
            button1.Name = "button1";
            button1.Size = new Size(92, 36);
            button1.TabIndex = 30;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MediumSeaGreen;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(40, 83);
            label2.Name = "label2";
            label2.Size = new Size(122, 28);
            label2.TabIndex = 1;
            label2.Text = "Employee ID";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(936, 749);
            Controls.Add(button1);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox4);
            Controls.Add(label8);
            Controls.Add(comboBox2);
            Controls.Add(label7);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Label label6;
        private ComboBox comboBox1;
        private Label label7;
        private ComboBox comboBox2;
        private Label label8;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button button1;
        private Label label2;
    }
}
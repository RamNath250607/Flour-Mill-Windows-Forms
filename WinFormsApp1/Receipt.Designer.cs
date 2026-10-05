namespace WinFormsApp1
{
    partial class Receipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipt));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            comboBox2 = new ComboBox();
            textBox3 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            textBox4 = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            textBox5 = new TextBox();
            textBox7 = new TextBox();
            dateTimePicker2 = new DateTimePicker();
            button1 = new Button();
            comboBox3 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumSeaGreen;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(531, 9);
            label1.Name = "label1";
            label1.Size = new Size(104, 37);
            label1.TabIndex = 0;
            label1.Text = "Receipt";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MediumSeaGreen;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(65, 108);
            label2.Name = "label2";
            label2.Size = new Size(108, 28);
            label2.TabIndex = 1;
            label2.Text = "Receipt No";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MediumSeaGreen;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(65, 159);
            label3.Name = "label3";
            label3.Size = new Size(122, 28);
            label3.TabIndex = 2;
            label3.Text = "Receipt Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.MediumSeaGreen;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(65, 207);
            label4.Name = "label4";
            label4.Size = new Size(120, 28);
            label4.TabIndex = 3;
            label4.Text = "Customer ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.MediumSeaGreen;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(65, 257);
            label5.Name = "label5";
            label5.Size = new Size(115, 28);
            label5.TabIndex = 4;
            label5.Text = "Shop Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.MediumSeaGreen;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(65, 305);
            label6.Name = "label6";
            label6.Size = new Size(129, 28);
            label6.TabIndex = 5;
            label6.Text = "Amount Type";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.MediumSeaGreen;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(65, 355);
            label7.Name = "label7";
            label7.Size = new Size(83, 28);
            label7.TabIndex = 6;
            label7.Text = "Amount";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(317, 113);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(255, 23);
            textBox1.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(317, 159);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(255, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(317, 207);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(255, 23);
            comboBox1.TabIndex = 9;
            comboBox1.Text = "Select";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(317, 257);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(255, 23);
            textBox2.TabIndex = 10;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Cash", "UPI", "Bank" });
            comboBox2.Location = new Point(317, 305);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(255, 23);
            comboBox2.TabIndex = 11;
            comboBox2.Text = "Select";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(317, 360);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(255, 23);
            textBox3.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.MediumSeaGreen;
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(953, 126);
            label8.Name = "label8";
            label8.Size = new Size(42, 28);
            label8.TabIndex = 13;
            label8.Text = "UPI";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.MediumSeaGreen;
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(764, 173);
            label9.Name = "label9";
            label9.Size = new Size(134, 28);
            label9.TabIndex = 14;
            label9.Text = "Transaction ID";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(953, 178);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(255, 23);
            textBox4.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.MediumSeaGreen;
            label10.Font = new Font("Segoe UI", 15F);
            label10.Location = new Point(941, 237);
            label10.Name = "label10";
            label10.Size = new Size(54, 28);
            label10.TabIndex = 16;
            label10.Text = "Bank";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.MediumSeaGreen;
            label11.Font = new Font("Segoe UI", 15F);
            label11.Location = new Point(764, 290);
            label11.Name = "label11";
            label11.Size = new Size(110, 28);
            label11.TabIndex = 17;
            label11.Text = "Cheque No";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.MediumSeaGreen;
            label12.Font = new Font("Segoe UI", 15F);
            label12.Location = new Point(764, 346);
            label12.Name = "label12";
            label12.Size = new Size(111, 28);
            label12.TabIndex = 18;
            label12.Text = "Bank Name";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.MediumSeaGreen;
            label13.Font = new Font("Segoe UI", 15F);
            label13.Location = new Point(764, 396);
            label13.Name = "label13";
            label13.Size = new Size(124, 28);
            label13.TabIndex = 19;
            label13.Text = "Cheque Date";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.MediumSeaGreen;
            label14.Font = new Font("Segoe UI", 15F);
            label14.Location = new Point(764, 450);
            label14.Name = "label14";
            label14.Size = new Size(71, 28);
            label14.TabIndex = 20;
            label14.Text = "Branch";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(910, 295);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(255, 23);
            textBox5.TabIndex = 21;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(910, 455);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(255, 23);
            textBox7.TabIndex = 23;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(910, 401);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(255, 23);
            dateTimePicker2.TabIndex = 24;
            dateTimePicker2.Value = new DateTime(2025, 7, 21, 16, 42, 49, 0);
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSeaGreen;
            button1.Font = new Font("Segoe UI", 20F);
            button1.Location = new Point(405, 500);
            button1.Name = "button1";
            button1.Size = new Size(91, 51);
            button1.TabIndex = 25;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Axis Bank Limited  ", "Bandhan Bank Limited  ", "Bank of Baroda  ", "Bank of India  ", "Bank of Maharashtra  ", "Canara Bank  ", "Central Bank of India  ", "City Union Bank Limited  ", "CSB Bank Limited  ", "DCB Bank Limited  ", "Dhanlaxmi Bank Limited  ", "Federal Bank Limited  ", "HDFC Bank Limited  ", "ICICI Bank Limited  ", "IDBI Bank Limited  ", "IDFC FIRST Bank Limited  ", "IndusInd Bank Limited  ", "Jammu & Kashmir Bank Limited  ", "Karnataka Bank Limited  ", "Karur Vysya Bank Limited  ", "Kotak Mahindra Bank Limited  ", "Nainital Bank Limited  ", "Punjab & Sind Bank  ", "Punjab National Bank  ", "RBL Bank Limited  ", "South Indian Bank Limited  ", "State Bank of India  ", "Tamilnad Mercantile Bank Limited  ", "UCO Bank  ", "Union Bank of India  ", "Yes Bank Limited" });
            comboBox3.Location = new Point(910, 351);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(255, 23);
            comboBox3.TabIndex = 26;
            comboBox3.Text = "Select";
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // Receipt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1219, 615);
            Controls.Add(comboBox3);
            Controls.Add(button1);
            Controls.Add(dateTimePicker2);
            Controls.Add(textBox7);
            Controls.Add(textBox5);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(textBox4);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textBox3);
            Controls.Add(comboBox2);
            Controls.Add(textBox2);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Receipt";
            Text = "Receipt";
            Load += Receipt_Load;
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
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private ComboBox comboBox2;
        private TextBox textBox3;
        private Label label8;
        private Label label9;
        private TextBox textBox4;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox textBox5;
        private TextBox textBox7;
        private DateTimePicker dateTimePicker2;
        private Button button1;
        private ComboBox comboBox3;
    }
}
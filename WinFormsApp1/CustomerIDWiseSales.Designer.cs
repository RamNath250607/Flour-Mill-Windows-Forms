namespace WinFormsApp1
{
    partial class CustomerIDWiseSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerIDWiseSales));
            comboBox1 = new ComboBox();
            label5 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label4 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(348, 106);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(178, 23);
            comboBox1.TabIndex = 27;
            comboBox1.Text = "Select";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.MediumSeaGreen;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(145, 106);
            label5.Name = "label5";
            label5.Size = new Size(120, 28);
            label5.TabIndex = 26;
            label5.Text = "Customer ID";
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSeaGreen;
            button1.Font = new Font("Segoe UI", 20F);
            button1.Location = new Point(715, 268);
            button1.Name = "button1";
            button1.Size = new Size(140, 46);
            button1.TabIndex = 25;
            button1.Text = "View";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(348, 238);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(191, 23);
            textBox1.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.MediumSeaGreen;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(145, 233);
            label4.Name = "label4";
            label4.Size = new Size(114, 28);
            label4.TabIndex = 23;
            label4.Text = "Credit Sales";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(680, 174);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MediumSeaGreen;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(589, 169);
            label3.Name = "label3";
            label3.Size = new Size(32, 28);
            label3.TabIndex = 21;
            label3.Text = "To";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(238, 178);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MediumSeaGreen;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(145, 170);
            label2.Name = "label2";
            label2.Size = new Size(58, 28);
            label2.TabIndex = 19;
            label2.Text = "From";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumSeaGreen;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(399, 28);
            label1.Name = "label1";
            label1.Size = new Size(288, 37);
            label1.TabIndex = 18;
            label1.Text = "CustomerID Wise Sales";
            // 
            // CustomerIDWiseSales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1072, 450);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(dateTimePicker2);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CustomerIDWiseSales";
            Text = "CustomerIDWiseSales";
            Load += CustomerIDWiseSales_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label5;
        private Button button1;
        private TextBox textBox1;
        private Label label4;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label1;
    }
}
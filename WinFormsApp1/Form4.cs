using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string Gender = "";
            if (radioButton1.Checked)
                Gender = radioButton1.Text;
            else if (radioButton2.Checked)
                Gender = radioButton2.Text;
            else if (radioButton3.Checked)
                Gender = radioButton3.Text;
            else
            {
                MessageBox.Show("Fill Gender");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(comboBox2.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(dateTimePicker1.Text) || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text) || string.IsNullOrWhiteSpace(textBox7.Text))
            {
                MessageBox.Show("Fill All Details");
                return;
            }
            String num = textBox5.Text.Trim();
            using SqlConnection con = new SqlConnection("Data Source=LAPTOP-HVG12FQ7\\SQLEXPRESS;Initial Catalog=flour;Integrated Security=True");
            con.Open();
            if (!num.All(char.IsDigit) || num.Length != 10)
            {
                MessageBox.Show("Reenter your contact Number");
                return;
            }
            SqlCommand com = new SqlCommand("Insert into Employee values(" + textBox1.Text + ",'" + textBox2.Text + "'," + textBox3.Text + ",'" + Gender + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox4.Text + "','" + Convert.ToDateTime(dateTimePicker1.Text).ToString("yyyy-MM-dd") + "'," + textBox5.Text + ",'" + textBox6.Text + "','" + textBox7.Text + "')", con);
            com.ExecuteNonQuery();
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            Gender = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox4.Text = "";
            dateTimePicker1.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox1.Focus();
            MessageBox.Show("Record Added Successfully");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(comboBox2.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(comboBox3.Text) || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text) || string.IsNullOrWhiteSpace(textBox7.Text) || string.IsNullOrWhiteSpace(textBox8.Text))
            {
                MessageBox.Show("Fill All Details");
                return;
            }
            String num = textBox6.Text.Trim();
            using SqlConnection con = new SqlConnection("Data Source=LAPTOP-HVG12FQ7\\SQLEXPRESS;Initial Catalog=flour;Integrated Security=True");
            con.Open();
            if (!num.All(char.IsDigit) || num.Length != 10)
            {
                MessageBox.Show("Reenter your contact Number");
                return;
            }
            SqlCommand com2 = new SqlCommand("UPDATE Employee SET " + "Age = " + textBox2.Text + ", " + "Qualification = '" + comboBox2.Text + "', " + "Designation = '" + comboBox3.Text + "', " + "BasicPay = '" + textBox4.Text + "', " + "Contact = '" + textBox6.Text + "', " + "EmailID = '" + textBox7.Text + "', " + "Address = '" + textBox8.Text + "' " + "WHERE EmployeeID = '" + comboBox1.Text + "'", con);
            com2.ExecuteNonQuery();
            con.Close();
            textBox1.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "SELECT";
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            comboBox1.Focus();
            MessageBox.Show("Record Updated Successfully");
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            using SqlConnection con = new SqlConnection("Data Source=LAPTOP-HVG12FQ7\\SQLEXPRESS;Initial Catalog=flour;Integrated Security=True");
            con.Open();
            SqlDataReader dr;
            SqlCommand com = new SqlCommand("select EmployeeID from Employee", con);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using SqlConnection con = new SqlConnection("Data Source=LAPTOP-HVG12FQ7\\SQLEXPRESS;Initial Catalog=flour;Integrated Security=True");
            con.Open();
            SqlDataReader dr1;
            SqlCommand com1 = new SqlCommand("select * from  Employee where EmployeeID='" + comboBox1.Text + "'", con);
            dr1 = com1.ExecuteReader();
            while (dr1.Read())
            {
                textBox1.Text = dr1[1].ToString();
                textBox2.Text = dr1[2].ToString();
                textBox3.Text = dr1[3].ToString();
                comboBox2.Text = dr1[4].ToString();
                comboBox3.Text = dr1[5].ToString();
                textBox4.Text = dr1[6].ToString();
                textBox5.Text = dr1[7].ToString();
                textBox6.Text = dr1[8].ToString();
                textBox7.Text = dr1[9].ToString();
                textBox8.Text = dr1[10].ToString();
            }
            dr1.Close();
            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

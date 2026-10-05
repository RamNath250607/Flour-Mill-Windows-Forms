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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class UpdateCustomer : Form
    {
        public UpdateCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(comboBox2.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(comboBox3.Text) || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text) || string.IsNullOrWhiteSpace(textBox7.Text) || string.IsNullOrWhiteSpace(textBox8.Text))
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
            SqlCommand com = new SqlCommand("UPDATE Customer SET " + "ShopName = '" + textBox1.Text + "', " + "PartnerName = '" + textBox2.Text + "', " + "GSTNo = '" + textBox3.Text + "', " + "EmailID = '" + textBox4.Text + "', " + "Contact = '" + textBox5.Text + "', " + "Address = '" + textBox6.Text + "', " + "BankName = '" + comboBox2.Text + "', " + "AccountNo = '" + textBox7.Text + "', " + "AccountType = '" + comboBox3.Text + "', " + "IFSCCode = '" + textBox8.Text + "' " + "WHERE CustomerID = '" + comboBox1.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            comboBox1.Text = "Select";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            comboBox2.Text = "";
            textBox7.Text = "";
            comboBox3.Text = "";
            textBox8.Text = "";
            comboBox1.Focus();
            MessageBox.Show("Customer record updated successfully.");

        }

        private void UpdateCustomer_Load(object sender, EventArgs e)
        {
            using SqlConnection con = new SqlConnection("Data Source=LAPTOP-HVG12FQ7\\SQLEXPRESS;Initial Catalog=flour;Integrated Security=True");
            con.Open();
            SqlDataReader dr;
            SqlCommand com = new SqlCommand("select CustomerID from Customer", con);
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
            SqlCommand com1 = new SqlCommand("select * from  Customer where CustomerID='" + comboBox1.Text + "'", con);
            dr1 = com1.ExecuteReader();
            while (dr1.Read())
            {
                textBox1.Text = dr1[1].ToString();
                textBox2.Text = dr1[2].ToString();
                textBox3.Text = dr1[3].ToString();
                textBox4.Text = dr1[4].ToString();
                textBox5.Text = dr1[5].ToString();
                textBox6.Text = dr1[6].ToString();
                comboBox2.Text = dr1[7].ToString();
                textBox7.Text = dr1[8].ToString();
                comboBox3.Text = dr1[9].ToString();
                textBox8.Text = dr1[10].ToString();
            }
            dr1.Close();
            con.Close();
        }
    }
}

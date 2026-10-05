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
    public partial class Salarycs : Form
    {
        public Salarycs()
        {
            InitializeComponent();
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
                textBox2.Text = dr1[5].ToString();
                textBox3.Text = dr1[6].ToString();
            }
            dr1.Close();
            con.Close();
        }
        private void NetSalary()
        {
            try

            {
                if (!string.IsNullOrWhiteSpace(textBox3.Text) && !string.IsNullOrWhiteSpace(textBox4.Text) && !string.IsNullOrWhiteSpace(textBox5.Text))
                {
                    decimal basicPay = decimal.Parse(textBox3.Text);
                    decimal allowance = decimal.Parse(textBox4.Text);
                    decimal reduction = decimal.Parse(textBox5.Text);
                    decimal netSalary = (basicPay + allowance) - reduction;
                    textBox6.Text = netSalary.ToString();
                }
                else
                {
                    textBox6.Text = string.Empty;
                }
            }
            catch
            {
                textBox6.Text = string.Empty;
            }
        }


        private void Salarycs_Load(object sender, EventArgs e)
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            NetSalary();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            NetSalary();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            NetSalary();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using SqlConnection con = new SqlConnection("Data Source=LAPTOP-HVG12FQ7\\SQLEXPRESS;Initial Catalog=flour;Integrated Security=True");
            con.Open();

            SqlCommand com2 = new SqlCommand("INSERT INTO Salary (EmployeeID, EmployeeName, Designation, BasicPay, Allowance, Deduction, NetSalary, Month_Year) " + "VALUES ('" + comboBox1.Text + "', '" + textBox1.Text + "', '" + textBox2.Text + "', " + textBox3.Text + ", " + textBox4.Text + ", " + textBox5.Text + ", " + textBox6.Text + ", '" + textBox7.Text + "')", con);
            com2.ExecuteNonQuery();
            con.Close();
            comboBox1.Text = "SELECT";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            comboBox1.Focus();

            MessageBox.Show("Record Inserted Successfully");
        }
    }
}

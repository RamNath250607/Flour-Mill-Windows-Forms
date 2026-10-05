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
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Receipt_Load(object sender, EventArgs e)
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
                textBox2.Text = dr1[1].ToString();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selected = comboBox2.Text;

            label8.Visible = false;
            label9.Visible = false;
            textBox4.Visible = false;

            label10.Visible = false;
            label11.Visible = false;
            textBox5.Visible = false;
            label12.Visible = false;
            comboBox3.Visible = false;
            label13.Visible = false;
            dateTimePicker2.Visible = false;
            label14.Visible = false;
            textBox7.Visible = false;
            if (selected == "UPI")
            {
                label8.Visible = true;
                label9.Visible = true;
                textBox4.Visible = true;

            }
            else if (selected == "Bank")
            {
                label10.Visible = true;
                label11.Visible = true;
                textBox5.Visible = true;
                label12.Visible = true;
                comboBox3.Visible = true;
                label13.Visible = true;
                dateTimePicker2.Visible = true;
                label14.Visible = true;
                textBox7.Visible = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using SqlConnection con = new SqlConnection("Data Source=LAPTOP-HVG12FQ7\\SQLEXPRESS;Initial Catalog=flour;Integrated Security=True");
            con.Open();
            string transactionId = null;
            string chequeNo = null;
            string bankName = null;
            DateTime? chequeDate = null;
            string branch = null;

            if (comboBox2.Text == "UPI")
            {
                transactionId = string.IsNullOrWhiteSpace(textBox4.Text) ? null : textBox4.Text;
            }
            else if (comboBox2.Text == "Bank")
            {
                chequeNo = string.IsNullOrWhiteSpace(textBox5.Text) ? null : textBox5.Text;
                bankName = string.IsNullOrWhiteSpace(comboBox3.Text) ? null : comboBox3.Text;
                chequeDate = dateTimePicker2.Value;
                branch = string.IsNullOrWhiteSpace(textBox7.Text) ? null : textBox7.Text;
            }
            SqlCommand com2 = new SqlCommand("INSERT INTO Receipt (ReceiptNo, ReceiptDate, CustomerId, ShopName, AmountType, Amount, TransactionId, ChequeNo, BankName, ChequeDate, Branch) " +"VALUES (@ReceiptNo, @ReceiptDate, @CustomerId, @ShopName, @AmountType, @Amount, @TransactionId, @ChequeNo, @BankName, @ChequeDate, @Branch)", con);

            com2.Parameters.AddWithValue("@ReceiptNo", textBox1.Text);
            com2.Parameters.AddWithValue("@ReceiptDate", dateTimePicker1.Value);
            com2.Parameters.AddWithValue("@CustomerId", comboBox1.Text);
            com2.Parameters.AddWithValue("@ShopName", textBox2.Text);
            com2.Parameters.AddWithValue("@AmountType", comboBox2.Text);
            com2.Parameters.AddWithValue("@Amount", textBox3.Text);
            com2.Parameters.AddWithValue("@TransactionId", (object?)transactionId ?? DBNull.Value);
            com2.Parameters.AddWithValue("@ChequeNo", (object?)chequeNo ?? DBNull.Value);
            com2.Parameters.AddWithValue("@BankName", (object?)bankName ?? DBNull.Value);
            com2.Parameters.AddWithValue("@ChequeDate", (object?)chequeDate ?? DBNull.Value);
            com2.Parameters.AddWithValue("@Branch", (object?)branch ?? DBNull.Value);

            com2.ExecuteNonQuery();
            con.Close();
            textBox1.Text = "";
            dateTimePicker1.Text = "";
            comboBox1.Text = "Select";
            textBox2.Text = "";
            comboBox2.Text = "Select";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox3.Text = "Select";
            dateTimePicker2.Text = "";
            textBox7.Text = "";
            textBox1.Focus();
            MessageBox.Show("Record Inserted Successfully");
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class CustomerIDWiseSales : Form
    {
        public CustomerIDWiseSales()
        {
            InitializeComponent();
        }

        private void CustomerIDWiseSales_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
         
            string cid = comboBox1.Text;
            DateTime from = dateTimePicker1.Value.Date;
            DateTime to = dateTimePicker2.Value.Date;

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-HVG12FQ7\\SQLEXPRESS;Initial Catalog=flour;Integrated Security=True");
            con.Open();
            if (to < from)
            {
                MessageBox.Show("Enter To Date Correctly");
                return;
            }

            SqlCommand com = new SqlCommand("SELECT ISNULL(SUM(NetAmount), 0) FROM CreditDetails WHERE CustomerID = @cid AND BillDate BETWEEN @from AND @to", con);
            com.Parameters.AddWithValue("@cid", cid);
            com.Parameters.AddWithValue("@from", from);
            com.Parameters.AddWithValue("@to", to);

            decimal total = Convert.ToDecimal(com.ExecuteScalar());
            textBox1.Text = total.ToString("F2");

            con.Close();
        }
    }
    
}

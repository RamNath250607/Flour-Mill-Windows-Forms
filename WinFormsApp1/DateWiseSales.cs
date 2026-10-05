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
    public partial class DateWiseSales : Form
    {
        public DateWiseSales()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DateTime selectedDate = dateTimePicker1.Value.Date;

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-HVG12FQ7\\SQLEXPRESS;Initial Catalog=flour;Integrated Security=True");
            con.Open();
            SqlCommand com1 = new SqlCommand("SELECT ISNULL(SUM(NetAmount), 0) FROM CreditDetails WHERE CONVERT(date, BillDate) = @d", con);
            com1.Parameters.AddWithValue("@d", selectedDate);
            decimal credit = Convert.ToDecimal(com1.ExecuteScalar());
            textBox1.Text = credit.ToString("F2");
            SqlCommand com2 = new SqlCommand("SELECT ISNULL(SUM(NetAmount), 0) FROM CashSales WHERE CONVERT(date, BillDate) = @d", con);
            com2.Parameters.AddWithValue("@d", selectedDate);
            decimal cash = Convert.ToDecimal(com2.ExecuteScalar());
            textBox2.Text = cash.ToString("F2");
            decimal total = credit + cash;
            textBox3.Text = total.ToString("F2");

            con.Close();
        }

        private void DateWiseSales_Load(object sender, EventArgs e)
        {

        }
    }
}

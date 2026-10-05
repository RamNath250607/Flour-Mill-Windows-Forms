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
    public partial class ViewCashSales : Form
    {
        public ViewCashSales()
        {
            InitializeComponent();
        }

        private void ViewCashSales_Load(object sender, EventArgs e)
        {
            using SqlConnection con = new SqlConnection("Data Source=LAPTOP-HVG12FQ7\\SQLEXPRESS;Initial Catalog=flour;Integrated Security=True");
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter("Select * from CashSales", con);
            DataSet ds = new DataSet();
            ad.Fill(ds, "a");
            dataGridView1.DataSource = ds.Tables["a"].DefaultView;
            con.Close();

        }
    }
}

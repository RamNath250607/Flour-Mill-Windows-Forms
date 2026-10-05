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
    public partial class CreditDetails : Form
    {
        public CreditDetails()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CreditDetails_Load(object sender, EventArgs e)
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
            using SqlConnection con1 = new SqlConnection("Data Source=LAPTOP-HVG12FQ7\\SQLEXPRESS;Initial Catalog=flour;Integrated Security=True");
            con1.Open();
            SqlDataReader dr1;
            SqlCommand com1 = new SqlCommand("select ProductID from Product", con1);
            dr1 = com1.ExecuteReader();
            while (dr1.Read())
            {
                comboBox2.Items.Add(dr1[0].ToString());
            }
            dr1.Close();
            con1.Close();
            using SqlConnection con2 = new SqlConnection("Data Source=LAPTOP-HVG12FQ7\\SQLEXPRESS;Initial Catalog=flour;Integrated Security=True");
            con2.Open();
            SqlDataReader dr2;
            SqlCommand com2 = new SqlCommand("select ProductID from Product", con2);
            dr2 = com2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox3.Items.Add(dr2[0].ToString());
            }
            dr2.Close();
            con2.Close();
            using SqlConnection con3 = new SqlConnection("Data Source=LAPTOP-HVG12FQ7\\SQLEXPRESS;Initial Catalog=flour;Integrated Security=True");
            con3.Open();
            SqlDataReader dr3;
            SqlCommand com3 = new SqlCommand("select ProductID from Product", con3);
            dr3 = com3.ExecuteReader();
            while (dr3.Read())
            {
                comboBox4.Items.Add(dr3[0].ToString());
            }
            dr3.Close();
            con3.Close();
            using SqlConnection con4 = new SqlConnection("Data Source=LAPTOP-HVG12FQ7\\SQLEXPRESS;Initial Catalog=flour;Integrated Security=True");
            con4.Open();
            SqlDataReader dr4;
            SqlCommand com4 = new SqlCommand("select ProductID from Product", con4);
            dr4 = com4.ExecuteReader();
            while (dr4.Read())
            {
                comboBox5.Items.Add(dr4[0].ToString());
            }
            dr4.Close();
            con4.Close();
            using SqlConnection con5 = new SqlConnection("Data Source=LAPTOP-HVG12FQ7\\SQLEXPRESS;Initial Catalog=flour;Integrated Security=True");
            con5.Open();
            SqlDataReader dr5;
            SqlCommand com5 = new SqlCommand("select ProductID from Product", con5);
            dr5 = com5.ExecuteReader();
            while (dr5.Read())
            {
                comboBox6.Items.Add(dr5[0].ToString());
            }
            dr5.Close();
            con5.Close();
            using SqlConnection con6 = new SqlConnection("Data Source=LAPTOP-HVG12FQ7\\SQLEXPRESS;Initial Catalog=flour;Integrated Security=True");
            con6.Open();
            SqlDataReader dr6;
            SqlCommand com6 = new SqlCommand("select ProductID from Product", con6);
            dr6 = com6.ExecuteReader();
            while (dr6.Read())
            {
                comboBox7.Items.Add(dr6[0].ToString());
            }
            dr6.Close();
            con6.Close();
            using SqlConnection con7 = new SqlConnection("Data Source=LAPTOP-HVG12FQ7\\SQLEXPRESS;Initial Catalog=flour;Integrated Security=True");
            con7.Open();
            SqlDataReader dr7;
            SqlCommand com7 = new SqlCommand("select ProductID from Product", con7);
            dr7 = com7.ExecuteReader();
            while (dr7.Read())
            {
                comboBox8.Items.Add(dr7[0].ToString());
            }
            dr7.Close();
            con7.Close();


        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {

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
                textBox45.Text = dr1[1].ToString();
                textBox2.Text = dr1[3].ToString();
                textBox3.Text = dr1[5].ToString();

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            using SqlConnection con = new SqlConnection("Data Source=LAPTOP-HVG12FQ7\\SQLEXPRESS;Initial Catalog=flour;Integrated Security=True");
            con.Open();
            SqlDataReader dr1;
            SqlCommand com1 = new SqlCommand("select * from  Product where ProductId='" + comboBox2.Text + "'", con);
            dr1 = com1.ExecuteReader();
            while (dr1.Read())
            {
                textBox4.Text = dr1[1].ToString();
                textBox5.Text = dr1[2].ToString();
                textBox6.Text = dr1[3].ToString();
            }
            dr1.Close();
            con.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            using SqlConnection con = new SqlConnection("Data Source=LAPTOP-HVG12FQ7\\SQLEXPRESS;Initial Catalog=flour;Integrated Security=True");
            con.Open();
            SqlDataReader dr1;
            SqlCommand com1 = new SqlCommand("select * from  Product where ProductId='" + comboBox3.Text + "'", con);
            dr1 = com1.ExecuteReader();
            while (dr1.Read())
            {
                textBox13.Text = dr1[1].ToString();
                textBox12.Text = dr1[2].ToString();
                textBox11.Text = dr1[3].ToString();
            }
            dr1.Close();
            con.Close();
        }



        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            using SqlConnection con = new SqlConnection("Data Source=LAPTOP-HVG12FQ7\\SQLEXPRESS;Initial Catalog=flour;Integrated Security=True");
            con.Open();
            SqlDataReader dr1;
            SqlCommand com1 = new SqlCommand("select * from  Product where ProductId='" + comboBox5.Text + "'", con);
            dr1 = com1.ExecuteReader();
            while (dr1.Read())
            {
                textBox23.Text = dr1[1].ToString();
                textBox22.Text = dr1[2].ToString();
                textBox21.Text = dr1[3].ToString();
            }
            dr1.Close();
            con.Close();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            using SqlConnection con = new SqlConnection("Data Source=LAPTOP-HVG12FQ7\\SQLEXPRESS;Initial Catalog=flour;Integrated Security=True");
            con.Open();
            SqlDataReader dr1;
            SqlCommand com1 = new SqlCommand("select * from  Product where ProductId='" + comboBox6.Text + "'", con);
            dr1 = com1.ExecuteReader();
            while (dr1.Read())
            {
                textBox28.Text = dr1[1].ToString();
                textBox27.Text = dr1[2].ToString();
                textBox26.Text = dr1[3].ToString();
            }
            dr1.Close();
            con.Close();
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            using SqlConnection con = new SqlConnection("Data Source=LAPTOP-HVG12FQ7\\SQLEXPRESS;Initial Catalog=flour;Integrated Security=True");
            con.Open();
            SqlDataReader dr1;
            SqlCommand com1 = new SqlCommand("select * from  Product where ProductId='" + comboBox7.Text + "'", con);
            dr1 = com1.ExecuteReader();
            while (dr1.Read())
            {
                textBox33.Text = dr1[1].ToString();
                textBox32.Text = dr1[2].ToString();
                textBox31.Text = dr1[3].ToString();
            }
            dr1.Close();
            con.Close();
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            using SqlConnection con = new SqlConnection("Data Source=LAPTOP-HVG12FQ7\\SQLEXPRESS;Initial Catalog=flour;Integrated Security=True");
            con.Open();
            SqlDataReader dr1;
            SqlCommand com1 = new SqlCommand("select * from  Product where ProductId='" + comboBox8.Text + "'", con);
            dr1 = com1.ExecuteReader();
            while (dr1.Read())
            {
                textBox38.Text = dr1[1].ToString();
                textBox37.Text = dr1[2].ToString();
                textBox36.Text = dr1[3].ToString();
            }
            dr1.Close();
            con.Close();
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            using SqlConnection con = new SqlConnection("Data Source=LAPTOP-HVG12FQ7\\SQLEXPRESS;Initial Catalog=flour;Integrated Security=True");
            con.Open();
            SqlDataReader dr1;
            SqlCommand com1 = new SqlCommand("select * from  Product where ProductId='" + comboBox4.Text + "'", con);
            dr1 = com1.ExecuteReader();
            while (dr1.Read())
            {
                textBox18.Text = dr1[1].ToString();
                textBox17.Text = dr1[2].ToString();
                textBox16.Text = dr1[3].ToString();
            }
            dr1.Close();
            con.Close();

        }

        private void Amount1()
        {
            double a, b, c;
            bool d = double.TryParse(textBox6.Text, out a);
            bool e = double.TryParse(textBox7.Text, out b);
            if (d && e)
            {
                c = a * b;
                textBox8.Text = c.ToString("0.00");
            }
            TotalAmount();

        }
        private void Amount2()
        {
            double a, b, c;
            bool d = double.TryParse(textBox10.Text, out a);
            bool e = double.TryParse(textBox11.Text, out b);
            if (d && e)
            {
                c = a * b;
                textBox9.Text = c.ToString("0.00");
            }
            TotalAmount();
        }
        private void Amount3()
        {
            double a, b, c;
            bool d = double.TryParse(textBox15.Text, out a);
            bool e = double.TryParse(textBox16.Text, out b);
            if (d && e)
            {
                c = a * b;
                textBox14.Text = c.ToString("0.00");
            }

            TotalAmount();
        }
        private void Amount4()
        {
            double a, b, c;
            bool d = double.TryParse(textBox20.Text, out a);
            bool e = double.TryParse(textBox21.Text, out b);
            if (d && e)
            {
                c = a * b;
                textBox19.Text = c.ToString("0.00");
            }

            TotalAmount();
        }
        private void Amount5()
        {
            double a, b, c;
            bool d = double.TryParse(textBox25.Text, out a);
            bool e = double.TryParse(textBox26.Text, out b);
            if (d && e)
            {
                c = a * b;
                textBox24.Text = c.ToString("0.00");
            }

            TotalAmount();
        }
        private void Amount6()
        {
            double a, b, c;
            bool d = double.TryParse(textBox30.Text, out a);
            bool e = double.TryParse(textBox31.Text, out b);
            if (d && e)
            {
                c = a * b;
                textBox29.Text = c.ToString("0.00");
            }

            TotalAmount();
        }
        private void Amount7()
        {
            double a, b, c;
            bool d = double.TryParse(textBox35.Text, out a);
            bool e = double.TryParse(textBox36.Text, out b);
            if (d && e)
            {
                c = a * b;
                textBox34.Text = c.ToString();
            }

            TotalAmount();
        }
        private void TotalAmount()
        {
            double a, b, c, d, e, f, g, o = 0;

            double.TryParse(textBox8.Text, out a);
            double.TryParse(textBox9.Text, out b);
            double.TryParse(textBox14.Text, out c);
            double.TryParse(textBox19.Text, out d);
            double.TryParse(textBox24.Text, out e);
            double.TryParse(textBox29.Text, out f);
            double.TryParse(textBox34.Text, out g);
            o = a + b + c + d + e + f + g;
            textBox39.Text = o.ToString("0.00");

        }
        private void CGST()
        {
            double a, b, c;
            bool d = double.TryParse(textBox40.Text, out a);
            bool e = double.TryParse(textBox39.Text, out b);
            if (d && e)
            {
                c = (a * b) / 100;
                textBox41.Text = c.ToString("0.00");
            }

        }
        private void SGST()
        {
            double a, b, c;
            bool d = double.TryParse(textBox42.Text, out a);
            bool e = double.TryParse(textBox39.Text, out b);
            if (d && e)
            {
                c = (a * b) / 100;
                textBox43.Text = c.ToString("0.00");
            }

        }
        private void NetAmount()
        {
            double a, b, c, d;
            bool e = double.TryParse(textBox41.Text, out a);
            bool f = double.TryParse(textBox39.Text, out b);
            bool g = double.TryParse(textBox43.Text, out c);
            if (e && f && g)
            {
                d = a + b + c;
                textBox44.Text = d.ToString("0.00");
            }

        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            TotalAmount();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            TotalAmount();
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            TotalAmount();
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            TotalAmount();
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            TotalAmount();
        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {
            TotalAmount();
        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {
            TotalAmount();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            Amount1();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            Amount1();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            Amount2();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            Amount2();
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            Amount3();
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            Amount3();
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            Amount4();
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            Amount4();
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            Amount5();
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            Amount5();
        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {
            Amount6();
        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {
            Amount6();
        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {
            Amount7();
        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {
            Amount7();
        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {
            CGST();
        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {
            SGST();
        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {
            CGST();
            SGST();
            NetAmount();
        }

        private void textBox43_TextChanged_1(object sender, EventArgs e)
        {
            NetAmount();
        }

        private void textBox41_TextChanged(object sender, EventArgs e)
        {
            NetAmount();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using SqlConnection con = new SqlConnection("Data Source=LAPTOP-HVG12FQ7\\SQLEXPRESS;Initial Catalog=flour;Integrated Security=True");
            con.Open();
            string productData = "";
            if (textBox4.Text!="" && textBox5.Text!=""  && textBox7.Text != "" && textBox8.Text != "")
                productData += textBox4.Text + "-" + textBox5.Text + "-" + textBox7.Text + "-" + textBox8.Text + ",";
            if (textBox13.Text != "" && textBox12.Text != "" && textBox10.Text != "" && textBox9.Text != "")
                productData += textBox13.Text + "-" + textBox12.Text + "-" + textBox10.Text + "-" + textBox9.Text + ",";

            if (textBox18.Text != "" && textBox17.Text != "" && textBox15.Text != "" && textBox14.Text != "")
                productData += textBox18.Text + "-" + textBox17.Text + "-" + textBox15.Text + "-" + textBox14.Text + ",";

            if (textBox23.Text != "" && textBox22.Text != "" && textBox20.Text != "" && textBox19.Text != "")
                productData += textBox23.Text + "-" + textBox22.Text + "-" + textBox20.Text + "-" + textBox19.Text + ",";

            if (textBox28.Text != "" && textBox27.Text != "" && textBox25.Text != "" && textBox24.Text != "")
                productData += textBox28.Text + "-" + textBox27.Text + "-" + textBox25.Text + "-" + textBox24.Text + ",";

            if (textBox33.Text != "" && textBox32.Text != "" && textBox30.Text != "" && textBox29.Text != "")
                productData += textBox33.Text + "-" + textBox32.Text + "-" + textBox30.Text + "-" + textBox29.Text + ",";

            if (textBox38.Text != "" && textBox37.Text != "" && textBox35.Text != "" && textBox34.Text != "")
                productData += textBox38.Text + "-" + textBox37.Text + "-" + textBox35.Text + "-" + textBox34.Text + ",";
            if (productData.EndsWith(","))
                productData = productData.Substring(0, productData.Length - 1);

            // Insert into DB
            SqlCommand com2 = new SqlCommand("INSERT INTO CreditDetails " +"(BillNo, BillDate, CustomerID, ShopName, GSTNo, Contact, ProductName_Pack_Quantity_Amount, TotalAmount, CGST, CGST_Amount, SGST, SGST_Amount, NetAmount) " +"VALUES ('" + textBox1.Text + "', '" + dateTimePicker1.Text + "', '" + comboBox1.Text + "', '" + textBox45.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + productData + "', '" + textBox39.Text + "', '" + textBox40.Text + "', '" + textBox41.Text + "', '" + textBox42.Text + "', '" + textBox43.Text + "', '" + textBox44.Text + "')",con);
             com2.ExecuteNonQuery();
            con.Close();
            textBox1.Text = "";
            dateTimePicker1.Text = "";
            comboBox1.Text = "";
            textBox45.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            comboBox6.Text = "";
            comboBox7.Text = "";
            comboBox8.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
            textBox18.Text = "";
            textBox19.Text = "";
            textBox20.Text = "";
            textBox21.Text = "";
            textBox22.Text = "";
            textBox23.Text = "";
            textBox24.Text = "";
            textBox25.Text = "";
            textBox26.Text = "";
            textBox27.Text = "";
            textBox28.Text = "";
            textBox29.Text = "";
            textBox30.Text = "";
            textBox31.Text = "";
            textBox32.Text = "";
            textBox33.Text = "";
            textBox34.Text = "";
            textBox35.Text = "";
            textBox36.Text = "";
            textBox37.Text = "";
            textBox38.Text = "";
            textBox39.Text = "";
            textBox40.Text = "";
            textBox41.Text = "";
            textBox42.Text = "";
            textBox43.Text = "";
            textBox44.Text = "";
            textBox1.Focus();
            MessageBox.Show("Record Inserted Successfully");
        }
    }
}

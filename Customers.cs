using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SellingApp
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GCBTDU9\SQLEXPRESS;Initial Catalog=CRUD;Integrated Security=True");
        private void Customers_Load(object sender, EventArgs e)
        {
            DisplayCustomer();
        }
        public void DisplayCustomer()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Customer", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Customer");
            dataGridViewCustomer.DataSource = ds.Tables["Customer"];
        }
        public void DisplayOne()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Customer WHERE CustomerId='"+searchTxt.Text+"'", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Customer");
            dataGridViewCustomer.DataSource = ds.Tables["Customer"];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO Customer values('" + custId.Text + "','" + firstNameTxt.Text + "','" + LastNameTxt.Text + "','" + genderTxt.SelectedText + "','" + AddressTxt.Text + "','" + dateTxt.Value.Date + "')", conn);
            conn.Open();
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Successfully inserted", "Insertion");
            DisplayCustomer();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DisplayOne();
        }
    }
}

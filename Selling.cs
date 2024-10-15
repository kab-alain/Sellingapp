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
    public partial class Selling : Form
    {
        public Selling()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GCBTDU9\SQLEXPRESS;Initial Catalog=CRUD;Integrated Security=True");
        private void Selling_Load(object sender, EventArgs e)
        {
            DisplaySales();
            DisplayCustCombo();
            DisplayProdCombo();
        }
        private void DisplaySales()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Selling", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Selling");
            dataGridViewSelling.DataSource = ds.Tables["Selling"];
        }
        private void DisplayProdCombo()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Product", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Product");
            prodCombotxt.DataSource = ds.Tables["Product"];
            prodCombotxt.DisplayMember = "productName";
            prodCombotxt.ValueMember = "productId";
        }
        private void DisplayCustCombo()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Customer", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Customer");
            custCombotxt.DataSource = ds.Tables["Customer"];
            custCombotxt.DisplayMember = "productName";
            custCombotxt.ValueMember = "firstName";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        SqlDataReader rd;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT unitPrice FROM Product WHERE productName='"+prodCombotxt.Text+"'",conn);
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                unityPriceTxt.Text=rd.GetValue(0).ToString();
            }
            conn.Close();
        }

        private void quantityTxt_TextChanged(object sender, EventArgs e)
        {
            float unitpr = float.Parse(unityPriceTxt.Text);
            int qty = Int32.Parse(quantityTxt.Text);
            float total = unitpr * qty;
            totalPriceTxt.Text = total.ToString();  
        }

        private void sellBTN_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Selling values(@product,@customer,@transdate,@quantity,@total", conn);
          //  cmd.Parameters.AddWithValue("@id", productNameTxt.Text);
            cmd.Parameters.AddWithValue("@product", prodCombotxt.Text);
            cmd.Parameters.AddWithValue("@customer", custCombotxt.Text);
            cmd.Parameters.AddWithValue("@transdate", dateTimePicker1.MaxDate);
            cmd.Parameters.AddWithValue("@quantity", quantityTxt.Text);
            cmd.Parameters.AddWithValue("@total", totalPriceTxt.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Successfully Inserted", "Insertion");
            DisplaySales();
        }
    }
}

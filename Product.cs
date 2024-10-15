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

namespace SellingApp
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GCBTDU9\SQLEXPRESS;Initial Catalog=CRUD;Integrated Security=True");
        private void Product_Load(object sender, EventArgs e)
        {
            DisplayProduct();
        }
        private void DisplayProduct()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Product", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Product");
            dataGridViewProduct.DataSource = ds.Tables["Product"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO Product values('"+productIdTxt.Text+ "','"+productNameTxt.Text+ "','"+unityPriceTxt.Text+ "','"+quantityPriceTxt.Text+ "','"+dateOfExpTxt.Value.Date+"')", conn);
            conn.Open();
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Successfully inserted","Insertion");
            DisplayProduct();
        }
        
        private void updateTxt_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Product set productName=@name,unitPrice=@price,quantityDate=@quantity,expiryDtae=@date WHERE productId=@id", conn);
            cmd.Parameters.AddWithValue("@name", productNameTxt.Text);
            cmd.Parameters.AddWithValue("@price",unityPriceTxt.Text);
            cmd.Parameters.AddWithValue("@quantity",quantityPriceTxt.Text);
            cmd.Parameters.AddWithValue("@date", dateOfExpTxt.MaxDate);
            cmd.Parameters.AddWithValue("@id",productIdTxt.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Successfully Updated", "Updation");
            DisplayProduct();
        }

        private void dataGridViewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewProduct.Rows.Count > 0) {

                foreach (DataGridViewRow row in dataGridViewProduct.SelectedRows)
                {
                    productIdTxt.Text = row.Cells[0].Value.ToString();
                    productNameTxt.Text = row.Cells[1].Value.ToString();
                    unityPriceTxt.Text = row.Cells[2].Value.ToString();
                    quantityPriceTxt.Text = row.Cells[3].Value.ToString();
                    dateOfExpTxt.Text = row.Cells[4].Value.ToString();

                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("DELETE FROM Product WHERE productId=@id", conn);
            
            cmd.Parameters.AddWithValue("@id", productIdTxt.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Successfully deleted", "Deletion");
            DisplayProduct();
        }

        private void productIdTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SellingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void manageProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product frm = new Product();
            frm.Show();
        }

        private void manageCustomerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Customers frm = new Customers();
            frm.Show();
        }

        private void sellProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Selling frm = new Selling();
            frm.Show();
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No Reports found yet", "Information");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
        }
    


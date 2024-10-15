namespace SellingApp
{
    partial class Selling
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.unityPriceTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.viewSellBTN = new System.Windows.Forms.Button();
            this.sellBTN = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.totalPriceTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.quantityTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.custCombotxt = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.prodCombotxt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewSelling = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelling)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.unityPriceTxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.viewSellBTN);
            this.groupBox1.Controls.Add(this.sellBTN);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.totalPriceTxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.quantityTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.custCombotxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.prodCombotxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(641, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selling";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // unityPriceTxt
            // 
            this.unityPriceTxt.Location = new System.Drawing.Point(433, 21);
            this.unityPriceTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.unityPriceTxt.Name = "unityPriceTxt";
            this.unityPriceTxt.ReadOnly = true;
            this.unityPriceTxt.Size = new System.Drawing.Size(178, 20);
            this.unityPriceTxt.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(351, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "unityPrice";
            // 
            // viewSellBTN
            // 
            this.viewSellBTN.Location = new System.Drawing.Point(468, 112);
            this.viewSellBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.viewSellBTN.Name = "viewSellBTN";
            this.viewSellBTN.Size = new System.Drawing.Size(85, 24);
            this.viewSellBTN.TabIndex = 12;
            this.viewSellBTN.Text = "View Sells";
            this.viewSellBTN.UseVisualStyleBackColor = true;
            // 
            // sellBTN
            // 
            this.sellBTN.Location = new System.Drawing.Point(363, 112);
            this.sellBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sellBTN.Name = "sellBTN";
            this.sellBTN.Size = new System.Drawing.Size(50, 24);
            this.sellBTN.TabIndex = 11;
            this.sellBTN.Text = "Sell";
            this.sellBTN.UseVisualStyleBackColor = true;
            this.sellBTN.Click += new System.EventHandler(this.sellBTN_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(433, 85);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(103, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // totalPriceTxt
            // 
            this.totalPriceTxt.Enabled = false;
            this.totalPriceTxt.Location = new System.Drawing.Point(433, 52);
            this.totalPriceTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.totalPriceTxt.Name = "totalPriceTxt";
            this.totalPriceTxt.ReadOnly = true;
            this.totalPriceTxt.Size = new System.Drawing.Size(178, 20);
            this.totalPriceTxt.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Transaction Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "totalPrice";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // quantityTxt
            // 
            this.quantityTxt.Location = new System.Drawing.Point(67, 86);
            this.quantityTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.Size = new System.Drawing.Size(231, 20);
            this.quantityTxt.TabIndex = 5;
            this.quantityTxt.TextChanged += new System.EventHandler(this.quantityTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity";
            // 
            // custCombotxt
            // 
            this.custCombotxt.FormattingEnabled = true;
            this.custCombotxt.Location = new System.Drawing.Point(67, 49);
            this.custCombotxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.custCombotxt.Name = "custCombotxt";
            this.custCombotxt.Size = new System.Drawing.Size(231, 21);
            this.custCombotxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer";
            // 
            // prodCombotxt
            // 
            this.prodCombotxt.FormattingEnabled = true;
            this.prodCombotxt.Location = new System.Drawing.Point(67, 16);
            this.prodCombotxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prodCombotxt.Name = "prodCombotxt";
            this.prodCombotxt.Size = new System.Drawing.Size(231, 21);
            this.prodCombotxt.TabIndex = 1;
            this.prodCombotxt.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product";
            // 
            // dataGridViewSelling
            // 
            this.dataGridViewSelling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelling.Location = new System.Drawing.Point(8, 181);
            this.dataGridViewSelling.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewSelling.Name = "dataGridViewSelling";
            this.dataGridViewSelling.RowHeadersWidth = 62;
            this.dataGridViewSelling.RowTemplate.Height = 28;
            this.dataGridViewSelling.Size = new System.Drawing.Size(641, 98);
            this.dataGridViewSelling.TabIndex = 1;
            this.dataGridViewSelling.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Selling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(677, 292);
            this.Controls.Add(this.dataGridViewSelling);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Selling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selling";
            this.Load += new System.EventHandler(this.Selling_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelling)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox prodCombotxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox custCombotxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox quantityTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox totalPriceTxt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button viewSellBTN;
        private System.Windows.Forms.Button sellBTN;
        private System.Windows.Forms.DataGridView dataGridViewSelling;
        private System.Windows.Forms.TextBox unityPriceTxt;
        private System.Windows.Forms.Label label6;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// in oerder 
using Dollar_Computers.Models;

namespace Dollar_Computers
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void Productdatalist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Productdatalist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_comp1004_17DataSet.PRODUCTS' table. You can move, or remove it, as needed.
            this.pRODUCTSTableAdapter.Fill(this._comp1004_17DataSet.PRODUCTS);
            
            var ProductContent = (from product in db.PRODUCTS
                              select product).tolist();

            Productdatalist.DataSource = Productdatalist;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            // Instantiate the next form
            ProductInfoForm ProductInfoForm = new ProductInfoForm();

            // show the next form
            ProductInfoForm.Show();

            // hide this one
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * 	App name = Dollar Computers
    Author's name = Amandeep Kaur
    Student	ID = 200332905
 */

namespace Dollar_Computers
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            // Instantiate the next form
            SelectForm SelectForm = new SelectForm();
            SelectForm.Show();
            this.Hide();
        }

        private void OpenSavedbutton_Click(object sender, EventArgs e)
        {
            // Instantiate the next form
            ProductInfoForm ProductInfoForm = new ProductInfoForm();
            ProductInfoForm.Show();
            this.Hide();
        }
    }
}

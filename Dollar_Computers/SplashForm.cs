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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /// Instantiate the form
            StartForm startForm = new StartForm();
            this.timer1.Enabled = false;
            startForm.Show();
            this.Hide();
        }
    }
}

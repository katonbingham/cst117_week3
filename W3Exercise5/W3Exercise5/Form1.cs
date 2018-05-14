using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W3Exercise5
{
    public partial class ApproximatePI : Form
    {
        public ApproximatePI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double pi = 4.0;
            int terms = Convert.ToInt32(termsBox.Text);
            if (terms < 1)
            {
                MessageBox.Show("Error: Enter a postitive integer!");
            }

            for (int n = 1; n <= terms; n += 4)
            {
                pi = pi - (4.0 / (n + 2.0)) + (4.0 / (n + 4.0));
                resultL.Text = pi.ToString();

            }
            
            resultValueLabel.Text = 
                "Approximate value of pi after "
                + terms.ToString() 
                + " terms";
        }

        private void termsBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

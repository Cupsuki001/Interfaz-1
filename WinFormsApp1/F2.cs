using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class F2 : Form
    {
        public F2()
        {
            InitializeComponent();
        }

        private void F2_Load(object sender, EventArgs e)
        {
            TXBresul.Enabled = false;
        }

        private void BTNcal_Click(object sender, EventArgs e)
        {

            double r, t , tt , tt1;
            try
            {
                r = Convert.ToDouble(TXBrad.Text);
                t = Convert.ToDouble(TXBtiem.Text);

                if(r <= 0 || r >= 0) 
                {
                    MessageBox.Show("No pueden ser negativos o cero");
                }
                else 
                {
                    tt = (2 * 3.1416) * r;
                    tt1 = tt / t;
                    TXBresul.Text = tt1.ToString();
                }
            }
            catch (Exception ex) 
            {
              MessageBox.Show("No puede estar en blanco");
            }
        }

        private void BTNlimp_Click(object sender, EventArgs e)
        {
            TXBrad.Text = "";
            TXBresul.Text = "";
            TXBtiem.Text = "";
        }

        private void BTNsalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TXBrad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar)) 
            {
                  
              e.Handled = true;
                 
            }
           
        }

        private void TXBtiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {

                e.Handled = true;

            }
        }
    }
}

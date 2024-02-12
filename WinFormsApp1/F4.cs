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
    public partial class F4 : Form
    {
        public F4()
        {
            InitializeComponent();
        }

        private void F4_Load(object sender, EventArgs e)
        {
            TXBresul.Enabled = false;
        }

        private void BTNcal_Click(object sender, EventArgs e)
        {
            int p , div = 1 , cont =0 ;
            try 
            {
              p = Convert.ToInt32(MSKprimo.Text);

                while(div <= p) 
                {
                  if (p % div == 0) 
                  {
                    cont ++;
                  }
                  div++;
                }
                
                if (cont == 2) 
                {
                    TXBresul.Text = "N.primo";
                }
                else 
                {
                    TXBresul.Text = "No es un N.primo";
                }

            }
            catch (Exception ex) 
            {
              MessageBox.Show("No puede estar en blanco");
            }
        }

        private void BTNlimp_Click(object sender, EventArgs e)
        {
            TXBresul.Text = "";
            MSKprimo.Text = "";
        }

        private void BTNsal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

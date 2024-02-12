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
    public partial class F1 : Form
    {
        public F1()
        {
            InitializeComponent();
        }

        private void F1_Load(object sender, EventArgs e)
        {
            TXBresul.Enabled = false;
            TXBestado.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n, m , tt;
            try 
            {
              n = Convert.ToDouble(MSKnota1.Text);
              m = Convert.ToDouble(MSKnota2.Text);

                if(n > 50 || m > 50) 
                {
                    MessageBox.Show("No puede ser mayor que 50");
                }
                else 
                {
                    tt = n + m;
                    if(tt >= 60) 
                    {
                       TXBresul.Text = tt.ToString();
                        TXBestado.Text = "Aprobado";
                    }
                    else 
                    {
                        TXBresul.Text = tt.ToString();
                        TXBestado.Text = "Reprobado";
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No puede estar en blenco");
            }
        }

        private void BTNlimp_Click(object sender, EventArgs e)
        {
            TXBestado.Text = "";
            TXBresul.Text = "";
            MSKnota1.Text = "";
            MSKnota2.Text = "";
        }

        private void BTNsalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

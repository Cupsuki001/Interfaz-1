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
    public partial class Practica2 : Form
    {
        public Practica2()
        {
            InitializeComponent();
        }

        private void Practica2_Load(object sender, EventArgs e)
        {
            TXBtotal.Enabled = false;
        }

        private void BTNcalcular_Click(object sender, EventArgs e)
        {
            double v , vr , vt;

            try 
            {
               v = Convert.ToDouble(MSKvalor.Text);

                if(v == 0)
                {
                    MessageBox.Show("No puede ser 0");
                }
                else 
                {

                    if (RDvehiculo.Checked == true)
                    {
                        vr = v / 5;
                        vt = (v - vr) / 5;
                        TXBtotal.Text = vt.ToString();
                    }
                    else if (RDindustrial.Checked == true)
                    {
                        vr = v / 2;
                        vt = (v - vr) / 2;
                        TXBtotal.Text = vt.ToString();
                    }
                    else
                    {
                        vr = v / 2;
                        vt = (v - vr) / 2;
                        TXBtotal.Text = vt.ToString();
                    }
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show("No puede estar en blanco");
            }
        }

        private void BTNlimp_Click(object sender, EventArgs e)
        {
            TXBtotal.Text = "";
            MSKvalor.Text = "";
        }

        private void BTNsalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

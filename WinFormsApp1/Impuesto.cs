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
    public partial class Impuesto : Form
    {
        public Impuesto()
        {
            InitializeComponent();
        }

        private void Impuesto_Load(object sender, EventArgs e)
        {
            TXBdesc.Enabled = false;
            TXBtot.Enabled = false;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sub, desc, tt , tt2;
           

            try 
            {
                sub = Convert.ToDouble(MSKsubtt.Text);
                if (sub == 0)
                {
                    MessageBox.Show("INGRESE UN VALOR, NO PUEDE SER 0");
                }
                else
                {
                    if (RDefectivo.Checked == true)
                    {
                        desc = sub * 0.05;
                        tt2 = sub - desc;
                        tt = tt2 * 1.15;
                        TXBdesc.Text = desc.ToString();
                        TXBtot.Text = tt.ToString();
                    }
                    else
                    {
                        tt = sub * 1.15;
                        TXBtot.Text = tt.ToString();
                        TXBdesc.Text = "";
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No puede ser nulo", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

           
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TXBdesc.Text = "";
            TXBtot.Text = "";
            MSKsubtt.Text = "";
        }

        private void BTNsalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

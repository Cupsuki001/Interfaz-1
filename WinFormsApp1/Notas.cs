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
    public partial class Notas : Form
    {
        public Notas()
        {
            InitializeComponent();
        }

        private void Notas_Load(object sender, EventArgs e)
        {
            TXBresul.Enabled = false;
        }

        private void BTNcalcular_Click(object sender, EventArgs e)
        {
            double n1 , n2 , n3 ,n4 , tt;
            n1 = double.Parse(MSKn1.Text);
            n2 = double.Parse(MSKn2.Text);
            n3 = double.Parse(MSKn3.Text);
            n4 = double.Parse(MSKn4.Text);


            
            
            
                if ((n1 < 0 || n1 > 25) || (n2 < 0 || n2 > 25) || (n3 < 0 || n3 > 25) || (n4 < 0 || n4 > 25))
                {
                    MessageBox.Show("NO Pude ser menor que 0 o mayor a 25");
                }
                else
                {
                    tt = n1 + n2 + n3 + n4;
                    TXBresul.Text = tt.ToString();

                    if (tt >= 60)
                    {
                        MessageBox.Show("Te la comes , [Aprobado]");
                    }
                    else
                    {
                        MessageBox.Show("No hay play , [Reprobado]");
                    }
                }
            

            

            
        }

        private void BTNlimp_Click(object sender, EventArgs e)
        {
            MSKn1.Text = "";
            MSKn2.Text = "";
            MSKn3.Text = "";
            MSKn4.Text = "";
            TXBresul.Text = "";
        }

        private void BTNsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

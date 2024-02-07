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
    public partial class Practica3 : Form
    {
        public Practica3()
        {
            InitializeComponent();
        }

        private void Practica3_Load(object sender, EventArgs e)
        {
            TXBantigue.Enabled = false;
            TXBAntporc.Enabled = false;
            TXBbruto.Enabled = false;
            TXBir.Enabled = false;
            TXBlaboral.Enabled = false;
            TXBneto.Enabled = false;
        }

        private void BTNcalcular_Click(object sender, EventArgs e)
        {
            double sal , antp , brut , laboral , ir , ingn , antp1 , inss , opebrut , opebrut1 ;
            int año , ant ;
            try 
            {
                sal= Convert.ToInt32(MSKsalario.Text);
                año= Convert.ToInt32(MSKaño.Text);

                if (sal == 0 || año==0)
                {
                    MessageBox.Show("No puede ser 0");
                }
                else
                {
                    if (sal <= 5000 || sal >350000 || año < 1980 || año > 2024 ) 
                    {
                        MessageBox.Show("Inngrese los datos correctamente :)");
                    }
                    else 
                    {
                        ant = 2024 - año;
                        antp1 = 2 * ant + 1;
                        antp = antp1 / 100;
                        brut = (ant * sal) + sal;
                        laboral = brut * 0.07;
                        opebrut = brut - laboral;
                        ir = opebrut * 0.1;
                        opebrut1 = opebrut - ir;
                        ingn = opebrut1;

                        TXBantigue.Text = ant.ToString();
                        TXBAntporc.Text = antp.ToString();
                        TXBbruto.Text = brut.ToString();
                        TXBlaboral.Text = laboral.ToString();
                        TXBir.Text = ir.ToString();
                        TXBneto.Text = ingn.ToString();
                    }

                    
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("No pueden estar en blanco");
            }
        }

        private void BTNlimpr_Click(object sender, EventArgs e)
        {
            TXBantigue.Text = "";
            TXBAntporc.Text = "";
            TXBbruto.Text = "";
            TXBir.Text = "";
            TXBlaboral.Text = "";
            TXBneto.Text = "";
            MSKaño.Text = "";
            MSKsalario.Text = "";
        }

        private void BTNsalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

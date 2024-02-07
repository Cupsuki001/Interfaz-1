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
    public partial class Practica1 : Form
    {
        public Practica1()
        {
            InitializeComponent();
        }

        private void Practica1_Load(object sender, EventArgs e)
        {
            TXBgramos.Enabled = false;
            TXBlibras.Enabled = false;
        }

        private void BTNcalcular_Click(object sender, EventArgs e)
        {

            double kg , tt;
            try 
            {
                kg = Convert.ToDouble(MSKkg.Text);
                if (kg == 0 || cmbOPCION.Text == "") 
                {
                    MessageBox.Show("Verifique los datos");
                }
                else 
                {
                    if (cmbOPCION.SelectedItem.Equals("Libras"))
                    {
                        tt = kg * 2.20462;
                        TXBlibras.Text = tt.ToString();
                        TXBgramos.Text= "";
                    }
                    else 
                    {
                        tt = kg * 1000;
                        TXBgramos.Text = tt.ToString();
                        TXBlibras.Text = "";
                    }
                }
              
            }
            catch (Exception ex) 
            {
                MessageBox.Show("No puede estar en blanco");
                MSKkg.Focus();
            }
        }

        private void BTNlimpiar_Click(object sender, EventArgs e)
        {
            TXBgramos.Text = "";
            TXBlibras.Text = "";
            cmbOPCION.Text = "";
            MSKkg.Text = "";
        }

        private void BTNsalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

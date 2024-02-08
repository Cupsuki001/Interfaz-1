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
    public partial class Sesion : Form
    {
        int contaInco = 3, intentos = 0;
        public Sesion()
        {
            InitializeComponent();
        }


        public void fn_barra()
        {
            if (Barra.Value < 100)
            {
                Barra.Value += 1;

                LBLporc.Text = Barra.Value.ToString() + "%";
            }
            if (Barra.Value == Barra.Maximum)
            {
                timer1.Enabled = false;
                timer1.Stop();
                new MDI().Show();
                this.Hide();
            }
        }

        public void congelar() 
        {
          intentos++;

            if(intentos == 1) 
            {
                MessageBox.Show("Fue bloqueado, espere 30 segundos");
                Thread.Sleep(30000);
                TXBnom.Enabled = true;
                TXBcontra.Enabled = true;
                contaInco = 3;
            }
            if (intentos == 2)
            {
                MessageBox.Show("Fue bloqueado, espere 40 segundos");
                Thread.Sleep(40000);
                TXBnom.Enabled = true;
                TXBcontra.Enabled = true;
                contaInco = 3;
            }
            if (intentos > 2)
            {
                MessageBox.Show("Fue bloqueado 1 minuto");
                Thread.Sleep(60000);
                TXBnom.Enabled = true;
                TXBcontra.Enabled = true;
                contaInco = 3;
            }
        }
        private void BTNconectar_Click(object sender, EventArgs e)
        {
            if (TXBnom.Text == "JJ" && TXBcontra.Text == "mondongo") 
            {
              timer1.Start();
                timer1_Tick(sender , e);
            }
            else 
            {
               contaInco--;

                MessageBox.Show("Contraseña o usuario incorrecto");
            }
            if(contaInco == 0) 
            {
              TXBnom.Enabled = false;
                TXBcontra.Enabled=false;

                congelar();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fn_barra();
            timer1.Enabled = true;

            if(Barra.Value == Barra.Maximum) 
            {
              timer1.Enabled = false;
                timer1.Stop();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            TXBcontra.Clear();
            TXBnom.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Sesion_Load(object sender, EventArgs e)
        {
           
            
        }
    }
}

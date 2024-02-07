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
    public partial class MDI : Form
    {
        Form1 f = new Form1();
        Notas n = new Notas();
        Impuesto i = new Impuesto();
        Consultorio c = new Consultorio();
        Practica1 p = new Practica1();
        Practica2 p2 = new Practica2();
        Practica3 p3 = new Practica3();
        public MDI()
        {
            InitializeComponent();
        }

        private void iNSSLaboralToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            f.MdiParent = this;
            f.Show();
        }

        private void sumaNotasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            n.MdiParent = this;
            n.Show();
        }

        private void compraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            i.MdiParent = this;
            i.Show();
        }

        private void farmaciaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            c.MdiParent = this;
            c.Show();
        }

        private void conversionDeKgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.MdiParent = this;
            p.Show();
        }

        private void depreciacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p2.MdiParent = this;
            p2.Show();
        }

        private void datosDelEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p3.MdiParent = this;
            p3.Show();
        }
    }
}

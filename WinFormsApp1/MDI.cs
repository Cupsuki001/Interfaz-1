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
        public MDI()
        {
            InitializeComponent();
        }

        private void iNSSLaboralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f.MdiParent = this;
            f.Show();
        }

        private void sumaNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n.MdiParent = this;
            n.Show();
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            i.MdiParent = this;
            i.Show();
        }
    }
}

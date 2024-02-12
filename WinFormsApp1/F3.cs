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
    public partial class F3 : Form
    {
        public F3()
        {
            InitializeComponent();
        }

        private void F3_Load(object sender, EventArgs e)
        {
            TXBresul.Enabled = false;
        }

        private void btnCALCULAR_Click(object sender, EventArgs e)
        {
            int n1 ,n2 ,n3 ,n4  , media;
            try 
            {
              n1 = Convert.ToInt32(MSK1.Text);
                n2 = Convert.ToInt32(MSK2.Text);
                n3 = Convert.ToInt32(MSK3.Text);
                n4 = Convert.ToInt32(MSK4.Text);

                media = (n1 + n2 + n3 + n4) / 4;
                TXBresul.Text = media.ToString();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("No puede estar en blanco");
            }
        }

        private void btnLIMP_Click(object sender, EventArgs e)
        {
            MSK1.Text = "";
            MSK2.Text = "";
            MSK3.Text = "";
            MSK4.Text = "";
            TXBresul.Text = "";
        }

        private void BTNsalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TXBlaboral.Enabled = false;
            TXBpatronal.Enabled = false;
        }

        private void BTNcalcular_Click(object sender, EventArgs e)
        {
            double ing, il , ip , ing2;

            ing = double.Parse(MSKingresos.Text);


            
            
                if (ing <= 0 || ing >= 500000)
                {
                    MessageBox.Show("El ingreso no puede ser myor que 500,000 0 menor que 0");
                    MSKingresos.Text = "";
                }
                else
                {
                    if (CMBtipo.Text == "") 
                    {
                    MessageBox.Show("No puede estar vacio");
                    }
                    else if (CMBtipo.SelectedItem.Equals("Laboral")) 
                    {
                        il = ing * 0.07;
                        TXBlaboral.Text = il.ToString();
                    }
                    else 
                    {
                        ip = ing * .22;
                        TXBpatronal.Text = ip.ToString();
                    }
                }
            
           
        }

        private void BTNlimp_Click(object sender, EventArgs e)
        {
            MSKingresos.Text = "";
            TXBlaboral.Text = "";
            TXBpatronal.Text = "";
            CMBtipo.Text =  "";
            MSKingresos.Focus();
        }

        private void BTNsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
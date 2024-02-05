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
        }

        private void BTNcalcular_Click(object sender, EventArgs e)
        {
            double ing, il;

            ing = double.Parse(MSKingresos.Text);

            if (ing <= 0 || ing >= 500000) 
            {
                MessageBox.Show("El ingreso no puede ser myor que 500,000 0 menor que 0");
                MSKingresos.Text = "";
            }
            else 
            {
              
                il = ing * 0.07;
                TXBlaboral.Text = il.ToString();
            }
        }

        private void BTNlimp_Click(object sender, EventArgs e)
        {
            MSKingresos.Text = "";
            TXBlaboral.Text = "";
            MSKingresos.Focus();
        }

        private void BTNsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
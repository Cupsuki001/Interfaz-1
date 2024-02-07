using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Consultorio : Form
    {
        public Consultorio()
        {
            InitializeComponent();
        }

        private void Consultorio_Load(object sender, EventArgs e)
        {
            MessageBox.Show("BIENVENIDO A CONSULTORIO ONLINE");
        }

        private void BTNanalizar_Click(object sender, EventArgs e)
        {

            if (CHKmuscular.Checked == false && CHKnauseas.Checked == false && CHKtos.Checked == false) 
            {
                MessageBox.Show("Ingrese un sintoma");
                richTextBox1.Text = "";
            }
            else 
            {
                if (CHKmuscular.Checked == true && CHKnauseas.Checked == true && CHKtos.Checked== true)
                {
                    richTextBox1.Text = "Posible Enfermedad: Covid 19 " + "\n" + "\n"

                        + "es una enfermedad infecciosa causada por el virus SARS-CoV-2. " + "\n" + "\n"

                            + "Recomendaciones: " + "\n"
                        + "Cubrir Nariz con tapaboca , lavarse las manos y vacunarse";
                }
                else if (CHKmuscular.Checked == true && CHKnauseas.Checked == true)
                {
                    richTextBox1.Text = "Posible Enfermedad: Dengue " + "\n" + "\n"

                        + "Se puede contagiar si le pica un mosquito infectado" + "\n" + "\n"

                        + "Enfermedades que puede dar Nauseas y Dolor de cuerpo: "
                          + "Gastroenteritis" + "\n" + "\n"

                            + "Recomendaciones: " + "\n"
                        + "Bber Agua carbonatada y jugos de fruta";
                 }
                 else if (CHKmuscular.Checked == true && CHKtos.Checked == true)
                {
                    richTextBox1.Text = "Posible Enfermedad: Resfriado " + "\n" + "\n"

                        + "El resfriado común es una enfermedad que afecta a la nariz y la garganta. " + "\n" + "\n"

                        + "Enfermedades que puede dar Dolor y tos: "
                          + "fibriomialgia , dengue" + "\n" + "\n"

                            + "Recomendaciones: " + "\n"
                        + "Descansar, mantenerse Hidratado";
                }
                 else if (CHKnauseas.Checked == true && CHKtos.Checked == true)
                {
                    richTextBox1.Text = "Posible Enfermedad: Tos paroxistica " + "\n" + "\n"

                        + " provoca ataques intermitentes de tos violenta e incontrolable. Una tos paroxística es agotadora y causa dolor. . " + "\n" + "\n"

                        + "Enfermedades que puede dar Dolor y tos: "
                          + "Pertusis" + "\n" + "\n"

                            + "Recomendaciones: " + "\n"
                        + "Usar Humidificador para la tos";
                }
                else if (CHKmuscular.Checked == true)
                     {
                    richTextBox1.Text = "Posible Enfermedad: Fiebre " + "\n" + "\n" +
                                        "La fiebre es el aumento temporal en la temperatura del " +
                                        "cuerpo en respuesta a alguna enfermedad o padecimiento." + "\n" + "\n" +

                                        "Otras enfermedades que puede causar Dolor muscular: " + "\n" +
                                        "Influenza , Polio y Neumonia" + "\n" + "\n" +

                                        "Medicamentos: " + "\n"
                                        + "Paracetamol , Ibuprofeno , Acetaminofen";

                     }
                else if (CHKnauseas.Checked == true)
                {
                    richTextBox1.Text = "Posible Enfermedad: Infeccion Estomacal " + "\n" + "\n"

                        + "puede ser causada por una infección viral, bacteriana o parasitaria." + "\n" + "\n"

                        + "Enfermedades que puede dar Infeccion Intestinal: " +
                                        "Rotavirus , Migraña y Anafilaxia" + "\n" + "\n"

                        + "Medicamentos: " + "\n"
                        + "Olanzapina y Dolasetron";
                }
                else if (CHKtos.Checked == true)
                {
                    richTextBox1.Text = "Posible Enfermedad: Bronquitis Aguda " + "\n" + "\n"

                        + "ocurre cuando las vías respiratorias en el pulmón se inflaman y producen mucosidad en los pulmones." + "\n" + "\n"

                        + "Enfermedades que puede dar Bronquitis Aguda: "
                          + "Asma , Sinusitis y Alergias" + "\n" + "\n"

                        + "Medicamentos: " + "\n"
                        + "Dextrometorfano , Antitusigeno";
                }
               
            }

        }

        private void BTNcancel_Click(object sender, EventArgs e)
        {
            CHKmuscular.Checked = false;
            CHKnauseas.Checked = false;
            CHKtos.Checked = false;
            richTextBox1.Text = "";
        }

        private void BTNsalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

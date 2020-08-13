using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormPrincipal : Form
    {
        FormRegEncuesta formRegEncuesta = new FormRegEncuesta();
        Consulta controlador = new Consulta();
        FormListadoAlumnos Alumnos = new FormListadoAlumnos();

        public FormPrincipal()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;

            Alumnos.Show();
            Alumnos.StartPosition = FormStartPosition.WindowsDefaultLocation;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            DialogResult dr;
            do
            {
                
                form2.Clear();
                dr = form2.ShowDialog();
                if (dr == DialogResult.OK)
                { 

                }
            } while (dr == DialogResult.OK);
            */

            DialogResult dr = DialogResult.OK;
            while(dr== DialogResult.OK)
            {
                formRegEncuesta.Clear();
                dr = formRegEncuesta.ShowDialog();
                formRegEncuesta.StartPosition = FormStartPosition.CenterScreen;

                if (dr == DialogResult.OK)
                {
                    Alumno alumno=controlador.Agregar(
                            formRegEncuesta.textBox1.Text, //nombre
                            Convert.ToInt16(formRegEncuesta.numericUpDown1.Value),
                            Convert.ToString(formRegEncuesta.comboBox1.SelectedItem),//carrera
                            formRegEncuesta.respuestas[0], //respuesta1
                            formRegEncuesta.respuestas[1], //respuesta2
                            formRegEncuesta.respuestas[2], //respuesta3
                            formRegEncuesta.respuestas[3]);

                    Alumnos.listBox1.Items.Add(alumno.Nombre + " - " + alumno.Resultado);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //controlador.Procesar();

            listBox1.Items.Clear();

            listBox1.Items.Add("Mayor puntaje:");
            listBox1.Items.Add(controlador.MayorPuntaje.Nombre);

            listBox1.Items.Add("Menor puntaje:");
            listBox1.Items.Add(controlador.MenorPuntaje.Nombre);

            string mayores10 = String.Format("Encuestas Mayores a 10: {0:f2}", controlador.Mayores10);
            listBox1.Items.Add(mayores10);

            string menores0 = String.Format("Encuestas Menores a 0: {0:f2}", controlador.Menores0);
            listBox1.Items.Add(menores0);

            string promedio = String.Format("El promedio es: {0:f2}", controlador.Promedio);
            listBox1.Items.Add(promedio);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 listadoControl = new Form3();
            listadoControl.Show();
            // listadoControl.Dispose();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // MessageBox.Show(System.Globalization.CultureInfo.CurrentCulture.ToString());
        }
    }
}

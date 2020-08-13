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
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();
        Consulta controlador = new Consulta();

        public Form1()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
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
                form2.Clear();
                dr = form2.ShowDialog();
                form2.StartPosition = FormStartPosition.CenterScreen;

                if (dr == DialogResult.OK)
                {
                    controlador.Agregar(
                            form2.textBox1.Text, //nombre
                            Convert.ToInt16(form2.numericUpDown1.Value),
                            Convert.ToString(form2.comboBox1.SelectedItem),//carrera
                            form2.respuestas[0], //respuesta1
                            form2.respuestas[1], //respuesta2
                            form2.respuestas[2], //respuesta3
                            form2.respuestas[3]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controlador.Procesar();

            listBox1.Items.Clear();

            listBox1.Items.Add("Mayor puntaje:");
            listBox1.Items.Add(controlador.MayorPuntaje.Nombre);

            listBox1.Items.Add("Menor puntaje:");
            listBox1.Items.Add(controlador.MenorPuntaje.Nombre);
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
    }
}

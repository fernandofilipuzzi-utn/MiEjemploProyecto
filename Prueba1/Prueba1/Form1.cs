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
        Encuesta encuesta = new Encuesta();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dialogo conf = new Dialogo();

            //inicialización y limpieza
            conf.checkBox1.Checked = false;

            while (conf.ShowDialog() == DialogResult.OK)
            {
                

                //procesa cargado/configurado
              //  encuesta.Registrar(conf.c.Nombre,1,1,1);

                if (conf.checkBox1.Checked == true)
                    Text = "true";
                else
                    Text = "false";

            }

            conf.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

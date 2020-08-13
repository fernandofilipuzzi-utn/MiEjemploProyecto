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
    public partial class FormRegEncuesta : Form
    {

        public char [] respuestas =new char[4];

        public FormRegEncuesta()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("TSP");
            comboBox1.Items.Add("TSIA");
            comboBox1.Items.Add("TSEVMA");

            listBox1.Items.Clear();
            listBox1.Items.Add("Pregunta 1");
            listBox1.Items.Add("Pregunta 2");
            listBox1.Items.Add("Pregunta 3");
            listBox1.Items.Add("Pregunta 4");

            groupBox1.Enabled = false;
           // MessageBox.Show("prueba");
        }

        public void Clear()
        {
            listBox1.SelectedIndex = -1;
            textBox1.Clear();
            
            comboBox1.SelectedIndex = -1;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("prueba2");

            
            if (listBox1.SelectedIndex == -1)
            {
                groupBox1.Enabled = false;
                groupBox1.Text = "Seleccione una pregunta!";

                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
            }
            else if (listBox1.SelectedIndex < 4)
            {
                groupBox1.Enabled = true;
                setRadioButtons(respuestas[listBox1.SelectedIndex]);
                groupBox1.Text = (string)listBox1.Items[listBox1.SelectedIndex];
            }
        }

        private char getRadioButtons()
        {
            if (radioButton1.Checked == true)
                return 'A';
            else if (radioButton2.Checked == true)
                return 'B';
            else if (radioButton3.Checked == true)
                return 'C';
            return ' ';
        }
        private void setRadioButtons(char resp)
        {
            switch(resp)
            {
                case 'A':
                    radioButton1.Checked = true;
                    break;
                case 'B':
                    radioButton2.Checked = true;
                    break;
                case 'C':
                    radioButton3.Checked = true;
                    break;
                default:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    break;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (listBox1.SelectedIndex == -1)
            {
            }
            else if (listBox1.SelectedIndex < 4)
            {
                respuestas[listBox1.SelectedIndex] = getRadioButtons();
            }

           // listBox1.Focus();
        }



        private void FormRegEncuesta_KeyDown(object sender, KeyEventArgs e)
        {
            /*
            if (Keys.Enter == e.KeyCode)
            {
                //SendKeys.Send("{TAB}");
                //e.Handled = true;
                //SelectNextControl(ActiveControl, true, true, true, true);
            }
            */
            

            

        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Right == e.KeyCode)
            {
                radioButton1.Focus();
                e.Handled = true;
            }
        }

        private void radioButton1_KeyDown(object sender, KeyEventArgs e)
        {

            if (Keys.Left == e.KeyCode)
            {
                listBox1.Focus();
                e.Handled = true;
            }
        }

    }
}

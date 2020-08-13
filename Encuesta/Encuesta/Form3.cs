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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 8;

            //ejemplo simple
            string[] linea = new string[] { "juan", "1", "TSP", "A", "C", "B", "A", ""};
            linea[7] = (Evaluar(linea[3]) + Evaluar(linea[4]) + Evaluar(linea[5]) + Evaluar(linea[6])).ToString();
            dataGridView1.Rows.Add(linea);

            linea = new string[] { "martín", "2", "TSP", "C", "C", "C", "A", "" };
            linea[7] = (Evaluar(linea[3]) + Evaluar(linea[4]) + Evaluar(linea[5]) + Evaluar(linea[6])).ToString();
            dataGridView1.Rows.Add(linea);

            linea = new string[] { "ana", "2", "TSP", "A", "A", "C", "A", "" };
            linea[7] = (Evaluar(linea[3]) + Evaluar(linea[4]) + Evaluar(linea[5]) + Evaluar(linea[6])).ToString();
            dataGridView1.Rows.Add(linea);

            linea = new string[] { "bernardo", "1", "TSP", "B", "B", "C", "B", "" };
            linea[7] = (Evaluar(linea[3]) + Evaluar(linea[4]) + Evaluar(linea[5]) + Evaluar(linea[6])).ToString();
            dataGridView1.Rows.Add(linea);

            linea = new string[] { "marta", "1", "TSP", "A", "A", "A", "A", "" };
            linea[7] = (Evaluar(linea[3]) + Evaluar(linea[4]) + Evaluar(linea[5]) + Evaluar(linea[6])).ToString();
            dataGridView1.Rows.Add(linea);
        }

        private int Evaluar(string r)
        {
            switch (r)
            {
                case "A":
                    return 10;
                case "B":
                    return 5;
                case "C":
                    return 3;
            }
            return 0;
        }
    }
}

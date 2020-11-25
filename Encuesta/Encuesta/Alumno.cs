using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    //comentario1
    class Alumno
    {
        private string nombre;
        public string Nombre{get{ return nombre;}}

        private int año;
        public int Año{get{ return año;}}

        private int resultado;
        public int Resultado { get { return resultado; } }

        public Alumno(string nombre, int año, string carrera, 
                        char r1, char r2, char r3, char r4)
        {
            this.nombre=nombre;
            this.año=año;

            resultado = Evaluar(r1) + Evaluar(r2) + Evaluar(r3) +Evaluar(r4);
        }
        
        private int Evaluar(char r)
        {
            switch (r)
            { 
                case 'A':
                    return 10;
                case 'B':
                    return 5;
                case 'C':
                    return -3;
            }
            return 0;
        }
    }
}
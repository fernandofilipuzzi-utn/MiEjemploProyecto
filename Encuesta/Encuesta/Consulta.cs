using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Consulta
    {
        Alumno mayorPuntaje;
        public Alumno MayorPuntaje { get { return mayorPuntaje; } }

        Alumno menorPuntaje;
        public Alumno MenorPuntaje { get { return menorPuntaje; } }


        private Alumno [] encuestas=new Alumno[100];
        int cnt=0;

        public Consulta()
        { 
        }

        public void Agregar(string nombre, int año, string carrera, 
                            char r1, char r2, char r3, char r4)
        {
            encuestas[cnt]=new Alumno(nombre, año, carrera, r1, r2, r3, r4);
            cnt++;
        }

        public void Procesar()
        {
            for (int i = 0; i < cnt; i++)
            {
                if (i == 0)
                {
                    menorPuntaje = encuestas[i];
                    mayorPuntaje = encuestas[i];
                }
                else
                {
                    if(encuestas[i].Resultado < menorPuntaje.Resultado)
                    {
                        menorPuntaje = encuestas[i];
                    }
                    if(encuestas[i].Resultado > mayorPuntaje.Resultado)
                    {
                        mayorPuntaje = encuestas[i];
                    }
                }
            }
        }
    }
}

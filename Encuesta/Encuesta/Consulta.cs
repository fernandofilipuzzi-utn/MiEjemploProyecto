using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Consulta
    {
        Alumno[] encuestas = new Alumno[100];
        int cnt = 0;

        
        public Alumno MayorPuntaje 
        { 
            get 
            {
                Alumno mayorPuntaje=null;
                for (int i = 0; i < cnt; i++)
                {
                   if (i == 0)
                    {
                        mayorPuntaje = encuestas[i];
                    }
                    else
                    {
                      
                        if (encuestas[i].Resultado > mayorPuntaje.Resultado)
                        {
                            mayorPuntaje = encuestas[i];
                        }
                    }
                }
                return mayorPuntaje;
            } 
        }

       
        public Alumno MenorPuntaje 
        {
            get 
            {
                Alumno menorPuntaje = null;

                for (int i = 0; i < cnt; i++)
                {
                    if (i == 0)
                    {
                        menorPuntaje = encuestas[i];
                    }
                    else
                    {
                        if (encuestas[i].Resultado < menorPuntaje.Resultado)
                        {
                            menorPuntaje = encuestas[i];
                        }
                    }
                }
                return menorPuntaje;
            } 
        }
              
        public Double Promedio 
        { 
            get 
            {
                double promedio = 0;

                int acPunt = 0;
                
                for (int i = 0; i < cnt; i++)
                {
                    acPunt += encuestas[i].Resultado;
                }

                promedio = acPunt * 1.0 / cnt;
                return promedio;
            } 
        }

        
        public int Mayores10 
        { 
            get 
            {
                int mayores10 = 0;

                for (int i = 0; i < cnt; i++)
                {
                    if (encuestas[i].Resultado > 10)
                        mayores10++;
                }

                return mayores10;
            } 
        }
        
        public int Menores0 
        { 
            get 
            {
                int menores0 = 0;

                for (int i = 0; i < cnt; i++)
                {
                    if (encuestas[i].Resultado < 0)
                        menores0++;
                }

                return menores0;
            } 
        }

        public Consulta()
        { 
        }

        public Alumno Agregar(string nombre, int año, string carrera, 
                            char r1, char r2, char r3, char r4)
        {
            encuestas[cnt]=new Alumno(nombre, año, carrera, r1, r2, r3, r4);
            return encuestas[cnt++];
        }

        /*comentar respecto a centralizar todo.
         * 
         * 
         * 
        public void Procesar()
        {
            int acPunt = 0;
            mayor10=0;
            menor0=0;

            for (int i = 0; i < cnt; i++)
            {
                acPunt += encuestas[i].Resultado;

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

                if (encuestas[i].Resultado > 10)
                    mayor10++;

                if (encuestas[i].Resultado < 0)
                    menor0++;
            }

            promedio = acPunt * 1.0 / cnt;
        }
        */
    }
}

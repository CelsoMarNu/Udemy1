using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareas
{
    internal class Tarea_6
    {
        #region Funciones
        #endregion

        #region Ejercicios

        static void promedioCalifiaciones()
        {

        }
        static void menorCalificacion()
        {

        }

        static void mayorCalificacion()
        {

        }



        #endregion
        static void main(string[] args)
        {
            byte i, j, numAlumnos, salones;
            double sumaCalif = 0, sumaCalifSalon = 0, promedio = 0, califMin = 10, califMax = 0;

            Console.WriteLine("Defina la cantidad de salones");
            salones = Convert.ToByte(Console.ReadLine());

            double[][] calificaciones = new double[salones][];

            Console.WriteLine();

            for (i = 0; i < salones; i++)
            {
                Console.WriteLine($"Defina la cantidad de alumnos por del salon {i}");
                numAlumnos = Convert.ToByte(Console.ReadLine());

                calificaciones[i] = new double[numAlumnos];
            }
            Console.WriteLine();

            double[] califMinSalon = new double[salones];
            double[] califMaxSalon = new double[salones];
            double[] PromedioSalon = new double[salones];

            for (i = 0; i < salones; i++)
            {
                sumaCalifSalon = 0;
                califMax = 0;
                califMin = 10;
                Console.WriteLine($"Salon {i}");
                for (j = 0; j < salones; j++)
                {
                    Console.WriteLine($"Ingrese la calificacion del alumno {j}");
                    calificaciones[i][j] = Convert.ToDouble(Console.ReadLine());

                    sumaCalif += calificaciones[i][j];

                    sumaCalifSalon += calificaciones[i][j];

                    if (calificaciones[i][j] < califMin)
                    {
                        califMin = calificaciones[i][j];
                    }
                    califMinSalon[i] = califMin;

                    if (calificaciones[i][j] > califMax)
                    {
                        califMax = calificaciones[i][j];
                    }                    
                    califMaxSalon[i] = califMax;                   
                }
                PromedioSalon[i] = sumaCalifSalon / calificaciones[i].Length;
            }

            for (i = 0; i < 0; i++)
            { 
                for(j = 0;j < salones; j++) 
                {

                    if (calificaciones[i][j] < califMin)
                    {
                        califMin = calificaciones[i][j];
                    }
                    if (calificaciones[i][j] > califMax)
                    {
                        califMax = calificaciones[i][j];
                    }
                }
            } 
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("¡DATOS DE LA ESCUELA!");
            for (i = 0; i < salones; i++)
            {
                Console.WriteLine("Salón {0}", i);
                for (j = 0; j < calificaciones[i].Length; j++)
                {
                    Console.WriteLine("El alumno {0}, tiene {1} de calificación", j, calificaciones[i][j]);
                }
            }

            for (i = 0; i < salones; i++)
            {
                Console.WriteLine("INFORMACIÓN DEL SALÓN {0}: ", i);
                Console.WriteLine("Calificación máxima: {0}, calificación mínima: {1}", califMaxSalon[i], califMinSalon[i]);
                Console.WriteLine("Promedio: {0}", PromedioSalon[i]);
            }

            Console.WriteLine();
           
            Console.WriteLine("El promedio de toda la escuela es: {0}", promedio);
            Console.WriteLine("La calificación más baja de la escuela es: {0}", califMin);
            Console.WriteLine("La calificación más alta de la escuela es: {0}", califMax);

        }
    }
}

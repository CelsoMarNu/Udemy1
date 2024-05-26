using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareas
{
    internal class Tarea_4
    {
        #region Funciones

        #endregion

        #region Ejericios
        static void Ejercicio1()
        {
            bool ciclo = true;
            while (ciclo)
            {
                //Hacer un programa que calcule la potencia, ya sea negativa o positiva de cualquier exponente.
                //Variables
                double valor = new double();
                double potencia = new double();
                double resultado = new double();

                Console.WriteLine("Cargue un valor");
                valor = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Cargue una potencia");
                potencia = Convert.ToDouble(Console.ReadLine());

                resultado = Math.Pow(valor, potencia);

                Console.WriteLine($"La potencia de {valor} elevado a {potencia} es = {resultado}");
                Console.ReadLine();
            }
        }
        static void Ejercicio2()
        {
            //Hacer un programa que calcule los números primos que existen entre el 1 y el 100
            for (int i = 0; i<100; i++)
            {
                if (i % 2 > 0 || i.Equals(2))
                {
                    Console.Write($"{i},");
                }
            }
            Console.ReadLine() ;
        }
        #endregion
        static void Main(string[] args)
        {
            //Ejercicio1();
            //Ejercicio2();
        }
    }
}

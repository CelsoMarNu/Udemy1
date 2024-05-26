using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareas
{
    internal class Tarea_5
    {
        #region Funciones
        static double calculaCirculo()
        {
            double area = new int();
            Console.WriteLine("Defina el radio del ciculo");
            double radio = Convert.ToDouble(Console.ReadLine());
            area = (Math.PI * Math.Pow(radio, 2));
            return area;
        }
        static double calculaCuadrado()
        {
            double area = new double();
            Console.WriteLine("Defina el lado del cuadrado");
            double lado = Convert.ToDouble(Console.ReadLine());
            area = Math.Pow(lado, 2);
            return area;
        }
        static double calculaTriangulo()
        {
            double area = new double();
            Console.WriteLine("Defina la base y la altura del triangulo");
            Console.WriteLine("Base");
            double @base = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Altura");
            double altura = Convert.ToDouble(Console.ReadLine());
            area = (@base * altura) / 2;
            return area;
        }


        #endregion

        #region Ejercicios
        static void Ejercicio1()
        {
            //Crear un método para transformar de grados a radianes
            //Variables
            double grados = new double();
            double radianes = new double();

            Console.WriteLine("Cargue el valor que desea pasar de Grados a radianes ");
            grados = Convert.ToDouble(Console.ReadLine());

            radianes = ((grados * Math.PI) / 180);

            Console.WriteLine($"El resultado de pasar {grados} grados a radianes es {radianes}");
            Console.ReadLine();
        }

        static void Ejercicio2()
        {
            //Crear una aplicación que calcule el área de un círculo, cuadrado o triangulo. Le preguntaremos al usuario a qué figura le quiere calcular el área y dependiendo el caso, ejecutará uno de los 3 métodos.
            Boolean repeat = false;
            Console.Clear();
            do
            {
                Console.WriteLine($"Defina el area de que figura desea calcular " + Environment.NewLine + "1 - Circulo " + Environment.NewLine + "2 - Cuadrado " + Environment.NewLine + "3 - triangulo");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine($"El area del cirulo es {calculaCirculo()}");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "2":
                        Console.WriteLine($"El area del cuadrado es {calculaCuadrado()}");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "3":
                        Console.WriteLine($"El area del triandulo es {calculaTriangulo()}");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Por favor elija una de la opciones definidas");
                        Console.ReadLine();
                        Console.Clear();
                        repeat = true;
                        break;
                }
            } while (repeat);
            Console.WriteLine();
        }
        #endregion

        static void Main(string[] args)
        {
            //Ejercicio1();
            //Ejercicio2();
        }
    }
}

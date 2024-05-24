using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Tareas
{
    internal class Tarea_2
    {
        static void Main(string[] arg)
        {
            //recibe los parametros para calcular el perimetro de un poligono regular
            //Formula de permimetro P=nl
            Console.WriteLine("Dime la medida de un lado");
            float lado;
            lado = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Dime la cantidad de lados");
            float cantidadLados;
            cantidadLados =Convert.ToSingle( Console.ReadLine());

            float perimetro = 0;
            perimetro = (lado * cantidadLados);
            Console.WriteLine($"El perimetro del poligono es {perimetro}");
        }
    }
}

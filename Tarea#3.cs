namespace Tareas
{
    internal class Tarea_3
    {
        #region Funciones
        //Funcion para validar si el valor es de tipo numerico o no
        static bool EsNumero(string valor)
        {
            return double.TryParse(valor, out _);
        }
        static bool EsPar(double valor)
        {
            if (valor % 2 == 0)
            {
                return true;
            }
            return false;
        }
        static double calcularCosto(double Tiempo)
        {
            double calculo = new double();
            switch (Tiempo)
            {
                case < 61:
                    calculo = 5;
                    break;
                case <= 120:
                    calculo = 15;
                    break;
                case > 120:
                    calculo = 40;
                    break;
            }

            return calculo;
        }
        #endregion

        static void Ejercicio1()
        {
            Boolean numeroValido = true;
            string numero;
            do
            {
                Console.Write("Elija un numero del 1 al 12: ");
                numero = Console.ReadLine();

                if (EsNumero(numero))
                {
                    if (Convert.ToInt32(numero) >= 1 && Convert.ToInt32(numero) <= 12)
                    {
                        DateTime fecha = new DateTime(1, Convert.ToInt32(numero), 1);
                        Console.WriteLine(fecha.ToString("MMMM"));
                        numeroValido = false;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Debe de elegir un numero entre 1 y 12");
                    }

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Debe de elegir un numero");
                }


            } while (numeroValido);
        }

        static void Ejercicio2()
        {
            bool ciclo = true;
            double valor = 0;
            do
            {
                Console.Clear();
                Console.Write("Escoja un numero y verificaremos si es par o no: ");
                valor = Convert.ToDouble(Console.ReadLine());
                if (EsPar(valor))
                {
                    Console.WriteLine($"El numero {valor} es par");
                }
                else
                {
                    Console.WriteLine($"El numero {valor} es impar");
                }
                Console.ReadLine();
            } while (ciclo);

        }

        static void Ejercicio3()
        {
            bool ciclo = true;
            do
            {
                Console.Clear();
                /*
                 Hacer un programa que le diga al usuario el precio que debe pagar por el servicio de estacionamiento de un centro comercial con base en el tiempo que ha permanecido ahí, 
                los primeros 60 minutos: $5.00, las primeras 2 horas $15.00 y de 2 horas en adelante: $40.00
                 */
                Console.Write("Cuanto tiempo se quedo?(el tiempo en minutos por favor): ");
                double Tiempo = new double();
                double costo = new double();
                Tiempo = Convert.ToDouble(Console.ReadLine());
                costo = calcularCosto(Tiempo);

                Console.WriteLine($"El costo por {Tiempo} minutos es {costo}$");
                Console.ReadLine();
            } while (ciclo);
        }

        static void Main(string[] args)
        {
            //Ejercicio1();
            //Ejercicio2();
            //Ejercicio3();
        }
    }
}

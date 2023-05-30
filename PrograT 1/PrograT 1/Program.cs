using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograT_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Salir");
                Console.WriteLine("Ingrese una opción (1-5):");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Sumar();
                        break;
                    case 2:
                        Restar();
                        break;
                    case 3:
                        Multiplicar();
                        break;
                    case 4:
                        Dividir();
                        break;
                    case 5:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Por favor, ingrese una opción válida (1-5).");
                        break;
                }

                Console.WriteLine();

            } while (opcion != 5);
        }

        static void Sumar()
        {
            Console.WriteLine("Ingrese el primer número:");
            double numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            double numero2 = double.Parse(Console.ReadLine());

            double resultado = numero1 + numero2;

            Console.WriteLine("El resultado de la suma es: " + resultado);
        }

        static void Restar()
        {
            Console.WriteLine("Ingrese el primer número:");
            double numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            double numero2 = double.Parse(Console.ReadLine());

            double resultado = numero1 - numero2;

            Console.WriteLine("El resultado de la resta es: " + resultado);
        }

        static void Multiplicar()
        {
            Console.WriteLine("Ingrese el primer número:");
            double numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            double numero2 = double.Parse(Console.ReadLine());

            double resultado = numero1 * numero2;

            Console.WriteLine("El resultado de la multiplicación es: " + resultado);
        }

        static void Dividir()
        {
            Console.WriteLine("Ingrese el primer número:");
            double numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            double numero2 = double.Parse(Console.ReadLine());

            if (numero2 != 0)
            {
                double resultado = numero1 / numero2;
                Console.WriteLine("El resultado de la división es: " + resultado);
            }
            else
            {
                Console.WriteLine("No se puede dividir entre cero.");
            }
        }
    }
}

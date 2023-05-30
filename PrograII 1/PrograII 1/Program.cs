using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograII_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tipos de datos

            byte b = 255; // 1 byte // Usa positivos

            int num1 = 50; // 4 bytes
            int num2, num3;
            int i = 0;

            float flotante = 33.3f;

            double doble = 14.25555555555576d;

            decimal deci = 158.366666666m;

            string frase = "Hoy es viernes";
            string nombre = null;

            char caracter = 'A';

            Boolean bolean = true;

            var variable = 30;
            variable = 20;

            dynamic dinamico = "texto";
            dinamico = 25;
            dinamico = true;
            dinamico = 256.322m;

            Console.WriteLine("Digite su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Digite su edad");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Mi nombre es:" + nombre + "y mi edad es:" + num1);
            Console.ReadLine();

            Console.WriteLine("la suma de dos numeros: " + (num1 + 10));
            Console.WriteLine("la multiplicacion de dos numeros: " + (num1 * num2));
            Console.WriteLine("la division de dos numeros: " + (num1 / num2));
            Console.WriteLine("la resta de dos numeros: " + (num1 - num2));
            Console.ReadLine();

            // Contadores
            i = i + 1;
            i = i - 1;

            i++;

            // ciclos

            if (num1 > num2)
            {
                Console.WriteLine("Num1 es mayor");
            }
            else if (num1 < num2)
            {
                Console.WriteLine("Num2 es mayor");
            }
            else
            {
                Console.WriteLine("Los numeros son iguales");
            }

            for (int j = 0; j < 10; j++) 
            { 
                Console.WriteLine(j); 
            }
            Console.ReadLine();

            int x = 10;
            while (x > 0)
            {
                Console.WriteLine(x);
                x--;
            }

            char opcion = 's';
            do
            {
                Console.WriteLine("1-sumar");
                Console.WriteLine("1-restar");
                Console.WriteLine("1-dividir");
                Console.WriteLine("1-multiplicar");
                Console.WriteLine("Digite una opcion... (s/n)");
                opcion = char.Parse(Console.ReadLine());
            } while (!opcion.Equals('n'));
        }
    }
}

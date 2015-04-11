using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDoWhile2
{
    class Program
    {
         //Escribir un programa que solicite la carga de numeros por teclado, obtener su promedio.// finalizar la carga de valore cuando se cargue el valor 0.
        static void Main(string[] args)
        {

            int numero = 0, suma = 0, contador=0;
            float promedio;
            do
            {
                Console.WriteLine("Digite numero   ");
                numero = int.Parse(Console.ReadLine());
                if (numero == 0)
                {
                    break;
                }

                suma += numero;
                contador++;

            }
            while (numero != 0);
            promedio = suma / contador;
            Console.WriteLine("El promedio es : " + promedio);
            
            Console.ReadKey();


        }
    }
}

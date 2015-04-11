using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNumerosEntrerosFor2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int cantidad, contador2=0, contador3=0;
            float numero = 0;
            Console.WriteLine("Digite cantidad de numeros ");
            cantidad = int.Parse(Console.ReadLine());
                for (int contador = 1; contador <= cantidad; contador++)
                {
                    Console.WriteLine("Digite numero:  " + contador);
                    numero=float.Parse(Console.ReadLine());
                   
                   
                    Console.WriteLine(" el numero   " + contador + "es:" + numero);
                    if (numero >= 1000     )
                    {
                        contador2 = contador2 + 1;
                    }
                    else
                    {
                        contador3 = contador3 + 1;
                    }
                   

                }

                Console.WriteLine(" las numeros mayores a 1000 son:" + contador2);
                Console.WriteLine(" las numeros menores a 1000 son:" + contador3);
                Console.ReadKey();

        }
    }
}

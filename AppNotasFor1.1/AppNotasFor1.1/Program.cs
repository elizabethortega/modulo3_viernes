using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNotasFor1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int notas, contador2=0, contador3=0;
            float nota = 0;
            Console.WriteLine("digite numero de notas ");
            notas = int.Parse(Console.ReadLine());
                for (int contador = 1; contador <= notas; contador++)
                {
                    Console.WriteLine("Digite nota:  " + contador);
                    nota=float.Parse(Console.ReadLine());
                   
                   
                    Console.WriteLine(" la nota del estudiante  " + contador + "es:" + nota);
                    if (nota >= 7)
                    {
                        contador2 = contador2 + 1;
                    }
                    else
                    {
                        contador3 = contador3 + 1;
                    }
                   

                }

                Console.WriteLine(" las notas mayores a 7 son:" + contador2);
                Console.WriteLine(" las notas menores a 7 son:" + contador3);
                Console.ReadKey();



        }
    }
}

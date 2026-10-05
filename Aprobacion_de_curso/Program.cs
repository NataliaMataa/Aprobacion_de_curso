using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprobacion_de_curso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la nota final del estudiante (0 a 100): ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double nota))
            {
                if (nota >= 0 && nota <= 100)
                {

                    if (nota >= 70)
                    {
                        Console.WriteLine("El estudiante ha aprobado el curso.");
                    }
                    else
                    {
                        Console.WriteLine("El estudiante ha reprobado el curso.");
                    }
                }
                else
                {
                    Console.WriteLine("La nota ingresada no es válida. Debe estar entre 0 y 100.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
            }
        }
    }

}

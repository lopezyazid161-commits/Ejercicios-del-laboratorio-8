using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ejercicio04
{
    internal class Program
    {
        // Este es el único punto de entrada de tu programa
        static void Main(string[] args)
        {
            Console.Write("Ingrese la nota del estudiante: ");

            // Usamos double.TryParse en lugar de Parse para evitar que el programa se cierre si escriben una letra
            if (double.TryParse(Console.ReadLine(), out double nota))
            {
                // Usamos la función NotaValida para verificar el rango
                if (NotaValida(nota))
                {
                    // Si es válida, evaluamos si aprueba (11 o más) o desaprueba
                    if (nota >= 11)
                    {
                        Console.WriteLine("Estado: Aprobado");
                    }
                    else
                    {
                        Console.WriteLine("Estado: Desaprobado");
                    }
                }
                else
                {
                    // Si la nota no está entre 0 y 20
                    Console.WriteLine("Error: La nota ingresada es inválida. Debe estar entre 0 y 20.");
                }
            }
            else
            {
                Console.WriteLine("Error: Debe ingresar un número válido.");
            }
        }

        // La función NotaValida ahora está afuera del Main, como un método independiente de la clase
        static bool NotaValida(double nota)
        {
            return nota >= 0 && nota <= 20;
        }
    }
}

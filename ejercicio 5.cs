using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_5_S8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese la nota : ");
            double nota = double.Parse(Console.ReadLine());
            nota = validacionNotas(nota);
            string clasificacion = ClasificacionNotas(nota);
            mostrarComprobante(clasificacion, nota);
        }
        static double validacionNotas(double nota)
        {
        while (nota < 0 || nota > 20)
            {
                Console.Write("#nota invalida# ingrese de nuevo : ");
                nota = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("nota válida");
            return nota;
        }
        static string ClasificacionNotas(double nota)
        {
            if (nota > 18)
            {
                return ("EXELENTE");
            }
            else if (nota > 14)
            {
                return ("bueno");
            }
            else if (nota > 11)
            {
                return ("regular");
            }
            else
            {
                return ("desaprobado");
            }
        }
        static void mostrarComprobante(string clasificacion, double nota)
        {
            Console.WriteLine($"nota ingresada {nota}");
            Console.WriteLine($"clasificacion: {clasificacion}");
        }
    }
}

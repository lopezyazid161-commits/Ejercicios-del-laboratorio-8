using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad comprada: ");
            int cantidad = int .Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el precio unitario: S/");
            double precioUnitario = double.Parse(Console.ReadLine());

            double subtotal = CalcularSubtotal(cantidad, precioUnitario);
            double igv = CalcularIgv(subtotal);
            double total = CalcularTotal(subtotal, igv);

            Console.WriteLine("\n=== BOLETA DE VENTA ===");
            Console.WriteLine($"Cantidad: {cantidad}");
            Console.WriteLine($"Precio Unitario: S/{precioUnitario}");
            Console.WriteLine($"Subtotal: S/{subtotal}");
            Console.WriteLine($"IGV(18%): S/{igv}");
            Console.WriteLine($"Total a pagar: S/{total}");
        }

        static double CalcularSubtotal(int cantidad, double precioUnitario)
        {
            double subtotal = cantidad * precioUnitario;
            return subtotal;
        }
        static double CalcularIgv (double subtotal)
        {
            double igv = 0.18 * subtotal;
            return igv;
        }
        static double CalcularTotal(double subtotal, double igv)
        {
            double total = igv + subtotal;
            return total;
        }
    }
}

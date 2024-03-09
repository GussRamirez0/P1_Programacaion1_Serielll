using System;

namespace Programa1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la aplicación de cálculo de precios");

            int precioProducto1, precioProducto2, precioProducto3;

            Console.WriteLine("Ingrese el precio del primer producto (en céntimos):");
            if (!int.TryParse(Console.ReadLine(), out precioProducto1))
            {
                Console.WriteLine("Error: Por favor, ingrese un valor entero válido para el precio del primer producto.");
                return;
            }

            Console.WriteLine("Ingrese el precio del segundo producto (en céntimos):");
            if (!int.TryParse(Console.ReadLine(), out precioProducto2))
            {
                Console.WriteLine("Error: Por favor, ingrese un valor entero válido para el precio del segundo producto.");
                return;
            }

            Console.WriteLine("Ingrese el precio del tercer producto (en céntimos):");
            if (!int.TryParse(Console.ReadLine(), out precioProducto3))
            {
                Console.WriteLine("Error: Por favor, ingrese un valor entero válido para el precio del tercer producto.");
                return;
            }

            int total = precioProducto1 + precioProducto2 + precioProducto3;

            total = total > 500 ? (int)(total * 0.9) : total;

            Console.WriteLine($"El total de los productos es: {total} céntimos.");

            // Solución para terminar un segundo proceso
            TerminarSegundoProceso();
        }

        static void TerminarSegundoProceso()
        {
            // Aquí coloca el código para identificar y terminar el segundo proceso
            // Reemplaza "nombre_del_proceso_a_terminar" con el nombre del proceso que deseas terminar

            string nombreProcesoATerminar = "nombre_del_proceso_a_terminar";

            int procesoATerminarID = ObtenerIDProceso(nombreProcesoATerminar);

            if (procesoATerminarID != -1)
            {
                try
                {
                    System.Diagnostics.Process procesoATerminar = System.Diagnostics.Process.GetProcessById(procesoATerminarID);
                    procesoATerminar.Kill();
                    Console.WriteLine($"Proceso con ID {procesoATerminarID} terminado exitosamente.");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine($"No se pudo encontrar un proceso con ID {procesoATerminarID}.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ocurrió un error al intentar terminar el proceso: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("No se encontró el proceso a terminar.");
            }
        }

        static int ObtenerIDProceso(string nombreProceso)
        {
            System.Diagnostics.Process[] procesos = System.Diagnostics.Process.GetProcessesByName(nombreProceso);

            if (procesos.Length > 0)
            {
                return procesos[0].Id;
            }

            return -1;
        }
    }
}

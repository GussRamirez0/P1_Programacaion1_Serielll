using System;

namespace Solucion2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la aplicación de generación de correo electrónico");

            Console.WriteLine("Ingrese su nombre:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su apellido:");
            string apellido = Console.ReadLine();

            Console.WriteLine("Ingrese su dominio de correo electrónico (por ejemplo, gmail):");
            string dominio = Console.ReadLine();

            string correo = GenerarCorreo(nombre, apellido, dominio);

            Console.WriteLine($"El correo electrónico generado es: {correo}");
        }

        static string GenerarCorreo(string nombre, string apellido, string dominio)
        {
            string correo = $"{nombre.Substring(0, 3).ToLower()}{apellido.Substring(0, 3).ToLower()}@{dominio}.com";
            return correo;
        }
    }
}

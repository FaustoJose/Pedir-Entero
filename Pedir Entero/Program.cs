using System;

namespace Pedir_Entero
{
    class Program
    {
        static void Main(string[] args)
        {

            string mensaje= PedirEntero("Este es el Tiempo seleccionado", 1800, 2100);

            Console.WriteLine(mensaje);
        }
        public static string PedirEntero(string texto,int valor1,int valor2)
        {
            int numero;
            Console.WriteLine("Introduce un numero");
            numero = Convert.ToInt32(Console.ReadLine());

            while ((numero <= valor1) || (numero >= valor2))
            {

                Console.WriteLine("valor incorrecto; Vuenva a intriducirlo");
                numero = Convert.ToInt32(Console.ReadLine());



            }

            return texto + " " + numero;
        }
    }
}

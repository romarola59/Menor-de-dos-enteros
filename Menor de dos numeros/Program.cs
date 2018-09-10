using System;

namespace Menor_de_dos_numeros
{
    public class Program
    {
        public static void Menor(int a,int b)
        {
            // realizamos la operaciones para saber cual es el menor
            if (a < b)
                Console.WriteLine("el numero menor es: {0}", a);
            else
                Console.WriteLine("el numero menor es: {0}", b);
        }
        public static void Main()
        {
            //declaracion de las variables, 
            int a, b;
            // interacion con el usuario
            Console.WriteLine("Escribe un numero entero: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe otro numero entero: ");
            b= Convert.ToInt32(Console.ReadLine());

            // llamado a a la funcion
            Menor(a, b);
            Console.ReadKey();
        }
    }
}

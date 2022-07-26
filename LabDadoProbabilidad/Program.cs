using System;

namespace LabDadoProbabilidad
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();

            Console.WriteLine("Ingrese la cantidad de veces que lanzará el dado");

            int CantidadDeTiradas = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < CantidadDeTiradas; i++)
            {
                Console.Write("Sale Nº " + random.Next(1, 7) + " ");

                Console.WriteLine("Tirada N° {0}", i + 1);
            }



        }
    }
}
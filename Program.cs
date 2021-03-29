using System;

namespace A133590.Ejercicio34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 34.");
            Console.WriteLine("Programa que imprime la fecha cada 10 segundos por 60 segundos");

            DateTime anterior = DateTime.Now;
            DateTime guarda60 = DateTime.Now;
            Console.WriteLine(anterior);
            while(true)
            {
                if((DateTime.Now - anterior).TotalSeconds > 10)
                {
                    anterior = DateTime.Now;
                    Console.WriteLine(anterior);
                }

                if((DateTime.Now - guarda60).TotalSeconds > 60)
                {
                    break;
                }
            }

            Console.WriteLine("Presione cualquier tecla para continuar..");
            Console.ReadKey();
        }
    }
}

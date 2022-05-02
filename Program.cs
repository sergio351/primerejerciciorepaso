// Realizar un programa que ingrese un vector de n elementos e imprimir el menor y un mensaje si se repite algun numero    
  

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PruebaVector
{
    class PruebaVector
    {
        private int[] vec;//Declaramos un vector
        private int menor;

        public void Cargar()
        {
            Console.Write("Ingrese la longitud del vector:");
            string linea;
            linea = Console.ReadLine();
            int n = int.Parse(linea);
            vec = new int[n];
            for (int f = 0; f < vec.Length; f++)
            {
                Console.Write("Ingrese componente ["+(f+1)+"]: ");
                linea = Console.ReadLine();
                vec[f] = int.Parse(linea);
            }
        }

        public void MenorElemento()
        {
            menor = vec[0];
            for (int f = 1; f < vec.Length; f++)
            {
                if (vec[f] < menor)
                {
                    menor = vec[f];
                }
            }
            Console.WriteLine("El elemento menor es: " + menor);
        }

        public void RepiteMenor()
        {
            int cant = 0;
            for (int f = 0; f < vec.Length; f++)
            {
                if (vec[f] == menor)
                {
                    cant++;
                }
            }
            if (cant > 1)
            {
                Console.WriteLine("Se repite el numero.");
            }
            else
            {
                Console.WriteLine("No se repite el menor.");
            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            PruebaVector pv = new PruebaVector();
            pv.Cargar();
            pv.MenorElemento();
            pv.RepiteMenor();
        }
    }
}

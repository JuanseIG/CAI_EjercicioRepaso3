using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_EjercicioRepaso3
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra = "";
            string invertida = "";
            string letra = "";
            int i = 0;

            Console.WriteLine("ingresar una palabra");
            palabra = Convert.ToString(Console.ReadLine());
            i = palabra.Length;
            for (int x=i-1; x >= 0; x--)
            {
                letra = palabra.Substring(x, 1);
                invertida = invertida + letra; 
            }
            if (palabra == invertida)
            {
                Console.WriteLine(palabra + " es palíndrome");
            }
            else
            {
                Console.WriteLine(palabra + " no es palíndrome");
            }

            Console.ReadKey();
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_01_Foreach__Soma_dos_Elementos_de_um_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int soma = 0;

            foreach (int elemento in array)
            {
                soma += elemento;
            }

            Console.WriteLine($"A soma dos elementos do array é: {soma}");

            Console.ReadKey();  
        }
    }
}
    
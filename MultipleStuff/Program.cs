using System;

namespace MultipleStuff
{
    public class Program
    {
        public static void Main()
        {
            SuperList lista = new SuperList { 5.4, 3.2, 8.1, 0.9, 7.3 };

            // Versão 1: parâmetros out
            lista.GetMinMax1(out double min1, out double max1);
            Console.WriteLine($"GetMinMax1: min = {min1}, max = {max1}");

            // Versão 2: struct interna
            var resultado2 = lista.GetMinMax2();
            Console.WriteLine($"GetMinMax2: min = {resultado2.Min}, max = {resultado2.Max}");

            // Versão 3: tuplos por referência
            double min3 = 0, max3 = 0;
            lista.GetMinMax3(ref min3, ref max3);
            Console.WriteLine($"GetMinMax3: min = {min3}, max = {max3}");

            // Versão 4: tuplos nomeados
            var (min4, max4) = lista.GetMinMax4();
            Console.WriteLine($"GetMinMax4: min = {min4}, max = {max4}");
        }
    }
}
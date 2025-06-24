using System;
using System.Collections.Generic;

namespace MultipleStuff
{
    public class SuperList : List<double>
    {
        // Versão 1: usando parâmetros out
        public void GetMinMax1(out double min, out double max)
        {
            if (this.Count == 0)
                throw new InvalidOperationException("A lista está vazia.");

            min = max = this[0];
            foreach (var val in this)
            {
                if (val < min) min = val;
                if (val > max) max = val;
            }
        }

        // Versão 2: usando struct interna
        public struct MinMax
        {
            public double Min;
            public double Max;
        }

        public MinMax GetMinMax2()
        {
            if (this.Count == 0)
                throw new InvalidOperationException("A lista está vazia.");

            double min = this[0], max = this[0];
            foreach (var val in this)
            {
                if (val < min) min = val;
                if (val > max) max = val;
            }
            return new MinMax { Min = min, Max = max };
        }

        // Versão 3: usando tuplos de referência
        public void GetMinMax3(ref double min, ref double max)
        {
            if (this.Count == 0)
                throw new InvalidOperationException("A lista está vazia.");

            min = max = this[0];
            foreach (var val in this)
            {
                if (val < min) min = val;
                if (val > max) max = val;
            }
        }

        // Versão 4: usando tuplos de valor com nomes
        public (double Min, double Max) GetMinMax4()
        {
            if (this.Count == 0)
                throw new InvalidOperationException("A lista está vazia.");

            double min = this[0], max = this[0];
            foreach (var val in this)
            {
                if (val < min) min = val;
                if (val > max) max = val;
            }
            return (Min: min, Max: max);
        }
    }
}
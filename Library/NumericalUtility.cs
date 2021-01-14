using System;
using System.Collections.Generic;

namespace UtilityLibrary
{
    /// <summary>
    /// Provém métodos estáticos para determinadas finalidades numéricas.
    /// </summary>
    public static class NumericalUtility
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Retorna uma lista de inteiros contendo todos os divisores</returns>
        public static IList<int> DivasorNumbers(int number)
        {
            IList<int> splitters = new List<int>();

            for (int i = 1; i < number; i++)
                if (IsDivider(number, i) || i == number) splitters.Add(i);

            splitters.Add(number);

            return splitters;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Retorna uma lista de números inteiros contendo todos os divisores pares.</returns>
        public static IList<int> EvenDividers(int number)
        {
            IList<int> divisors = DivasorNumbers(number);
            IList<int> evenDividers = new List<int>();

            for (int i = 0; i < divisors.Count; i++)
            {
                int dividend = divisors[i];

                if (IsDivider(dividend, 2)) evenDividers.Add(dividend);
            }

            return evenDividers;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Retorna uma lista de números inteiros contendo todos os divisores ímpares.</returns>
        public static IList<int> PrimeDividers(int number)
        {
            IList<int> divisors = DivasorNumbers(number);
            IList<int> primeDividers = new List<int>();

            for (int i = 1; i < divisors.Count; i++)
            {
                int dividend = divisors[i];

                if (!IsDivider(dividend, 2)) primeDividers.Add(dividend);
            }

            return primeDividers;
        }

        /// <summary>
        /// Números inteiros naturais são todos os números positivos contando por 0 (zero).
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Retorna verdadeiro caso valor informado seja um número inteiro natural ou false caso não seja um número inteiro natural.</returns>
        public static bool IsNaturalNumber(string value)
        {
            return int.TryParse(value, out int newValue) && newValue >= 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dividend">Dividendo</param>
        /// <param name="divider">Divisor</param>
        /// <returns>Verdadeiro caso <paramref name="dividend"/> seja divisível por <paramref name="divider"/> e false caso não seja divisor.</returns>
        public static bool IsDivider(int dividend, int divider)
        {
            return dividend % divider == 0;
        }
    }
}

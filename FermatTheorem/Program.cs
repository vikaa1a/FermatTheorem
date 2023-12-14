using System;

namespace FermatTheorem
{
    public class Program
    {
        /// <summary>
        /// Функция позволяет проверить, что Великая теорема Ферма выполняется для определенного диапазона значений.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool CheckFermatTheorem(int a, int b, int c, int n)
        {
            if (n <= 2)
            {
                return false;
            }

            int lhs = (int)Math.Pow(a, n) + (int)Math.Pow(b, n);
            int rhs = (int)Math.Pow(c, n);

            return lhs == rhs;
        }

        static void Main()
        {
            int a = 3;
            int b = 4;
            int c = 5;
            int n = 3;

            if (CheckFermatTheorem(a, b, c, n))
            {
                Console.WriteLine("The Fermat's Last Theorem holds for the given values.");
            }
            else
            {
                Console.WriteLine("The Fermat's Last Theorem does not hold for the given values.");
            }
        }
    }
}

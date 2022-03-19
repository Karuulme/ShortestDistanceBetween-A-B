using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] LabArray = new string[10, 10] {
            {"0","0","0","0","0","0","0","0","0","0"},
            {"0","0","0","0","0","0","0","0","0","0"},
            {"0","0","0","0","0","0","0","0","0","0"},
            {"0","0","A","0","0","0","0","0","0","0"},
            {"0","0","0","0","0","0","0","0","0","0"},
            {"0","0","0","0","0","0","0","0","0","0"},
            {"0","0","0","0","0","0","0","0","0","0"},
            {"0","0","0","0","0","0","0","0","0","0"},
            {"0","0","0","0","0","0","0","0","0","0"},
            {"0","0","0","0","0","0","B","0","0","0"},
            };
            string[,] a = Patharray(LabArray, 3, 2, 9, 6);
            LabArray[3, 2] = "A";
            LabArray[9, 6] = "B";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(a[i, j]);
                }
                Console.WriteLine("");
            }
        }
        static string[,] Patharray(string[,] array, int Ai, int Aj, int Bi, int Bj)
        {
            int
                i = (Ai <= Bi) ? Ai : Bi,
                j = (Ai <= Bi) ? Aj : Bj,
                n = (Ai <= Bi) ? Bj : Aj,
                k = (Ai <= Bi) ? Bi : Ai;
            do
            {
                i = (Ai == Bi) ? i : ++i;
                j = (j >= n) ? --j : ++j;
                array[i, j] = "X";
                if (j == n || i == 9 || i == k)
                    if (Ai != Bi) ShortPatharray(array, i, j, k, n);
            }
            while (j != n && i < 10 && i < k);
            return array;
        }
        static string[,] ShortPatharray(string[,] array, int Ai, int Aj, int Bi, int Bj)
        {
            int
                i = (Ai <= Bi) ? Ai : Bi, //  ai
                j = (Ai <= Bi) ? Aj : Bj, //  aj
                k = (Ai <= Bi) ? Bi : Ai, //  bi
                n = (Ai <= Bi) ? Bj : Aj; //  bj
            while (i != k || j != n)
            {
                i = (Ai == Bi) ? i : ++i;
                j = (Ai == Bi) ? (Aj <= Bj) ? ++j : --j : j;
                array[i, j] = "X";
            }
            return array;
        }
    }
}

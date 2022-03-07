using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] LabArray = new string[10, 10] {
            {"A","0","0","0","0","A","0","0","0","0"},
            {"0","0","0","0","0","0","0","0","0","0"},
            {"0","0","0","0","0","0","0","0","0","0"},
            {"0","0","0","0","0","0","0","0","0","0"},
            {"0","0","0","0","0","0","0","0","0","0"},
            {"0","0","0","0","0","0","0","0","0","0"},
            {"0","0","0","0","0","0","0","0","0","0"},
            {"0","0","0","0","0","0","0","0","0","0"},
            {"0","0","0","0","0","0","0","0","0","0"},
            {"0","0","0","0","0","0","0","B","0","0"},
            };
            string[,] a=Patharray(LabArray, 0, 0, 9, 7);
              LabArray[0,0] = "A";
              LabArray[9, 7] = "B";
            for (int i=0;i<10;i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(a[i, j]);
                }
                Console.WriteLine("");
            }
        }
        static string[,] Patharray(string[,] array,int Ai,int Aj, int Bi, int Bj)
        {
            int
                i = (Ai <= Bi) ? Ai : Bi,
                j = (Ai <= Bi) ? Aj : Bj,
                n = (Ai <= Bi) ? Bj : Aj;
            do
            {
                i = (Ai == Bi) ? i : ++i;
                j = (j >= n) ? --j : ++j;
                array[i, j] = "X";
                if (j == n || i == 9)
                    if (Ai != Bi) ShortPatharray(array,i,j,Bi,Bj);
            }
            while (j != n && i < 10);
            return array;
        }
        static string[,] ShortPatharray(string[,] array,int Xi,int Xj,int Bi,int Bj)
        {
           for (int i=(Xj == Bj) ? Xi : (Xj <= Bj) ? Xi : Bj,
                n= (Xj == Bj) ?  Bi: (Xj <= Bj) ? Xi : Bj;
                i!=n;i++
                )
            {
                if (Xj == Bj)
                    array[i, Bj] = "X";
                else array[Bi, i] = "X";               
            }
            return array;
        }
    }
}

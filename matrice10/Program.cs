using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[,] matr = new int[5, 5];
        Random rnd = new Random();
        bool ver = false;
        //assegnazione valori alla matrice
        for (int i = 0; i < matr.GetLength(0); i++)
            {
            for (int j = 0; j < matr.GetLength(1); j++)
                {
                matr[i, j] = rnd.Next(0, 2);
                }
            }
        for (int i = 0; i < matr.GetLength(0); i++)
            {
            for (int j = 0; j < matr.GetLength(1); j++)
                {
                Console.Write(matr[i, j] + " ");
                }
            Console.WriteLine();
            }

        for (int i = 0; i < matr.GetLength(0); i++)
            {
            for (int j = 0; j < matr.GetLength(1); j++)
                {
                if (i == j)
                {
                    if (matr[i, j] != 1)
                        {
                        ver = true;
                        }
                }
                else
                    { 
                     if (matr[i, j] != 0)
                        {
                        ver = true;
                        }
                    }
                }
            }
        if (ver)
            {
                Console.WriteLine("matrice identità no");            
            }
        else
            {
                Console.WriteLine("matrice identità si");
            }
    }
}

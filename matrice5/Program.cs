using System;
using System.Globalization;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[,] matr = new int[5, 5];
        Random rnd = new Random();
        int n = 0, m = 1, cont = 0;
        bool ver = false;
        //assegnazione valori alla matrice
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i, j] = rnd.Next(0,101);   
            }
        }
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write(matr[i,j] + " ");
            }
            Console.WriteLine();
        }
        for (int i = 0; i < matr.GetLength(0); i++)
            {
             for (int j = 0; j < matr.GetLength(1); j++)
               {
                if (matr[i, j] < n || matr[i, j] > m)
                  {
                    ver = true;
                    cont++;
                  }
               }
            }
        if (ver)
        {
            Console.WriteLine("il numero di valori non compresi è: " + cont);
        }
        else
        {
            Console.WriteLine("tutti i valori sono compresi tra n e m");
        }
    }
}
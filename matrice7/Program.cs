using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[,] matr = new int[9, 9];
        Random rnd = new Random();
        int somma1 = 0, somma2 = 0;
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
                Console.Write(matr[i,j] + " ");
                }
            Console.WriteLine();
            }

        for (int i = 0; i < matr.GetLength(0); i++)
            {
            for (int j = 0; j < matr.GetLength(1); j++)
                {
                if (i == j)
                    {
                    somma1 += matr[i, j];
                    }
                else if (i + j == 8)
                    {
                    somma2 += matr[i, j];
                    }
                }
            
            }
        
        Console.WriteLine(somma1);
        Console.WriteLine(somma2);
        if (somma1 == somma2)
            {
            Console.WriteLine("le due diagonali hanno somma uguale");
            }
        else
            {
            Console.WriteLine("le due diagonali hanno somma diversa");
            }
        }
}
using System;

public class HelloWorld
    {
    public static void Main(string[] args)
        {
        int[,] matr = new int[6, 6];
        int[,] matrix = new int[6, 6];
        bool ver = false;
        Random rnd = new Random();

        //assegnazione valori alla matrice
        for (int i = 0; i < matr.GetLength(0); i++)
            {
            for (int j = 0; j < matr.GetLength(1); j++)
                {
                matr[i, j] = rnd.Next(0, 10);
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
                matrix[i, j] = matr[j, i];
                }
            
            }
        Console.WriteLine();
        for (int i = 0; i < matr.GetLength(0); i++)
            {
            for (int j = 0; j < matr.GetLength(1); j++)
                {
                Console.Write(matrix[i, j] + " ");
                }
            Console.WriteLine();
            }
         
        for (int i = 0; i < matr.GetLength(0); i++)
            {
            for (int j = 0; j < matr.GetLength(1); j++)
                {
                if (i == j)
                    {
                    if (matr[i, j] != matrix[i, j])
                        {
                            ver = true;
                        }
                    }
                }
            }
        if (ver)
            {
                Console.WriteLine("le matrici hanno diagonali principali diverse!");
            }
        else
            {
                Console.WriteLine("le matrici hanno diagonali principali uguali");
            }
        }
    }


using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[,] matr = new int[6, 6];
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                if (i == j)
                {
                    matr[i, j] = 1;
                }
                else
                { 
                    matr[i, j] = 0;
                }
            }
        }
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write(matr[i, j]);
            }
            Console.WriteLine();
        }
        
        }
    }

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[,] matr = new int[5, 5];
        Random rnd = new Random();
        bool ver = true, ver2 = true;
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
            for (int j = 0; j < matr.GetLength(1)- 1; j++)
                {
                if (matr[i, j] > matr[i, j + 1])
                    {
                    ver = false;
                    }
                }
        }
        for (int i = 0; i < matr.GetLength(1) - 1; i++)
            {
            for (int j = 0; j < matr.GetLength(0); j++)
                {
                if (matr[i, j] > matr[i + 1, j])
                    {
                    ver2 = false;
                    }
                }
            }
        if (ver && ver2)
            { 
                Console.WriteLine("verificata");
            }
        else
            {
                Console.WriteLine("non verificata");
            }
            
    }
}
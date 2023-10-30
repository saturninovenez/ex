using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[,] matr = new int[4, 4];
        Random rnd = new Random();
        int vmax = 0, somma = 0;
        
        //assegnazione valori matrice
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i, j] = rnd.Next(0, 51);
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
               somma += matr[i, j];
            }
            
            if (somma > vmax)
            { 
                vmax = somma;
            }    
            
            somma = 0;
        }
        somma = 0;
        for (int i = 0; i < matr.GetLength(1); i++)
        {
            for (int j = 0; j < matr.GetLength(0); j++)
            {
                somma += matr[j, i];
            }
            
            if (somma > vmax)
            {
                vmax = somma;
            }
            somma = 0;
        }
        Console.Write("la somma più grande è: " + vmax);

    }
}

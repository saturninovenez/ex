using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[,] matr = { {0,1,0,1,0,1,0,1 },
                        {1,0,1,0,1,0,1,0 },
                        {0,1,0,1,0,1,0,1 },
                        {1,0,1,0,1,0,1,0 },
                        {0,1,0,1,0,1,0,1 },
                        {1,0,1,0,1,0,1,0 },
                        {0,1,0,1,0,1,0,1 },
                        {1,0,1,0,1,0,1,0 }};
        Random rnd = new Random();
        bool ver = false;

        /*for (int i = 0; i < matr.GetLength(0); i++)
            {
            for (int j = 0; j < matr.GetLength(1); j++)
                {
                matr[i, j] = rnd.Next(0, 2);
                }
            }*/
        
        for (int i = 0; i < matr.GetLength(0); i++)
            {
            for (int j = 0; j < matr.GetLength(1); j++)
                {
                    Console.Write(matr[i,j] + " ");
                }
            Console.WriteLine();
            }
        for (int i = 0; i < matr.GetLength(0)-1; i++)
            {
            for (int j = 0; j < matr.GetLength(1)-1; j++)
                {
                if (matr[i, j] == matr[i + 1, j] || matr[i,j] == matr[i,j+1] )
                    {
                    ver = true;
                    }
                }
            
            }
        if (ver)
            {
                Console.WriteLine("non è una scacchiera");
            }
        else
            {
                Console.WriteLine("è una scacchiera"); 
            }
        }
}
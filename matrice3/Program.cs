using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[,] matr = new int[6, 6];
        Random rnd = new Random();
        int somma = 0, somma2 = 0;
        //caricamento matrice
        for (int i = 0; i < matr.GetLength(0); i++) 
        {
            for (int j = 0; j< matr.GetLength(1); j++)
            {
                matr[i, j] = rnd.Next(0,51);
            }
        }
        //stampa matrice
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write(" " + matr[i,j]);
            }
            Console.WriteLine();
        }
        
        int k = 5;
        for (int i = 0; i < matr.GetLength(0)/2; i++)
        {
            
            for (int j = 0; j < matr.GetLength(1); j++)
            {
               somma += matr[i,j];
            }
            Console.WriteLine("le somme sono: ");
            Console.WriteLine(somma);
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                somma2 += matr[k,j];
            }
            Console.WriteLine(somma2);
            k--;
            Console.WriteLine("quindi è palindromo? ");
            if (somma == somma2)
            {
                Console.WriteLine("si");
            }
            else 
            {
                Console.WriteLine("no");
            }
            somma = 0;
            somma2 = 0;
        }
    }
}
       
    


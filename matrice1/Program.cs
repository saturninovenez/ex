namespace matricecosta
{
    internal class Program
{
    static void Main(string[] args)
    {
        int r = 0, c = 0;
        r = int.Parse(Console.ReadLine());
        Console.WriteLine("inserisci il numero di colonne: ");
        c = int.Parse(Console.ReadLine());

        int[,] matr;
        matr = new int[r, c];
        int n = 0, somma = 0;
        Random rnd = new Random();


        for (int i = 0; i < matr.GetLength(0); i++) //caricamento della matrice con random
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                n = rnd.Next(0, 101);
                matr[i, j] = n;
            }
        }
        Console.WriteLine();

        for (int i = 0; i < matr.GetLength(0); i++) //stampa matrice
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write(matr[i, j] + " ");
            }
            Console.Write("\n");
        }

        
        for (int i = 0; i < matr.GetLength(0); i++)//somma della matrice per la somma totale
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                somma += matr[i, j];

            }
        }
        Console.WriteLine("\nla somma è: " + somma);
        int vmax = 0, vmin = 0;
        for (int i = 0; i < matr.GetLength(0); i++) //ricerca massimo
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                if (vmax < matr[i, j])
                {
                    vmax = matr[i, j];
                }
            }
        }
        Console.WriteLine("il valore massimo è: " + vmax);

        vmin = vmax;
        for (int i = 0; i < matr.GetLength(0); i++) //ricerca minimo
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                if (vmin > matr[i, j])
                {
                    vmin = matr[i, j];
                }
            }
        }
        Console.WriteLine("il valore minimo è: " + vmin);
        int media = 0;
        int moltrc = 0, cont = 0;
        moltrc = r * c;
        media = somma / moltrc;

        Console.WriteLine("la media è: " + media);

        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                if (matr[i, j] <= media - 2 || matr[i, j] >= media + 2)
                {
                    cont++;
                }
            }
        }
        Console.WriteLine("il numero di valori che di discosta dalla media di +-2 è: " + cont);
            vmax = 0;
            Console.WriteLine();
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    if (vmax < matr[i, j])
                    {
                        vmax = matr[i, j];
                    }
                }
                Console.WriteLine("il numero più grande nella riga " + i + " è: " + vmax);
                vmax = 0;
            }
            Console.WriteLine();
            vmax = 0;
            for (int i = 0; i < matr.GetLength(1); i++)
            {

                for (int j = 0; j < matr.GetLength(0); j++)
                {
                    if (vmax < matr[j, i])
                    {
                        vmax = matr[j, i];
                    }
                }
                Console.WriteLine("il numero più grande nella colonna " + i + " è: " + vmax);
                vmax = 0;
            }

            Console.WriteLine();
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                vmin = matr[i, 0];
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    if (vmin > matr[i, j])
                    {
                        vmin = matr[i, j];
                    }
                }
                Console.WriteLine("il numero più piccolo nella riga " + i + " è: " + vmin);
            }
            
            Console.WriteLine();
            for (int i = 0; i < matr.GetLength(1); i++)
            {
                vmin = matr[0,i];
                for (int j = 0; j < matr.GetLength(0); j++)
                {
                    
                    if (vmin > matr[j, i])
                    {
                        vmin = matr[j, i];
                    }
                }
                Console.WriteLine("il numero più piccolo nella colonna" + i + " è: " + vmin);
            }

            somma = 0;
            media = 0;
            Console.WriteLine();
            for (int i = 0; i < matr.GetLength(0); i++)
            {

                for (int j = 0; j < matr.GetLength(1); j++)
                {   
                    somma += matr[i, j];
                }
                media = somma / c;
                Console.WriteLine("la media per la riga " + i + " è: " + media);
                media = 0;
                somma = 0;
            }
            
            somma = 0;
            media = 0;
            Console.WriteLine();
            for (int i = 0; i < matr.GetLength(1); i++)
            {

                for (int j = 0; j < matr.GetLength(0); j++)
                {
                    somma += matr[j, i];
                }
                media = somma / r;
                Console.WriteLine("la media per colonna " + i + " è: " + media);
                media = 0;
                somma = 0;
            }
            Console.ReadKey();
    }
}
}
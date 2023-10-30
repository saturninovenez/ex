using System;
namespace hellosword
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("inserisci il numero di canzoni riprodotte in radio quest'oggi: ");
            num = int.Parse(Console.ReadLine());

            int[] durate_canzoni = new int[num];
            string[] nomi_cantanti = new string[num];
            string[] nomi_canzoni = new string[num];

            for (int i = 0; i < num; i++)
            {
                Console.Write("\ninserisci il nome del cantante: ");
                nomi_cantanti[i] = Console.ReadLine();
                Console.Write("Inserisci il nome della canzone: ");
                nomi_canzoni[i] = Console.ReadLine();
                Console.Write("Inserisci la durata della canzone in secondi: ");
                durate_canzoni[i] = int.Parse(Console.ReadLine());

                //Il programma in caso di errore nell’inserimento della durata deve richiedere l’inserimento della solo durata, mantenendo il titolo e il cantante precedentemente inseriti.
                if (durate_canzoni[i] < 30)
                {
                    Console.Write("La durata della canzone e' sbagliata, immetti un valore valido: ");
                    durate_canzoni[i] = int.Parse(Console.ReadLine());
                }
            }

            Console.Clear();

            //Il programma deve indicare la canzone con durata massima, quella con durata minima (che possono essere più di una) e la durata media.
            int max_durata = durate_canzoni[0];
            int min_durata = durate_canzoni[0];
            int media = durate_canzoni[0];

            //calcolo delle durate massime, minime e medie di tutte le canzoni
            for (int i = 1; i < num; i++)
            {
                if (max_durata < durate_canzoni[i])
                {
                    max_durata = durate_canzoni[i];
                }
                if (min_durata > durate_canzoni[i])
                {
                    min_durata = durate_canzoni[i];
                }
                media += durate_canzoni[i];
            }

            //print lunghezza massima
            Console.WriteLine(String.Format("La canzone piu' lunga dura: {0} secondi", max_durata));
            
            //print canzoni con durata massima
            Console.WriteLine("Queste sono tutte le canzoni con la durata massima: ");
            for (int i = 0; i < num; i++)
            {
                if (max_durata == durate_canzoni[i])
                {
                    Console.WriteLine(nomi_canzoni[i]);
                }
            }

            //print lunghezza minima 
            Console.WriteLine(String.Format("\nLa canzone piu' corta dura: {0} secondi", min_durata));

            //print canzoni con durata minima
            Console.WriteLine("Queste sono tutte le canzoni con la durata minima: ");
            for (int i = 0; i < num; i++)
            {
                if (min_durata == durate_canzoni[i])
                {
                    Console.WriteLine(nomi_canzoni[i]);
                }
            }

            //calcolo della media ed effettivo print
            media /= num;
            Console.WriteLine(String.Format("\nLa media della lunghezza delle canzoni e': {0} secondi\n", media));

            //Il programma deve stampare a video tutte le canzoni la cui durata si discosta dalla media di più o meno di 10 secondi e contarle
            int count = 0;
            Console.WriteLine("le canzoni che si discostano dalla media di più o meno di 10 secondi sono: ");
            for (int i = 0; i < num; i++)
            {
                if (media - 10 <= durate_canzoni[i] && durate_canzoni[i] <= media + 10)
                {
                    Console.WriteLine(nomi_canzoni[i]);
                    count++;
                }
            }

            //print del numero di canzoni che si discostano dalla media
            if (count != 0) 
            {
                Console.WriteLine(String.Format("Il numero delle canzoni che si discostano dalla media è: {0}", count));
            }
            else 
            {
                Console.WriteLine("Nessuna canzone si discosta dalla media!");
            }


            //Stampare le canzoni di un cantante letto in input riportando quante sono e la media e quella con durata massima.
            string nome;
            Console.Write("\nInserisci il nome di un cantante di cui vorresti sapere le statistiche: ");
            nome = Console.ReadLine();

            while (Array.IndexOf(nomi_cantanti, nome) == -1)
            {
                Console.Write("ERROR 404, il nome inserito non esiste, inserisci un nome che esiste: ");
                nome = Console.ReadLine();
            }
            media = 0;
            while (nome != "stop")
            {
                for (int i = 0; i < num; i++)
                {
                    if (nome == nomi_cantanti[i])
                    {
                        Console.WriteLine(nomi_canzoni[i]);
                        count++;

                        if (max_durata < durate_canzoni[i])
                        {
                            max_durata = durate_canzoni[i];
                        }

                        media += durate_canzoni[i];
                    }
                }

                for (int i = 0; i < count; i++)
                {
                    if (max_durata == durate_canzoni[i])
                    {
                        Console.WriteLine(String.Format("la canzone più lunga di {0} e': {1}. E dura: {2} secondi", nome, nomi_canzoni[i], max_durata));
                    }
                }
                
                media = media / count;
                Console.WriteLine(String.Format("La lunghezza media delle canzoni del cantante e': {0} secondi", media));

                Console.Write("\ndigita stop per uscire dalla ricerca in base all' artista. oppure digita un altro nome: ");
                nome = Console.ReadLine();

                while(Array.IndexOf(nomi_cantanti, nome) == -1 && nome != "stop")
                {
                    Console.Write("ERROR 404, il nome inserito non esiste, inserisci un nome che esiste: ");
                    nome = Console.ReadLine();
                }
            }


            //Stampare l’elenco delle canzoni ordinate per cantante, e alla fine di ogni cantante riportare il numero di canzoni e la durata media
            string[] nomi_usati = new string[num];
            bool check = true;
            count = 0;
            media = 0;
            for (int i = 0; i < num; i++)
            {
                nome = nomi_cantanti[i];
                for (int j = 0; j < num; j++)
                {
                    if (nome == nomi_usati[j])
                    {
                        check = false;
                    }
                }

                if (check)
                {
                    Console.WriteLine(String.Format("\nLe canzoni di: {0}: ", nome));
                    for (int k = 0; k < num; k++)
                    {
                        if (nomi_cantanti[k] == nome)
                        {
                            Console.WriteLine(nomi_canzoni[k]);
                            count++;
                            media += durate_canzoni[k];
                        }
                    }

                    Console.WriteLine(String.Format("Il numero delle canzoni e': {0}", count));

                    media /= count;
                    Console.WriteLine(String.Format("La lunghezza media delle canzoni e': {0}", media));

                    count = 0;
                    media = 0;
                }
                check = true;
                nomi_usati[i] = nome;

            }
        }
    }
}


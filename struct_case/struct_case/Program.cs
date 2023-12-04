using System;
namespace ConsoleApplication1
    {

    class Program
        {

        static void Main()
            {
            float[] vet_val = new float[3];
            casa[] casas = new casa[3];
            carica(ref casas[0]);
            carica(ref casas[1]);
            carica(ref casas[2]);
            casas[0].money = risultato(ref casas[0]);
            casas[1].money = risultato(ref casas[1]);
            casas[2].money = risultato(ref casas[2]);
            float a = casas[0].money;
            char b = casas[0].classe;
            bool check = false;
            for (int i = 1; i < 3; i++)
                {
                if (a < casas[i].money)
                    {
                    a = casas[i].money;
                    b = casas[i].classe;
                    }
                }
            for (int i = 1; i < 3; i++)
                {
                if (a == casas[i].money)
                    {
                    check = true;
                    if (b > casas[i].classe)
                        {
                        b = casas[i].classe;    
                        }
                    }
                }
            
            
            Console.WriteLine("il valore massimo è: " +a);
            if (check)
                Console.WriteLine("ci sono più case dello stesso valore ma la classe più efficiente è: " + b);

            for (int i = 0; i < 3; i++)
                {
                Console.WriteLine("il valore della casa {0} é: {1}", (i+1), casas[i].sumkwh);
                }
            Console.ReadKey();
            }

        static void carica(ref casa c)
            {
            try
                {
                Console.Write("inserisci i mq della casa: ");
                c.mq = int.Parse(Console.ReadLine());

                Console.Write("inserisci la classe energetica (a, b, c, d, e, f, g): ");
                c.classe = char.Parse(Console.ReadLine());

                Console.Write("inserisci il costo al mq: ");
                c.costo = float.Parse(Console.ReadLine());

                c.kwh = new float[12];
                Random rnd = new Random();
                for (int i = 0; i < 12; i++)
                    {
                    /*Console.WriteLine("inserisci i consumi kwh del " + (i + 1) + "mese");
                    c.kwh[i] = float.Parse(Console.ReadLine());*/
                    c.kwh[i] = rnd.Next(0, 1001);
                    }
                }
            catch (Exception) {Console.WriteLine("errore riprova.");}
            }
        static float risultato(ref casa p)
            {

            p.sumkwh = 0;
            for (int i = 0; i < 12; i++)
                {
                p.sumkwh += p.kwh[i];
                }
            p.maxcasa = p.mq * p.costo;

            return p.maxcasa;
            }
        }
    public struct casa
        {
        public int mq;
        public char classe;
        public float costo;
        public float[] kwh;
        public float sumkwh;
        public float maxcasa;
        public float money;
        }

    }

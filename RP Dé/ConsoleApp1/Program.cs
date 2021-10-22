using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            const int NOMBRE_MIN = 1;
            const int NOMBRE_MAX = 10;
            int NOMBRE_MAGIQUE = rand.Next(NOMBRE_MIN, NOMBRE_MAX + 1);

            int nombre = NOMBRE_MAGIQUE + 1;

            int nbVies = 4;

            while (nbVies > 0)
            {
                Console.WriteLine("choisi un nombre entre 1 et 10");
                string Nombre_Joueur = Console.ReadLine();
                int nj = int.Parse(Nombre_Joueur);
                if (NOMBRE_MAGIQUE > nj)
                {
                    Console.WriteLine("c'est plus grand");
                    nbVies--;
                    if (nbVies == 0)
                    {
                        Console.WriteLine("omae wa mou shindeiru");
                    }
                }
                else if (NOMBRE_MAGIQUE < nj)
                {
                    Console.WriteLine("c'est plus petit");
                    nbVies--;
                    if (nbVies == 0)
                    {
                        Console.WriteLine("omae wa mou shindeiru");
                    }
                }
                else
                {
                    Console.WriteLine("Bravo tu a trouvé");
                    nbVies = 0;
                }
            }
        }
    }
}

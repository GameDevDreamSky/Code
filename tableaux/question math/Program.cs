using System;

namespace question_math
{
    class Program
    {

        static void Main(string[] args)
        {
            int NombreMaxQuestion = 5; //Nombre de question au max
            int NombreDeReussite = 0; //Nombre de reussite
            int NombreActuel = 1; //Nombre de question actuel

            while (NombreActuel < NombreMaxQuestion + 1)
            {
                Console.WriteLine("Question n°" + NombreActuel + "/" + NombreMaxQuestion + "\n");
                NombreActuel = NombreActuel + 1;
                Random rand = new Random();
                const int min = 1;
                const int max = 2;
                int cequiadedans = rand.Next(min, max + 1);
                int n = cequiadedans + 1;
                if (cequiadedans == 1)
                {
                    Random rand2 = new Random();

                    const int min2 = -50;
                    const int max2 = 50;
                    int V1 = rand.Next(min2, max2 + 1);
                    int n1 = V1 + 1;
                    int V2 = rand.Next(min2, max2 + 1);
                    int n2 = V2 + 1;

                    Console.Write(V1 + " + " + V2 + " = ");

                    string reponse = Console.ReadLine();

                    int r = getNumber(reponse);

                    if ((V1 + V2) == r)
                    {
                        Console.WriteLine("GG mec une autre question\n\n");
                        NombreDeReussite = NombreDeReussite + 1;
                    }
                    else
                    {
                        Console.WriteLine("NOP pas la bonne une autre question\n\n");
                    }
                }
                else
                {
                    Random rand2 = new Random();

                    const int min2 = -50;
                    const int max2 = 50;
                    int V1 = rand.Next(min2, max2 + 1);
                    int n1 = V1 + 1;
                    int V2 = rand.Next(min2, max2 + 1);
                    int n2 = V2 + 1;
                    Console.Write(V1 + " x " + V2 + " = ");
                    string reponse = Console.ReadLine();

                    int r = getNumber(reponse);

                    if ((V1 * V2) == r)
                    {
                        Console.WriteLine("GG mec une autre question\n\n");
                        NombreDeReussite = NombreDeReussite + 1;
                    }
                    else
                    {
                        Console.WriteLine("NOP pas la bonne une autre question\n\n");
                    }
                }

            }

            Console.WriteLine("Réponse juste : " + NombreDeReussite + "/" + NombreMaxQuestion);

            if (NombreDeReussite == 2 || NombreDeReussite == 3)
                Console.WriteLine("fait mieux mec");
            else if (NombreDeReussite == 0)
                Console.WriteLine("Mec va si recommence parce que le je suis pas fier de toi !!!!!!!!!!");
            else if (NombreDeReussite == 5)
                Console.WriteLine("bien jouer tu est pas débile tu veux une médaille ?");
            else
                Console.WriteLine("ok ça passe");

        }

        private static int getNumber(string entry)
        {
            bool state = int.TryParse(entry, out int r);

            while (state == false)
            {
                Console.Write("Mec tu force pourquoi tu prend pas un nombre entier maintenant répond bien : ");
                entry = Console.ReadLine();
                state = int.TryParse(entry, out r);
            }

            return r;
        }

    }
}

using System;

namespace Générateur_de_mdp
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Quel est la longueur du mdp que tu veux généré ?");
            int MinMDP = 1;
            int MaxMDP = 2;
            int chiffres = 3;
            int CS = 4;//charactères spé
            int NDC;// nombre de chara








            while (!int.TryParse(Console.ReadLine(), out NDC) || NDC <= 3)
            {
                Console.Write("Seulement des chiffres au minimun  de 4");
            }
            Console.WriteLine("Le mot de passe fera " + NDC + " de longueur.");
            Console.WriteLine("Vous voulez un mot de passe avec :");
            Console.WriteLine("1 - Uniquement des caractères en minuscule");
            Console.WriteLine("2 - Des caractères minuscules et maj");
            Console.WriteLine("3 - des caractères et chiffres");
            Console.WriteLine("4 - Caractères, chiffres et caractères spéciaux");



            string réponse = Console.ReadLine();// prend en compte la réponse

            int RP = int.Parse(réponse); // fait que RP prend la valeur de réponse



            if (RP == MinMDP)
            {
                int i2 = 0;
                while (i2 < 10)// si i2 inférieur à 10
                {


                    int i = 0;
                    while (NDC > i)
                    {

                        Random rand = new Random();
                        int ascii_index = rand.Next(97, 122);
                        char MinusculeT = Convert.ToChar(ascii_index);
                        Console.Write(MinusculeT);

                        i = i + 1;

                    }
                    i2 = i2 + 1;
                    Console.WriteLine("");
                }




            }

            else if (RP == MaxMDP)
            {
                int i2 = 0;
                while (i2 < 10) // si i2 inférieur à 10
                {
                    Random rand = new Random();
                    int ascii_index = rand.Next(65, 90); // randomize les caractères ascii entre 65, 90
                    char MinusculeT = Convert.ToChar(ascii_index);
                    Console.Write(MinusculeT);
                    i2 = i2 + 1;

                }

                int i = 0;
                while (NDC > i) //si i supérieur à NDC
                {
                    Random rand = new Random();
                    int ascii_index = rand.Next(65, 90);
                    char MajusculeT = Convert.ToChar(ascii_index);
                    Console.Write("\r" + MajusculeT);
                    i = i + 1;
                }
            }


            else if (RP == chiffres)
            {

                int i2 = 0;
                while (i2 < 10)// si i2 inférieur à 10
                {
                    Random rand = new Random();
                    int ascii_index = rand.Next(30, 39);
                    char MinusculeT = Convert.ToChar(ascii_index);
                    Console.Write(MinusculeT);
                    i2 = i2 + 1;

                }


                int i = 0;
                while (NDC > i)// si NDC inférieur à i
                {
                    Random rand = new Random();
                    int ascii_index = rand.Next(30, 39);
                    char chiffres1 = Convert.ToChar(ascii_index);
                    Console.Write(chiffres1);
                    i = i + 1;
                }
            }

            else if (RP == CS)
            {
                int i2 = 0;
                while (i2 < 10)// si i2 inférieur à 10
                {
                    Random rand = new Random();
                    int ascii_index = rand.Next(32, 47);
                    char MinusculeT = Convert.ToChar(ascii_index);
                    Console.Write(MinusculeT);
                    i2 = i2 + 1;

                }

                int i = 0;
                while (NDC > i)// si NDC inférieur à i
                {
                    Random rand = new Random();
                    int ascii_index = rand.Next(32, 47);
                    char CaracSpé = Convert.ToChar(ascii_index);
                    Console.WriteLine(CaracSpé);
                    i = i + 1;
                }
            }
        }

    }
}

using System;

namespace MyApp 
{
    internal class Program
    {
        static bool PoserQuestion(int min, int max)
        {
            Random rand = new Random();
            int reponseInt = 0;

            while (true)
            {
                int a = rand.Next(min, max+1);
                int b = rand.Next(min, max+1);
                int o = rand.Next(1, 3);
                int resultatAttendu;

                if (o == 1)
                {
                    Console.Write(a + " + " + b + " = ");
                    resultatAttendu = a + b;
                }
                else
                {
                    Console.Write(a + " x " + b + " = ");
                    resultatAttendu = a * b;
                }
                string reponse = Console.ReadLine();

                try
                {
                    reponseInt = int.Parse(reponse);
                    if(reponseInt == resultatAttendu)
                    {
                        return true;
                    }
                    return false;
                }
                catch
                {
                    Console.WriteLine("Erreur: Vous devez rentrer un nombre.");
                }
            }
        }
        
        static void Main(string[] args)
        {
            const int NOMBRE_MIN = 1;
            const int NOMBRE_MAX = 10;
            const int NB_QUESTIONS = 5;
            int points = 0;
            int moyenne = NB_QUESTIONS / 2;

            for (int i = 0; i < NB_QUESTIONS; i++)
            {
                Console.WriteLine("Question n° " + (i+1) + "/" + NB_QUESTIONS);
                bool bonneReponse = PoserQuestion(NOMBRE_MIN, NOMBRE_MAX);
                if (bonneReponse)
                {
                    Console.WriteLine("Bonne réponse");
                    points++;
                }
                else
                {
                    Console.WriteLine("Mauvaise réponse");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Nombre de points : " + points);
            
            if(points == NB_QUESTIONS)
            {
                Console.WriteLine("Exellent");
            }
            else if(points == 0)
            {
                Console.WriteLine("Révisez vos maths");
            }
            else if (points > moyenne)
            {
                Console.WriteLine("pas mal");
            }
            else if(points <= moyenne)
            {
                Console.WriteLine("Peux mieux faire");
            }
        }
    }
}
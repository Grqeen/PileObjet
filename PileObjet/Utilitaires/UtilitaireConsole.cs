using MesOutils;
using System;

namespace Utilitaires
{
    public abstract class UtilitaireConsole
    {
        public static int SaisirNb()
        {

            int temp = 0;
            bool isNumber = false;
            do
            {
                Console.WriteLine("Saisisez un nombre entier :");
                try
                {
                    temp = Convert.ToInt32(Console.ReadLine());
                    isNumber = true;


                }
                catch (FormatException) { }

            } while (!isNumber);
            return temp;






        }

        public static int SaisirNb(int pMin)
        {
            int nb = 0;
            do
            {

                try
                {
                    Console.WriteLine("Veuillez saisir un nombre entier supérieur à " + pMin + " : ");
                    nb = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException) { }


            }
            while (nb < pMin);
            return nb;
        }



        public static int SaisirNb(int pMin, int pMax)
        {
            int nb = 0;
            do
            {

                try
                {
                    Console.WriteLine("Veuillez saisir un nombre entier entre " + pMin + " et " + pMax + " : ");
                    nb = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException) { }


            }
            while (nb < pMin || nb > pMax);
            return nb;
        }

        public static string Convertir(int pNbAConvertir, int newbase)
        {
            if (pNbAConvertir <= 0)
            {
                throw new Exception("Le nombre à convertir doit être strictement positif");
            }
            if (newbase < 2 || newbase > 16)
            {
                throw new Exception("La nouvelle base doit être comprise entre 2 et 16");
            }

            int resultat = pNbAConvertir;
            int reste;
            Pile<int> unePile = new Pile<int>();

            while (resultat != 0)
            {
                reste = resultat % newbase;
                resultat = resultat / newbase;
                unePile.Empiler(reste);
            }


            string message = "";
            while (!unePile.PileVide())
            {
                int retour = unePile.Depiler();
                if (retour < 10)
                {
                    message += Convert.ToChar(48 + retour);
                }
                else
                {
                    message += Convert.ToChar(55 + retour);
                }
            }

            return message;
        }

        public static string InversePhraseMieux(string phrase)
        {
            String message = "";
            var tab = phrase.Split(' ');
            foreach (string mot in tab)
            {
                message = " " + mot + message;
            }
            return message;
        }
    }
}

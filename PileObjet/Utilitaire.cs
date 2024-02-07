using System;

namespace Utilitaires
{
    public abstract class Utilitaire
    {
        public static int SaisirNb()
        {
            Type type = typeof(int); 
            
            Console.WriteLine("Saisisez un nombre entier :");
            string nb = Console.ReadLine();
            
            if (nb.GetType().Equals(type))
            {
                Console.WriteLine("ok");
            }
            else
            {
                return nb; 
            }


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
    }
}

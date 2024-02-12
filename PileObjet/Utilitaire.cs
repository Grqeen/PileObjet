using System;

namespace Utilitaires
{
    public abstract class Utilitaire
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
                    
                    
                }catch(FormatException) { }
                            
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
    }
}

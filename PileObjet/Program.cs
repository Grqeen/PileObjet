using PileObjet.Tests;
using System;
using Utilitaires;

namespace PileObjet
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                //TestPile.TestePileVide();
                //TestPile.TestEmpiler();
                //TestPile.TestEmpilerDepiler();

                //// appels des méthodes de tests conversion
                //TestPile.TesteConversion();
                //TestPile.TesteConversion(154, 2);
                //TestPile.TesteConversion(11, 16);
                //TestPile.TesteConversion(2986, 16);
                //TestPile.TesteConversion(9999, 16);

                //String phrase = UtilitairesAPI.RecupereLoremIpsum(3);
                //Console.WriteLine("-----------------------------------");
                //Console.WriteLine("phrase :");
                //Console.WriteLine(phrase);
                //String phraseInversee = UtilitaireConsole.InversePhrase(phrase);
                //Console.WriteLine("\nphrase inversée : ");
                //Console.WriteLine(phraseInversee);
                //Console.WriteLine("-----------------------------------");
                TestPile.TesteInversePhrase();

                //Console.WriteLine(UtilitairesAPI.RecupereLoremIpsum(3)); ;

            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.WriteLine("Fin du programme");
            Console.ReadKey();



        }
    }

}

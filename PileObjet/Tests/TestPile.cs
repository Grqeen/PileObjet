using MesOutils;
using System;
using System.Runtime.Remoting.Messaging;
using Utilitaires;

namespace PileObjet.Tests
{
    //Les types et les membres internes (internal) sont accessibles uniquement dans
    //les fichiers d’un même projet, comme dans l’exemple suivant :
    internal abstract class TestPile
    {
        public static void TestePileVide()
        {
            Pile<int> nb = new Pile<int>();

            if (nb.PileVide())
            {
                Console.WriteLine("la pile est vide");
            }
            else
            {
                Console.WriteLine("La pile n'est pas vide");
            }
            
        }

        public static void TestEmpiler()
        {

            Pile<int> unePile = new Pile<int>();
            unePile.Empiler(2);
            unePile.Empiler(14);
            unePile.Empiler(6);



        }

        public static void TestEmpilerDepiler()
        {
            try
            {
                Pile<int> unePile = new Pile<int>();

                unePile.Empiler(2);
                unePile.Empiler(22);
                int valeurDepilee = unePile.Depiler();
                Console.WriteLine("valeur dépilée : " + valeurDepilee);
                unePile.Empiler(17);
                valeurDepilee = unePile.Depiler();
                valeurDepilee = unePile.Depiler();
                valeurDepilee = unePile.Depiler();
                valeurDepilee = unePile.Depiler();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void TesteConversion()
        {

            Console.WriteLine("Saisie du nombre à convertir.");
            int nbAConvertir = UtilitaireConsole.SaisirNb(0);

            Console.WriteLine("Saisie de la nouvelle base. : ");
            int newBase = UtilitaireConsole.SaisirNb(2, 16);


            //Appel de la méthode surchargé TesteConversion pour effectuer la conversion

            TesteConversion(nbAConvertir, newBase);

        }

        public static void TesteConversion(int nbAConvertir, int newBase)
        {
            try
            {
                String valeurConvertie = UtilitaireConsole.Convertir(nbAConvertir, newBase);
                Console.WriteLine("valeurConvertie convertie : " + valeurConvertie);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


        static void TesteSplit()
        {
            String phrase = "Il fait toujours beau à Toulon";
            var tab = phrase.Split(' ');

            String valeurs = "rue;avenue;boulevard;place";
            tab = phrase.Split(';');
        }

        

        public static void TesteInversePhrase()
        {
            try
            {
                String phrase = UtilitairesAPI.RecupereLoremIpsum(3);                
                Console.WriteLine(phrase);
                String phraseInversee = UtilitairesAPI.InversePhrase(phrase);
                Console.WriteLine("\n Version Pile");
                Console.WriteLine(phraseInversee);
                phraseInversee = UtilitaireConsole.InversePhraseMieux(phrase);
                Console.WriteLine("\n Version Améliorée");
                Console.WriteLine(phraseInversee);

              
            }catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }

       
    }
}

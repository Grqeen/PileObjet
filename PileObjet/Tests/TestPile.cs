using MesOutils;
using System;
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
            //if (nb.PilePleine())
            //{
            //    Console.WriteLine("La pile est pleine");
            //}
            //else
            //{
            //    Console.WriteLine("La pile n'est pas pleine");
            //}
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
            int nbAConvertir = Utilitaire.SaisirNb(0);

            Console.WriteLine("Saisie de la nouvelle base. : ");
            int newBase = Utilitaire.SaisirNb(2, 16);


            //Appel de la méthode surchargé TesteConversion pour effectuer la conversion

            TesteConversion(nbAConvertir, newBase);

        }

        public static void TesteConversion(int nbAConvertir, int newBase)
        {
            try
            {
                String valeurConvertie = Utilitaire.Convertir(nbAConvertir, newBase);
                Console.WriteLine("valeurConvertie convertie : " + valeurConvertie);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}

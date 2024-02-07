using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitaires;

namespace MesOutils
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {

                //TestePileVidePleine(5);
                //TestePileVidePleine(0);
                //TestEmpiler(5);
                //TestEmpiler(2);
                //TestEmpilerDepiler(5);            
                //int nbSaisi = Utilitaire.SaisirNb();
                //Console.WriteLine("Nombre saisi : " + nbSaisi);
                //nbSaisi = Utilitaire.SaisirNb(10);
                //Console.WriteLine("Nombre saisi : " + nbSaisi);
                //nbSaisi = Utilitaire.SaisirNb(10, 30);
                //Console.WriteLine("Nombre saisi : " + nbSaisi);
                TesteConversion();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

            Console.WriteLine("Fin du programme, Appuyez sur une touche pour terminer");
            Console.ReadKey();
        }

        static void TestePileVidePleine(int nbElements)
        {
            Pile nb = new Pile(nbElements);

            if (nb.PileVide())
            {
                Console.WriteLine("la pile est vide");
            }
            else
            {
                Console.WriteLine("La pile n'est pas vide");
            }
            if (nb.PilePleine())
            {
                Console.WriteLine("La pile est pleine");
            }
            else
            {
                Console.WriteLine("La pile n'est pas pleine");
            }
        }

        static void TestEmpiler(int nbElements)
        {

            Pile unePile = new Pile(nbElements);           
            unePile.Empiler(2);
            unePile.Empiler(14);
            unePile.Empiler(6);



        }

        static void TestEmpilerDepiler(int nbElements)
        {
            try
            {
                Pile unePile = new Pile(nbElements);
                
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

        static string Convertir(int pNbElements, int pNbAConvertir, int pNewbase)
        {

            int resultat = pNbAConvertir;
            int reste;
            Pile unePile = new Pile(pNbElements);           

            while (resultat != 0)
            {
                reste = resultat % pNewbase;
                resultat = resultat / pNewbase;
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

        static void TesteConversion()
        {
            try
            {
                int nbSaisiP = Utilitaire.SaisirNb();
                Console.WriteLine("Nombre d'éléments maximum de la pile saisie : " + nbSaisiP);
                

                int nbSaisiC = Utilitaire.SaisirNb(0);
                Console.WriteLine("Nombre à convertir saisie : " + nbSaisiC);
                

                int nbSaisiB = Utilitaire.SaisirNb(2, 16);
                Console.WriteLine("Nouvelle base saisie :" + nbSaisiB);
                

                string resultat = Convertir(nbSaisiP, nbSaisiC, nbSaisiB);
                Console.WriteLine($"Le nombre converti est : {resultat}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
    
}

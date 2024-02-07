using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                TestEmpilerDepiler(5);
                //TesteConversion();

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
            Pile test = new Pile(nbElements);

            if (test.PileVide())
            {
                Console.WriteLine("la pile est vide");
            }
            else
            {
                Console.WriteLine("La pile n'est pas vide");
            }
            if (test.PilePleine())
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
    }
    
}

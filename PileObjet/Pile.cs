using System;
using System.Collections.Generic;

namespace MesOutils
{
    /// <summary>
    /// Pile contenant pouvant contenir des entiers.
    /// On ajoute après le dernier élément ajouté
    /// On retire toujours le dernier élément ajouté
    /// </summary>
     class Pile
    {
        /// <summary>
        /// Nombre maximum d'élements de la Pile
        /// </summary>
        private int nbMaxElt;

        /// <summary>
        /// Liste contenant les éléments de la pile
        /// </summary>
        private List<int> elements;

        public Pile(int nbMaxElt)
        {
            this.nbMaxElt = nbMaxElt;
            this.elements = new List<int>();
        }


        public bool PilePleine()
        {
            return (this.nbMaxElt == this.elements.Count);
        }

        public bool PileVide()
        {
            return this.elements.Count == 0;
        }

        public void Empiler(int nb)
        {
            if (!PilePleine())
            {
                this.elements.Add(nb);
            }
            else
            {
                throw new Exception("Pile pleine, impossible d'empiler un élément");
            }
        }

        public int Depiler()
        {
            if (PileVide())
            {
                throw new Exception("Impossible de Dépiler , la pile est déjà vide");
            }
            else
            {


                int valeurDepilee = this.elements[this.elements.Count - 1];

                this.elements.RemoveAt(this.elements.Count - 1);

                return valeurDepilee;
            }



        }


    }
}

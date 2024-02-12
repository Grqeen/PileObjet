using System;
using System.Collections.Generic;

namespace MesOutils
{
    /// <summary>
    /// Pile contenant pouvant contenir des entiers.
    /// On ajoute après le dernier élément ajouté
    /// On retire toujours le dernier élément ajouté
    /// </summary>
    class Pile<T>
    {


        /// <summary>
        /// Liste contenant les éléments de la pile
        /// </summary>
        private List<T> elements;

        public Pile()
        {
            this.elements = new List<T>();
        }


        public bool PileVide()
        {
            return this.elements.Count == 0;
        }

        public void Empiler(T nb)
        {

            this.elements.Add(nb);


        }

        public T Depiler()
        {
            if (PileVide())
            {
                throw new Exception("Impossible de Dépiler , la pile est déjà vide");
            }
            else
            {


                T valeurDepilee = this.elements[this.elements.Count - 1];

                this.elements.RemoveAt(this.elements.Count - 1);

                return valeurDepilee;
            }



        }

        public int Count { get => this.elements.Count; }


    }
}

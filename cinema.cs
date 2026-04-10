using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salles
{
    class Cinema
    {
        //déclarer la collection des salles,ici on suppose qu'un cinéma n'a qu'une seule salle!!
        //en tant que propriétés accessibles sur la classe : collSalles

        private int id;
        private string nom;
        //déclarer la propriété privée représentant la collection de films projetés appelée maCollFilm

        public Cinema(int id, string nom)
        {
             //implémenter le constructeur
             //complèter ici

        }
        public int IdSalle
        {
            get { return id; }
            set { id = value; }
        }
        
        public string NomSalle
        {
            get { return nom; }
            set { nom = value; }
        }
        public ???? MesFilms
        {
            get { return maCollFilm; }
            set { maCollFilm = value; }
        }

        public int TotalSalle()
        {
           //calcul des recettes globales pour une salle : pour tous les films projetés
            //complèter ici

        }

        public string SalleRentable()
        {
         //vérifier si le CA pour tous les films est supérieur aux montants réglés pour tous les films
         //complèter ici Retour OUI si rentable et NON autrement


        }
		public void AjouterUnFilm(Film UnFilm)
        {
           //ajouter un film aux film projetés dans la salle
                     //complèter ici
           
        }
    }
}

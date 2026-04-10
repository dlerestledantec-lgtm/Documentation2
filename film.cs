using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salles
{
    class Film
    {
        //déclarer la collection des films en tant que propriétés accessibles sur la classe : collFilms

        private int id;
        private string nom;
        private int cout;
        //déclarer la propriété privée représentant la collection de film appelée maCollSeance

        public Film(int id, string nom, int cout)
        { 
                   //implémenter le constructeur
                     //complèter ici
           

        }
        public int IdFilm
        {
            get { return id; }
            set { id = value; }
        }

        public string NomFilm
        {
            get { return nom; }
            set { nom = value; }
        }

        public int CoutFilm
        {
            get { return cout; }
            set { cout = value; }
        }

        public ??????? MesSeance
        {
            get { return maCollSeance; }
            set { maCollSeance = value; }
        }
        
        public int TotalFilm()
        {
           //calculer le CA réalisé sur l'ensemble des séances pour un film
                    //complèter ici

        }

        public string FilmRentable()
        {
            //vérifier si le CA pour le film est supérieur aux montants réglés pour le film
                    //complèter ici

        }

        public int GainFilm()
        {
           //calculer le gain ou bénéfice pour chaque film (CA -coût)
                     //complèter ici
           
        }
		 public void AjouterUneSeance(Seance uneSeance)
        {
           //ajouter une séance aux séances projetées dans la salle
                     //complèter ici
           
        }
    }
}

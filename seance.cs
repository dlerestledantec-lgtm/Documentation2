using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salles
{
    class Seance
    {
        //déclarer la collection des séances en tant que propriétés accessible sur la classe : collSeances

        private int id;
        private string date;
        private int prix;
        private int nbreClients;

        public Seance(int id, string date, int prix, int nbreClients)
        {
            //implémenter le constructeur
         //complèter ici

        }
        public int IdSeance
        {
            get { return id; }
            set { id = value; }
        }

        public string DateSeance
        {
            get { return date; }
            set { date = value; }
        }

        public int PrixSeance
        {
            get { return prix; }
            set { prix = value; }
        }

        public int NbreClientsSeance
        {
            get { return nbreClients; }
            set { nbreClients = value; }
        }

        public int TotalSeance()
        {   // implémenter le CA total en une séance en fonction du prix payé et du nombre de spectateurs
            //complèter ici

        }   
    }
}

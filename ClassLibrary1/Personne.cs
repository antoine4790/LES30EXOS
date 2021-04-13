using System;

namespace ClassLibrary1
{
    public class Personne
    {
        public string nom;
        public string prenom;
        public DateTime dateNaissance;

        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }

        public void MajPrenom() {
            Nom = Nom.ToUpper();
        }
    }
}

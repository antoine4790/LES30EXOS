using System;
using ClassLibrary1;

namespace ExosClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(1988,10,11);
            Personne personne = new Personne() { Nom = "Leleu", Prenom = "Antoine", DateNaissance = date };

            //Exo32
            personne.MajPrenom();
            Console.WriteLine(personne.Nom);
            Console.WriteLine(personne.Prenom);
            Console.WriteLine(personne.DateNaissance);


        }
    }
}

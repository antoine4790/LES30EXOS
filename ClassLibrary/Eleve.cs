using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Eleve
    {
        private string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 18 )
                    throw new InvalidAgeException($"L'age entré ({value})est invalide car inférieur à 18");
                else if (value > 26)
                    throw new InvalidAgeException($"L'age entré ({value})est invalide car supérieur à 26");
                else
                    age = value;
            }
        }

        private double moyenne;

        public double Moyenne
        {
            get { return moyenne; }
            set
            {
                if (value < 0 )
                    throw new InvalidAgeException($"La moyenne entrée ({value})est invalide car inférieure à 0");
                else if (value>20)
                    throw new InvalidAgeException($"La moyenne entrée ({value})est invalide car supérieure à 20");
                else
                    moyenne = value;
            }
        }

        public Eleve(string nom, int age, double moyenne)
        {
            Nom = nom;
            Age = age;
            Moyenne = moyenne;
        }

    }
}

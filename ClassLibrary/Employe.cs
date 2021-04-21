using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Employe : Personne, ITravailleur
    {
        
        private double _salaire;

        public Employe(string nom, string prenom, DateTime date, double salaire): base(nom,prenom,date)
        {
            _salaire = salaire;
        }

        public double GetSalaire()
        {
            return _salaire;
        }

        public void SetSalaire(double value)
        {
            _salaire = value;
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", base.ToString(), GetSalaire());
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine("Salaire de l'employé : {0}", GetSalaire());
            Console.WriteLine();
        }
    }
}

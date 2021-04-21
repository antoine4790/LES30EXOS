using System;


namespace ClassLibrary
{
    public class Personne : ITravailleur, IEquatable<Personne>, IComparable<Personne>
    {
        public static string test ="HelloWorld";
        
        private string nom;
        private string prenom;
        private DateTime dateNaissance;

        public Personne(string nom, string prenom, DateTime dateNaissance)
        {
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
        }

        public Personne()
        {
        }

        public string Nom {get;  set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }

        public virtual void MajPrenom() {
            Prenom = Prenom.ToUpper();
        }

        public override string ToString()
        {
            //return $"{base.ToString()}    {Nom}  {Prenom}  {DateNaissance}";
            return $"{Nom}  {Prenom}  {DateNaissance}";
        }

        public virtual void Afficher()
        {
            Console.WriteLine($"Nom : {Nom} Prenom : {Prenom}");
            Console.WriteLine($"Date de Naissance : {DateNaissance}");
        }

        public bool Equals(Personne other)
        {
            if (Nom == other.Nom && Prenom==other.Prenom)
            {
                return true;
            }
            else
                return false;
            throw new NotImplementedException();
        }

        public int CompareTo(Personne other)
        {
            return Nom.CompareTo(other.Nom);
            throw new NotImplementedException();
        }
    }
}

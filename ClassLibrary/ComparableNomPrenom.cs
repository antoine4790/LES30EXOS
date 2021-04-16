using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ComparableNomPrenom : IComparer<Personne>
    {
        public int Compare(Personne x, Personne y)
        {
            var result = x.Nom.CompareTo(y.Nom);
            if (result == 0) result= x.Prenom.CompareTo(y.Prenom);
            return result;
            throw new NotImplementedException();
        }
    }
}

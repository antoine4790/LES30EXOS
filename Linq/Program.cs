using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using static ClassLibrary.SampleDatas;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Somme de d'une liste d'entiers!");
            //List<int> numberlist = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 10, 9 };
            //int somme = numberlist.Sum(p => p);
            //Console.WriteLine(somme);

            //double moyenne = numberlist.Average(p => p);
            //Console.WriteLine(moyenne);

            //List<int> filterlist = numberlist.Where(p => p > 6).ToList();
            //Console.WriteLine(String.Join(" ", filterlist));

            //int count = numberlist.Count();
            //Console.WriteLine(count);

            //Exos sur la liste de Personnes
            List<Personne> personnes = GetSamplePersonnes();
            //Console.WriteLine(String.Join(" ", personnes));
            
            //Exo 5
            //Console.WriteLine(String.Join(" ", personnes.OrderBy(p => p.Nom).ToList()));
            //personnes= personnes.OrderBy(p => p.Prenom).ToList();
            //Console.WriteLine(String.Join(" ", personnes));
            //personnes = personnes.OrderBy(p => p.Nom).ThenBy(p => p.Prenom).ToList();
            //Console.WriteLine(String.Join(" ", personnes));
            
            //Exo 6
            //List<string> nomsPersonnes = personnes.Where(p => p.Nom.StartsWith("D")).Select(p => p.Nom).ToList();
            //Console.WriteLine(String.Join(" ", nomsPersonnes));

            //Exo 7
            //List<string> nomsPersonnes = personnes.Select(p => p.Nom).ToList();
            //Console.WriteLine(String.Join(" ", nomsPersonnes));
        }
    }
}

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

            //Exo 8
            //var nomsPersonnes = personnes.Where(p => p.Nom.StartsWith("D")).
            //    OrderByDescending(p => p.Prenom).
            //    Select(p => new { nom = p.Nom.ToUpper(), prenom =p.Prenom }).ToList();

            ////On recupere ici une liste avec des elements anonymes accessibles via nomList.attribut
            //foreach (var item in nomsPersonnes)
            //{
            //    Console.WriteLine(item);
            //    //Console.WriteLine(item.prenom);
            //}
            ////Console.WriteLine(String.Join(" ", nomsPersonnes));

            //Exo9
            //List<Personne> nomsPersonnes = personnes.Take(2).ToList();
            //Console.WriteLine(String.Join(" ", nomsPersonnes));

            //Exo10
            //Console.WriteLine(String.Join(" ", personnes));
            //List<Personne> nomsPersonnes = personnes.Skip(6).Take(3).ToList();
            //Console.WriteLine("");
            //Console.WriteLine(String.Join(" ", nomsPersonnes));

            //Exo11
            //List<Personne> prenomsD = personnes.Where(p => p.Prenom == "Dupont").ToList();
            //if (prenomsD.Count() == 0) Console.WriteLine("Aucun Prenom correspondant à Dupont");
            //List<Personne> nomsD = personnes.Where(p => p.Nom == "Dupont").ToList();
            //if (nomsD.Count() == 0) Console.WriteLine("Aucun Nom correspondant à Dupont");
            //Console.WriteLine(String.Join(" ", nomsD));

            //Exo12
            //if (personnes.Any(p => p.Prenom.StartsWith("D")))
            //{
            //    Console.WriteLine("Une personne a le prenom qui commence par D");
            //}

            //Exo13
            var groupedbyprenoms = personnes.GroupBy( p => p.Prenom).ToList();
            foreach (var item in groupedbyprenoms)
            {
                Console.WriteLine(item.Key);
                //Console.WriteLine(item.prenom);
            }

        }
    }
}

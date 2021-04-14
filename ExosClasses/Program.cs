using System;
using static System.Console;
using ClassLibrary;
using System.Collections.Generic;

namespace ExosClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exo 31
            //DateTime date = new DateTime(1988,10,11);
            //Personne personne = new Personne() { Nom = "Leleu", Prenom = "Antoine", DateNaissance = date };

            //Exo32
            //personne.MajPrenom();

            //Exo33
            //static string GetStringFromCmdLine(string question = "Quelle est la valeur?")
            //{
            //    WriteLine(question);
            //    string input = Console.ReadLine();

            //    return input;
            //}

            //Console.WriteLine("Creation d'une nouvelle Personne");

            //string nom = GetStringFromCmdLine("Donnez un nom à la Personne");
            //string prenom = GetStringFromCmdLine("Donnez un prénom à la Personne");
            //string dateNaissance = GetStringFromCmdLine("Donnez une date de naissance JJ/MM/AAAA");;

            //if (DateTime.TryParse(GetStringFromCmdLine("Donnez une date de naissance JJ/MM/AAAA"), out dateNaissance))
            //    Console.WriteLine("date is ok");


            //Personne personne = new Personne() { Nom = nom, Prenom = prenom, DateNaissance = dateNaissance };
            //personne.Afficher();
            //personne.MajPrenom();
            //personne.Afficher();

            //Exo34
            //Personne personne1 = new Personne() { Nom="LELEU", Prenom = "Antoine", DateNaissance = DateTime.Now.ToShortDateString() };
            //Personne personne2 = personne1;
            //personne1.MajPrenom();
            //personne1.Afficher();
            //personne2.Afficher();

            //Exo35
            //Personne personne = new Personne();
            //Console.WriteLine("Acces à la proprieté directement : {0}", Personne.test);

            //Exo36
            string monnom = "Leleu";
            string monprenom = "Antoine";
            DateTime madate = DateTime.Now;
            double monsalaire = 3000.00;

            //Personne personne = new Personne(monnom, monprenom,madate);
            //Console.WriteLine(  personne.AfficherTravailleur(monnom, monprenom, madate));
            //Console.WriteLine(  personne.ToString());

            //Employe employe = new Employe(monnom, monprenom, madate, monsalaire);
            //Console.WriteLine(  employe.ToString());
            //Console.WriteLine(  employe.AfficherTravailleur(monnom, monprenom, madate, monsalaire));

            //Personne[] personnes = new Personne[4];
            //personnes[0] = new Personne(monnom, monprenom, madate);
            //personnes[1] = new Personne("Rueda", monprenom, madate);
            //personnes[2] = new Employe(monnom, "David", madate, monsalaire);
            //personnes[3] = new Employe(monnom, monprenom, madate, monsalaire);

            //foreach (var personne in personnes)
            //{
            //    personne.Afficher();
            //}

            //ITravailleur[] itravailleurs = new ITravailleur[4];
            //itravailleurs[0] = new Personne(monnom, monprenom, madate);
            //itravailleurs[1] = new Personne("Rueda", monprenom, madate);
            //itravailleurs[2] = new Employe(monnom, "David", madate, monsalaire);
            //itravailleurs[3] = new Employe(monnom, monprenom, madate, monsalaire);
            //foreach (var personne in itravailleurs)
            //{
            //    Console.WriteLine(  personne.AfficherTravailleur());
            //}

            //Tableaux Listes
            //int[] tableau = { 1,6,9,7,33,21,45};
            //Array.Sort(tableau);
            //foreach (var item in tableau)
            //{
            //    Console.WriteLine(item);
            //}

            //List<string> maliste = new List<string> { "coco", "abc", "zzz" };
            //maliste.Sort();
            //foreach (var item in maliste)
            //{
            //    Console.WriteLine(item);
            //}

            //List<Personne> personnes = new List<Personne> {
            //                                                new Personne("Antoine","Leleu",DateTime.Now),
            //                                                new Personne("David", "Leleu", DateTime.Now),
            //                                                new Personne("Maria", "Rueda", DateTime.Now) };

            //foreach (var item in personnes)
            //{
            //    Console.WriteLine(item);
            //}

            //Dictionaires
            //Dictionary<int, Personne> mondico = new Dictionary<int, Personne> { 
            //    { 1, new Personne("Antoine", "Leleu", DateTime.Now) },
            //    { 2, new Personne("David", "Leleu", DateTime.Now) },
            //    { 3, new Personne("Maria", "Leleu", DateTime.Now) }
            //};
            //foreach (KeyValuePair<int,Personne> item in mondico)
            //{
            //    Console.WriteLine(item.Key);
            //    Console.WriteLine(item.Value);
            //}

            //Contains avec les listes
            //List<Personne> personnes = new List<Personne> { new Personne("Leleu","Antoine",DateTime.Now),
            //                                                new Personne("Leleu","Arthur",DateTime.Now),
            //                                                new Personne("Leleu","AAAA",DateTime.Now),
            //                                                new Personne("Lala", "Jack", DateTime.Now),
            //                                                new Personne("AAAA", "David", DateTime.Now) };
            //Il faut implementer L'interface IEquatable et coder la methode equals pour pouvoir comparer 2 objets car ca n'existe pas par default
            //if (personnes.Contains(new Personne("Luke", "Antoine", DateTime.Now)))
            //{
            //    Console.WriteLine("Egalité trouvée");
            //}
            //else
            //    Console.WriteLine("Pas d'Egalité");

            //Tri de la liste par Nom
            //personnes.Sort();
            //WriteLine(string.Join("\n", personnes));
            //Console.WriteLine();

            //Tri avec IComparer en utilisant la nouvelle classe ComparableNomPrenom
            //C'est une autre manière de comparer avec sort()
            //En cas de noms égaux et de prenoms differents, le prenom sera trié
            //personnes.Sort(new ComparableNomPrenom());

            //WriteLine(string.Join("\n", personnes));

            //Test Stack et Queues
            //Stack<Personne> personnes = new Stack<Personne>(5);
            //personnes.Push(new Personne("Leleu", "Antoine", DateTime.Now));
            //personnes.Push(new Personne("Leleu", "Arthur", DateTime.Now));
            //Console.WriteLine(personnes.Peek());
            //personnes.Pop();
            //Console.WriteLine(personnes.Peek());

            Queue<Personne> personnes = new Queue<Personne>();
            personnes.Enqueue(new Personne("Leleu", "Antoine", DateTime.Now));
            Console.WriteLine(personnes.Peek());
            personnes.Enqueue(new Personne("Leleu", "Arthur", DateTime.Now));
            Console.WriteLine(personnes.Peek());
            Console.WriteLine(personnes.Dequeue());
            Console.WriteLine(personnes.Peek());
            Console.WriteLine(personnes.Dequeue());
        }
    }
}

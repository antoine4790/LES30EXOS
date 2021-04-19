using ClassLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using static ClassLibrary.SampleDatas;


namespace Classes_Linq_Exceptions
{
    public class Program
    {
        public static void Main(string[] args)
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
            //string monnom = "Leleu";
            //string monprenom = "Antoine";
            //DateTime madate = DateTime.Now;
            //double monsalaire = 3000.00;

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
            //Stack<Personne> personnes = new(5);
            //personnes.Push(new Personne("Leleu", "Antoine", DateTime.Now));
            //personnes.Push(new Personne("Leleu", "Arthur", DateTime.Now));
            //Console.WriteLine(personnes.Peek());
            //personnes.Pop();
            //Console.WriteLine(personnes.Peek());

            //Queue<Personne> personnes = new();
            //personnes.Enqueue(new Personne("Leleu", "Antoine", DateTime.Now));
            //Console.WriteLine(personnes.Peek());
            //personnes.Enqueue(new Personne("Leleu", "Arthur", DateTime.Now));
            //Console.WriteLine(personnes.Peek());
            //Console.WriteLine(personnes.Dequeue());
            //Console.WriteLine(personnes.Peek());
            //Console.WriteLine(personnes.Dequeue());

            //Exercices sur les Classes

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
            //List<Personne> personnes = GetSamplePersonnes();
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
            //    Select(p => new { nom = p.Nom.ToUpper(), prenom = p.Prenom }).ToList();
            //// dans le select on peut recuperer le nom et le prenom separement avec le nommage dans l'objet anonyme crée avec new
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
            //var groupedbyprenoms = personnes.GroupBy( p => p.Prenom).ToList();
            //foreach (var item in groupedbyprenoms)
            //{
            //    Console.WriteLine(item.Key);
            //    //Console.WriteLine(item.prenom);
            //}

            //Exceptions




            try
            {
                //OK
                Console.WriteLine(Tools.diviser(1, 9));
                //////Exception
                Console.WriteLine(Tools.diviser(9, 0));
            }
            catch(ExceptionDivision e)
            {
                Console.WriteLine($"Voici le message d'erreur : {e.Message}");
            }
            //try
            //{
            //    Eleve eleve1 = new Eleve("Antoine", 21, 10);
            //    eleve1.Age = 20;
            //    Console.WriteLine(eleve1.Age);
            //    eleve1.Moyenne = 19;
            //    Console.WriteLine(eleve1.Moyenne);
            //    eleve1.Moyenne = 21.2;
            //}
            //catch (InvalidAgeException e)
            //{
            //    Console.WriteLine($"Voici l'erreur : {e.Message} ");
            //}
            //catch (InvalidMoyenneException e)
            //{
            //    Console.WriteLine($"Voici l'erreur : {e.Message} ");
            //}

            // I/O
            //Ecrit le contenu d'une liste d'objets dans un fichier xml
            //using(var fileWritestream = new FileStream("C:\\Users\\optimum\\Documents\\fomation .NET\\person.xml", FileMode.OpenOrCreate,FileAccess.Write))
            //{
            //    var xmlSerializer = new XmlSerializer(typeof(List<Personne>));

            //    xmlSerializer.Serialize(fileWritestream, new List<Personne> { new Personne { Nom = "nom" }, new Personne { Nom = "nom2" } });
            //}

            //Lit un fichier xml  pour l'envoyer en memoire dans le programme
            //using (var fileReadstream = new FileStream("C:\\Users\\optimum\\Documents\\fomation .NET\\person.xml", FileMode.Open, FileAccess.Read))
            //{
            //    var xmlDeSerializer = new XmlSerializer(typeof(List<Personne>));

            //    var personsFromFile = (List<Personne>)xmlDeSerializer.Deserialize(fileReadstream);
            //    foreach (var item in personsFromFile)
            //    {
            //        Console.WriteLine(item);
            //    }

            //}

            //Parcours recursif des fichiers


            static void ParseAndDisplayAllFiles(DirectoryInfo DirInfo, int niveau)
            {
                niveau += 1;
                try
                {
                    foreach (var item in DirInfo.GetDirectories())
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("|");
                        for (int i = 0; i < niveau; i++)
                        {
                            Console.Write("-");
                        }
                        Console.WriteLine(item.Name);
                        ParseAndDisplayAllFiles(item, niveau);

                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine($"Voici l'erreur : {e.Message} ");
                }

                foreach (var item in DirInfo.GetFiles())
                {
                    Console.ForegroundColor = ConsoleColor.Blue;

                    if (item.Attributes != FileAttributes.Hidden)
                    {
                        Console.Write("|");
                        for (int i = 0; i < niveau; i++)
                        {
                            Console.Write("-");
                        }
                        Console.WriteLine(item.Name);
                    }

                }
            }
            Console.ReadLine();
            ////const string SOURCE_DIRECTORY = "C:\\Users\\optimum\\Documents\\fomation .NET\\";
            //const string SOURCE_DIRECTORY = "C:\\";
            //DirectoryInfo DirectoryInfo = new DirectoryInfo(SOURCE_DIRECTORY);
            //ParseAndDisplayAllFiles(DirectoryInfo, 0);
            //Console.ForegroundColor = ConsoleColor.White;

        }
    }
}

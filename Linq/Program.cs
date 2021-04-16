using ClassLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static ClassLibrary.SampleDatas;


namespace LinqEtExceptions
{
    public class Program
    {
        public static void Main(string[] args)
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

            static double diviser(double nb1, double nb2)
            {
                try
                {
                    if (nb2 != 0)
                        return nb1 / nb2;
                    else
                        throw new ExceptionDivision("Impossible de diviser par 0");
                }
                //gestion de la division par 0
                catch (Exception e)
                {
                    Console.WriteLine($"Voici l'erreur {e} .");
                    return 0;
                }

            }

            //OK
            //Console.WriteLine(diviser(1, 9));
            //////Exception
            ////Console.WriteLine( diviser(9, 0));
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

            //a faire sous linux

            //Parcours recursif des fichiers


            static void DisplayAllFiles(DirectoryInfo DirInfo, int niveau)
            {
                niveau += 1;
                //List<DirectoryInfo> dirs = new List<DirectoryInfo>(DirInfo.GetDirectories());
                try
                {
                    foreach (var item in DirInfo.GetDirectories())
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        for (int i = 0; i < niveau; i++)
                        {
                            Console.Write(".");
                        }
                        Console.WriteLine(item.Name);
                        DisplayAllFiles(item, niveau);

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
                        for (int i = 0; i < niveau; i++)
                        {
                            Console.Write(".");
                        }
                        Console.WriteLine(item.Name);
                    }

                }
            }

            const string SOURCE_DIRECTORY = "C:\\Users\\optimum\\Documents\\fomation .NET\\";
            //const string SOURCE_DIRECTORY = "C:\\";
            DirectoryInfo DirectoryInfo = new DirectoryInfo(SOURCE_DIRECTORY);
            DisplayAllFiles(DirectoryInfo, 0);
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}

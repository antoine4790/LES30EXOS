using ClassLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using static System.Console;
using static ClassLibrary.SampleDatas;
using static ClassLibrary.Tools;
using System.Globalization;

namespace Classes_Linq_Exceptions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ////Exo1
            HelloWorld();

            ////Exo2
            //WriteLine("voici votre valeur :" + GetStringFromCmdLine());
            //WriteLine("voici votre valeur :" + GetIntegerFromCmdLine());

            //////Exo3
            //WriteLine("Inverse trois mots");

            //string[] WordsArray = GetEntriesStringFromParameter(3);
            //WriteLine(SwitchOrder(WordsArray));

            ////Exo4 
            //WriteLine("Affiche si les 2 nombres sont égaux");
            //WriteLine(DisplayEqualNumbers());

            ////Exo5
            //WriteLine("Affiche inverse et affiche 2 nombres");
            //WriteLine(DisplaySwitchAndDisplay2Numbers());

            ////Exo6
            //WriteLine("Operations Addition Soustraction Division Multiplication");
            //float[] ArrayResults = AddSubstractDivideMultiple2Numbers();
            //for (int i = 0; i < ArrayResults.Length; i++)
            //{
            //    WriteLine(ArrayResults[i]);
            //}

            ////Exo7
            //WriteLine("Moyenne");
            //WriteLine("La moyenne est de " + DisplayMean());

            ////Exo8
            //WriteLine("Affiche le plus grand des nombres");
            //WriteLine("Le plus grand nombre est :" + BiggestNumber());

            ////Exo9
            //WriteLine("CheckSign");
            //GetIntegerFromCmdLine("Entrez un chiffre pour vérifier son signe", true);

            ////Exo10
            //WriteLine("Pair or not Pair");
            //int[] ArrayNumbers = GetEntriesIntegerNumberFromCmdLine();
            //for (int i = 0; i < ArrayNumbers.Length; i++)
            //{
            //    if (IsPair(ArrayNumbers[i]))
            //        WriteLine("Nombre Pair");
            //    else
            //        WriteLine("Nombre Impair");
            //}

            ////Exo11
            //WriteLine("Convert to Kelvin and Fahrenheit");
            //float[] ArrayNumbers = GetEntriesFloatNumberFromCmdLine();
            //for (int i = 0; i < ArrayNumbers.Length; i++)
            //{
            //    WriteLine(String.Format("{0}°C  donne {1}°F  et {2}°K", ArrayNumbers[i], CelsiusToFahrenheit(ArrayNumbers[i]), CelsiusToKelvin(ArrayNumbers[i])));
            //}

            ////Exo12
            //WriteLine("Day of Week");
            //WriteLine(DayOfWeek(GetIntegerFromCmdLine()));

            ////Exo13:
            //WriteLine("Enter correct password");
            //EnterPassword();

            ////Exo14
            //WriteLine("Display a arithmetic operation");
            //WriteLine(DisplayArithmeticOperation());

            ////Exo15
            //WriteLine("Display 10 first numbers");
            //int[] ArrayNumbers = ReturnTenFirstNumbers(10, true);


            ////Exo16
            //WriteLine("Display Multiplication Table Of 10");
            //DisplayTenMultiplicationTable();

            ////Exo17
            //WriteLine("Display a triangle with a letter of your choice");
            //int number = GetIntegerFromCmdLine("Entrez la taille du triangle");
            //string pattern = GetStringFromCmdLine("Motif pour dessiner le triangle?");
            //DisplayTriangle(number, pattern);

            ////Exo18
            //WriteLine("Display Pyramide");
            //int hauteur = GetIntegerFromCmdLine("Entrez la hauteur de la pyramide");
            //string pattern = GetStringFromCmdLine("Entrez le motif de la pyramide");
            //DisplayPyramide(hauteur, pattern);

            ////Exo19
            //WriteLine("Display Diamant");
            //int hauteur = GetIntegerFromCmdLine("Entrez la hauteur du diamant");
            //string pattern = GetStringFromCmdLine("Entrez le motif du diamant");
            //DisplayDiamant(hauteur, pattern);

            ////Exo 20
            //WriteLine(DateDuJourComplete());
            //WriteLine(DateDuJour());

            ////Exo 21
            //WriteLine("Entrez une date et récuperez le jour de la semaine");

            //DateTime Userdate = GetDateTimeFromCmdLine();
            //WriteLine(Userdate);

            ////Exo22
            //DateTime date1 = GetDateTimeFromCmdLine();
            //DateTime date2 = GetDateTimeFromCmdLine();
            //DateTime earlierDate = GetMinDate(date1, date2);
            //DateTime laterDate = GetMaxDate(date1, date2);


            //WriteLine("il y a {0} jours d'écart entre la date {1} et la date {2}", GetTotalDays(earlierDate, laterDate), earlierDate, laterDate);

            ////Exo23
            //string date = GetStringFromCmdLine("Entrez une date (dd/mm/yyyy)");

            //DateTime result;

            //CultureInfo frFr = new CultureInfo("fr-FR");
            ////Parse date string to check format
            //while (!DateTime.TryParseExact(date, "dd/MM/yyyy", frFr, DateTimeStyles.None, out result))
            //{
            //    WriteLine("Saisie Incorrecte");
            //    date = GetStringFromCmdLine("Entrez une date (dd/mm/yyyy)");
            //}
            //WriteLine(result.ToString());

            ////Exo24
            //WriteLine("Jeu Du Plus ou Moins");

            //int secretNumber = 13;

            //int userNumber = GetIntegerFromCmdLine("Entrez un nombre le plus proche du nombre secret");
            //int intents = 10;
            //do
            //{
            //    if (userNumber.CompareTo(secretNumber) < 0)
            //        WriteLine("Plus !"); // le chiffre entré est plus petit que le nombre secret
            //    else if (userNumber.CompareTo(secretNumber) > 0)
            //        WriteLine("Moins !"); // le chiffre entré est plus grand que le nombre secret
            //    else
            //        break;
            //    intents--;

            //} while ((userNumber = GetIntegerFromCmdLine("Entrez un nombre le plus proche du nombre secret")) != secretNumber && intents != 0);

            //if (secretNumber == userNumber)
            //    WriteLine("Vous avez deviné le nombre secret");
            //else
            //    WriteLine("Perdu , vous n'avez pas pu deviner le mot secret ! Réessayez plus tard !");

            ////Exo 25
            //WriteLine("Convertit la chaine de caractères en majuscules");
            //string userInput = GetStringFromCmdLine("Entrez une phrase ou un mot");
            //WriteLine($"Avant : {userInput}, Après : {userInput.ToUpper()}");

            ////Exo 26
            //WriteLine("Parcours de chaine de caractères ");
            //String chaine = GetStringFromCmdLine("Entrez une phrase ou un mot");
            //foreach (var item in chaine)
            //    WriteLine(item);

            ////Exo 27
            //WriteLine("Inversion d'une chaine de caractères et ajout d'espaces entre chacun");
            //String chaine = GetStringFromCmdLine("Entrez une phrase ou un mot");
            //String newChaine = "";
            //foreach (var item in chaine)
            //{
            //    WriteLine(item);
            //    newChaine = newChaine.Insert(0, $"{item.ToString()} ");
            //}
            //WriteLine(newChaine);

            ////Exo28
            //WriteLine("Egalité de chaines de caractères (Case insensitive)");
            //do
            //{
            //    String chaine1 = GetStringFromCmdLine("Entrez la premiere phrase ou le premier mot").ToUpper();
            //    String chaine2 = GetStringFromCmdLine("Entrez la deuxième phrase ou le deuxième mot").ToUpper();

            //    bool result = chaine1.Equals(chaine2);
            //    if (result)
            //        WriteLine("Les deux chaines entrées sont identiques");
            //    else
            //        WriteLine("Les deux chaines entrées sont différentes");
            //}
            //while ((GetStringFromCmdLine("Continue ? (O/N)").ToUpper()).Equals("O"));

            ////Exo 29
            //WriteLine("Est ce un palindrome ?");
            //do
            //{
            //    String chaine = GetStringFromCmdLine("Entrez un mot uniquement");

            //    string halfstring1 = chaine.Substring(0, chaine.Length / 2);
            //    string halfstring2 = ReverseString(chaine.Substring(chaine.Length / 2));

            //    if (chaine.Length % 2 != 0)
            //        halfstring2 = ReverseString(chaine.Substring(chaine.Length / 2 + 1));

            //    if (halfstring1.Equals(halfstring2))
            //        WriteLine("C'est un palindrome");
            //    else
            //        WriteLine("Ceci n'est pas un palindrome");
            //}
            //while ((GetStringFromCmdLine("Continue ? (O/N)").ToUpper()).Equals("O"));

            ////Exo 30
            //WriteLine("Liste de 1 à 100 et Remplacement par Fizz,Buzz ou FizzBuzz selon le resultat du modulo");
            //List<string> listModified = new List<string>();
            //for (int nb = 1; nb < 101; nb++)
            //{
            //    if (nb % 3 == 0 && nb % 5 == 0) Console.Write("FizzBuzz ");
            //    else if (nb % 3 == 0) Console.Write("Fizz ");
            //    else if (nb % 5 == 0) Console.Write("Buzz ");
            //    else Console.Write($"{nb} ");
            //    if (nb % 9 == 0) WriteLine();

            //}

            ////Exo 31
            //DateTime date = new DateTime(1988, 10, 11);
            //Personne personne = new Personne() { Nom = "Leleu", Prenom = "Antoine", DateNaissance = date };

            ////Exo32
            //personne.MajPrenom();

            ////Exo33
            //WriteLine("Creation d'une nouvelle Personne");

            //string nom = GetStringFromCmdLine("Donnez un nom à la Personne");
            //string prenom = GetStringFromCmdLine("Donnez un prénom à la Personne");


            //if (DateTime.TryParse(GetStringFromCmdLine("Donnez une date de naissance JJ/MM/AAAA"), out DateTime dateNaissance))
            //    WriteLine("date is ok");

            //Personne personne = new Personne() { Nom = nom, Prenom = prenom, DateNaissance = dateNaissance };
            //personne.Afficher();
            //personne.MajPrenom();
            //personne.Afficher();

            ////Exo34
            //WriteLine("Creation d'une Personne et Copie par reference ,mise a jour d'un attribut en majuscule");
            //Personne personne1 = new Personne() { Nom = "LELEU", Prenom = "Antoine", DateNaissance = DateTime.Now };
            //Personne personne2 = personne1;
            //personne1.Afficher();
            //personne2.Afficher();
            //personne1.MajPrenom();
            //personne1.Afficher();
            //personne2.Afficher();

            ////Exo35
            //Personne personne = new Personne();
            //WriteLine("Acces à la proprieté directement : {0}", Personne.test);

            ////Exo36
            //string monnom = "Leleu";
            //string monprenom = "Antoine";
            //DateTime madate = DateTime.Now;
            //double monsalaire = 3000.00;

            //Personne personne = new Personne(monnom, monprenom, madate);
            //personne.Afficher();
            //WriteLine();
            //WriteLine(personne.ToString());

            //Employe employe = new Employe(monnom, monprenom, madate, monsalaire);
            //WriteLine(employe.ToString());
            //employe.Afficher();

            //Tableau de Personnes
            //Personne[] personnes = new Personne[4];
            //personnes[0] = new Personne(monnom, monprenom, madate);
            //personnes[1] = new Personne("Rueda", monprenom, madate);
            //personnes[2] = new Employe(monnom, "David", madate, monsalaire);
            //personnes[3] = new Employe(monnom, monprenom, madate, monsalaire);

            //foreach (var personne in personnes)
            //{
            //    personne.Afficher();
            //}

            ////Tableau de ITravailleurs
            //ITravailleur[] itravailleurs = new ITravailleur[4];
            //itravailleurs[0] = new Personne(monnom, monprenom, madate);
            //itravailleurs[1] = new Personne("Rueda", monprenom, madate);
            //itravailleurs[2] = new Employe(monnom, "David", madate, monsalaire);
            //itravailleurs[3] = new Employe(monnom, monprenom, madate, monsalaire);
            //foreach (var personne in itravailleurs)
            //{
            //    personne.Afficher();
            //}

            ////Tableaux et Listes
            //int[] tableau = { 1, 6, 9, 7, 33, 21, 45 };
            //Array.Sort(tableau);
            //foreach (var item in tableau)
            //{
            //    WriteLine(item);
            //}

            //List<string> maliste = new List<string> { "coco", "abc", "zzz" };
            //maliste.Sort();
            //foreach (var item in maliste)
            //{
            //    WriteLine(item);
            //}

            //List<Personne> personnes = new List<Personne> { new Personne("Antoine","Leleu",DateTime.Now),
            //                                                new Personne("David", "Leleu", DateTime.Now),
            //                                                new Personne("Maria", "Rueda", DateTime.Now) };

            //foreach (var item in personnes)
            //{
            //    WriteLine(item);
            //}

            //Dictionaires
            //Dictionary<int, Personne> mondico = new Dictionary<int, Personne> {
            //    { 1, new Personne("Antoine", "Leleu", DateTime.Now) },
            //    { 2, new Personne("David", "Leleu", DateTime.Now) },
            //    { 3, new Personne("Maria", "Leleu", DateTime.Now) }
            //};
            //foreach (KeyValuePair<int, Personne> item in mondico)
            //{
            //    WriteLine(item.Key);
            //    WriteLine(item.Value);
            //}

            //Methode Contains avec les listes
            //List<Personne> personnes = new List<Personne> { new Personne("Leleu","Antoine",DateTime.Now),
            //                                                new Personne("Leleu","Arthur",DateTime.Now),
            //                                                new Personne("Leleu","AAAA",DateTime.Now),
            //                                                new Personne("Lala", "Jack", DateTime.Now),
            //                                                new Personne("AAAA", "David", DateTime.Now) };
            ////Il faut implementer L'interface IEquatable et coder la methode equals pour pouvoir comparer 2 objets car ca n'existe pas par default
            //if (personnes.Contains(new Personne("Luke", "Antoine", DateTime.Now)))
            //{
            //    WriteLine("Egalité trouvée");
            //}
            //else
            //    WriteLine("Pas d'Egalité");

            ////Tri de la liste par Nom
            //personnes.Sort();
            //WriteLine(string.Join("\n", personnes));
            //WriteLine();

            ////Tri avec IComparer en utilisant la nouvelle classe ComparableNomPrenom
            ////C'est une autre manière de comparer avec sort()
            ////En cas de noms égaux et de prenoms differents, le prenom sera trié
            //personnes.Sort(new ComparableNomPrenom());

            //WriteLine(string.Join("\n", personnes));

            ////Test Stack et Queues
            //Stack<Personne> personnesStack = new(5);
            //personnesStack.Push(new Personne("Leleu", "Antoine", DateTime.Now));
            //personnesStack.Push(new Personne("Leleu", "Arthur", DateTime.Now));
            //WriteLine(personnesStack.Peek());
            //personnesStack.Pop();
            //WriteLine(personnesStack.Peek());

            //Queue<Personne> personnesQueue = new();
            //personnesQueue.Enqueue(new Personne("Leleu", "Antoine", DateTime.Now));
            //WriteLine(personnesQueue.Peek());
            //personnesQueue.Enqueue(new Personne("Leleu", "Arthur", DateTime.Now));
            //WriteLine(personnesQueue.Peek());
            //WriteLine(personnesQueue.Dequeue());
            //WriteLine(personnesQueue.Peek());
            //WriteLine(personnesQueue.Dequeue());

            ////Exercices Linq

            //WriteLine("Somme de d'une liste d'entiers!");
            //List<int> numberlist = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 10, 9 };
            //int somme = numberlist.Sum(p => p);
            //WriteLine(somme);

            //double moyenne = numberlist.Average(p => p);
            //WriteLine(moyenne);

            //List<int> filterlist = numberlist.Where(p => p > 6).ToList();
            //WriteLine(String.Join(" ", filterlist));

            //int count = numberlist.Count();
            //WriteLine(count);

            ////Exos Linq sur la liste de Personnes
            //List<Personne> personnesLinq = GetSamplePersonnes();
            //WriteLine(String.Join(" ", personnesLinq));

            ////Exo 5
            //WriteLine(String.Join(" ", personnesLinq.OrderBy(p => p.Nom).ToList()));
            //personnesLinq = personnesLinq.OrderBy(p => p.Prenom).ToList();
            //WriteLine(String.Join(" ", personnesLinq));
            //personnesLinq = personnesLinq.OrderBy(p => p.Nom).ThenBy(p => p.Prenom).ToList();
            //WriteLine(String.Join(" ", personnesLinq));

            ////Exo 6
            //List<string> nomsPersonnes = personnesLinq.Where(p => p.Nom.StartsWith("D")).Select(p => p.Nom).ToList();
            //WriteLine(String.Join(" ", nomsPersonnes));

            ////Exo 7
            //List<string> nomsPersonnes = personnesLinq.Select(p => p.Nom).ToList();
            //WriteLine(String.Join(" ", nomsPersonnes));

            ////Exo 8
            //var nomsPersonnes = personnesLinq.Where(p => p.Nom.StartsWith("D")).
            //    OrderByDescending(p => p.Prenom).
            //    Select(p => new { nom = p.Nom.ToUpper(), prenom = p.Prenom }).ToList();
            //// dans le select on peut recuperer le nom et le prenom separement avec le nommage dans l'objet anonyme crée avec new
            ////On recupere ici une liste avec des elements anonymes accessibles via nomList.attribut
            //foreach (var item in nomsPersonnes)
            //{
            //    WriteLine(item);
            //    //WriteLine(item.prenom);
            //}

            ////Exo9
            //List<Personne> nomsPersonnes = personnesLinq.Take(2).ToList();
            //WriteLine(String.Join(" ", nomsPersonnes));

            ////Exo10
            //WriteLine(String.Join(" ", personnesLinq));
            //List<Personne> nomsPersonnes = personnesLinq.Skip(6).Take(3).ToList();
            //WriteLine("");
            //WriteLine(String.Join(" ", nomsPersonnes));

            ////Exo11
            //List<Personne> prenomsD = personnesLinq.Where(p => p.Prenom == "Dupont").ToList();
            //if (prenomsD.Count() == 0) WriteLine("Aucun Prenom correspondant à Dupont");
            //List<Personne> nomsD = personnesLinq.Where(p => p.Nom == "Dupont").ToList();
            //if (nomsD.Count() == 0) WriteLine("Aucun Nom correspondant à Dupont");
            //WriteLine(String.Join(" ", nomsD));

            ////Exo12
            //if (personnesLinq.Any(p => p.Prenom.StartsWith("D")))
            //{
            //    WriteLine("Une personne a le prenom qui commence par D");
            //}

            ////Exo13
            //var groupedbyprenoms = personnesLinq.GroupBy(p => p.Prenom).ToList();
            //foreach (var item in groupedbyprenoms)
            //{
            //    WriteLine(item.Key);
            //    //WriteLine(item.prenom);
            //}

            ////Exceptions

            //try
            //{
            //    //OK
            //    WriteLine(Tools.diviser(1, 9));
            //    //////Exception
            //    WriteLine(Tools.diviser(9, 0));
            //}
            //catch (ExceptionDivision e)
            //{
            //    WriteLine($"Voici le message d'erreur : {e.Message}");
            //}

            //try
            //{
            //    Eleve eleve1 = new Eleve("Antoine", 21, 10);
            //    eleve1.Age = 20;
            //    WriteLine(eleve1.Age);
            //    eleve1.Moyenne = 19;
            //    WriteLine(eleve1.Moyenne);
            //    eleve1.Moyenne = 21.2;
            //}
            //catch (InvalidAgeException e)
            //{
            //    WriteLine($"Voici l'erreur : {e.Message} ");
            //}
            //catch (InvalidMoyenneException e)
            //{
            //    WriteLine($"Voici l'erreur : {e.Message} ");
            //}

            //// I/O
            ////Ecrit le contenu d'une liste d'objets dans un fichier xml
            //List<Personne> personnes = new List<Personne> { new Personne("Leleu","Antoine",DateTime.Now),
            //                                                new Personne("Leleu","Arthur",DateTime.Now),
            //                                                new Personne("Leleu","AAAA",DateTime.Now),
            //                                                new Personne("Lala", "Jack", DateTime.Now),
            //                                                new Personne("AAAA", "David", DateTime.Now) };

            ////FileMode à Create pour écraser l'ancien contenu
            //var fileMode = FileMode.Create;
            //string fileName = Tools.GetStringFromCmdLine("Entrez le nom du fichier à créer");
            //string rootPath = "C:\\Users\\optimum\\Documents\\fomation .NET";

            //try
            //{
            //    using (var fileWritestream = new FileStream($"{rootPath}\\{fileName}", fileMode, FileAccess.Write))
            //    {
            //        var xmlSerializer = new XmlSerializer(typeof(List<Personne>));

            //        WriteLine($"Ecriture dans le fichier {fileName}");
            //        //xmlSerializer.Serialize(fileWritestream, new List<Personne> { new Personne { Nom = "nom" }, new Personne { Nom = "nom2" } });
            //        xmlSerializer.Serialize(fileWritestream, personnes);
            //    }
            //}
            //catch (UnauthorizedAccessException e)
            //{
            //    WriteLine($"Le fichier {fileName} est un fichier caché");
            //    WriteLine($"Voici l'erreur : {e.Message}");

            //}

            ////Lit un fichier xml  pour l'envoyer en memoire dans le programme
            //try
            //{
            //    fileMode = FileMode.Open;
            //    using (var fileReadstream = new FileStream($"{rootPath}\\{fileName}", fileMode, FileAccess.Read))
            //    {
            //        var xmlDeSerializer = new XmlSerializer(typeof(List<Personne>));

            //        var personsFromFile = (List<Personne>)xmlDeSerializer.Deserialize(fileReadstream);
            //        WriteLine($"Lecture du contenu fichier :{fileName}");
            //        foreach (var item in personsFromFile)
            //        {
            //            WriteLine(item);
            //        }

            //    }
            //}
            //catch (FileNotFoundException e)
            //{
            //    WriteLine($"Le fichier {fileName} n'existe pas");
            //    WriteLine($"Voici l'erreur : {e.Message}");
            //}


            ////Parcours recursif des fichiers


            //static void ParseAndDisplayAllFiles(DirectoryInfo DirInfo, int niveau)
            //{
            //    niveau += 1;
            //    try
            //    {
            //        foreach (var item in DirInfo.GetDirectories())
            //        {
            //            Console.ForegroundColor = ConsoleColor.Green;
            //            Console.Write("|");
            //            for (int i = 0; i < niveau; i++)
            //            {
            //                Console.Write("-");
            //            }
            //            WriteLine(item.Name);
            //            ParseAndDisplayAllFiles(item, niveau);

            //        }
            //    }
            //    catch (Exception e)
            //    {

            //        WriteLine($"Voici l'erreur : {e.Message} ");
            //    }

            //    foreach (var item in DirInfo.GetFiles())
            //    {
            //        Console.ForegroundColor = ConsoleColor.Blue;

            //        if (item.Attributes != FileAttributes.Hidden)
            //        {
            //            Console.Write("|");
            //            for (int i = 0; i < niveau; i++)
            //            {
            //                Console.Write("-");
            //            }
            //            WriteLine(item.Name);
            //        }

            //    }
            //}
            //Console.ReadLine();
            ////const string SOURCE_DIRECTORY = "C:\\Users\\optimum\\Documents\\fomation .NET\\";
            //const string SOURCE_DIRECTORY = "C:\\";
            //DirectoryInfo DirectoryInfo = new DirectoryInfo(SOURCE_DIRECTORY);
            //ParseAndDisplayAllFiles(DirectoryInfo, 0);
            //Console.ForegroundColor = ConsoleColor.White;

        }
    }
}

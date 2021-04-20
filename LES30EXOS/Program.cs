using System;
using System.Collections.Generic;
using System.Globalization;
using static System.Console;

namespace LES30EXOS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exo1
            //HelloWorld();

            //Exo2
            //WriteLine("voici votre valeur :" + GetStringFromCmdLine());
            //WriteLine("voici votre valeur :" + GetIntegerFromCmdLine());

            //Exo3
            //WriteLine("Inverse trois mots");

            //string[] WordsArray = GetEntriesStringsFromParameter(3);
            //WriteLine(SwitchOrder(WordsArray));

            //Exo4 
            //WriteLine("Affiche si les 2 nombres sont égaux");
            //WriteLine(DisplayEqualNumbers());

            //Exo5
            //WriteLine("Affiche inverse et affiche 2 nombres");
            //WriteLine(DisplaySwitchAndDisplay2Numbers());

            //Exo6
            //WriteLine("Operations Addition Soustraction Division Multiplication");
            //float[] ArrayResults= AddSubstractDivideMultiple2Numbers();
            //for (int i = 0; i < ArrayResults.Length; i++)
            //{
            //    WriteLine(ArrayResults[i]);
            //}

            //Exo7
            //WriteLine("Moyenne");
            //WriteLine("La moyenne est de " + DisplayMean());

            //Exo8
            //WriteLine("Affiche le plus grand des nombres");
            //WriteLine("Le plus grand nombre est :" + BiggestNumber());

            //Exo9
            //WriteLine("CheckSign");
            //GetIntegerFromCmdLine("Entrez un chiffre pour vérifier son signe", true);

            //Exo10
            //WriteLine("Pair or not Pair");
            //int[] ArrayNumbers = GetEntriesIntegerNumberFromCmdLine();
            //for (int i = 0; i < ArrayNumbers.Length; i++)
            //{
            //    if(IsPair(ArrayNumbers[i]))
            //        WriteLine("Nombre Pair");
            //    else
            //        WriteLine("Nombre Impair");
            //}

            //Exo11
            //WriteLine("Convert to Kelvin and Fahrenheit");
            //float[] ArrayNumbers = GetEntriesFloatNumberFromCmdLine();
            //for (int i = 0; i < ArrayNumbers.Length; i++)
            //{
            //    WriteLine(String.Format("{0}°C  donne {1}°F  et {2}°K", ArrayNumbers[i], CelsiusToFahrenheit(ArrayNumbers[i]), CelsiusToKelvin(ArrayNumbers[i])));
            //}

            //Exo12
            //WriteLine("Day of Week");
            //WriteLine(DayOfWeek(GetIntegerFromCmdLine()));

            //Exo13:
            //WriteLine("Enter correct password");
            //EnterPassword();

            //Exo14
            //WriteLine("Display a arithmetic operation");
            //WriteLine(DisplayArithmeticOperation());

            //Exo15
            //WriteLine("Display 10 first numbers");
            //int[] ArrayNumbers = ReturnTenFirstNumbers(10,true);


            //Exo16
            //WriteLine("Display Multiplication Table Of 10");
            //DisplayTenMultiplicationTable();

            //Exo17
            //WriteLine("Display a triangle with a letter of your choice");
            //int number = GetIntegerFromCmdLine("Entrez la taille du triangle");
            //string pattern = GetStringFromCmdLine("Motif pour dessiner le triangle?");
            //DisplayTriangle(number,pattern);

            //Exo18
            //WriteLine("Display Pyramide");
            //int hauteur = GetIntegerFromCmdLine("Entrez la hauteur de la pyramide");
            //string pattern = GetStringFromCmdLine("Entrez le motif de la pyramide");
            //DisplayPyramide(hauteur,pattern);

            //Exo19
            //WriteLine("Display Diamant");
            //int hauteur = GetIntegerFromCmdLine("Entrez la hauteur du diamant");
            //string pattern = GetStringFromCmdLine("Entrez le motif du diamant");
            //DisplayDiamant(hauteur,pattern);

            //Exo 20
            //Console.WriteLine(DateDuJourComplete());
            //Console.WriteLine(DateDuJour());

            //Exo 21
            //Console.WriteLine("Entrez une date et récuperez le jour de la semaine");
            //string response = GetStringFromCmdLine("Test avec la date du jour ? (O/N)");
            //if (response == "O" || response == "o")
            //    WriteLine(DayofSpecificDate(DateTime.Now));
            //else
            //{
            //    string year = GetStringFromCmdLine("Entrez l'année :");
            //    string month = GetStringFromCmdLine("Entrez le mois :");
            //    string day = GetStringFromCmdLine("Entrez le jour :");
            //    string hours = GetStringFromCmdLine("Entrez les heures :");
            //    string minutes = GetStringFromCmdLine("Entrez les minutes :");
            //    string seconds = GetStringFromCmdLine("Entrez les secondes :");

            //    if (!IsDateTimeOK(year, month, day, hours, minutes, seconds))
            //    {
            //        Console.WriteLine("Erreur dans le format entré");
            //        Console.WriteLine("La date du jour sera utilisée");
            //        WriteLine(DayofSpecificDate(DateTime.Now));
            //    }
            //    DateTime.TryParse($"{year}-{month}-{day} {hours}:{minutes}:{seconds}", out DateTime date);
            //    WriteLine(WeekDayofSpecificDate(date));
            //}

            //Exo22
            //DateTime date1 = GetDateTimeFromCmdLine();
            //DateTime date2 = GetDateTimeFromCmdLine();
            //DateTime earlierDate = GetMinDate(date1, date2);
            //DateTime laterDate = GetMaxDate(date1, date2);


            //Console.WriteLine("il y a {0} jours d'écart entre la date {1} et la date {2}",GetTotalDays(earlierDate, laterDate), earlierDate, laterDate);

            //Exo23
            //string date = GetStringFromCmdLine("Entrez une date (dd/mm/yyyy)");

            //DateTime result;

            //CultureInfo frFr = new CultureInfo("fr-FR");
            ////Parse date string to check format
            //while (!DateTime.TryParseExact(date, "dd/MM/yyyy", frFr, DateTimeStyles.None, out result))
            //{
            //    Console.WriteLine("Saisie Incorrecte");
            //    date = GetStringFromCmdLine("Entrez une date (dd/mm/yyyy)");
            //}
            //Console.WriteLine(result.ToString());

            //Exo24
            //Console.WriteLine("Jeu Du Plus ou Moins");

            //int secretNumber = 13;

            //int userNumber = GetIntegerFromCmdLine("Entrez un nombre le plus proche du nombre secret");
            //int intents = 10;
            //do
            //{
            //    if (userNumber.CompareTo(secretNumber) < 0)
            //        Console.WriteLine("Plus !"); // le chiffre entré est plus petit que le nombre secret
            //    else if (userNumber.CompareTo(secretNumber) > 0)
            //        Console.WriteLine("Moins !"); // le chiffre entré est plus grand que le nombre secret
            //    else
            //        break;
            //    intents--;

            //} while ((userNumber = GetIntegerFromCmdLine("Entrez un nombre le plus proche du nombre secret")) != secretNumber && intents != 0);

            //if (secretNumber == userNumber)
            //    Console.WriteLine("Vous avez deviné le nombre secret");
            //else
            //    Console.WriteLine("Perdu , vous n'avez pas pu deviner le mot secret ! Réessayez plus tard !");

            //Exo 25
            //Console.WriteLine("Convertit la chaine de caractères en majuscules");
            //string userInput = GetStringFromCmdLine("Entrez une phrase ou un mot");
            //Console.WriteLine($"Avant : {userInput}, Après : {userInput.ToUpper()}");

            //Exo 26
            //Console.WriteLine("Parcours de chaine de caractères ");
            //String chaine = GetStringFromCmdLine("Entrez une phrase ou un mot");
            //foreach (var item in chaine)
            //    Console.WriteLine(item);

            //Exo 27
            //Console.WriteLine("Inversion d'une chaine de caractères et ajout d'espaces entre chacun");
            //String chaine = GetStringFromCmdLine("Entrez une phrase ou un mot");
            //String newChaine = "";
            //foreach (var item in chaine)
            //{
            //    Console.WriteLine(item);
            //    newChaine= newChaine.Insert(0, $"{item.ToString()} ");
            //}
            //Console.WriteLine(newChaine);

            //Exo28
            //Console.WriteLine("Egalité de chaines de caractères (Case insensitive)");
            //do
            //{
            //    String chaine1 = GetStringFromCmdLine("Entrez la premiere phrase ou le premier mot").ToUpper();
            //    String chaine2 = GetStringFromCmdLine("Entrez la deuxième phrase ou le deuxième mot").ToUpper();

            //    bool result = chaine1.Equals(chaine2);
            //    if (result)
            //        Console.WriteLine("Les deux chaines entrées sont identiques");
            //    else
            //        Console.WriteLine("Les deux chaines entrées sont différentes");
            //}
            //while ((GetStringFromCmdLine("Continue ? (O/N)").ToUpper()).Equals("O"));

            //Exo 29
            //Console.WriteLine("Est ce un palindrome ?");
            //do
            //{
            //    String chaine = GetStringFromCmdLine("Entrez un mot uniquement");

            //    string halfstring1 = chaine.Substring(0, chaine.Length / 2);
            //    string halfstring2 = ReverseString(chaine.Substring(chaine.Length / 2));

            //    if (chaine.Length % 2 != 0)
            //        halfstring2 = ReverseString(chaine.Substring(chaine.Length / 2 + 1));

            //    if (halfstring1.Equals(halfstring2))
            //        Console.WriteLine("C'est un palindrome");
            //    else
            //        Console.WriteLine("Ceci n'est pas un palindrome");
            //}
            //while ((GetStringFromCmdLine("Continue ? (O/N)").ToUpper()).Equals("O"));

            //Exo 30
            //Console.WriteLine("Liste de 1 à 100 et Remplacement par Fizz,Buzz ou FizzBuzz selon le resultat du modulo");
            //List<string> listModified = new List<string>();
            //for (int nb = 1; nb < 101; nb++)
            //{
            //    if (nb % 3 == 0 && nb % 5 == 0) Console.Write("FizzBuzz ");
            //    else if (nb % 3 == 0) Console.Write("Fizz ");
            //    else if (nb % 5 == 0) Console.Write("Buzz ");
            //    else Console.Write($"{nb} ");
            //    if (nb % 9 == 0) Console.WriteLine();
                 
            //}
        }


        static float[] GetEntriesFloatNumberFromCmdLine()
        {
            int EntriesNumber = -1;
            //Check if positive if not and do while until it's positive 
            //or diff from 0
            while (CheckSignOfInteger(EntriesNumber))
            {
                EntriesNumber = GetIntegerFromCmdLine("Combien de nombres devez vous entrer?");
                if (EntriesNumber == 0)
                    WriteLine("Vous ne pouvez entrer de nombre");
            }

            float[] ArrayNumbers = new float[EntriesNumber];

            for (int i = 0; i < EntriesNumber; i++)
            {
                ArrayNumbers[i] = GetIntegerFromCmdLine("Entrez un nombre");
            }

            return ArrayNumbers;
        }

        static int[] GetEntriesIntegerNumberFromCmdLine()
        {
            int EntriesNumber = -1;
            //Check if positive if not and do while until it's positive 
            //or diff from 0
            while (CheckSignOfInteger(EntriesNumber))
            {
                EntriesNumber = GetIntegerFromCmdLine("Combien de nombres devez vous entrer?");
                if (EntriesNumber == 0)
                    Console.WriteLine("Vous ne pouvez entrer de nombre");
            }

            int[] ArrayNumbers = new int[EntriesNumber];

            for (int i = 0; i < EntriesNumber; i++)
                ArrayNumbers[i] = GetIntegerFromCmdLine("Entrez un nombre");

            return ArrayNumbers;
        }

        static int[] GetEntriesIntegerNumberFromParameter(int EntriesNumber = -1)
        {
            //Check if positive if not and do while until it's positive 
            //or diff from 0
            while (CheckSignOfInteger(EntriesNumber))
            {
                EntriesNumber = GetIntegerFromCmdLine("Combien de nombres devez vous entrer?");
                if (EntriesNumber == 0)
                    Console.WriteLine("Vous ne pouvez entrer de nombre");
            }

            int[] ArrayNumbers = new int[EntriesNumber];

            for (int i = 0; i < EntriesNumber; i++)
                ArrayNumbers[i] = GetIntegerFromCmdLine("Entrez un nombre");

            return ArrayNumbers;
        }

        static string[] GetEntriesStringsFromCmdLine()
        {
            int EntriesNumber = 0;
            //Check if positive if not and do while until it's positive 
            //or diff from 0
            while (CheckSignOfInteger(EntriesNumber))
            {
                EntriesNumber = GetIntegerFromCmdLine("Combien de mots devez vous entrer?");
                if (EntriesNumber == 0)
                    WriteLine("Vous ne pouvez entrer de mot");
            }

            string[] ArrayWords = new string[EntriesNumber];

            for (int i = 0; i < EntriesNumber; i++)
            {
                ArrayWords[i] = GetStringFromCmdLine("Entrez un mot");
            }

            return ArrayWords;
        }

        static DateTime GetDateTimeFromCmdLine()
        {
            Console.WriteLine("Entrez une date et récuperez le jour de la semaine");
            string response = GetStringFromCmdLine("Test avec la date du jour ? (O/N)");
            if (response == "O" || response == "o")
                return DateTime.Now;
            else
            {
                string year = GetStringFromCmdLine("Entrez l'année :");
                string month = GetStringFromCmdLine("Entrez le mois :");
                string day = GetStringFromCmdLine("Entrez le jour :");
                string hours = GetStringFromCmdLine("Entrez les heures :");
                string minutes = GetStringFromCmdLine("Entrez les minutes :");
                string seconds = GetStringFromCmdLine("Entrez les secondes :");

                if (!IsDateTimeOK(year, month, day, hours, minutes, seconds))
                {
                    Console.WriteLine("Erreur dans le format entré");
                    Console.WriteLine("La date du jour sera utilisée");
                    return DateTime.Now;
                }
                DateTime.TryParse($"{year}-{month}-{day} {hours}:{minutes}:{seconds}", out DateTime date);
                return date;
            }
        }

        static void HelloWorld()
        {
            WriteLine("Hello World!");
        }

        static string GetStringFromCmdLine(string question = "Quelle est la valeur?")
        {
            WriteLine(question);
            string input = Console.ReadLine();

            return input;
        }

        static bool CheckSignOfInteger(int number = 0)
        {
            bool isNegative = false;
            if (number < 0)
                isNegative = true;
            else if (number > 0)
                isNegative = false;


            return isNegative;
        }

        static int GetIntegerFromCmdLine(string question = "Quelle est la valeur?", bool checkSign = false)
        {
            if (int.TryParse(GetStringFromCmdLine(question), out int integer_input))
            {
                if (checkSign)
                {
                    if (CheckSignOfInteger(integer_input))
                        WriteLine(integer_input + " est négatif");
                    else
                        WriteLine(integer_input + " est positif");
                }
                return integer_input;
            }
            else
                WriteLine("Ceci n'est pas un chiffre");
            return -1;
        }

        static string SwitchOrder(string[] WordsArray) => $"{WordsArray[2]} {WordsArray[1]} {WordsArray[0]}";

        static string DisplayEqualNumbers()
        {
            int[] ArrayNumbers = GetEntriesIntegerNumberFromCmdLine();

            if (ArrayNumbers.Length == 2)
            {
                if (ArrayNumbers[0] == ArrayNumbers[1])
                    return String.Format("{0} {1}", ArrayNumbers[0], ArrayNumbers[1]);
                else
                    return "";
            }
            else
                return "Incorrect Number of numbers : Should be 2";
        }

        static string DisplaySwitchAndDisplay2Numbers()
        {
            int[] ArrayNumbers = GetEntriesIntegerNumberFromCmdLine();
            if (ArrayNumbers.Length == 2)
            {
                WriteLine(ArrayNumbers[0] + " " + ArrayNumbers[1]);
                int tmp = ArrayNumbers[0];
                ArrayNumbers[0] = ArrayNumbers[1];
                ArrayNumbers[1] = tmp;

                return String.Format("{0} {1}", ArrayNumbers[0], ArrayNumbers[1]);
            }
            else
                return "Incorrect Number of numbers : Should be 2";
        }

        static float[] AddSubstractDivideMultiple2Numbers()
        {
            float[] ArrayNumbers = GetEntriesFloatNumberFromCmdLine();
            float[] ArrayResults = new float[ArrayNumbers.Length];

            if (ArrayNumbers.Length == 2)
            {
                ArrayNumbers[0] = Addition(ArrayNumbers[0], ArrayNumbers[1]);
                ArrayNumbers[1] = Soustraction(ArrayNumbers[0], ArrayNumbers[1]);
                ArrayNumbers[2] = Multiplication(ArrayNumbers[0], ArrayNumbers[1]);
                ArrayNumbers[3] = Division(ArrayNumbers[0], ArrayNumbers[1]);

            }
            else
                ArrayResults = ArrayNumbers;

            return ArrayResults;
        }

        static float Addition(float chiffre1 = 0, float chiffre2 = 0)
        {
            return chiffre1 + chiffre2;
        }

        static float Soustraction(float chiffre1 = 0, float chiffre2 = 0)
        {
            return chiffre1 - chiffre2;
        }

        static float Multiplication(float chiffre1 = 0, float chiffre2 = 0)
        {
            return chiffre1 * chiffre2;
        }

        static float Division(float chiffre1 = 0, float chiffre2 = 0)
        {
            return chiffre1 / chiffre2;
        }

        static float DisplayMean()
        {
            float[] ArrayNumbers = GetEntriesFloatNumberFromCmdLine();

            float mean = 0;
            for (int i = 0; i < ArrayNumbers.Length; i++)
            {
                mean += ArrayNumbers[i];
            }

            return mean / ArrayNumbers.Length;
        }

        static float BiggestNumber()
        {
            float biggestNumber;
            float[] Enb = GetEntriesFloatNumberFromCmdLine();
            biggestNumber = Enb[0];
            for (int i = 1; i < Enb.Length; i++)
            {
                if (Enb[i] > biggestNumber)
                    biggestNumber = Enb[i];
            }

            return biggestNumber;
        }

        static bool IsPair(int chiffre = 0)
        {
            bool isPair = false;
            if (chiffre % 2 == 0)
                isPair = true;

            return isPair;
        }

        static float CelsiusToFahrenheit(float tempCelsius = 0)
        {
            //(0 °C × 9/5) + 32 = 32 °F
            float fahrTemp = tempCelsius * (9 / 5) + 32;
            return fahrTemp;
        }

        static float CelsiusToKelvin(float tempCelsius = 0)
        {
            //0 °C + 273,15 = 273,15 K
            float kelvinTemp = tempCelsius + (float)273.15;
            return kelvinTemp;
        }

        static string DayOfWeek(int numero)
        {
            string day = "Unknown";
            switch (numero)
            {
                case 1:
                    day = "Lundi"; break;
                case 2:
                    day = "Mardi"; break;
                case 3:
                    day = "Mercredi"; break;
                case 4:
                    day = "Jeudi"; break;
                case 5:
                    day = "Vendredi"; break;
                case 6:
                    day = "Samedi"; break;
                case 7:
                    day = "Dimanche"; break;

            }
            return day;
        }

        static void EnterPassword()
        {
            string secretPassword = "Zouzou";
            int intent = 0;
            int max_intents = 3;
            string password = "";
            while (intent < max_intents)
            {
                password = GetStringFromCmdLine(String.Format("Entrez le bon mot de passe ({0} essais)", max_intents - intent));
                if (password == secretPassword)
                    break;
                else
                {
                    WriteLine("Password incorrect!");
                    intent++;
                }

            }
            if (password == secretPassword)
                WriteLine("Password correct, You can go");
            else
                WriteLine("You got blocked, unsuccessful intents !");
        }

        static string DisplayArithmeticOperation()
        {
            string[] ArrayOperators = GetEntriesStringsFromCmdLine();
            bool hasNotArithmeticOperator = false;

            if (ArrayOperators.Length != 3)
            {
                WriteLine("Incorrect number of arguments");
                return String.Join(" ", ArrayOperators);
            }
            for (int i = 0; i < ArrayOperators.Length; i++)
            {
                if (!hasNotArithmeticOperator &&
                    ArrayOperators[i] == "/" ||
                    ArrayOperators[i] == "+" ||
                    ArrayOperators[i] == "-" ||
                    ArrayOperators[i] == "*")
                {
                    hasNotArithmeticOperator = true;
                    return String.Format("This is arithmetical operation : {0}", String.Join(" ", ArrayOperators));
                }
            }

            return String.Format("This is not arithmetical operation : {0}", String.Join(" ", ArrayOperators));



        }

        static bool CheckDisplayLimit(int increment, int limitNumber)
        {
            if (increment < limitNumber)
                return true;
            else
                return false;
        }

        static int[] ReturnTenFirstNumbers(int maxToDisplay, bool display = false)
        {
            int[] ArrayNumbers = new int[maxToDisplay];
            for (int i = 0; i < 100; i++)
            {
                if (CheckDisplayLimit(i, maxToDisplay))
                {
                    if (display) WriteLine(i);
                    ArrayNumbers[i] = i;
                }
                else
                    break;
            }
            return ArrayNumbers;
        }

        static void DisplayTenMultiplicationTable()
        {
            int[] ArrayNumbers = ReturnTenFirstNumbers(11);
            for (int i = 0; i < ArrayNumbers.Length; i++)
                WriteLine("10 x {0} = {1}", ArrayNumbers[i], 10 * ArrayNumbers[i]);
        }

        static void DisplayTriangle(int hauteur = 0, string pattern = "")
        {
            for (int i = 0; i <= hauteur; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(pattern);
                }
                WriteLine("");
            }
        }

        static void DisplayPyramide(int hauteur = 0, string pattern = "")
        {
            //on écrit les espaces(avec comme nbre max nb_espaces puis les patterns avec nb_motif
            int nb_motif = 1;
            int nb_espaces = hauteur;

            for (int ligne = 0; ligne < hauteur; ligne++)
            {
                int xpos = 0;
                while (xpos != nb_espaces)
                {
                    xpos++;
                    Console.Write(" ");
                }
                for (int j = 0; j < nb_motif; j++)
                {
                    Console.Write(pattern);
                }
                nb_espaces--;
                nb_motif += 2;
                WriteLine("");
            }

        }

        static void DisplayDiamant(int hauteur = 0, string pattern = "")
        {
            int hauteurPyramide = (hauteur % 2 == 0) ? hauteur / 2 : hauteur / 2 + 1;
            DisplayPyramide(hauteurPyramide, pattern);
            //on écrit les espaces(avec comme nbre max nb_espaces puis les patterns avec nb_motif
            int hauteurBasDiamant = hauteur - hauteurPyramide;
            int nb_motifs = (hauteur % 2 == 0) ? hauteur - 1 : hauteur - 2;
            int nb_espaces = (hauteur % 2 == 0) ? 1 : 2;

            for (int ligne = 0; ligne < hauteurBasDiamant; ligne++)
            {
                int xpos = 0;
                while (xpos != nb_espaces)
                {
                    xpos++;
                    Console.Write(" ");
                }
                nb_espaces++;
                for (int j = 0; j < nb_motifs; j++)
                {
                    Console.Write(pattern);
                }
                nb_motifs -= 2;
                WriteLine("");
            }
        }

        static string DateDuJourComplete() => DateTime.Now.ToString();
        static string DateDuJour() => DateTime.Now.ToString("dd/MM/yyyy");

        static string WeekDayofSpecificDate(DateTime date) => date.ToString(format: "dddd");

        static bool IsDateTimeOK(string year, string month, string day, string hours = "0", string minutes = "0", string seconds = "0")
        {
            bool isDateOk = false;
            if (int.TryParse(year, out int iYear) && iYear < 9999 && iYear > 0)
                isDateOk = true;
            if (int.TryParse(month, out int iMonth) && iMonth < 13 && iMonth > 0)
                isDateOk = true;
            if (int.TryParse(day, out int result) && result < DateTime.DaysInMonth(iYear, iMonth) && result > 1)
                isDateOk = true;
            if (int.TryParse(hours, out result) && result < 24 && result > 0)
                isDateOk = true;
            if (int.TryParse(minutes, out result) && result < 60 && result > 0)
                isDateOk = true;
            if (int.TryParse(seconds, out result) && result < 60 && result > 0)
                isDateOk = true;
            return isDateOk;
        }

        static DateTime GetMaxDate(DateTime date1, DateTime date2)
        {
            int result = DateTime.Compare(date1, date2);
            if (result < 0)
                return date2;
            else if (result == 0)
                return date1;
            else
                return date1;
        }

        static DateTime GetMinDate(DateTime date1, DateTime date2)
        {
            int result = DateTime.Compare(date1, date2);
            if (result < 0)
                return date1;
            else if (result == 0)
                return date1;
            else
                return date2;
        }

        static double GetTotalDays(DateTime earlierdate, DateTime laterdate)
        {
            return (laterdate - earlierdate).TotalDays;
        }

        static string ReverseString(string chaine)
        {
            String newChaine = "";
            foreach (var item in chaine)
                newChaine = newChaine.Insert(0, item.ToString());

            return newChaine;
        }
    }

}

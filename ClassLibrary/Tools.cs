using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class Tools
    {
        public static double diviser(double nb1, double nb2)
        {

            if (nb2 != 0)
                return nb1 / nb2;
            else
                throw new ExceptionDivision("Impossible de diviser par 0");


        }

        public static float[] GetEntriesFloatNumberFromCmdLine()
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

        public static int[] GetEntriesIntegerNumberFromCmdLine()
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

        public static int[] GetEntriesIntegerNumberFromParameter(int EntriesNumber = -1)
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

        public static string[] GetEntriesStringFromParameter(int EntriesNumber = -1)
        {
            //Check if positive if not and do while until it's positive 
            //or diff from 0
            while (CheckSignOfInteger(EntriesNumber))
            {
                EntriesNumber = GetIntegerFromCmdLine("Combien de mots devez vous entrer?");
                if (EntriesNumber == 0)
                    Console.WriteLine("Vous ne pouvez entrer de mot");
            }

            string[] ArrayWords = new string[EntriesNumber];

            for (int i = 0; i < EntriesNumber; i++)
                ArrayWords[i] = GetStringFromCmdLine("Entrez un mot");

            return ArrayWords;
        }

        public static string[] GetEntriesStringsFromCmdLine()
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

        public static DateTime GetDateTimeFromCmdLine()
        {
            Console.WriteLine("Entrez une date et récuperez le jour de la semaine");
            string response = GetStringFromCmdLine("Test avec la date du jour ? (O/N)");
            DateTime date = DateTime.Now;
            if (response == "O" || response == "o")
                return date;
            else
            {
                string year = GetStringFromCmdLine("Entrez l'année :");
                string month = GetStringFromCmdLine("Entrez le mois :");
                string day = GetStringFromCmdLine("Entrez le jour :");
                string hours = GetStringFromCmdLine("Entrez les heures :");
                string minutes = GetStringFromCmdLine("Entrez les minutes :");
                string seconds = GetStringFromCmdLine("Entrez les secondes :");

                //Double check du format de date
                bool dateFormatOk = DateTime.TryParse($"{year}-{month}-{day} {hours}:{minutes}:{seconds}", out date) &&
                                    IsDateTimeOK(year, month, day, hours, minutes, seconds);

                if (!dateFormatOk)
                {
                    Console.WriteLine("Erreur dans le format entré");
                    Console.WriteLine("La date du jour sera utilisée");
                    date = DateTime.Now;
                }
                return date;

            }
        }

        public static void HelloWorld()
        {
            WriteLine("Hello World!");
        }

        public static string GetStringFromCmdLine(string question = "Quelle est la valeur?")
        {
            WriteLine(question);
            string input = Console.ReadLine();

            return input;
        }

        public static bool CheckSignOfInteger(int number = 0)
        {
            bool isNegative = false;
            if (number < 0)
                isNegative = true;
            else if (number > 0)
                isNegative = false;


            return isNegative;
        }

        public static int GetIntegerFromCmdLine(string question = "Quelle est la valeur?", bool checkSign = false)
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

        public static string SwitchOrder(string[] WordsArray) => $"{WordsArray[2]} {WordsArray[1]} {WordsArray[0]}";

        public static string DisplayEqualNumbers()
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

        public static string DisplaySwitchAndDisplay2Numbers()
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

        public static float[] AddSubstractDivideMultiple2Numbers()
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

        public static float Addition(float chiffre1 = 0, float chiffre2 = 0)
        {
            return chiffre1 + chiffre2;
        }

        public static float Soustraction(float chiffre1 = 0, float chiffre2 = 0)
        {
            return chiffre1 - chiffre2;
        }

        public static float Multiplication(float chiffre1 = 0, float chiffre2 = 0)
        {
            return chiffre1 * chiffre2;
        }

        public static float Division(float chiffre1 = 0, float chiffre2 = 0)
        {
            return chiffre1 / chiffre2;
        }

        public static float DisplayMean()
        {
            float[] ArrayNumbers = GetEntriesFloatNumberFromCmdLine();

            float mean = 0;
            for (int i = 0; i < ArrayNumbers.Length; i++)
            {
                mean += ArrayNumbers[i];
            }

            return mean / ArrayNumbers.Length;
        }

        public static float BiggestNumber()
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

        public static bool IsPair(int chiffre = 0)
        {
            bool isPair = false;
            if (chiffre % 2 == 0)
                isPair = true;

            return isPair;
        }

        public static float CelsiusToFahrenheit(float tempCelsius = 0)
        {
            //(0 °C × 9/5) + 32 = 32 °F
            float fahrTemp = tempCelsius * (9 / 5) + 32;
            return fahrTemp;
        }

        public static float CelsiusToKelvin(float tempCelsius = 0)
        {
            //0 °C + 273,15 = 273,15 K
            float kelvinTemp = tempCelsius + (float)273.15;
            return kelvinTemp;
        }

        public static string DayOfWeek(int numero)
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

        public static void EnterPassword()
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

        public static string DisplayArithmeticOperation()
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

        public static bool CheckDisplayLimit(int increment, int limitNumber)
        {
            if (increment < limitNumber)
                return true;
            else
                return false;
        }

        public static int[] ReturnTenFirstNumbers(int maxToDisplay, bool display = false)
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

        public static void DisplayTenMultiplicationTable()
        {
            int[] ArrayNumbers = ReturnTenFirstNumbers(11);
            for (int i = 0; i < ArrayNumbers.Length; i++)
                WriteLine("10 x {0} = {1}", ArrayNumbers[i], 10 * ArrayNumbers[i]);
        }

        public static void DisplayTriangle(int hauteur = 0, string pattern = "")
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

        public static void DisplayPyramide(int hauteur = 0, string pattern = "")
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

        public static void DisplayDiamant(int hauteur = 0, string pattern = "")
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

        public static string DateDuJourComplete() => DateTime.Now.ToString();
        public static string DateDuJour() => DateTime.Now.ToString("dd/MM/yyyy");

        public static string WeekDayofSpecificDate(DateTime date) => date.ToString(format: "dddd");

        public static bool IsDateTimeOK(string year, string month, string day, string hours = "0", string minutes = "0", string seconds = "0")
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

        public static DateTime GetMaxDate(DateTime date1, DateTime date2)
        {
            int result = DateTime.Compare(date1, date2);
            if (result < 0)
                return date2;
            else if (result == 0)
                return date1;
            else
                return date1;
        }

        public static DateTime GetMinDate(DateTime date1, DateTime date2)
        {
            int result = DateTime.Compare(date1, date2);
            if (result < 0)
                return date1;
            else if (result == 0)
                return date1;
            else
                return date2;
        }

        public static double GetTotalDays(DateTime earlierdate, DateTime laterdate)
        {
            return (laterdate - earlierdate).TotalDays;
        }

        public static string ReverseString(string chaine)
        {
            String newChaine = "";
            foreach (var item in chaine)
                newChaine = newChaine.Insert(0, item.ToString());

            return newChaine;
        }
    }
}

using System;
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
            //WriteLine(SwitchOrder());

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
        }

        static float[] GetEntriesFloatNumberFromCmdLine()
        {

            int EntriesNumber = GetIntegerFromCmdLine("Combien de chiffres devez vous entrer?");

            float[] ArrayNumbers = new float[EntriesNumber];

            for (int i = 0; i < EntriesNumber; i++)
            {
                ArrayNumbers[i] = GetIntegerFromCmdLine("Entrez un chiffre");
            }

            return ArrayNumbers;
        }

        static int[] GetEntriesIntegerNumberFromCmdLine()
        {

            int EntriesNumber = GetIntegerFromCmdLine("Combien de chiffres devez vous entrer?");

            int[] ArrayNumbers = new int[EntriesNumber];

            for (int i = 0; i < EntriesNumber; i++)
            {
                ArrayNumbers[i] = GetIntegerFromCmdLine("Entrez un chiffre");
            }

            return ArrayNumbers;
        }

        static string[] GetEntriesStringsFromCmdLine()
        {

            int EntriesNumber = GetIntegerFromCmdLine("Combien de mots devez vous entrer?");
            //Check if positive
            while (CheckSignOfInteger(EntriesNumber))
                EntriesNumber = GetIntegerFromCmdLine("Combien de mots devez vous entrer?");

            string[] ArrayWords = new string[EntriesNumber];

            for (int i = 0; i < EntriesNumber; i++)
            {
                ArrayWords[i] = GetStringFromCmdLine("Entrez un mot");
            }

            return ArrayWords;
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
            else
                WriteLine("Vous avez entré 0 comme chiffre");

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

        static string SwitchOrder()
        {

            string[] WordsArray = GetEntriesStringsFromCmdLine();

            return String.Format("{0} {1} {2}", WordsArray[2], WordsArray[1], WordsArray[0]);
        }

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

        static int[] ReturnTenFirstNumbers(int maxToDisplay,bool display = false)
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
            int nb_motifs = (hauteur % 2 == 0) ? hauteur -1 : hauteur - 2;
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


    }
}

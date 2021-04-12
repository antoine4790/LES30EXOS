using System;

namespace LES30EXOS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exo1
            //HelloWorld();

            //Exo2
            //Console.WriteLine("voici votre valeur :" + GetStringFromCmdLine());
            //Console.WriteLine("voici votre valeur :" + GetIntegerFromCmdLine());

            //Exo3
            //Console.WriteLine("Inverse trois mots");
            //Console.WriteLine(SwitchOrder());

            //Exo4 
            //Console.WriteLine("Affiche si les 2 nombres sont égaux");
            //Console.WriteLine(DisplayEqualNumbers());

            //Exo5
            //Console.WriteLine("Affiche inverse et affiche 2 nombres");
            //Console.WriteLine(DisplaySwitchAndDisplay2Numbers());

            //Exo6
            //Console.WriteLine("Operations Addition Soustraction Division Multiplication");
            //float[] ArrayResults= AddSubstractDivideMultiple2Numbers();
            //for (int i = 0; i < ArrayResults.Length; i++)
            //{
            //    Console.WriteLine(ArrayResults[i]);
            //}

            //Exo7
            //Console.WriteLine("Moyenne");
            //Console.WriteLine("La moyenne est de " + DisplayMean());

            //Exo8
            //Console.WriteLine("Affiche le plus grand des nombres");
            //Console.WriteLine("Le plus grand nombre est :" + BiggestNumber());

            //Exo9
            //Console.WriteLine("CheckSign");
            //GetIntegerFromCmdLine("Entrez un chiffre pour vérifier son signe", true);

            //Exo10
            //Console.WriteLine("Pair or not Pair");
            //int[] ArrayNumbers = GetEntriesIntegerNumberFromCmdLine();
            //for (int i = 0; i < ArrayNumbers.Length; i++)
            //{
            //    if(IsPair(ArrayNumbers[i]))
            //        Console.WriteLine("Nombre Pair");
            //    else
            //        Console.WriteLine("Nombre Impair");
            //}

            //Exo11
            //Console.WriteLine("Convert to Kelvin and Fahrenheit");
            //float[] ArrayNumbers = GetEntriesFloatNumberFromCmdLine();
            //for (int i = 0; i < ArrayNumbers.Length; i++)
            //{
            //    Console.WriteLine(String.Format("{0}°C  donne {1}°F  et {2}°K", ArrayNumbers[i], CelsiusToFahrenheit(ArrayNumbers[i]), CelsiusToKelvin(ArrayNumbers[i])));
            //}

            //Exo12
            //Console.WriteLine("Day of Week");
            //Console.WriteLine(DayOfWeek(GetIntegerFromCmdLine()));

            //Exo13:
            //Console.WriteLine("Enter correct password");
            //EnterPassword();

            //Exo14
            //Console.WriteLine("Display a arithmetic operation");
            //Console.WriteLine(DisplayArithmeticOperation());

            //Exo15
            //Console.WriteLine("Display 10 first numbers");
            //int[] ArrayNumbers = ReturnTenFirstNumbers(10,true);


            //Exo16
            //Console.WriteLine("Display Multiplication Table Of 10");
            //DisplayTenMultiplicationTable();

            //Exo17
            //Console.WriteLine("Display a triangle with a letter of your choice");
            //int number = GetIntegerFromCmdLine("Entrez la taille du triangle");
            //string pattern = GetStringFromCmdLine("Motif pour dessiner le triangle?");
            //DisplayTriangle(number,pattern);

            //Exo18
            //Console.WriteLine("Display Pyramide");
            //DisplayPyramide();
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
            Console.WriteLine("Hello World!");
        }

        static string GetStringFromCmdLine(string question = "Quelle est la valeur?")
        {
            Console.WriteLine(question);
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
                Console.WriteLine("Vous avez entré 0 comme chiffre");

            return isNegative;
        }

        static int GetIntegerFromCmdLine(string question = "Quelle est la valeur?", bool checkSign = false)
        {
            if (int.TryParse(GetStringFromCmdLine(question), out int integer_input))
            {
                if (checkSign)
                {
                    if (CheckSignOfInteger(integer_input))
                        Console.WriteLine(integer_input + " est négatif");
                    else
                        Console.WriteLine(integer_input + " est positif");
                }
                return integer_input;
            }
            else
                Console.WriteLine("Ceci n'est pas un chiffre");
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
                Console.WriteLine(ArrayNumbers[0] + " " + ArrayNumbers[1]);
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
                    Console.WriteLine("Password incorrect!");
                    intent++;
                }

            }
            if (password == secretPassword)
                Console.WriteLine("Password correct, You can go");
            else
                Console.WriteLine("You got blocked, unsuccessful intents !");
        }

        static string DisplayArithmeticOperation()
        {
            string[] ArrayOperators = GetEntriesStringsFromCmdLine();
            bool hasNotArithmeticOperator = false;

            if (ArrayOperators.Length != 3)
            {
                Console.WriteLine("Incorrect number of arguments");
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
                    if (display) Console.WriteLine(i);
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
                Console.WriteLine("10 x {0} = {1}", ArrayNumbers[i], 10 * ArrayNumbers[i]);
        }

        static void DisplayTriangle(int number=0, string pattern="*")
        {
            for (int i = 0; i <= number; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(pattern);
                }
                Console.WriteLine("");
            }

        }

        static void DisplayPyramide()
        {
            int hauteur = GetIntegerFromCmdLine("Entrez la hauteur de la pyramide");
            string pattern = GetStringFromCmdLine("Entrez le motif de la pyramide");
            //on écrit les espaces(avec comme nbre max largeur puis tous les patterns avec nb_motif
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
                Console.WriteLine("");
            }
            
        }

        static void DisplayDiamond()
        {
            int hauteur = GetIntegerFromCmdLine("Entrez la hauteur de la pyramide");
            string pattern = GetStringFromCmdLine("Entrez le motif de la pyramide");
            //on écrit les espaces(avec comme nbre max largeur puis tous les patterns avec nb_motif
            int nb_motif = 1;
            int largeur = hauteur;
            for (int y = 0; y < hauteur; y++)
            {
                int xpos = 0;
                while (xpos != largeur)
                {
                    xpos++;
                    Console.Write(" ");
                }
                for (int j = 0; j < nb_motif; j++)
                {
                    Console.Write(pattern);
                }
                largeur--;
                nb_motif += 2;
                Console.WriteLine("");
            }

        }
    }
}

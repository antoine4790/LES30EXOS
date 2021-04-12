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

        static int GetIntegerFromCmdLine(string question = "Quelle est la valeur?")
        {
            if (int.TryParse(GetStringFromCmdLine(question), out int integer_input))
            {
                if (CheckSignOfInteger(integer_input))
                    Console.WriteLine(integer_input + " est négatif");
                else
                    Console.WriteLine(integer_input + " est positif");

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
                ArrayNumbers[0] = Addition(ArrayNumbers[0], ArrayNumbers[1]) ;
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
            while (intent < max_intents )
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
    }
}

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
            //Console.WriteLine("voici votre valeur :" + GetString());
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
            Console.WriteLine("Le plus grand nombre est :" + BiggestNumber());
        }

        static float[] GetEntriesNumberFromCmdLine()
        {

            Console.WriteLine("Combien de chiffres devez vous entrer?");

            bool isOk = int.TryParse(Console.ReadLine(), out int EntriesNumber);
            //if (isOk)
            //{
            //    float[] ArrayNumbers = new float[EntriesNumber];
            //}
            //else
            //    return 1;

            float[] ArrayNumbers = new float[EntriesNumber];

            for (int i = 0; i < EntriesNumber; i++)
            {
                ArrayNumbers[i] = GetIntegerFromCmdLine("Entrez un chiffre");
            }

            return ArrayNumbers;
        }
        static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        static string GetString(string question = "Quelle est la valeur?")
        {
            Console.WriteLine(question);
            string input = Console.ReadLine();

            return input;
        }

        static bool CheckSignOfInteger(int number = 0)
        {
            bool result = false;
            if (number < 0)
                result = true;
            else if (number > 0)
                result = true;
            else
                Console.WriteLine("Vous avez entré 0 comme chiffre");

            return result;
        }

        static int GetIntegerFromCmdLine(string question = "Quelle est la valeur?")
        {
            if (int.TryParse(GetString(question), out int integer_input))
            {
                if (CheckSignOfInteger(integer_input))
                    Console.WriteLine(integer_input + "est négatif");
                else
                    Console.WriteLine(integer_input + "est positif");

                return integer_input;
            }
            else
                Console.WriteLine("Ceci n'est pas un chiffre");
                return -1;
        }

        static string SwitchOrder()
        {
            string[] WordsArray = new string[3];
            WordsArray[0] = GetString("Entrez le premier mot");

            WordsArray[1] = GetString("Entrez le deuxieme mot");

            WordsArray[2] = GetString("Entrez le troisieme mot");



            return String.Format("{0} {1} {2}", WordsArray[2] , WordsArray[1] , WordsArray[0]);
        }

        static string DisplayEqualNumbers()
        {
            int chiffre1 = GetIntegerFromCmdLine("Entrez un chiffre");
            int chiffre2 = GetIntegerFromCmdLine("Entrez un autre chiffre");

            if (chiffre1 == chiffre2)
                return String.Format("{0} {1}", chiffre1, chiffre2);
            else
                return "";
        }

        static string DisplaySwitchAndDisplay2Numbers()
        {

            int[] ArrayNumbers = { GetIntegerFromCmdLine("Entrez un chiffre"), GetIntegerFromCmdLine("Entrez un autre chiffre") };
            Console.WriteLine(ArrayNumbers[0] + " " + ArrayNumbers[1]);
            int tmp = ArrayNumbers[0];
            ArrayNumbers[0] = ArrayNumbers[1];
            ArrayNumbers[1] = tmp;

            return String.Format("{0} {1}",ArrayNumbers[0], ArrayNumbers[1]);
        }

        static float[] AddSubstractDivideMultiple2Numbers()
        {
            float[] ArrayNumbers = { GetIntegerFromCmdLine("Entrez un chiffre"), GetIntegerFromCmdLine("Entrez un autre chiffre") };
            float[] ArrayResults = {
                ArrayNumbers[0] + ArrayNumbers[1],
                ArrayNumbers[0] - ArrayNumbers[1],
                (float)ArrayNumbers[0] / ArrayNumbers[1],
                ArrayNumbers[0] * ArrayNumbers[1]
            };


            return ArrayResults;
        }

        static float DisplayMean()
        {

            float[] ArrayNumbers = {
                GetIntegerFromCmdLine("Entrez un chiffre"),
                GetIntegerFromCmdLine("Entrez un autre chiffre"),
                GetIntegerFromCmdLine("Entrez un autre chiffre"),
                GetIntegerFromCmdLine("Entrez un autre chiffre")
            };

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
            float[] Enb = GetEntriesNumberFromCmdLine();
            biggestNumber = Enb[0];
            for (int i = 1; i < Enb.Length; i++)
            {
                if (Enb[i] > biggestNumber)
                    biggestNumber = Enb[i];
            }

            return biggestNumber;
        }
    }
}

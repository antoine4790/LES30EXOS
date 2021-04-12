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
            //Console.WriteLine(SwitchOrder());

            //Exo4 
            //Console.WriteLine(DisplayEqualNumbers());

            //Exo5
            //Console.WriteLine(DisplaySwitchAndDisplay2Numbers());

            //Exo6
            //float[] ArrayResults= AddSubstractDivideMultiple2Numbers();
            //for (int i = 0; i < ArrayResults.Length; i++)
            //{
            //    Console.WriteLine(ArrayResults[i]);
            //}

            //Exo7
            Console.WriteLine("La moyenne est de " + DisplayMean());

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

        static int GetIntegerFromCmdLine(string question = "Quelle est la valeur?")
        {
            if (int.TryParse(GetString(question), out int integer_input))
                return integer_input;
            else
                return -1;
        }

        static string SwitchOrder()
        {
            string[] WordsArray = new string[3];
            WordsArray[0] = GetString("Entrez le premier mot");

            WordsArray[1] = GetString("Entrez le deuxieme mot");

            WordsArray[2] = GetString("Entrez le troisieme mot");



            return WordsArray[2] + WordsArray[1] + WordsArray[0];
        }

        static string DisplayEqualNumbers()
        {
            int chiffre1 = GetIntegerFromCmdLine("Entrez un chiffre");
            int chiffre2 = GetIntegerFromCmdLine("Entrez un autre chiffre");

            if (chiffre1 == chiffre2)
                return chiffre1 + " " + chiffre2;
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

            return ArrayNumbers[0] +" "+ ArrayNumbers[1];
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

            float mean=0;
            for (int i = 0; i < ArrayNumbers.Length; i++)
            {
                mean += ArrayNumbers[i];
            }

            return mean / ArrayNumbers.Length;
        }
    }
}

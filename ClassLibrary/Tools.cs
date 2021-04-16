using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Tools
    {
        public static double diviser(double nb1, double nb2)
        {
            try
            {
                if (nb2 != 0)
                    return nb1 / nb2;
                else
                    throw new ExceptionDivision("Impossible de diviser par 0");
            }
            //gestion de la division par 0
            catch (ExceptionDivision e)
            {
                Console.WriteLine($"Voici l'erreur {e} .");
                return 0;
            }

        }
    }
}

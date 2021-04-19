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
            
            if (nb2 != 0)
                return nb1 / nb2;
            else
                throw new ExceptionDivision("Impossible de diviser par 0");
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class InvalidMoyenneException:Exception
    {
        public InvalidMoyenneException(string message) : base(message) { }
    }
}

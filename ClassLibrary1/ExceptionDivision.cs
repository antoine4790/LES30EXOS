using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ExceptionDivision : Exception
    {
        public ExceptionDivision(string message) : base(message) { }
    }
}

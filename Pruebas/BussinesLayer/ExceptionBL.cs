using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer
{
    public class ExceptionBL : Exception
    {
        public string messag;
        public ExceptionBL(string message)
        {
            messag = message;
        }

    }

}

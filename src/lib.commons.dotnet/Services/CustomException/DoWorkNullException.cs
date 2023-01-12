using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lib.commons.dotnet.Services.CustomException
{
    public class DoWorkNullException : Exception
    {
       public DoWorkNullException(string message) : base(message)
       { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eWebCore.Utilities.Exceptions
{
    public class EWebCoreException : Exception
    {
        public EWebCoreException()
        {
        }

        public EWebCoreException(string message)
            : base(message)
        {
        }

        public EWebCoreException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}

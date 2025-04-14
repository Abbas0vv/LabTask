using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLab.Exeptions
{
    class SomethingWentWrongException : Exception
    {
        public SomethingWentWrongException() { }
        public SomethingWentWrongException(string message) : base(message) { }
    }
}

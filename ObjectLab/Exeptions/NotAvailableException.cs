using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLab.Exeptions
{
    class NotAvailableException : Exception
    {
        public NotAvailableException(string message) : base(message) { }
        public NotAvailableException() { }
    }
}

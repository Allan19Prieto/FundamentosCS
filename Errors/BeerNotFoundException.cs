using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCSCHARP.Errors
{
    public class BeerNotFoundException : Exception
    {
        public BeerNotFoundException() : base() {  }
        public BeerNotFoundException(string massage) : base(massage) { }
        public BeerNotFoundException(string message, Exception innerException) : base(message, innerException) { }

    }
}

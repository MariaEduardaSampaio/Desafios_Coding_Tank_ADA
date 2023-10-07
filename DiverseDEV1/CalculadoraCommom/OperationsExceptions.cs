using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commom
{
    public class OperationsExceptions: Exception
    {
        public OperationsExceptions()
        {
            
        }
        public OperationsExceptions(string message): base(message)
        {
            
        }

        public OperationsExceptions(string message, Exception inner): base(message, inner) 
        {
            
        }
    }
}

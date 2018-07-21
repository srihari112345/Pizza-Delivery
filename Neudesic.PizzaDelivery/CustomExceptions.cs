using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neudesic.PizzaDelivery
{
    public class InvalidOptionException : Exception
    {
        public InvalidOptionException()
            : base(String.Format("Wrong Option"))
        {
            
        }

    }
}

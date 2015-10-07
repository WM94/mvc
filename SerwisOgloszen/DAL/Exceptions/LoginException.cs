using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Exceptions
{
    public class Exceptions
    {
        public class WrongPasswordException : Exception
            
        {
            public WrongPasswordException()
                : base()
            {

            }
        }
        public class WrongLoginException : Exception
        {
            public WrongLoginException()
                : base()
            {

            }
        }
    }
 
}

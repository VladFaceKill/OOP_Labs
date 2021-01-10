using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABwork7
{
    namespace UserExceptions
    {
        class AgeException : Exception
        {
            int errorCode;
            public AgeException(string msg, int errorCode):base(msg)
            {
                this.errorCode = errorCode;
            }

            public int ErrorCode
            {
                get
                {
                    return errorCode;
                }
            }
        }
    }
}

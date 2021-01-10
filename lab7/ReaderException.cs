using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LABwork7.UserExceptions;

namespace LABwork7
{
    namespace UserExceptions
    {
        class ReaderException : Exception
        {
            int errorCode;
            public ReaderException(string msg, int errorCode):base(msg)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamrinDr
{
    public static class Methods
    {

        public static UInt64 CalPow(UInt64 a , UInt64 b) 
        {
            if (b == 0) return 1;

            var result = a * CalPow(a,b-1);

            return result;
        }

        public static UInt64 CalFac(UInt64 a)
        {
            if (a == 0) return 1;

            var result = a * CalFac(a - 1);

            return result;
        }

    }
}

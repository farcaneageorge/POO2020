using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigNum
{
    class Util
    {
        public static BigNumber max(BigNumber bn1, BigNumber bn2)
        {
            if (bn1.getLength() >= bn2.getLength())
                return bn1;
            else
                return bn2;
        }
    }
}
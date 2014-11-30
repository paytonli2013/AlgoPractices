using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Algo.IntegerMultiplication
{
    public class KaratsubaMultiplication : IAlgo<IInput<BigInteger, BigInteger>, BigInteger>
    {
        const int KaratsubaCutoff = 10;

        #region IAlgo<IInput<int,int>,int> Members

        public BigInteger Compute(IInput<BigInteger, BigInteger> input)
        {
            return Multiply(input.Input1, input.Input2);
        }

        BigInteger Multiply(BigInteger x, BigInteger y)
        {
            if (x.Equals(BigInteger.Zero) || y.Equals(BigInteger.Zero))
                return 0;

            int n = Math.Max(GetMSB(x), GetMSB(y));

            if (n < KaratsubaCutoff)
            {
                return x * y;
            }

            n = ((n + 1) / 2);

            BigInteger b = x >> n;
            BigInteger a = x - (b << n);
            BigInteger d = y >> n;
            BigInteger c = y - (d << n);

            BigInteger ac = Multiply(a, c);
            BigInteger bd = Multiply(b, d);
            BigInteger abcd = Multiply(a + b, c + d);

            return ac + ((abcd - ac - bd) << n) + (bd << (2 * n));
        }

        private int GetMSB(BigInteger bint)
        {
            byte[] data = bint.ToByteArray();
            int result = (data.Length - 1) * 8;
            byte Msb = data[data.Length - 1];
            while (Msb != 0)
            {
                result += 1;
                Msb >>= 1;
            }
            return result;
        }
        #endregion
    }
}

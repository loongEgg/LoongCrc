using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoongCrc
{
    public static class UInt64Extensions
    {
        public static UInt64 ReverseBits(this UInt64 self, int valueLength)
        {
            UInt64 ret = 0;
            for (int i = valueLength - 1; i >= 0; i--)
            {
                ret |= (self & 1) << i;
                self >>= 1;
            }
            return ret;
        }
    }
}

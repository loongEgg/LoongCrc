using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoongCrc.Test
{
    [TestClass]
    public class UInt64Extensions_Test
    {
        [TestMethod]
        public void ReverseBits_Check()
        {
            UInt64 origin = (UInt64)0xAAAAAAAA;
            UInt64 result = origin.ReverseBits(32);

            Assert.AreEqual((UInt64)0x55555555, result);
        }
    }
}

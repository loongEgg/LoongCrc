using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LoongCrc.Test
{
    [TestClass]
    public class EnumExtensions_Test
    {
        [TestMethod]
        public void GetDescription_Check()
        {
            var description = CrcAlgorithms.Crc16CcittFalse.GetDescription();

            Assert.IsNotNull(description);
            Assert.IsTrue(description.Length > 5);
            Assert.AreNotEqual(CrcAlgorithms.Crc16CcittFalse.ToString(), description);
            //Assert.AreEqual("CRC-16/CCITT-FALSE", description);
        }
    }
}

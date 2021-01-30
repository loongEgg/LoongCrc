using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoongCrc
{
    public static class CrcStdParameters
    {
        private static Dictionary<CrcAlgorithms, Parameters> StandardParameters = new Dictionary<CrcAlgorithms, Parameters>()
        {
            {CrcAlgorithms.Crc16CcittFalse, new Parameters(hashSize: 16, poly: 0x1021, init: 0xFFFF, refIn: false, refOut: false, xorOut: 0x0,    check: 0x29B1, name: CrcAlgorithms.Crc16CcittFalse.GetDescription()) },
            {CrcAlgorithms.Crc16Kermit,     new Parameters(          16,       0x1021,       0x0,           true,          true,          0x0,           0x2189, name: CrcAlgorithms.Crc16Kermit.GetDescription()) },
            {CrcAlgorithms.Crc16X25,        new Parameters(          16,       0x1021,       0xFFFF,        true,          true,          0xFFFF,        0x906E, name: CrcAlgorithms.Crc16X25.GetDescription()) }
        };
        
        public static Parameters GetParameter(CrcAlgorithms algorithms)
        {
            if (StandardParameters.ContainsKey(algorithms))
                return StandardParameters[algorithms];

            throw new NotImplementedException($"not implemented crc algorithms[{algorithms}]");
        }
    }
}

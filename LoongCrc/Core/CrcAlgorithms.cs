using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoongCrc
{
    public enum CrcAlgorithms
    {
        /// <summary>
        /// CRC-16/CCITT-FALSE
        /// </summary>
        [Description("CRC-16/CCITT-FALSE")]
        Crc16CcittFalse,
        /// <summary>
        /// CRC-16/KERMIT
        /// </summary>
        [Description("CRC-16/KERMIT")]
        Crc16Kermit,
        /// <summary>
        /// CRC-16/X-25
        /// </summary>
        [Description("CRC-16/X-25")]
        Crc16X25,
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoongCrc
{
    /// <summary>
    /// Crc算法参数定义
    /// </summary>
    public struct Parameters
    {
        /// <summary>
        /// 算法名称
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// 
        /// </summary>
        public int HashSize { get; }
        /// <summary>
        /// 计算多项式
        /// </summary>
        public ulong Poly { get; }
        /// <summary>
        /// 校验码的初值
        /// </summary>
        public ulong Init { get; }
        public bool RefIn { get; }
        public bool RefOut { get; }
        public ulong XorOut { get; }
        public ulong Check { get; }

        /// <summary>
        /// Instance of <see cref="Parameters"/>
        /// </summary>
        /// <param name="name"><see cref="Name"/></param>
        /// <param name="hashSize"><see cref="HashSize"/></param>
        /// <param name="poly"><see cref="Poly"/></param>
        /// <param name="init"><see cref="Init"/> </param>
        /// <param name="refIn"><see cref="RefIn"/></param>
        /// <param name="refOut"><see cref="RefOut"/></param>
        /// <param name="xorOut"><see cref="XorOut"/></param>
        /// <param name="check"><see cref="Check"/></param>
        public Parameters(
            int hashSize,
            ulong poly,
            ulong init,
            bool refIn,
            bool refOut,
            ulong xorOut,
            ulong check,
            string name)
        {
            Name = name;
            HashSize = hashSize;
            Poly = poly;
            Init = init;
            RefIn = refIn;
            RefOut = refOut;
            XorOut = xorOut;
            Check = check;
        }
    }
}

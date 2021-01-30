using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LoongCrc
{
    public class Crc : HashAlgorithm
    {
        private readonly ulong _mask;

        private readonly ulong[] _table = new ulong[256];

        private ulong _currentValue;

        public Parameters Parameters { get; }

        public Crc(Parameters paremeters)
        {
            Parameters = paremeters;

            _mask = ulong.MaxValue >> (64 - Parameters.HashSize);
        }
        public override void Initialize()
        {
            throw new NotImplementedException();
        }

        protected override void HashCore(byte[] array, int ibStart, int cbSize)
        {
            throw new NotImplementedException();
        }

        protected override byte[] HashFinal()
        {
            throw new NotImplementedException();
        }
    }
}

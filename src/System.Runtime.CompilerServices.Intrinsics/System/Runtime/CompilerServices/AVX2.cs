using System;

namespace System.Runtime.CompilerServices
{
    public static class AVX2
    {
        public static uint PopulationCount(int value) { throw new NotImplementedException(); }
        public static uint PopulationCount(uint value) { throw new NotImplementedException(); }
        public static uint PopulationCount(long value) { throw new NotImplementedException(); }
        public static uint PopulationCount(ulong value) { throw new NotImplementedException(); }

        public static uint LeadingZeroCount(int value) { throw new NotImplementedException(); }
        public static uint LeadingZeroCount(uint value) { throw new NotImplementedException(); }
        public static uint LeadingZeroCount(long value) { throw new NotImplementedException(); }
        public static uint LeadingZeroCount(ulong value) { throw new NotImplementedException(); }

        public static unsafe uint Crc32(byte[] data, uint length) { throw new NotImplementedException(); }
        public static unsafe uint Crc32(byte* data, uint length) { throw new NotImplementedException(); }
        public static unsafe uint Crc32(IntPtr data, uint length) { throw new NotImplementedException(); }
    }
}
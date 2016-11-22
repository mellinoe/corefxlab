using System;

namespace System.Runtime.CompilerServices
{
    public static class ProcessorCapabilities
    {
        public static bool IsSupported(InstructionSet instructionSet) { throw new NotImplementedException(); }
        public static InstructionSet GetSupportedInstructionSet() { throw new NotImplementedException(); }
    }

    public enum InstructionSet
    {
        SSE2,
        AVX2,
    }
}
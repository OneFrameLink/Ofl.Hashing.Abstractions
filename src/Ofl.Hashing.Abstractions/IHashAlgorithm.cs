using System;

namespace Ofl.Hashing
{
    public interface IHashAlgorithm
    {
        int HashSize { get; }

        void TransformBlock(ReadOnlySpan<byte> bytes);

        ref readonly ReadOnlyMemory<byte> Hash { get; }
    }
}

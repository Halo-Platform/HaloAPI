﻿using System.IO;

namespace Halo.Lux.Cryptography
{
    public interface ISerializable
    {
        int Size { get; }

        void Serialize(BinaryWriter writer);

        void Deserialize(BinaryReader reader);
    }
}

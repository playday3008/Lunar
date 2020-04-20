﻿using System.Runtime.InteropServices;

namespace Lunar.Native.Structures
{
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    internal readonly struct ApiSetNamespace
    {
        [FieldOffset(0x0C)]
        internal readonly int Count;

        [FieldOffset(0x10)]
        internal readonly int EntryOffset;
    }
}
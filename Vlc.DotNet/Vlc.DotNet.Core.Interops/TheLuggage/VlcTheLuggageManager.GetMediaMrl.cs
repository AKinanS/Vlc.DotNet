﻿using System;
using System.Runtime.InteropServices;
using System.Text;
using Vlc.DotNet.Core.Interops.Signatures.TheLuggage;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcTheLuggageManager
    {
        public string GetMediaMrl(IntPtr mediaInstance)
        {
            if (mediaInstance == IntPtr.Zero)
                throw new ArgumentException("Media instance is not initialized.");
            var ptr = GetInteropDelegate<GetMediaMrl>().Invoke(mediaInstance);
            return Marshal.PtrToStringAnsi(ptr);
        }
    }
}

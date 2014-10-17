﻿using System;
using System.Runtime.InteropServices;
using System.Text;
using Vlc.DotNet.Core.Interops.Signatures.TheLuggage;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcTheLuggageManager
    {
        public void AddOptionFlagToMedia(IntPtr mediaInstance, string option, uint flag)
        {
            if (mediaInstance == IntPtr.Zero)
                throw new ArgumentException("Media instance is not initialized.");
            var handle = GCHandle.Alloc(Encoding.UTF8.GetBytes(option), GCHandleType.Pinned);
            GetInteropDelegate<AddOptionFlagToMedia>().Invoke(mediaInstance, handle.AddrOfPinnedObject(), flag);
            handle.Free();
        }
    }
}

﻿using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Signatures.Rincewind;

namespace Vlc.DotNet.Core.Rincewind
{
    public partial class VlcMedia
    {
        private EventCallback myOnMediaSubItemTreeAddedInternalEventCallback;
        public event EventHandler<VlcMediaSubItemTreeAddedEventArgs> SubItemTreeAdded;

        private void OnMediaSubItemTreeAddedInternal(IntPtr ptr)
        {
            var args = (VlcEventArg) Marshal.PtrToStructure(ptr, typeof (VlcEventArg));
            OnMediaSubItemTreeAdded(new VlcMedia(myVlcMediaPlayer, args.MediaSubItemTreeAdded.MediaInstance));
        }

        public void OnMediaSubItemTreeAdded(VlcMedia newSubItemTreeAdded)
        {
            var del = SubItemTreeAdded;
            if (del != null)
                del(this, new VlcMediaSubItemTreeAddedEventArgs(newSubItemTreeAdded));
        }
    }
}
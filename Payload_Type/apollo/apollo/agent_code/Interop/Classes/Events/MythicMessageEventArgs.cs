using Interop.Interfaces;
using System;

namespace Interop.Classes.Events
{
    public class MythicMessageEventArgs : EventArgs
    {
        public IMythicMessage Message;

        public MythicMessageEventArgs(IMythicMessage msg) => Message = msg;
    }
}

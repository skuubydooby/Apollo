using System;
using System.IO.Pipes;
using Interop.Structs.ApolloStructs;

namespace Interop.Interfaces
{
    public interface INamedPipeCallback
    {
        void OnAsyncConnect(PipeStream pipe, out Object state);
        void OnAsyncDisconnect(PipeStream pipe, Object state);
        void OnAsyncMessageReceived(PipeStream pipe, IPCData data, Object state);
    }
}

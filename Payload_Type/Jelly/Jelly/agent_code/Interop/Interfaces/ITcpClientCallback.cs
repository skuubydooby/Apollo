using Interop.Structs.ApolloStructs;
using System;
using System.Net.Sockets;

namespace Interop.Interfaces
{
    public interface ITcpClientCallback
    {
        void OnAsyncConnect(TcpClient client, out Object state);
        void OnAsyncDisconnect(TcpClient client, Object state);
        void OnAsyncMessageReceived(TcpClient client, IPCData data, Object state);
    }
}

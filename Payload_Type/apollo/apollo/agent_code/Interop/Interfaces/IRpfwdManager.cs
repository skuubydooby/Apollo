using Interop.Structs.MythicStructs;
using System.Net.Sockets;
using Interop.Classes;

namespace Interop.Interfaces
{
    public interface IRpfwdManager
    {
        bool Route(SocksDatagram dg);
        bool AddConnection(TcpClient client, int ServerID, int port, int debugLevel, Tasking task);
        bool Remove(int id);
    }
}

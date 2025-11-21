using Interop.Structs.MythicStructs;

namespace Interop.Interfaces
{
    public interface ISocksManager
    {
        bool Route(SocksDatagram dg);

        bool Remove(int id);
    }
}

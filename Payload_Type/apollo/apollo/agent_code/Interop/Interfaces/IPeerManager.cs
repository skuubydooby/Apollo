using Interop.Classes.P2P;
using Interop.Structs.MythicStructs;
namespace Interop.Interfaces
{
    public interface IPeerManager
    {
        Peer AddPeer(PeerInformation info);
        bool Remove(string uuid);
        bool Remove(IPeer peer);
        bool Route(DelegateMessage msg);
    }
}

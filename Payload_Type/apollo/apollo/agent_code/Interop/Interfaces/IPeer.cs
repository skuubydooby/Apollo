using Interop.Structs.MythicStructs;

namespace Interop.Interfaces
{
    public interface IPeer
    {
        bool Start();
        void Stop();
        string GetUUID();
        string GetMythicUUID();
        bool Connected();
        void ProcessMessage(DelegateMessage message);
        bool Finished();
    }
}

using Interop.Types.Delegates;
using Interop.Structs.MythicStructs;
using Interop.Enums.ApolloEnums;

namespace Interop.Interfaces
{
    public interface ITaskManager
    {
        string[] GetExecutingTaskIds();
        bool CancelTask(string taskId);

        bool CreateTaskingMessage(OnResponse<TaskingMessage> onResponse);

        bool ProcessMessageResponse(MessageResponse resp);

        void AddTaskResponseToQueue(MythicTaskResponse message);

        void AddDelegateMessageToQueue(DelegateMessage delegateMessage);

        void AddSocksDatagramToQueue(MessageDirection dir, SocksDatagram dg);
        void AddRpfwdDatagramToQueue(MessageDirection dir, SocksDatagram dg);

        bool LoadTaskModule(byte[] taskAsm, string[] commands);
    }
}

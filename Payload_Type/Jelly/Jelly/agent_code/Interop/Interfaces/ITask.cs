using System.Threading.Tasks;
namespace Interop.Interfaces
{
    public interface ITask
    {
        string ID();
        void Start();
        Task CreateTasking();
        void Kill();
    }
}

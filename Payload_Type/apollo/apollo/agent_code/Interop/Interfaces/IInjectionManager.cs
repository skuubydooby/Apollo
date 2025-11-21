using Interop.Classes.Core;
using System;

namespace Interop.Interfaces
{
    public interface IInjectionManager
    {
        string[] GetTechniques();
        bool SetTechnique(string technique);
        InjectionTechnique CreateInstance(byte[] code, int pid);
        InjectionTechnique CreateInstance(byte[] code, IntPtr hProcess);
        bool LoadTechnique(byte[] assembly, string name);

        Type GetCurrentTechnique();
    }
}

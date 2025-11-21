using Interop.Structs.ApolloStructs;
using Interop.Structs.MythicStructs;
using System;
using System.Security.Principal;

namespace Interop.Interfaces
{
    public interface IIdentityManager
    {
        WindowsIdentity GetCurrentPrimaryIdentity();
        WindowsIdentity GetCurrentImpersonationIdentity();
        WindowsIdentity GetOriginal();

        bool GetCurrentLogonInformation(out ApolloLogonInformation logonInfo);

        void Revert();

        void SetPrimaryIdentity(WindowsIdentity identity);

        void SetPrimaryIdentity(IntPtr hToken);

        void SetImpersonationIdentity(WindowsIdentity identity);
        void SetImpersonationIdentity(IntPtr hToken);

        bool SetIdentity(ApolloLogonInformation token);

        IntegrityLevel GetIntegrityLevel();

        bool IsOriginalIdentity();

        (bool,IntPtr) GetSystem();

    }
}

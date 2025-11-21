using System;
using Interop.Interfaces;
using Interop.Structs.MythicStructs;

namespace Interop.Classes
{
    public abstract class SocksManager : ISocksManager
    {
        protected IAgent _agent;

        public SocksManager(IAgent agent)
        {
            _agent = agent;
        }

        public virtual bool Route(SocksDatagram dg)
        {
            throw new NotImplementedException();
        }

        public virtual bool Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}

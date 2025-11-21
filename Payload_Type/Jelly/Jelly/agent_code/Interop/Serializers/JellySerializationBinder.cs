using Interop.Structs.ApolloStructs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Interop.Serializers
{
    public class ApolloSerializationBinder : SerializationBinder
    {
        public override Type BindToType(string assemblyName, string typeName)
        {
            if (typeName == "Interop.Structs.ApolloStructs.PeerMessage")
            {
                return typeof(PeerMessage);
            }
            else
            {
                return typeof(Nullable);
            }
        }
    }
}

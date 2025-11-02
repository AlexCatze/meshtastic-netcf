using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProtoBuf;

namespace MeshtasticNETCF.Protobufs
{
    [ProtoContract]
    public class Heartbeat
    {
        [ProtoMember(1)]
        public uint nonce { get; set; }

        public Heartbeat(uint _nonce)
        {
            nonce = _nonce;
        }
    }
}

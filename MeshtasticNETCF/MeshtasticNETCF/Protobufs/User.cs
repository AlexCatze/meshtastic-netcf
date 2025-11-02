using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProtoBuf;
using MeshtasticNETCF.Enums;

namespace MeshtasticNETCF.Protobufs
{
    [ProtoContract]
    public class User
    {
        [ProtoMember(1)]
        public string Id { get; set; }

        [ProtoMember(2)]
        public string LongName { get; set; }

        [ProtoMember(3)]
        public string ShortName { get; set; }

        [ProtoMember(5)]
        public HardwareModel HardwareModel { get; set; }

        [ProtoMember(6)]
        public bool IsLicensed { get; set; }

        [ProtoMember(7)]
        public Role Role { get; set; }

        [ProtoMember(8)]
        public byte[] PublicKey { get; set; }
    }
}

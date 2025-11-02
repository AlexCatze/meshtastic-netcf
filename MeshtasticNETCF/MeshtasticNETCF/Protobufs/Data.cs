using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProtoBuf;
using MeshtasticNETCF.Enums;

namespace MeshtasticNETCF.Protobufs
{
    [ProtoContract]
    public class Data
    {
        [ProtoMember(1)]
        public PortNum Portnum { get; set; }

        [ProtoMember(2)]
        public byte[] Payload { get; set; }

        [ProtoMember(3)]
        public bool want_response { get; set; }

        [ProtoMember(4, DataFormat = DataFormat.FixedSize)]
        public uint dest { get; set; }

        [ProtoMember(5, DataFormat = DataFormat.FixedSize)]
        public uint source { get; set; }

        [ProtoMember(6, DataFormat = DataFormat.FixedSize)]
        public uint request_id { get; set; }

        [ProtoMember(7, DataFormat = DataFormat.FixedSize)]
        public uint reply_id { get; set; }

        [ProtoMember(8)]
        public uint emoji { get; set; }

        [ProtoMember(9)]
        public uint bitfield { get; set; }
    }
}

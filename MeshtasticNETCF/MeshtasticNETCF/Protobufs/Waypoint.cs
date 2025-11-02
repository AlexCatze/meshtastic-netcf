using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProtoBuf;

namespace MeshtasticNETCF.Protobufs
{
    [ProtoContract]
    public class Waypoint
    {
        [ProtoMember(1)]
        uint id { get; set; }

        [ProtoMember(2, DataFormat = DataFormat.FixedSize)]
        public int latitude_i { get; set; }

        [ProtoMember(3, DataFormat = DataFormat.FixedSize)]
        public int longitude_i { get; set; }

        [ProtoMember(4)]
        public uint expire { get; set; }

        [ProtoMember(5)]
        public uint locked_to { get; set; }
        [ProtoMember(6)]
        public string name { get; set; }

        [ProtoMember(7)]
        public string description { get; set; }

        [ProtoMember(8, DataFormat = DataFormat.FixedSize)]
        public uint icon { get; set; }
    }
}

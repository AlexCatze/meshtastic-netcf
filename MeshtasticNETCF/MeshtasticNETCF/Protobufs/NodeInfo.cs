using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProtoBuf;

namespace MeshtasticNETCF.Protobufs
{
    [ProtoContract]
    public class NodeInfo
    {
        [ProtoMember(1)]
        public int Num {get; set;}

        [ProtoMember(2)]
	    public User User {get; set;}

        [ProtoMember(3)]
        public Position Position {get; set;}

        [ProtoMember(4)]
	    public float Snr {get; set;}

        [ProtoMember(5, DataFormat = DataFormat.FixedSize)]
	    public uint last_heard {get; set;}
	    
        [ProtoMember(6)]
	    public DeviceMetrics DeviceMetrics {get; set;}
	
        [ProtoMember(7)]
        public int channel {get; set;}
	
        [ProtoMember(8)]
	    public bool via_mqtt {get; set;}

        [ProtoMember(9)]
        public int HopsAway { get; set; }

        [ProtoMember(10)]
        public bool is_favorite { get; set; }

        [ProtoMember(11)]
        public bool is_ignored { get; set; }

        [ProtoMember(12)]
        public bool is_key_manually_verified { get; set; }
    }
}

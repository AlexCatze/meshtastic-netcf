using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProtoBuf;

namespace MeshtasticNETCF.Protobufs
{
    [ProtoContract]
    public class DeviceMetrics
    {
        [ProtoMember(1)]
        public uint battery_level { get; set; }
	
        [ProtoMember(2)]
        public float voltage { get; set; }
	
        [ProtoMember(3)]
        public float channel_utilization { get; set; }
	
        [ProtoMember(4)]
        public float air_util_tx { get; set; }
	
        [ProtoMember(5)]
        public uint uptime_seconds { get; set; }
    }
}

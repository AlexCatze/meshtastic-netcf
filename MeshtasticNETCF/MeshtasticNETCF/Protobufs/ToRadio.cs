using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProtoBuf;

namespace MeshtasticNETCF.Protobufs
{
    [ProtoContract]
    public class ToRadio
    {
        [ProtoMember(1)]
		public MeshPacket Packet {get; set;}
		
        [ProtoMember(3)]
        public uint WantConfigId { get; set; }
		
        [ProtoMember(4)]
        public bool disconnect { get; set; }

        [ProtoMember(7)]
        public Heartbeat Heartbeat { get; set; }

        /*
		XModem xmodemPacket = 5;
		// MQTT Client Proxy Message (for client / phone subscribed to MQTT sending to device)
		MqttClientProxyMessage mqttClientProxyMessage = 6;
		// Heartbeat message (used to keep the device connection awake on serial)
		Heartbeat heartbeat = 7;
	};*/
    }
}

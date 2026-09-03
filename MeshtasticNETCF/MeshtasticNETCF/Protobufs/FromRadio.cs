using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProtoBuf;

namespace MeshtasticNETCF.Protobufs
{
    [ProtoContract]
    public class FromRadio
    {
        [ProtoMember(1)]
        public uint id { get; set; }

        [ProtoMember(2)]
        public MeshPacket Packet { get; set; }

        [ProtoMember(3)]
        public MyNodeInfo my_info { get; set; }

        [ProtoMember(4)]
        public NodeInfo node_info { get; set; }

        [ProtoMember(5)]
        public Config Config { get; set; }

        [ProtoMember(6)]
        public LogRecord log_record { get; set; }

        [ProtoMember(7)]
        public uint ConfigCompleteId { get; set; }

        [ProtoMember(8)]
        public bool Rebooted { get; set; }

        [ProtoMember(9)]
        public ModuleConfig ModuleConfig { get; set; }

        [ProtoMember(10)]
        public Channel Channel { get; set; }

        [ProtoMember(11)]
        public QueueStatus queueStatus { get; set; }

        [ProtoMember(13)]
        public DeviceMetadata metadata { get; set; }

        [ProtoMember(16)]
        public ClientNotification clientNotification { get; set; }

        [ProtoMember(17)]
        public DeviceUIConfig deviceuiConfig { get; set; }

        /*
		// Queue status info
		QueueStatus queueStatus = 11;
		// File Transfer Chunk
		XModem xmodemPacket = 12;
		// MQTT Client Proxy Message (device sending to client / phone for publishing to MQTT)
		MqttClientProxyMessage mqttClientProxyMessage = 14;
		// File system manifest messages
		FileInfo fileInfo = 15;
	};*/
    }
}

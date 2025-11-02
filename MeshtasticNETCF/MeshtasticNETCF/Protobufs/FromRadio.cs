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

        /*
		// Include a part of the config (was: RadioConfig radio)
		Config config = 5;
		// Set to send debug console output over our protobuf stream
		LogRecord log_record = 6;
		// Sent as true once the device has finished sending all of the responses to want_config
		// recipient should check if this ID matches our original request nonce, if
		// not, it means your config responses haven't started yet.
		// NOTE: This ID must not change - to keep (minimal) compatibility with <1.2 version of android apps.
		uint32 config_complete_id = 7;
		// Sent to tell clients the radio has just rebooted.
		// Set to true if present.
		// Not used on all transports, currently just used for the serial console.
		// NOTE: This ID must not change - to keep (minimal) compatibility with <1.2 version of android apps.
		bool rebooted = 8;
		// Include module config
		ModuleConfig moduleConfig = 9;
		// One packet is sent for each channel
		Channel channel = 10;
		// Queue status info
		QueueStatus queueStatus = 11;
		// File Transfer Chunk
		XModem xmodemPacket = 12;
		// Device metadata message
		DeviceMetadata metadata = 13;
		// MQTT Client Proxy Message (device sending to client / phone for publishing to MQTT)
		MqttClientProxyMessage mqttClientProxyMessage = 14;
		// File system manifest messages
		FileInfo fileInfo = 15;
		// Notification message to the client
		ClientNotification clientNotification = 16;
		// Persistent data for device-ui
		DeviceUIConfig deviceuiConfig = 17;
	};*/
    }
}

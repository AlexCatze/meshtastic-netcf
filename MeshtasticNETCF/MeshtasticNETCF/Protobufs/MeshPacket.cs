using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProtoBuf;

namespace MeshtasticNETCF.Protobufs
{
    [ProtoContract]
    public class MeshPacket
    {
        [ProtoMember(1, DataFormat = DataFormat.FixedSize)]
        public uint From { get; set; }

        [ProtoMember(2, DataFormat = DataFormat.FixedSize)]
        public uint To { get; set; }

        [ProtoMember(3)]
        public uint Channel { get; set; }

        [ProtoMember(4)]
        public Data Decoded { get; set; }

        [ProtoMember(5)]
        public byte[] Encrypted { get; set; }

        [ProtoMember(6, DataFormat = DataFormat.FixedSize)]
        public uint Id { get; set; }

        [ProtoMember(7, DataFormat = DataFormat.FixedSize)]
        public uint rx_time { get; set; }

        [ProtoMember(8)]
        public float rx_snr { get; set; }

        [ProtoMember(9)]
        public uint hop_limit { get; set; }

        [ProtoMember(10)]
        public bool want_ack { get; set; }

        [ProtoMember(11)]
        MeshPacket.Priority priority { get; set; }

        [ProtoMember(12)]
        public int rx_rssi { get; set; }

        [ProtoMember(14)]
        public bool via_mqtt { get; set; }

        [ProtoMember(15)]
        public uint hop_start { get; set; }

        [ProtoMember(16)]
        public byte[] public_key { get; set; }

        [ProtoMember(17)]
        public bool pki_encrypted { get; set; }

        [ProtoMember(18)]
        public uint next_hop { get; set; }

        [ProtoMember(19)]
        public uint relay_node { get; set; }

        [ProtoMember(20)]
        public uint tx_after { get; set; }

        [ProtoMember(21)]
        MeshPacket.TransportMechanism transport_mechanism { get; set; }

        public enum TransportMechanism
        {
            // The default case is that the node generated a packet itself
            TRANSPORT_INTERNAL = 0,
            // Arrived via the primary LoRa radio
            TRANSPORT_LORA = 1,
            // Arrived via a secondary LoRa radio
            TRANSPORT_LORA_ALT1 = 2,
            // Arrived via a tertiary LoRa radio
            TRANSPORT_LORA_ALT2 = 3,
            // Arrived via a quaternary LoRa radio
            TRANSPORT_LORA_ALT3 = 4,
            // Arrived via an MQTT connection
            TRANSPORT_MQTT = 5,
            // Arrived via Multicast UDP
            TRANSPORT_MULTICAST_UDP = 6,
            // Arrived via API connection
            TRANSPORT_API = 7,
        }

        public enum Delayed
        {
            // If unset, the message is being sent in real time.
            NO_DELAY = 0,
            // The message is delayed and was originally a broadcast
            DELAYED_BROADCAST = 1,
            // The message is delayed and was originally a direct message
            DELAYED_DIRECT = 2,
        }

        public enum Priority
        {
            // Treated as Priority.DEFAULT
            UNSET = 0,
            // TODO: REPLACE
            MIN = 1,
            // Background position updates are sent with very low priority -
            // if the link is super congested they might not go out at all
            BACKGROUND = 10,
            // This priority is used for most messages that don't have a priority set
            DEFAULT = 64,
            // If priority is unset but the message is marked as want_ack,
            // assume it is important and use a slightly higher priority
            RELIABLE = 70,
            // If priority is unset but the packet is a response to a request, we want it to get there relatively quickly.
            // Furthermore, responses stop relaying packets directed to a node early.
            RESPONSE = 80,
            // Higher priority for specific message types (portnums) to distinguish between other reliable packets.
            HIGH = 100,
            // Higher priority alert message used for critical alerts which take priority over other reliable packets.
            ALERT = 110,
            // Ack/naks are sent with very high priority to ensure that retransmission
            // stops as soon as possible
            ACK = 120,
            // TODO: REPLACE
            MAX = 127,
        }
    }
}

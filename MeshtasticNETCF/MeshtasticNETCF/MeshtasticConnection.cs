using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MeshtasticNETCF.Protobufs;
using ProtoBuf;
using System.IO;

namespace MeshtasticNETCF
{
    public class MeshtasticConnection
    {
        public const int DEFAULT_BAUD_RATE = 115200;
        public const int DEFAULT_READ_TIMEOUT = 15000;
        public const int MAX_TO_FROM_RADIO_LENGTH = 512;

        public static byte[] PACKET_FRAME_START = new byte[] { 0x94, 0xc3 };
        public static byte[] SERIAL_PREAMBLE = new byte[]
    {
        PACKET_FRAME_START[1],
        PACKET_FRAME_START[1],
        PACKET_FRAME_START[1],
        PACKET_FRAME_START[1]
    };

        public const int PACKET_HEADER_LENGTH = 4;
        public static byte[] GetPacketHeader(byte[] data)
        {
            return
                new byte[] {
            PACKET_FRAME_START[0],
            PACKET_FRAME_START[1],
            (byte)((data.Length >> 8) & 0xff),
            (byte)(data.Length & 0xff),
        };
        }

        public static byte[] CreatePacket(byte[] data)
        {
            return
                GetPacketHeader(data)
                .Concat(data)
                .ToArray();
        }

        protected List<byte> Buffer { get; set; }
        protected int PacketLength { get; set; }
        public readonly DeviceStateContainer DeviceStateContainer = new DeviceStateContainer();

        public MeshtasticConnection()
        {
            Buffer = new List<byte>();
        }

        protected bool ParsePackets(byte item, Func<FromRadio, DeviceStateContainer, bool> isComplete)
        {
            int bufferIndex = Buffer.Count;
            Buffer.Add(item);
            if (bufferIndex == 0 && item != PACKET_FRAME_START[0])
                Buffer.Clear();
            else if (bufferIndex == 1 && item != PACKET_FRAME_START[1])
                Buffer.Clear();
            else if (bufferIndex >= PACKET_HEADER_LENGTH - 1)
            {
                PacketLength = (Buffer[2] << 8) + Buffer[3];
                if (bufferIndex == PACKET_HEADER_LENGTH - 1 && PacketLength > MAX_TO_FROM_RADIO_LENGTH)
                {
                    //Logger.LogTrace("Packet failed size validation");
                    Buffer.Clear();
                }

                if (Buffer.Count > 0 && (bufferIndex + 1) >= (PacketLength + PACKET_HEADER_LENGTH))
                {
                    var payload = Buffer.Skip(PACKET_HEADER_LENGTH).ToArray();
                    //var message = new FromDeviceMessage(Logger);
                    var fromRadio = ParseFromRadio(payload);

                    if (fromRadio != null)
                    {
                        //DeviceStateContainer.AddFromRadio(fromRadio);
                        //Logger.LogDebug("Received: " + fromRadio);
                        // Use telemetry packets as a cue to keep the connection alive
                        if (fromRadio.GetPayload<Telemetry>() != null)
                        {
                            //Logger.LogDebug("Sending heartbeat");
                            WriteToRadio(MessageFactory.CreateKeepAliveMessage());
                        }

                        if (isComplete(fromRadio, DeviceStateContainer))
                        {
                            Buffer.Clear();
                            return true;
                        }
                    }
                    else
                    {
                        //Logger.LogDebug("Notification of pending packets " + Convert.ToBase64String(payload));
                    }
                    Buffer.Clear();
                }
            }
            return false;
        }

        private FromRadio ParseFromRadio(byte[] buffer)
        {
            using (var stream = new MemoryStream(buffer))
            {
                return Serializer.Deserialize<FromRadio>(stream);
            }
        }

        public void WriteToRadio(ToRadio toRadio)
        {
        }
    }
}

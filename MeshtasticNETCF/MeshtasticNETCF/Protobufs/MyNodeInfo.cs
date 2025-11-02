using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProtoBuf;
using MeshtasticNETCF.Enums;

namespace MeshtasticNETCF.Protobufs
{
    [ProtoContract]
    public class MyNodeInfo
    {
        [ProtoMember(1)]
        public uint my_node_num { get; set; }

        [ProtoMember(8)]
        public uint reboot_count { get; set; }

        [ProtoMember(11)]
        public uint min_app_version { get; set; }

        [ProtoMember(12)]
        public byte[] device_id { get; set; }

        [ProtoMember(13)]
        public string pio_env { get; set; }

        [ProtoMember(14)]
        FirmwareEdition firmware_edition { get; set; }

        [ProtoMember(15)]
        public uint nodedb_count { get; set; }
    }
}

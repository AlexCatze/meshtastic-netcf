using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProtoBuf;

namespace MeshtasticNETCF.Protobufs
{
    [ProtoContract]
    public class Position
    {
        [ProtoMember(1, DataFormat = DataFormat.FixedSize)]
        public int latitude_i { get; set; }

        [ProtoMember(2, DataFormat = DataFormat.FixedSize)]
        public int longitude_i { get; set; }

        [ProtoMember(3)]
        public int altitude { get; set; }

        [ProtoMember(4, DataFormat = DataFormat.FixedSize)]
        public uint time { get; set; }

        [ProtoMember(5)]
        Position.LocSource location_source { get; set; }

        [ProtoMember(6)]
        Position.AltSource altitude_source { get; set; }

        [ProtoMember(7, DataFormat = DataFormat.FixedSize)]
        public uint timestamp { get; set; }

        [ProtoMember(8)]
        public int timestamp_millis_adjust { get; set; }

        [ProtoMember(9)]
        public int altitude_hae { get; set; }

        [ProtoMember(10)]
        public int altitude_geoidal_separation { get; set; }

        [ProtoMember(11)]
        public uint PDOP { get; set; }

        [ProtoMember(12)]
        public uint HDOP { get; set; }

        [ProtoMember(3)]
        public uint VDOP { get; set; }

        [ProtoMember(14)]
        public uint gps_accuracy { get; set; }

        [ProtoMember(15)]
        public uint ground_speed { get; set; }

        [ProtoMember(16)]
        public uint ground_track { get; set; }

        [ProtoMember(17)]
        public uint fix_quality { get; set; }

        [ProtoMember(18)]
        public uint fix_type { get; set; }

        [ProtoMember(19)]
        public uint sats_in_view { get; set; }

        [ProtoMember(20)]
        public uint sensor_id { get; set; }

        [ProtoMember(21)]
        public uint next_update { get; set; }

        [ProtoMember(22)]
        public uint seq_number { get; set; }

        [ProtoMember(23)]
        public uint precision_bits { get; set; }

        public enum LocSource
        {
            LOC_UNSET = 0,
            LOC_MANUAL = 1,
            LOC_INTERNAL = 2,
            LOC_EXTERNAL = 3,
        }

        enum AltSource
        {
            ALT_UNSET = 0,
            ALT_MANUAL = 1,
            ALT_INTERNAL = 2,
            ALT_EXTERNAL = 3,
            ALT_BAROMETRIC = 4,
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProtoBuf;

namespace MeshtasticNETCF.Protobufs
{
    [ProtoContract]
    public class Telemetry
    {

        [ProtoMember(1, DataFormat = DataFormat.FixedSize)]
	    public uint time {get;set;}

        [ProtoMember(2)]
        public DeviceMetrics device_metrics { get; set; }
        /*
		// Weather station or other environmental metrics
		EnvironmentMetrics environment_metrics = 3;
		// Air quality metrics
		AirQualityMetrics air_quality_metrics = 4;
		// Power Metrics
		PowerMetrics power_metrics = 5;
		// Local device mesh statistics
		LocalStats local_stats = 6;
		// Health telemetry metrics
		HealthMetrics health_metrics = 7;
		// Linux host metrics
		HostMetrics host_metrics = 8;*/
    }
}

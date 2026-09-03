using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MeshtasticNETCF.Protobufs;
using ProtoBuf;
using MeshtasticNETCF.Enums;
using System.IO;

namespace MeshtasticNETCF
{
    public static class Extensions
    {
        public static Type GetPacketType(this FromRadio fromRadio) 
        {
            if (fromRadio.Packet != null) return typeof(MeshPacket);
            if (fromRadio.my_info != null) return typeof(MyNodeInfo);
            if (fromRadio.node_info != null) return typeof(NodeInfo);
            if (fromRadio.ModuleConfig != null) return typeof(ModuleConfig);
            if (fromRadio.Channel != null) return typeof(Channel);
            if (fromRadio.Config != null) return typeof(Config);
            if (fromRadio.clientNotification != null) return typeof(ClientNotification);
            if (fromRadio.deviceuiConfig != null) return typeof(DeviceUIConfig);
            if (fromRadio.log_record != null) return typeof(LogRecord);
            if (fromRadio.metadata != null) return typeof(DeviceMetadata);
            if (fromRadio.queueStatus != null) return typeof(QueueStatus);
            if (fromRadio.Rebooted) return typeof(bool);
            if (fromRadio.ConfigCompleteId != 0) return typeof(uint);

            return null;
        }

        public static TResult GetPayload<TResult>(this FromRadio fromRadio) where TResult : class
        {
            if (fromRadio.Packet == null) return null;

            var packet = fromRadio.Packet;

            if (
                (typeof(TResult) == typeof(Telemetry) && fromRadio.Packet.Decoded.Portnum == PortNum.TELEMETRY_APP) ||
                (typeof(TResult) == typeof(NodeInfo) && fromRadio.Packet.Decoded.Portnum == PortNum.NODEINFO_APP) ||
                (typeof(TResult) == typeof(Waypoint) && fromRadio.Packet.Decoded.Portnum == PortNum.WAYPOINT_APP) ||
                (typeof(TResult) == typeof(string) && fromRadio.Packet.Decoded.Portnum == PortNum.TEXT_MESSAGE_APP)
             )
                using (var stream = new MemoryStream(fromRadio.Packet.Decoded.Payload))
                    return Serializer.Deserialize<TResult>(stream);


            /*
             
        if (typeof(TResult) == typeof(AdminMessage) && fromRadio.Packet?.Decoded?.Portnum == PortNum.AdminApp)
            return AdminMessage.Parser.ParseFrom(fromRadio.Packet?.Decoded?.Payload) as TResult;

        else if (typeof(TResult) == typeof(RouteDiscovery) && fromRadio.Packet?.Decoded?.Portnum == PortNum.TracerouteApp)
            return RouteDiscovery.Parser.ParseFrom(fromRadio.Packet?.Decoded?.Payload) as TResult;

        else if (typeof(TResult) == typeof(Routing) && fromRadio.Packet?.Decoded?.Portnum == PortNum.RoutingApp)
            return Routing.Parser.ParseFrom(fromRadio.Packet?.Decoded?.Payload) as TResult;

        else if (typeof(TResult) == typeof(Position) && fromRadio.Packet?.Decoded?.Portnum == PortNum.PositionApp)
            return Position.Parser.ParseFrom(fromRadio.Packet?.Decoded?.Payload) as TResult;

        else 

        else if (typeof(TResult) == typeof(NodeInfo) && fromRadio.Packet?.Decoded?.Portnum == PortNum.NodeinfoApp)
            return NodeInfo.Parser.ParseFrom(fromRadio.Packet?.Decoded?.Payload) as TResult;

        else if (typeof(TResult) == typeof(Waypoint) && fromRadio.Packet?.Decoded?.Portnum == PortNum.WaypointApp)
            return NodeInfo.Parser.ParseFrom(fromRadio.Packet?.Decoded?.Payload) as TResult;

        else if (typeof(TResult) == typeof(string) && fromRadio.Packet?.Decoded?.Portnum == PortNum.TextMessageApp)
            return fromRadio.Packet?.Decoded?.Payload.ToStringUtf8() as TResult;

        else if (typeof(TResult) == typeof(string) && fromRadio.Packet?.Decoded?.Portnum == PortNum.SerialApp)
            return fromRadio.Packet?.Decoded?.Payload.ToStringUtf8() as TResult;
             */

            return null;
        }
    }
}

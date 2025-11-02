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
        public static TResult GetPayload<TResult>(this FromRadio fromRadio) where TResult : class
        {
            if (fromRadio.Packet == null) return null;

            var packet = fromRadio.Packet;

            if (
                (typeof(TResult) == typeof(Telemetry) && fromRadio.Packet.Decoded.Portnum == PortNum.TELEMETRY_APP) ||
                (typeof(TResult) == typeof(NodeInfo) && fromRadio.Packet.Decoded.Portnum == PortNum.NODEINFO_APP) ||
                (typeof(TResult) == typeof(Waypoint) && fromRadio.Packet.Decoded.Portnum == PortNum.WaypointApp) ||
                (typeof(TResult) == typeof(string) && fromRadio.Packet.Decoded.Portnum == PortNum.TextMessageApp)
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

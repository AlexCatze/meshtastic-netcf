using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MeshtasticNETCF.Protobufs;

namespace MeshtasticNETCF
{
    public class MessageFactory
    {
        private static Random SharedRandom = new Random();

        public static ToRadio CreateKeepAliveMessage() {return
       new ToRadio()
       {
           Heartbeat = new Heartbeat((uint)SharedRandom.Next())
       };}

    public static ToRadio CreateWantConfigMessage() {return
        new ToRadio()
        {
            WantConfigId = (uint)SharedRandom.Next(),
        };}

    public static ToRadio CreateWantConfigOnlyMessage() {return
        new ToRadio()
        {
            WantConfigId = 69420,
        };}

    public static ToRadio CreateWantConfigOnlyNodesMessage() {return
        new ToRadio()
        {
            WantConfigId = 69421,
        };}

    public static ToRadio CreateMeshPacketMessage(MeshPacket packet) {return
        new ToRadio()
        {
            Packet = packet
        };}
    }
}

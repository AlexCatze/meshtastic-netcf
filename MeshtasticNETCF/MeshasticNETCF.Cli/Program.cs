using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using MeshtasticNETCF.Connections;
using MeshtasticNETCF;
using System.Threading;
using MeshtasticNETCF.Protobufs;

namespace MeshasticNETCF.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = new NativeSerialConnection("COM11", 115200);
            connection.Open();
            connection.OnPacketReceived += new EventHandler<NativeSerialConnection.PacketEventArgs>(connection_OnPacketReceived);

            connection.WriteToRadio(MessageFactory.CreateWantConfigMessage());

            Thread.Sleep(10000);

            connection.Close();
        }

        static void connection_OnPacketReceived(object sender, NativeSerialConnection.PacketEventArgs e)
        {
            Console.WriteLine("Got packet " + e.Packet.GetPacketType());
            if (e.Packet.GetPacketType() == typeof(NodeInfo))
            {
                Console.WriteLine(e.Packet.node_info.User.LongName);
            }
        }
    }
}

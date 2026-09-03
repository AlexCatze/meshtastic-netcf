using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MeshtasticNETCF.Protobufs;

namespace MeshtasticNETCF
{
    public class DeviceStateContainer
    {
        public MyNodeInfo MyNode;

        public List<NodeInfo> Nodes = new List<NodeInfo>();

        public List<Channel> Channel = new List<Channel>();
    }
}

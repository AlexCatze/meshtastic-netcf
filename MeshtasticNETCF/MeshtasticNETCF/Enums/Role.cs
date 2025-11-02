using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MeshtasticNETCF.Enums
{
    public enum Role {
	// Description: App connected or stand alone messaging device.
	// Technical Details: Default Role
	CLIENT = 0,
	// Description: Device that does not forward packets from other devices.
	CLIENT_MUTE = 1,
	// Description: Infrastructure node for extending network coverage by relaying messages. Visible in Nodes list.
	// Technical Details: Mesh packets will prefer to be routed over this node. This node will not be used by client apps.
	//   The wifi radio and the oled screen will be put to sleep.
	//   This mode may still potentially have higher power usage due to it's preference in message rebroadcasting on the mesh.
	ROUTER = 2,
	ROUTER_CLIENT = 3,
	// Description: Infrastructure node for extending network coverage by relaying messages with minimal overhead. Not visible in Nodes list.
	// Technical Details: Mesh packets will simply be rebroadcasted over this node. Nodes configured with this role will not originate NodeInfo, Position, Telemetry
	//   or any other packet type. They will simply rebroadcast any mesh packets on the same frequency, channel num, spread factor, and coding rate.
	// Deprecated in v2.7.11 because it creates "holes" in the mesh rebroadcast chain.
	REPEATER = 4,
	// Description: Broadcasts GPS position packets as priority.
	// Technical Details: Position Mesh packets will be prioritized higher and sent more frequently by default.
	//   When used in conjunction with power.is_power_saving = true, nodes will wake up,
	//   send position, and then sleep for position.position_broadcast_secs seconds.
	TRACKER = 5,
	// Description: Broadcasts telemetry packets as priority.
	// Technical Details: Telemetry Mesh packets will be prioritized higher and sent more frequently by default.
	//   When used in conjunction with power.is_power_saving = true, nodes will wake up,
	//   send environment telemetry, and then sleep for telemetry.environment_update_interval seconds.
	SENSOR = 6,
	// Description: Optimized for ATAK system communication and reduces routine broadcasts.
	// Technical Details: Used for nodes dedicated for connection to an ATAK EUD.
	//    Turns off many of the routine broadcasts to favor CoT packet stream
	//    from the Meshtastic ATAK plugin -> IMeshService -> Node
	TAK = 7,
	// Description: Device that only broadcasts as needed for stealth or power savings.
	// Technical Details: Used for nodes that "only speak when spoken to"
	//    Turns all of the routine broadcasts but allows for ad-hoc communication
	//    Still rebroadcasts, but with local only rebroadcast mode (known meshes only)
	//    Can be used for clandestine operation or to dramatically reduce airtime / power consumption
	CLIENT_HIDDEN = 8,
	// Description: Broadcasts location as message to default channel regularly for to assist with device recovery.
	// Technical Details: Used to automatically send a text message to the mesh
	//    with the current position of the device on a frequent interval:
	//    "I'm lost! Position: lat / long"
	LOST_AND_FOUND = 9,
	// Description: Enables automatic TAK PLI broadcasts and reduces routine broadcasts.
	// Technical Details: Turns off many of the routine broadcasts to favor ATAK CoT packet stream
	//    and automatic TAK PLI (position location information) broadcasts.
	//    Uses position module configuration to determine TAK PLI broadcast interval.
	TAK_TRACKER = 10,
	// Description: Will always rebroadcast packets, but will do so after all other modes.
	// Technical Details: Used for router nodes that are intended to provide additional coverage
	//    in areas not already covered by other routers, or to bridge around problematic terrain,
	//    but should not be given priority over other routers in order to avoid unnecessaraily
	//    consuming hops.
	ROUTER_LATE = 11,
	// Description: Treats packets from or to favorited nodes as ROUTER, and all other packets as CLIENT.
	// Technical Details: Used for stronger attic/roof nodes to distribute messages more widely
	//    from weaker, indoor, or less-well-positioned nodes. Recommended for users with multiple nodes
	//    where one CLIENT_BASE acts as a more powerful base station, such as an attic/roof node.
	CLIENT_BASE = 12,
}
}

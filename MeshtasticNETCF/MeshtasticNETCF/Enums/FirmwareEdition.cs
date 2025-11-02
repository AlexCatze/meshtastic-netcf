using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MeshtasticNETCF.Enums
{
    public enum FirmwareEdition {
	// Vanilla firmware
	VANILLA = 0,
	// Firmware for use in the Smart Citizen environmental monitoring network
	SMART_CITIZEN = 1,
	// Open Sauce, the maker conference held yearly in CA
	OPEN_SAUCE = 16,
	// DEFCON, the yearly hacker conference
	DEFCON = 17,
	// Burning Man, the yearly hippie gathering in the desert
	BURNING_MAN = 18,
	// Hamvention, the Dayton amateur radio convention
	HAMVENTION = 19,
	// Placeholder for DIY and unofficial events
	DIY_EDITION = 127,
}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MeshtasticNETCF.Enums
{
    public enum HardwareModel {
	// TODO: REPLACE
	UNSET = 0,
	// TODO: REPLACE
	TLORA_V2 = 1,
	// TODO: REPLACE
	TLORA_V1 = 2,
	// TODO: REPLACE
	TLORA_V2_1_1P6 = 3,
	// TODO: REPLACE
	TBEAM = 4,
	// The original heltec WiFi_Lora_32_V2, which had battery voltage sensing hooked to GPIO 13
	// (see HELTEC_V2 for the new version).
	HELTEC_V2_0 = 5,
	// TODO: REPLACE
	TBEAM_V0P7 = 6,
	// TODO: REPLACE
	T_ECHO = 7,
	// TODO: REPLACE
	TLORA_V1_1P3 = 8,
	// TODO: REPLACE
	RAK4631 = 9,
	// The new version of the heltec WiFi_Lora_32_V2 board that has battery sensing hooked to GPIO 37.
	// Sadly they did not update anything on the silkscreen to identify this board
	HELTEC_V2_1 = 10,
	// Ancient heltec WiFi_Lora_32 board
	HELTEC_V1 = 11,
	// New T-BEAM with ESP32-S3 CPU
	LILYGO_TBEAM_S3_CORE = 12,
	// RAK WisBlock ESP32 core: https://docs.rakwireless.com/Product-Categories/WisBlock/RAK11200/Overview/
	RAK11200 = 13,
	// B&Q Consulting Nano Edition G1: https://uniteng.com/wiki/doku.php?id=meshtastic:nano
	NANO_G1 = 14,
	// TODO: REPLACE
	TLORA_V2_1_1P8 = 15,
	// TODO: REPLACE
	TLORA_T3_S3 = 16,
	// B&Q Consulting Nano G1 Explorer: https://wiki.uniteng.com/en/meshtastic/nano-g1-explorer
	NANO_G1_EXPLORER = 17,
	// B&Q Consulting Nano G2 Ultra: https://wiki.uniteng.com/en/meshtastic/nano-g2-ultra
	NANO_G2_ULTRA = 18,
	// LoRAType device: https://loratype.org/
	LORA_TYPE = 19,
	// wiphone https://www.wiphone.io/
	WIPHONE = 20,
	// WIO Tracker WM1110 family from Seeed Studio. Includes wio-1110-tracker and wio-1110-sdk
	WIO_WM1110 = 21,
	// RAK2560 Solar base station based on RAK4630
	RAK2560 = 22,
	// Heltec HRU-3601: https://heltec.org/project/hru-3601/
	HELTEC_HRU_3601 = 23,
	// Heltec Wireless Bridge
	HELTEC_WIRELESS_BRIDGE = 24,
	// B&Q Consulting Station Edition G1: https://uniteng.com/wiki/doku.php?id=meshtastic:station
	STATION_G1 = 25,
	// RAK11310 (RP2040 + SX1262)
	RAK11310 = 26,
	// Makerfabs SenseLoRA Receiver (RP2040 + RFM96)
	SENSELORA_RP2040 = 27,
	// Makerfabs SenseLoRA Industrial Monitor (ESP32-S3 + RFM96)
	SENSELORA_S3 = 28,
	// Canary Radio Company - CanaryOne: https://canaryradio.io/products/canaryone
	CANARYONE = 29,
	// Waveshare RP2040 LoRa - https://www.waveshare.com/rp2040-lora.htm
	RP2040_LORA = 30,
	// B&Q Consulting Station G2: https://wiki.uniteng.com/en/meshtastic/station-g2
	STATION_G2 = 31,
	// ---------------------------------------------------------------------------
	// Less common/prototype boards listed here (needs one more byte over the air)
	// ---------------------------------------------------------------------------
	LORA_RELAY_V1 = 32,
	// TODO: REPLACE
	NRF52840DK = 33,
	// TODO: REPLACE
	PPR = 34,
	// TODO: REPLACE
	GENIEBLOCKS = 35,
	// TODO: REPLACE
	NRF52_UNKNOWN = 36,
	// TODO: REPLACE
	PORTDUINO = 37,
	// The simulator built into the android app
	ANDROID_SIM = 38,
	// Custom DIY device based on @NanoVHF schematics: https://github.com/NanoVHF/Meshtastic-DIY/tree/main/Schematics
	DIY_V1 = 39,
	// nRF52840 Dongle : https://www.nordicsemi.com/Products/Development-hardware/nrf52840-dongle/
	NRF52840_PCA10059 = 40,
	// Custom Disaster Radio esp32 v3 device https://github.com/sudomesh/disaster-radio/tree/master/hardware/board_esp32_v3
	DR_DEV = 41,
	// M5 esp32 based MCU modules with enclosure, TFT and LORA Shields. All Variants (Basic, Core, Fire, Core2, CoreS3, Paper) https://m5stack.com/
	M5STACK = 42,
	// New Heltec LoRA32 with ESP32-S3 CPU
	HELTEC_V3 = 43,
	// New Heltec Wireless Stick Lite with ESP32-S3 CPU
	HELTEC_WSL_V3 = 44,
	// New BETAFPV ELRS Micro TX Module 2.4G with ESP32 CPU
	BETAFPV_2400_TX = 45,
	// BetaFPV ExpressLRS "Nano" TX Module 900MHz with ESP32 CPU
	BETAFPV_900_NANO_TX = 46,
	// Raspberry Pi Pico (W) with Waveshare SX1262 LoRa Node Module
	RPI_PICO = 47,
	// Heltec Wireless Tracker with ESP32-S3 CPU, built-in GPS, and TFT
	// Newer V1.1, version is written on the PCB near the display.
	HELTEC_WIRELESS_TRACKER = 48,
	// Heltec Wireless Paper with ESP32-S3 CPU and E-Ink display
	HELTEC_WIRELESS_PAPER = 49,
	// LilyGo T-Deck with ESP32-S3 CPU, Keyboard and IPS display
	T_DECK = 50,
	// LilyGo T-Watch S3 with ESP32-S3 CPU and IPS display
	T_WATCH_S3 = 51,
	// Bobricius Picomputer with ESP32-S3 CPU, Keyboard and IPS display
	PICOMPUTER_S3 = 52,
	// Heltec HT-CT62 with ESP32-C3 CPU and SX1262 LoRa
	HELTEC_HT62 = 53,
	// EBYTE SPI LoRa module and ESP32-S3
	EBYTE_ESP32_S3 = 54,
	// Waveshare ESP32-S3-PICO with PICO LoRa HAT and 2.9inch e-Ink
	ESP32_S3_PICO = 55,
	// CircuitMess Chatter 2 LLCC68 Lora Module and ESP32 Wroom
	// Lora module can be swapped out for a Heltec RA-62 which is "almost" pin compatible
	// with one cut and one jumper Meshtastic works
	CHATTER_2 = 56,
	// Heltec Wireless Paper, With ESP32-S3 CPU and E-Ink display
	// Older "V1.0" Variant, has no "version sticker"
	// E-Ink model is DEPG0213BNS800
	// Tab on the screen protector is RED
	// Flex connector marking is FPC-7528B
	HELTEC_WIRELESS_PAPER_V1_0 = 57,
	// Heltec Wireless Tracker with ESP32-S3 CPU, built-in GPS, and TFT
	// Older "V1.0" Variant
	HELTEC_WIRELESS_TRACKER_V1_0 = 58,
	// unPhone with ESP32-S3, TFT touchscreen,  LSM6DS3TR-C accelerometer and gyroscope
	UNPHONE = 59,
	// Teledatics TD-LORAC NRF52840 based M.2 LoRA module
	// Compatible with the TD-WRLS development board
	TD_LORAC = 60,
	// CDEBYTE EoRa-S3 board using their own MM modules, clone of LILYGO T3S3
	CDEBYTE_EORA_S3 = 61,
	// TWC_MESH_V4
	// Adafruit NRF52840 feather express with SX1262, SSD1306 OLED and NEO6M GPS
	TWC_MESH_V4 = 62,
	// NRF52_PROMICRO_DIY
	// Promicro NRF52840 with SX1262/LLCC68, SSD1306 OLED and NEO6M GPS
	NRF52_PROMICRO_DIY = 63,
	// RadioMaster 900 Bandit Nano, https://www.radiomasterrc.com/products/bandit-nano-expresslrs-rf-module
	// ESP32-D0WDQ6 With SX1276/SKY66122, SSD1306 OLED and No GPS
	RADIOMASTER_900_BANDIT_NANO = 64,
	// Heltec Capsule Sensor V3 with ESP32-S3 CPU, Portable LoRa device that can replace GNSS modules or sensors
	HELTEC_CAPSULE_SENSOR_V3 = 65,
	// Heltec Vision Master T190 with ESP32-S3 CPU, and a 1.90 inch TFT display
	HELTEC_VISION_MASTER_T190 = 66,
	// Heltec Vision Master E213 with ESP32-S3 CPU, and a 2.13 inch E-Ink display
	HELTEC_VISION_MASTER_E213 = 67,
	// Heltec Vision Master E290 with ESP32-S3 CPU, and a 2.9 inch E-Ink display
	HELTEC_VISION_MASTER_E290 = 68,
	// Heltec Mesh Node T114 board with nRF52840 CPU, and a 1.14 inch TFT display, Ultimate low-power design,
	// specifically adapted for the Meshtatic project
	HELTEC_MESH_NODE_T114 = 69,
	// Sensecap Indicator from Seeed Studio. ESP32-S3 device with TFT and RP2040 coprocessor
	SENSECAP_INDICATOR = 70,
	// Seeed studio T1000-E tracker card. NRF52840 w/ LR1110 radio, GPS, button, buzzer, and sensors.
	TRACKER_T1000_E = 71,
	// RAK3172 STM32WLE5 Module (https://store.rakwireless.com/products/wisduo-lpwan-module-rak3172)
	RAK3172 = 72,
	// Seeed Studio Wio-E5 (either mini or Dev kit) using STM32WL chip.
	WIO_E5 = 73,
	// RadioMaster 900 Bandit, https://www.radiomasterrc.com/products/bandit-expresslrs-rf-module
	// SSD1306 OLED and No GPS
	RADIOMASTER_900_BANDIT = 74,
	// Minewsemi ME25LS01 (ME25LE01_V1.0). NRF52840 w/ LR1110 radio, buttons and leds and pins.
	ME25LS01_4Y10TD = 75,
	// RP2040_FEATHER_RFM95
	// Adafruit Feather RP2040 with RFM95 LoRa Radio RFM95 with SX1272, SSD1306 OLED
	// https://www.adafruit.com/product/5714
	// https://www.adafruit.com/product/326
	// https://www.adafruit.com/product/938
	//  ^^^ short A0 to switch to I2C address 0x3C
	RP2040_FEATHER_RFM95 = 76,
	// M5 esp32 based MCU modules with enclosure, TFT and LORA Shields. All Variants (Basic, Core, Fire, Core2, CoreS3, Paper) https://m5stack.com/
	M5STACK_COREBASIC = 77,
	M5STACK_CORE2 = 78,
	// Pico2 with Waveshare Hat, same as Pico
	RPI_PICO2 = 79,
	// M5 esp32 based MCU modules with enclosure, TFT and LORA Shields. All Variants (Basic, Core, Fire, Core2, CoreS3, Paper) https://m5stack.com/
	M5STACK_CORES3 = 80,
	// Seeed XIAO S3 DK
	SEEED_XIAO_S3 = 81,
	// Nordic nRF52840+Semtech SX1262 LoRa BLE Combo Module. nRF52840+SX1262 MS24SF1
	MS24SF1 = 82,
	// Lilygo TLora-C6 with the new ESP32-C6 MCU
	TLORA_C6 = 83,
	// WisMesh Tap
	// RAK-4631 w/ TFT in injection modled case
	WISMESH_TAP = 84,
	// Similar to PORTDUINO but used by Routastic devices, this is not any
	// particular device and does not run Meshtastic's code but supports
	// the same frame format.
	// Runs on linux, see https://github.com/Jorropo/routastic
	ROUTASTIC = 85,
	// Mesh-Tab, esp32 based
	// https://github.com/valzzu/Mesh-Tab
	MESH_TAB = 86,
	// MeshLink board developed by LoraItalia. NRF52840, eByte E22900M22S (Will also come with other frequencies), 25w MPPT solar charger (5v,12v,18v selectable), support for gps, buzzer, oled or e-ink display, 10 gpios, hardware watchdog
	// https://www.loraitalia.it
	MESHLINK = 87,
	// Seeed XIAO nRF52840 + Wio SX1262 kit
	XIAO_NRF52_KIT = 88,
	// Elecrow ThinkNode M1 & M2
	// https://www.elecrow.com/wiki/ThinkNode-M1_Transceiver_Device(Meshtastic)_Power_By_nRF52840.html
	// https://www.elecrow.com/wiki/ThinkNode-M2_Transceiver_Device(Meshtastic)_Power_By_NRF52840.html (this actually uses ESP32-S3)
	THINKNODE_M1 = 89,
	THINKNODE_M2 = 90,
	// Lilygo T-ETH-Elite
	T_ETH_ELITE = 91,
	// Heltec HRI-3621 industrial probe
	HELTEC_SENSOR_HUB = 92,
	// Reserved Fried Chicken ID for future use
	RESERVED_FRIED_CHICKEN = 93,
	// Heltec Magnetic Power Bank with Meshtastic compatible
	HELTEC_MESH_POCKET = 94,
	// Seeed Solar Node
	SEEED_SOLAR_NODE = 95,
	// NomadStar Meteor Pro https://nomadstar.ch/
	NOMADSTAR_METEOR_PRO = 96,
	// Elecrow CrowPanel Advance models, ESP32-S3 and TFT with SX1262 radio plugin
	CROWPANEL = 97,
	// Lilygo LINK32 board with sensors
	LINK_32 = 98,
	// Seeed Tracker L1
	SEEED_WIO_TRACKER_L1 = 99,
	// Seeed Tracker L1 EINK driver
	SEEED_WIO_TRACKER_L1_EINK = 100,
	// Muzi Works R1 Neo
	MUZI_R1_NEO = 101,
	// Lilygo T-Deck Pro
	T_DECK_PRO = 102,
	// Lilygo TLora Pager
	T_LORA_PAGER = 103,
	// M5Stack Reserved
	M5STACK_RESERVED = 104,
	// RAKwireless WisMesh Tag
	WISMESH_TAG = 105,
	// RAKwireless WisBlock Core RAK3312 https://docs.rakwireless.com/product-categories/wisduo/rak3112-module/overview/
	RAK3312 = 106,
	// Elecrow ThinkNode M5 https://www.elecrow.com/wiki/ThinkNode_M5_Meshtastic_LoRa_Signal_Transceiver_ESP32-S3.html
	THINKNODE_M5 = 107,
	// MeshSolar is an integrated power management and communication solution designed for outdoor low-power devices.
	// https://heltec.org/project/meshsolar/
	HELTEC_MESH_SOLAR = 108,
	// Lilygo T-Echo Lite
	T_ECHO_LITE = 109,
	// New Heltec LoRA32 with ESP32-S3 CPU
	HELTEC_V4 = 110,
	// M5Stack C6L
	M5STACK_C6L = 111,
	// M5Stack Cardputer Adv
	M5STACK_CARDPUTER_ADV = 112,
	// ESP32S3 main controller with GPS and TFT screen.
	HELTEC_WIRELESS_TRACKER_V2 = 113,
	// LilyGo T-Watch Ultra
	T_WATCH_ULTRA = 114,
	// ------------------------------------------------------------------------------------------------------------------------------------------
	// Reserved ID For developing private Ports. These will show up in live traffic sparsely, so we can use a high number. Keep it within 8 bits.
	// ------------------------------------------------------------------------------------------------------------------------------------------
	PRIVATE_HW = 255,
}
}

using System;

namespace VSmicro.Datatypes.Devices
{
    [Flags]
    public enum DeviceManufacturer
    {
        Unknown = 0,
        Cypress = 1,                // California, USA
        Infineon = 2,               // Neubiberg, Germany - by Siemens AG
        Microchip = 4,              // Chandler, USA - in 2016, Microchip acquired Atmel (AVR and ARM microcontrollers)
        NXP = 8,                    // Eindhoven, Netherlands - merged with Freescale Semiconductor
        Renesas = 16,               // Tokyo, Japan
        SiliconLabs = 32,           // Austin, Texas, USA - EFM32™ ARM® Cortex® 32-bit and EFM8™ 8051-based 8-bit
        STMicroelectronics = 64,    // Plan-les-Ouates, Switzerland - Franco-Italian
        TexasInstruments = 128,     // Dallas, Texas, USA
    }
}

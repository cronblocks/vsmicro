using System;

namespace VSmicro.Datatypes.Devices
{
    [Flags]
    public enum DeviceManufacturer
    {
        NONE,
        Cypress,               // California, USA
        Infineon,              // Neubiberg, Germany - by Siemens AG
        Microchip,             // Chandler, USA - in 2016, Microchip acquired Atmel (AVR and ARM microcontrollers)
        NXP,                   // Eindhoven, Netherlands - merged with Freescale Semiconductor
        Renesas,               // Tokyo, Japan
        SiliconLabs,           // Austin, Texas, USA - EFM32™ ARM® Cortex® 32-bit and EFM8™ 8051-based 8-bit
        STMicroelectronics,    // Plan-les-Ouates, Switzerland - Franco-Italian
        TexasInstruments,      // Dallas, Texas, USA
    }
}

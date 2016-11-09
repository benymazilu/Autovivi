using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Autovivi.Models
{
    public enum Options
    {
        ABS,
        [Display(Name ="Adaptive Lighting")]
        AdaptiveLighting,
        [Display(Name = "Air Conditioning")]
        AirConditioning,
        [Display(Name = "Auxiliary Heating")]
        AuxiliaryHeating,
        Bluetooth,
        [Display(Name = "Central Locking")]
        CentralLocking,
        [Display(Name = "Cruise Control")]
        CruiseControl,
        Camera,
        DSC,
        ESP,
        [Display(Name = "Electric Windows")]
        ElectricWindows,
        [Display(Name = "Hands Free Kit")]
        HandsFreeKit,
        [Display(Name = "Head-Up Display")]
        HeadUpDisplay,
        [Display(Name = "Keyless Entry")]
        KeylessEntry,
        Leather,
        Led,
        [Display(Name = "Navigation System")]
        NavigationSystem,
        [Display(Name = "Parking Sensors")]
        ParkingSensors,
        Radio,
        [Display(Name = "Rain Sensor")]
        RainSensor
    }
}
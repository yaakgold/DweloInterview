using System;
using System.Collections.Generic;
using System.Text;

namespace DweloInterview.Devices
{
    public class Dimmer : IDevice
    {
        eDeviceType IDevice.DeviceType { get; set; } = eDeviceType.DIMMER;
        
        float _value { get; set; }

        public void DeleteDevice()
        {
            IDevice.Devices.Remove(this);
        }

        public string GetInfo()
        {
            return $"Dim value: {_value}";
        }

        public void ModifyInfo(float newValue)
        {
            _value = newValue;
        }
    }
}

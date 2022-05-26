using System;
using System.Collections.Generic;
using System.Text;

namespace DweloInterview.Devices
{
    public class Thermostat : IDevice
    {
        eDeviceType IDevice.DeviceType { get; set; } = eDeviceType.THERMOSTAT;

        float _value { get; set; }

        public void DeleteDevice()
        {
            IDevice.Devices.Remove(this);
        }

        public string GetInfo()
        {
            return $"The thermostat is set to: {_value}";
        }

        public void ModifyInfo(float value)
        {
            _value = value;
        }
    }
}

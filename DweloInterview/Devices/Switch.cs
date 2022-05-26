using System;
using System.Collections.Generic;
using System.Text;

namespace DweloInterview.Devices
{
    public class Switch : IDevice
    {
        eDeviceType IDevice.DeviceType { get; set; } = eDeviceType.SWITCH;

        float _value { get; set; }

        public void DeleteDevice()
        {
            IDevice.Devices.Remove(this);
        }

        public string GetInfo()
        {
            string turnedOnValue = _value == 0 ? "off": "on";
            return $"Switch is currently turned {turnedOnValue}";
        }

        public void ModifyInfo(float value)
        {
            _value = value;
        }
    }
}

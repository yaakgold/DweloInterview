using System;
using System.Collections.Generic;
using System.Text;

namespace DweloInterview.Devices
{
    public class Lock : IDevice
    {
        eDeviceType IDevice.DeviceType { get; set; } = eDeviceType.LOCK;

        float _value { get; set; }

        public void DeleteDevice()
        {
            IDevice.Devices.Remove(this);
        }

        public string GetInfo()
        {
            string lockedValue = _value == 0 ? "locked" : "unlocked";
            return $"Lock is currently in a {lockedValue} state";
        }

        public void ModifyInfo(float value)
        {
            _value = value;
        }
    }
}

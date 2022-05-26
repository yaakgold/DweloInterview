using System;
using System.Collections.Generic;
using System.Text;

namespace DweloInterview
{
    public class Hub
    {
        public List<IDevice> devices = new List<IDevice>();

        public void PairDevice(IDevice device)
        {
            devices.Add(device);
        }

        public string GetDeviceState(IDevice device)
        {
            return device.GetInfo();
        }

        public void RemoveDevice(IDevice device)
        {
            devices.Remove(device);
        }

        public List<IDevice> ListDevices() => devices;
    }
}

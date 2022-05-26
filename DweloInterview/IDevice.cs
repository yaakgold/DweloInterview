using System;
using System.Collections.Generic;
using System.Text;
using DweloInterview.Devices;

namespace DweloInterview
{
    public interface IDevice
    {
        public static List<IDevice> Devices = new List<IDevice>();

        protected eDeviceType DeviceType { get; set; }

        public static IDevice CreateDevice(eDeviceType type)
        {
            switch (type)
            {
                case eDeviceType.DIMMER:
                    return new Dimmer();
                case eDeviceType.LOCK:
                    return new Lock();
                case eDeviceType.SWITCH:
                    return new Switch();
                case eDeviceType.THERMOSTAT:
                    return new Thermostat();
            }

            return null;
        }

        public void DeleteDevice();

        public string GetInfo();

        public void ModifyInfo(float value);

        public static List<IDevice> ListDevices() => Devices;

    }

    public enum eDeviceType
    {
        DIMMER,
        LOCK,
        SWITCH,
        THERMOSTAT
    }
}

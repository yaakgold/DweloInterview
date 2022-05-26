using System;
using System.Collections.Generic;

namespace DweloInterview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dwelling mainDwelling = new Dwelling("The Tower");
            Hub towerHub = new Hub();

            mainDwelling.InstallHub(towerHub);

            IDevice lockDevice = IDevice.CreateDevice(eDeviceType.LOCK);
            IDevice switchDevice = IDevice.CreateDevice(eDeviceType.SWITCH);

            mainDwelling.MyHub.PairDevice(lockDevice);
            mainDwelling.MyHub.PairDevice(switchDevice);

            List<IDevice> devices = mainDwelling.MyHub.ListDevices();

            foreach (IDevice device in devices)
            {
                Console.WriteLine(mainDwelling.MyHub.GetDeviceState(device));
            }

            devices[0].ModifyInfo(1);

            IDevice thermostatDevice = IDevice.CreateDevice(eDeviceType.THERMOSTAT);

            mainDwelling.MyHub.PairDevice(thermostatDevice);
            mainDwelling.MyHub.RemoveDevice(switchDevice);

            devices[1].ModifyInfo(256);

            foreach (IDevice device in devices)
            {
                Console.WriteLine(mainDwelling.MyHub.GetDeviceState(device));
            }

            Dwelling secondDwelling = new Dwelling("Other one");

            foreach (Dwelling d in Dwelling.ListDwellings())
            {
                Console.WriteLine(d);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Antivirus.Repository
{
    public class PortRepository
    {
        public static PhysicalAddress GetMacAddress()
        {
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                // Only consider Ethernet network interfaces
                if (nic.NetworkInterfaceType != NetworkInterfaceType.Ethernet)
                {
                    Console.WriteLine(nic.GetPhysicalAddress().ToString() + " " + nic.Name.ToString());
                }
            }
            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modbus;

namespace NModBus
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Net.Sockets.TcpClient client = new System.Net.Sockets.TcpClient("127.0.0.1", 502);
            //ushort StartAddress = Convert.ToUInt16(400000);
            //ushort RegisterCount = Convert.ToUInt16(100);

            Modbus.Device.ModbusIpMaster master = Modbus.Device.ModbusIpMaster.CreateIp(client);
            //master.WriteSingleCoil(Convert.ToUInt16(0), true);

            
            //System.Threading.Thread.Sleep(5000);
            //master.WriteSingleCoil(Convert.ToUInt16(0), false);

            //System.Threading.Thread.Sleep(5000);

            bool[] readings =  master.ReadInputs(Convert.ToUInt16(0), 2);
            master.
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendModBusMessages
{
    class Program
    {
        static void Main(string[] args)
        {
           // EasyModbus.ModbusClient client = new EasyModbus.ModbusClient("127.0.0.1", 502);
            //client.Connect();

            for(var x=0; x < 10; x++)
            {
               EasyModbus.ModbusClient client = new EasyModbus.ModbusClient("127.0.0.1", 502);
                client.Connect();
                client.WriteSingleRegister(x, 1000);
                client.Disconnect();
            }

           
           

            while(true)
            {

            }
        }
    }
}

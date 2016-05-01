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



         //   WriteValuesToHoldingRegisters();
          
           
           

            while(true)
            {
                Console.ReadLine();

                WriteValuesToHoldingRegisters();

            }
        }

        private static void WriteValuesToHoldingRegisters()
        {
            //Writing the following array will write the following values in the 
            //click PLC 
            // DS1(400001) = 944
            // DS2(400002) = 1

            EasyModbus.ModbusClient client = new EasyModbus.ModbusClient("10.0.0.181", 502);
            client.Connect();
            int[] values = { 944, 1, 1, 1, 1, 2, 1, 1, 1, 500,944,1080 };
            client.WriteMultipleRegisters(1, values);
            client.Disconnect();
            bool[] inputs = client.ReadDiscreteInputs(1,10);
        }
    }
}

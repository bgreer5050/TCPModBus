using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SRModbusTCP;
using EasyModbus;

namespace SparkModbus.Console
{
    class Program
    {

        private  string ipAddress = "192.168.1.3";
        private  int port = 502;
        private ushort startAddress = 0;
        private ushort qty = 10;
        private  ModbusTCP modbusTCP;
        private EasyModbus.ModbusServer server;

        public Program()
        {
            ModbusClient modbusClient = new ModbusClient("192.168.1.3", 502);    //Ip-Address and Port of Modbus-TCP-Server
            modbusClient.Connect();                                                    //Connect to Server

            modbusClient.WriteSingleCoil(3, true);

            //modbusClient.WriteMultipleCoils(4, new bool[] { true, true, true, true, true, true, true, true, true, true });    //Write Coils starting with Address 5
            //bool[] readCoils = modbusClient.ReadCoils(9, 10);                        //Read 10 Coils from Server, starting with address 10
            //int[] readHoldingRegisters = modbusClient.ReadHoldingRegisters(0, 10);    //Read 10 Holding Registers from Server, starting with Address 1

            //// Console Output
            //for (int i = 0; i < readCoils.Length; i++)
            //    System.Console.WriteLine("Value of Coil " + (9 + i + 1) + " " + readCoils[i].ToString());

            //for (int i = 0; i < readHoldingRegisters.Length; i++)
            //    System.Console.WriteLine("Value of HoldingRegister " + (i + 1) + " " + readHoldingRegisters[i].ToString());
            modbusClient.Disconnect();                                                //Disconnect from Server
            System.Console.Write("Press any key to continue . . . ");
            System.Console.ReadKey(true);

        }

      

        static void Main(string[] args)
        {

            Program program = new Program();
            System.Console.ReadKey();



        }
    }
}

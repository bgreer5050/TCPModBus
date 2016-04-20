using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SRModbusTCP;

namespace SparkModbus.Console
{
    class Program
    {

        private  string ipAddress = "192.168.1.3";
        private  int port = 502;
        private ushort startAddress = 0;
        private ushort qty = 10;
        private  ModbusTCP modbusTCP;


        public Program()
        {
            modbusTCP = new ModbusTCP(ipAddress, port);
            modbusTCP.Connect();
            //int[] response = modbusTCP.ReadInputRegisters(startAddress, qty);
            bool[] response = modbusTCP.ReadDiscreteInputs(40001, qty);
          

            modbusTCP.Disconnect();

            System.Console.WriteLine("Reg 1: " + response[0].ToString());
            System.Console.WriteLine("Reg 2: " + response[1].ToString());
            System.Console.WriteLine("Reg 1: " + response[2].ToString());
            System.Console.WriteLine("Reg 1: " + response[3].ToString());
            System.Console.WriteLine("Reg 1: " + response[4].ToString());
            System.Console.WriteLine("Reg 1: " + response[5].ToString());
            System.Console.WriteLine("Reg 1: " + response[6].ToString());
            System.Console.WriteLine("Reg 1: " + response[7].ToString());
            System.Console.WriteLine("Reg 1: " + response[8].ToString());
            System.Console.WriteLine("Reg 1: " + response[9].ToString());

        }


        static void Main(string[] args)
        {

            Program program = new Program();
            System.Console.ReadKey();



        }
    }
}

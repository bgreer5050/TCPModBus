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
            System.Console.Beep();

           server  = new ModbusServer();
            server.Port = 502;
            server.numberOfConnectedClientsChanged += Server_numberOfConnectedClientsChanged;
            server.Listen();
            while(true)
            {
                System.Console.WriteLine(server.NumberOfConnections.ToString());
                //server.coilsChanged += Server_coilsChanged;
                //server.holdingRegistersChanged += Server_coilsChanged;
                server.logDataChanged += Server_coilsChanged;
            }
        }

      

        private void Server_coilsChanged()
        {
            System.Console.Beep();
            bool[] coils = server.coils;

            System.Console.WriteLine(coils.Where(c => c.ToString() == "true").Count());
            System.Console.WriteLine("Coils Changed");

        }

        private void Server_numberOfConnectedClientsChanged()
        {
            System.Console.Beep();
            System.Console.WriteLine("Changed");
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            System.Console.ReadKey();
        }
    }
}

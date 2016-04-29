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

        //private  string ipAddress = "192.168.1.3";
        private  int port = 502;
        private ushort startAddress = 0;
        private ushort qty = 10;

        // TODO Implement modbusTCP as a client
        private  ModbusTCP modbusTCP;

        private EasyModbus.ModbusServer server502;
        private EasyModbus.ModbusServer server503;
        private EasyModbus.ModbusServer server504;
        private EasyModbus.ModbusServer server505;
        private EasyModbus.ModbusServer server502_2;



        public Program()
        {
            System.Console.Beep();
            List<EasyModbus.ModbusServer> Servers = new List<ModbusServer>();

            //Instantiate Our Servers
            server502 = new ModbusServer();
            server503 = new ModbusServer();
            server504 = new ModbusServer();
            server505 = new ModbusServer();
            server502_2 = new ModbusServer();

            //Assign Ports
            server502.Port = 502;
            server503.Port = 503;
            server504.Port = 504;
            server505.Port = 505;
            server502_2.Port = 502;

            //Add servers to list of servers
            Servers.Add(server502);
            Servers.Add(server503);
            Servers.Add(server504);
            Servers.Add(server505);
            Servers.Add(server502_2);


            //Create seperate threads and event handlers for each server
            foreach(ModbusServer item in Servers)
            {
                item.holdingRegistersChanged += Item_holdingRegistersChanged;
            }


            //server502.holdingRegistersChanged += Server_holdingRegistersChanged;

            while (true)
            {
                //System.Console.WriteLine(server.NumberOfConnections.ToString());
              


                //server.holdingRegistersChanged += Server_coilsChanged;
                
                //server.logDataChanged += Server_coilsChanged;
            }
        }

        private void Item_holdingRegistersChanged()
        {
            System.Console.Beep(); System.Console.Beep();
            System.Console.WriteLine("Holding Registers Changed ************************ ");
            System.Console.WriteLine(server502.holdingRegisters[0].ToString());
            System.Console.WriteLine(server502.holdingRegisters[1].ToString());
            System.Console.WriteLine(server502.holdingRegisters[2].ToString());
            System.Console.WriteLine(server502.holdingRegisters[3].ToString());
        }

        private void Server_holdingRegistersChanged()
        {
            System.Console.Beep(); System.Console.Beep();
            System.Console.WriteLine("Holding Registers Changed ************************ ");
            System.Console.WriteLine(server502.holdingRegisters[0].ToString());
            System.Console.WriteLine(server502.holdingRegisters[1].ToString());
            System.Console.WriteLine(server502.holdingRegisters[2].ToString());
            System.Console.WriteLine(server502.holdingRegisters[3].ToString());
                        
        }

        private void Server_coilsChanged()
        {
            System.Console.Beep(); System.Console.Beep();
            bool[] coils = server502.coils;

            //System.Console.WriteLine(coils.Where(c => c.ToString() == "true").Count());
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

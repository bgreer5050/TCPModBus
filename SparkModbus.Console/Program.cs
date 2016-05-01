using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SRModbusTCP;
using EasyModbus;
using SparkCycleListener.DataModel;

namespace SparkModbus.Console
{
    class Program
    {

        //private  string ipAddress = "192.168.1.3";
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

            server.coilsChanged += Server_coilsChanged;


            server.holdingRegistersChanged += Server_holdingRegistersChanged;

            while (true)
            {
                //System.Console.WriteLine(server.NumberOfConnections.ToString());



                //server.holdingRegistersChanged += Server_coilsChanged;

                //server.logDataChanged += Server_coilsChanged;\\

            }
        }

        private void Server_holdingRegistersChanged()
        {
            System.Console.Beep(); System.Console.Beep();
            System.Console.WriteLine("Holding Registers Changed ************************ ");
            System.Console.WriteLine("Holding Register at  0: " + server.holdingRegisters[0].ToString());
            System.Console.WriteLine("Holding Register at  1: " + server.holdingRegisters[1].ToString());
            System.Console.WriteLine("Holding Register at  2: " + server.holdingRegisters[2].ToString());
            System.Console.WriteLine("Holding Register at  3: " + server.holdingRegisters[3].ToString());
            System.Console.WriteLine(DateTime.Now.ToLocalTime());

            bool blnState;
            if(server.holdingRegisters[2]==0)
            {
                blnState = false;
            }
            else
            {
                blnState = true;
            }

            SparkCycleListener.DataModel.MachineStateDataContext db = new MachineStateDataContext();
            MachineState state = new MachineState{ AssetNumber = server.holdingRegisters[1].ToString(), DateTime = DateTime.Now.ToLocalTime(), MachineState1 = int.Parse(server.holdingRegisters[2].ToString()) };
            db.MachineStates.InsertOnSubmit(state);
            db.SubmitChanges();
            db.Dispose();
        }

        private void Server_coilsChanged()
        {
            System.Console.Beep(); System.Console.Beep();
            bool[] coils = server.coils;

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

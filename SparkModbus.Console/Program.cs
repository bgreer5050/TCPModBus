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


        List<MachineState> recentMachineStateEntries = new List<MachineState>(); //Used to prevent duplicate entries
      

        public Program()
        {
            System.Console.Beep();

            server  = new ModbusServer();
            server.Port = 502;
           
            server.Listen();

          


            server.holdingRegistersChanged += Server_holdingRegistersChanged;

            while (true)
            {
               

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
            bool blnContinue = true;
            if (server.holdingRegisters[2]==0)
            {
                blnState = false;
            }
            else
            {
                blnState = true;
            }

            var mostRecentEvent = recentMachineStateEntries.OrderByDescending(c => c.DateTime).Where(c => c.AssetNumber == server.holdingRegisters[1].ToString()).FirstOrDefault();

            if (mostRecentEvent != null)
            {
                TimeSpan ts = DateTime.Now.ToLocalTime() - mostRecentEvent.DateTime;
                System.Console.WriteLine(ts.TotalSeconds);

                if(ts.TotalMilliseconds > 3000)
                {
                    blnContinue = true;
                }
                else
                {
                    blnContinue = false;
                }
            }
            else
            {
                blnContinue = true;
            }


            if(blnContinue==true)
            {
                SparkCycleListener.DataModel.CloudSparkContextDataContext db = new CloudSparkContextDataContext();


                MachineState state = new MachineState { AssetNumber = server.holdingRegisters[1].ToString(), DateTime = DateTime.Now.ToLocalTime(), MachineState1 = int.Parse(server.holdingRegisters[2].ToString()) };
                db.MachineStates.InsertOnSubmit(state);


                recentMachineStateEntries.Remove(recentMachineStateEntries.OrderBy(c => c.DateTime).FirstOrDefault());

                recentMachineStateEntries.Add(state);
                db.SubmitChanges();
                db.Dispose();
            }

           
        }

       

       

        static void Main(string[] args)
        {
            Program program = new Program();
            System.Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using SRModbusTCP;
using EasyModbus;

namespace SparkModbus.Console
{
    class Program
    {

       


        public Program()
        {
           

        }


        static void Main(string[] args)
        {

            ModbusClient client = new ModbusClient("192.168.1.3", 502);
            client.Connect();

            for(var x=0; x < 1000; x++)
            {
                client.WriteSingleCoil(x, true);
                System.Threading.Thread.Sleep(250);
                System.Console.WriteLine(x.ToString());
            }

            for (var x = 0; x < 1000; x++)
            {
                client.WriteSingleCoil(x, false);
                System.Threading.Thread.Sleep(250);

            }



            System.Console.ReadKey();





        }
    }
}

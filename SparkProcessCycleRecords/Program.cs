using SparkCycleListener.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkProcessCycleRecords
{
    class Program
    {
      public static  System.Threading.SemaphoreSlim slim;
        static void Main(string[] args)
        {
          slim = new System.Threading.SemaphoreSlim(1, 1);


            System.Threading.Timer timer = new System.Threading.Timer(ProcessCycleRecords, null, 1000, 5000);
            ProcessCycleRecords(null);
            while(true)
            {

            }

        }

        
        private static void ProcessCycleRecords(object state)
        {
            slim.Wait(System.Threading.Timeout.Infinite);

            SparkCycleListener.DataModel.MachineStateDataContext db = new SparkCycleListener.DataModel.MachineStateDataContext();
            Console.WriteLine("Run");


            //List<SparkCycleListener.DataModel.MachineState> states = db.MachineStates.Where(c => c.Processed == false).OrderBy(c => c.AssetNumber).ThenBy(c => c.DateTime).GroupBy(c=>c.AssetNumber).ToList()
            var states = db.MachineStates.GroupBy(c => c.AssetNumber);
            

            foreach (IGrouping<string,MachineState> group in states)
            {
                Console.WriteLine(group.Key);

                

                foreach(var st in group)
                {
                    Console.WriteLine(st.AssetNumber + " " + st.MachineState1 + " " + st.DateTime);

                }
                Console.ReadLine();

            }
            slim.Release();
        }
    }
}

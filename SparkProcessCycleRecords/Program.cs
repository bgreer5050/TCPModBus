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
                    bool blnOkayToPost = false;
                    Console.WriteLine(st.AssetNumber + " " + st.MachineState1 + " " + st.DateTime);

                    //Get the last entry that was processed for the same asset number to see if we need to post this one or if it's a duplicate or
                    //another RUN or just too close in time indicating a possible debounce issue.
                    MachineState previousMachineStatePosted = db.MachineStates.OrderByDescending(c => c.DateTime).Where(c => c.Processed == false && c.AssetNumber == st.AssetNumber).FirstOrDefault();
                    ExpectedCycleTimeDataContext cycleTimeDB = new ExpectedCycleTimeDataContext();
                    if(previousMachineStatePosted != null)
                    {
                        if(st.MachineState1 == 1 && previousMachineStatePosted.MachineState1 == 1)
                        {
                            blnOkayToPost = false;

                        }
                    }
                    else
                    {
                        blnOkayToPost = true;
                    }


                }
                Console.ReadLine();

            }
            slim.Release();
        }
    }
}

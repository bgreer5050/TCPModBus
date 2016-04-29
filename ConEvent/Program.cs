using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            SparkMessageList list = new SparkMessageList();
            list.messageHadler += new SparkMessageList.BlahHandler(HandleEvent)

            Console.WriteLine("......");
            Console.ReadLine();
            list.MyProperty = "test";
            Console.WriteLine("......");

        }

        public void HandleEvent(SparkMessageList message)
        {
            Console.WriteLine("Something Happened In MesssgeGadler");
        }
    }

    public class SparkMessageList
    {
        public delegate void BlahHandler(SparkMessageList message);
        public event BlahHandler messageHadler; //Declare Event

        private string myVar;

        public string MyProperty
        {
            get { return myVar; }
            set {
                myVar = value;
                messageHadler(this);
            }
        }


    }

    public class MessageGadler
    {
        public void DoSomethign()
        {
            SparkMessageList list = new SparkMessageList();
            list.messageHadler += new SparkMessageList.BlahHandler(HandleEvent); // List_messageHadler;



        }

       

    }
}

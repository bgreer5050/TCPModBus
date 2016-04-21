using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NModBus.Desktop
{
    public partial class Form1 : Form
    {
        int intToggle = 0;
      


        public Form1()
        {
            InitializeComponent();

        }

        private void btnReadDigitalInputs_Click(object sender, EventArgs e)
        {
            //ushort StartAddress = Convert.ToUInt16(400000);
            //ushort RegisterCount = Convert.ToUInt16(100);

            //master.WriteSingleCoil(Convert.ToUInt16(0), true);


            //System.Threading.Thread.Sleep(5000);
            //master.WriteSingleCoil(Convert.ToUInt16(0), false);

            //System.Threading.Thread.Sleep(5000);

            System.Net.Sockets.TcpClient client = new System.Net.Sockets.TcpClient("192.168.1.3", 502);
            Modbus.Device.ModbusIpMaster master = Modbus.Device.ModbusIpMaster.CreateIp(client);


            master.WriteSingleRegister(Convert.ToUInt16(0), Convert.ToUInt16(210));
            master.WriteSingleCoil(Convert.ToUInt16(0), true);
          

            master.Dispose();
            client.Close();

           // MessageBox.Show(table.Columns.Count.ToString());

        }
    }
}

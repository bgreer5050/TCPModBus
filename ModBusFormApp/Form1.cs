using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModBusFormApp
{
    public partial class Form1 : Form
    {

        EasyModbus.ModbusServer server;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnSendHoldingRegister_Click(object sender, EventArgs e)
        {
            EasyModbus.ModbusClient client = new EasyModbus.ModbusClient("127.0.0.1", 502);
            client.WriteSingleRegister(400001, 100);


        }


        public void ListenForRequests()
        {
            server = new EasyModbus.ModbusServer();
            server.Listen();

            server.holdingRegistersChanged += Server_holdingRegistersChanged;
            
        }

        private void Server_holdingRegistersChanged()
        {
            lblServerValue.Text = server.holdingRegisters.Where(c => c > 0).Count().ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListenForRequests();
        }
    }
}

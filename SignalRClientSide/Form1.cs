using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignalRClientSide
{

    public partial class Form1 : Form
    {
        IHubProxy hubProxy;

        string nextmessage = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                string url = @"http://localhost:8080/";
                var connection = new HubConnection(url);
                hubProxy = connection.CreateHubProxy("HubManager");
                connection.Start().Wait();

                txtmsgs.Text = "Client is waiting for messages from the Hub Server" + Environment.NewLine;

                hubProxy.On("receiveMsgFromServer", x=> {
                    nextmessage = x;
                    txtmsgs.Invoke((MethodInvoker)(()=>txtmsgs.Text+=nextmessage+Environment.NewLine));
                });

                txtmsgs.Text += Environment.NewLine;

            }
            catch (Exception ex)
            {

                throw;
            }
          
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            try
            {
                hubProxy.Invoke("stopProcess", "BOOT").Wait();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}

using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignalRServerSide
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startHubServer();
        }

        void startHubServer()
        {
            try
            {
                string url = @"http://localhost:8080/";
                WebApp.Start<Startup>(url);                
                txtprosmsgs.Text += string.Format("Hub Server is running at {0}",url);
                txtprosmsgs.Text += Environment.NewLine;
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        private void btnBoot_Click(object sender, EventArgs e)
        {
            try
            {
                HubServer hs = new HubServer();
                hs.sendProcessNameToClients("BOOT");
            }
            catch (Exception ex)
            {

                throw;
            }
        }


        public void setTheText(string txt)
        {
            try
            {
                txtprosmsgs.Invoke((MethodInvoker)(() =>
                {
                    txtprosmsgs.Text += txt;
                    txtprosmsgs.Text += Environment.NewLine;
                }));
            }
            catch (Exception ex)
            {

                throw;
            }
        }

    }
}

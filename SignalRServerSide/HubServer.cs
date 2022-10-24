using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignalRServerSide
{
    [HubName("HubManager")]
    public class HubServer:Hub
    {

        public void sendProcessNameToClients(string pname)
        {
            try
            {
                var context = GlobalHost.ConnectionManager.GetHubContext<HubServer>();
                string msg = string.Format("Server has set the process to {0}",pname);
                context.Clients.All.receiveMsgFromServer(msg);

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void stopProcess(string pname)
        {
            try
            {
                Form1 form1 = (Form1)Application.OpenForms["Form1"];

                form1.setTheText(string.Format("{0} has stopped the process",pname));
            }
            catch (Exception ex)
            {

                throw;
            }
        }


    }
}

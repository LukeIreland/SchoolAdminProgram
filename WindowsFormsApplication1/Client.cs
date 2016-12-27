using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WindowsFormsApplication1
{
    class Client
    {
        [STAThread()]
        static void Main(string[] args)
        {
            string myHost = System.Net.Dns.GetHostName();
            string myIp = System.Net.Dns.GetHostEntry(myHost).AddressList[1].ToString();

            Uri baseAddress = new Uri("http://" + myIp + ":8080/Rlc/RemoteDesktop");

            Console.WriteLine("WCF Remote Desktop Server");
            Console.WriteLine("=========================");
            Console.WriteLine();
            Console.WriteLine("Initializing server endpoint...");
            Console.WriteLine("Listening on: " + baseAddress.ToString());
            Console.WriteLine();
            ServiceHost myServiceHost = new ServiceHost(typeof(RemoteDesktopService), baseAddress);
            myServiceHost.Open();

            Console.ReadLine();

            if (myServiceHost.State != CommunicationState.Closed)
            {
                myServiceHost.Close();
            }
        }
    }
}

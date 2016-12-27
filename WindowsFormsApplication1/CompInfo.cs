using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.Threading;
using System.Management;
using System.Runtime.Remoting;

namespace WindowsFormsApplication1
{
    public partial class CompInfo : Form
    {
        public CompInfo(CtrlComputer C)
        {
            InitializeComponent();
            this.Computer = C;
            this.label4.Text = C.Name;
            this.label5.Text = C.MACAddress;
            this.label6.Text = C.IPAddress;
        }

        private CtrlComputer _Computer;

        public CtrlComputer Computer
        {
            get { return _Computer; }
            set { _Computer = value; }
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            Shutdown(this.Computer.IPAddress);
            this.Computer.ContainerRoom.Remove(this.Computer);
        }

        void Shutdown(string IP)
        {
            string computerName = IP;
            ConnectionOptions options = new ConnectionOptions();
            options.EnablePrivileges = true;
            ManagementScope scope = new ManagementScope(
              "\\\\" + computerName + "\\root\\CIMV2", options);
            scope.Connect();
            SelectQuery query = new SelectQuery("Win32_OperatingSystem");
            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher(scope, query);
            foreach (ManagementObject os in searcher.Get())
            {
                ManagementBaseObject inParams = os.GetMethodParameters("Win32Shutdown");
                inParams["Flags"] = 1;
                ManagementBaseObject outParams = os.InvokeMethod("Win32Shutdown", inParams, null);
            }
        } 
       
        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("chrome", this.Computer.Name + ":8080");
        }   
    }
}

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



namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {       
        Room ThisRoom = new Room();
        private Panel CurrentPanel = null;
        Dictionary<string, string> F31Dictionary = new Dictionary<string, string>();
        public void SwapPanel(Panel p)
        {
            //If no panel has been placed yet, get rid of the default one
            if (RoomPanel != null)
            {
                //we should never need the designer panel again, so dispose it
                RoomPanel.Dispose();
                this.Controls.Remove(RoomPanel);
            }
            else
            {
                //we may return to this panel later, so don't dispose it
                this.Controls.Remove(CurrentPanel);
            }
            CurrentPanel = p;
            p.Size = new Size(607, 304);
            p.Location = new Point(144, 27);
            this.Controls.Add(p);
        }
        public Form1()
        {
            InitializeComponent();           
            this.Text = "Aquinas College Master Controller";

        }

        private void roomDesignerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RoomDesigner().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            roomsToolStripMenuItem.DropDownItems.Clear();
            bool DictionaryBuilt = false;
            foreach (var Room in Global.Aquinas.Aquinas)
            {
                ToolStripMenuItem NewItem = new ToolStripMenuItem(Room.RoomID);
                NewItem.Name = Room.RoomID;
                NewItem.Click += new EventHandler(RoomClick);
                roomsToolStripMenuItem.DropDownItems.Add(NewItem);
            }
            if (DictionaryBuilt == false)
            {
                BuildDictionary();
                DictionaryBuilt = true;
            }
            Room F31 = new Room();
            foreach (KeyValuePair<string, string> entry in F31Dictionary)
            {
                string IP = entry.Value;
                string Host = entry.Key;
                CtrlComputer NewComputer = new CtrlComputer();
                NewComputer.IPAddress = IP;
                NewComputer.Name = Host;
                NewComputer.Text = Host;
                NewComputer.ContainerRoom = F31;
                F31.Add(NewComputer);
            }
            LoadNetworkPanel(F31);
        }

        void RoomClick(object sender, EventArgs e)
        {
            ToolStripItem item = (ToolStripItem)sender;
            label2.Text = item.Name;
            foreach (var Room in Global.Aquinas.Aquinas)
            {
                if (Room.RoomID == item.Name)
                {
                    ThisRoom = Room;
                    break;
                }
            }
            label2.Text = ThisRoom.RoomID;
            SwapPanel(ThisRoom.Panel);
        }

        void LoadNetworkPanel(Room thisRoom)
        {
            Panel NetworkPanel = new Panel();
            NetworkPanel.Size = new Size(607, 304);
            int CW = 0;
            int CH = 0;
            foreach (CtrlComputer C in thisRoom.Computers)
            {
                NetworkPanel.Controls.Add(C);
                C.Parent = NetworkPanel;
                if (C.Width+CW>NetworkPanel.Width)
                {
                    CW=0;
                    CH = CH + C.Height;
                    if (CH > NetworkPanel.Height)
                    {
                        this.Height = this.Height + CH;
                        NetworkPanel.Height = NetworkPanel.Height + CH;          
                        C.Location = new Point(CW, CH);
                    }
                    else
                    {
                        C.Location = new Point(CW, CH);
                    }
                }
                else
                {
                    C.Location = new Point(CW, CH);
                    CW = CW + C.Width;  
                }       
            }
            SwapPanel(NetworkPanel);
        }

        void BuildDictionary()
        {
            byte[] buffer = Encoding.ASCII.GetBytes(".");
            PingOptions options = new PingOptions(50, true);
            AutoResetEvent reset = new AutoResetEvent(false);
            var IPList = GetIPs();
            foreach (var IP in IPList)
            {
                Ping p = new Ping();
                PingReply d = p.Send(IP);
                if (d.Status == IPStatus.Success)
                {
                    IPHostEntry Host = Dns.GetHostEntry(IP);
                    string HostName = Host.HostName;
                    if (HostName.Contains("f31"))
                    {
                        HostName = HostName.Substring(0, 6);
                        if (!F31Dictionary.ContainsKey(HostName))
                        {
                            F31Dictionary.Add(HostName, IP.ToString());
                        }
                        else
                        {
                            HostName = HostName + IP.ToString().Substring(10);
                        }
                    }

                }
            }
        }
        

        List<IPAddress> GetIPs()
        {
            List<IPAddress> FloorList = new List<IPAddress>();
            string Base = "10.10.118.";
            for (int i = 0; i < 255; i++)
            {
                FloorList.Add(IPAddress.Parse(Base + i.ToString()));
            }
            return FloorList;
        }
    }
}


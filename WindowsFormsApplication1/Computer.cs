using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Computer
    {
        private string _ComputerID;

        public string ComputerID
        {
            get { return _ComputerID; }
            set { _ComputerID = value; }
        }

        private string _MACAddress;

        public string MACAddress
        {
            get
            {
                return _MACAddress;
            }

            set
            {
                _MACAddress = value;
            }
        }

        public string IPAddress
        {
            get
            {
                return _IPAddress;
            }

            set
            {
                _IPAddress = value;
            }
        }

        private string _IPAddress;

        public Computer()
        {
        }
    }
}

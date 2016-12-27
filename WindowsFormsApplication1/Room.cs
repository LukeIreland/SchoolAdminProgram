using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class Room 
    {

        private List<CtrlComputer> _Computers;

        public List<CtrlComputer> Computers
        {
            get { return _Computers; }
            set { _Computers = value; }
        }

        private string _RoomID;

        public Room()
        {
            _Computers=new List<CtrlComputer>();
        }

        public string RoomID
        {
            get
            {
                return _RoomID;
            }

            set
            {
                _RoomID = value;
            }
        }

        public Panel Panel
        {
            get
            {
                return _Panel;
            }

            set
            {
                _Panel = value;
            }
        }

        private Panel _Panel;

        public void Add (CtrlComputer ThisComputer)
        {
            Computers.Add(ThisComputer);
        }

        public void Remove(CtrlComputer ThisComputer)
        {
            Computers.Remove(ThisComputer);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class CtrlComputer : UserControl
    {
        private string _ComputerID;

        private Room _ContainerRoom;

        public Room ContainerRoom
        {
            get { return _ContainerRoom; }
            set { _ContainerRoom = value; }
        }

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

        public CtrlComputer()
        {
            InitializeComponent();
            this.Text = this.Name;          
        }      

        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public override string Text
        {
            get
            {
                return label1.Text;
            }

            set
            {
                label1.Text = value;
            }
        }

        private void CompButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Top += e.Y;
                this.Left += e.X;
            }
        }

        private void CtrlComputer_Click(object sender, EventArgs e)
        {
            new CompInfo(this).Show();
        }

        private void CompButton_Click(object sender, EventArgs e)
        {
            new CompInfo(this).Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            new CompInfo(this).Show();

        }
    }
}

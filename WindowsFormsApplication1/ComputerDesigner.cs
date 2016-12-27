using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ComputerDesigner : Form
    {
        Computer NewComputer = new Computer();
        public string ID = "";
        public bool Complete = false;
        public ComputerDesigner()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            ID = textBox1.Text;
            Complete = true;
        }
    }
}

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
    public partial class RoomDesigner : Form
    {
        Room NewRoom = new Room();
        Panel RoomDesignerPanel = new Panel();
        public RoomDesigner()
        {
            InitializeComponent();
            RoomDesignerPanel.Size = new Size(607, 304);
            RoomDesignerPanel.Location = new Point(144, 27);
            RoomDesignerPanel.BackColor = Color.White;
            this.Controls.Add(RoomDesignerPanel);
            textBox1.ForeColor = SystemColors.GrayText;
            textBox1.Text = "Enter Computer ID Here";
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            textBox2.ForeColor = SystemColors.GrayText;
            textBox2.Text = "Enter Room ID Here";
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                textBox1.Text = "Enter Computer ID Here";
                textBox1.ForeColor = SystemColors.GrayText;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter Computer ID Here")
            {
                textBox1.Text = "";
                textBox1.ForeColor = SystemColors.WindowText;
            }
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                textBox2.Text = "Enter Room ID Here";
                textBox2.ForeColor = SystemColors.GrayText;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Enter Room ID Here")
            {
                textBox2.Text = "";
                textBox2.ForeColor = SystemColors.WindowText;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            CtrlComputer NewComputer = new CtrlComputer();
            NewComputer.ComputerID = textBox1.Text;
            NewComputer.Text = NewComputer.ComputerID;
            NewComputer.Parent = RoomDesignerPanel;
            RoomDesignerPanel.Controls.Add(NewComputer);
            NewRoom.Add(NewComputer);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewRoom.RoomID = textBox2.Text;
            NewRoom.Panel = RoomDesignerPanel;
            Global.Aquinas.Aquinas.Add(NewRoom);
            this.Controls.Remove(RoomDesignerPanel);
            this.Dispose();
        }
    }
}

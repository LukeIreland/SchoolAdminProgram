namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.RoomViewer = new System.Windows.Forms.MenuStrip();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AdminTool = new System.Windows.Forms.ToolStripMenuItem();
            this.roomDesignerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.RoomPanel = new System.Windows.Forms.Panel();
            this.RoomViewer.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 19;
            // 
            // RoomViewer
            // 
            this.RoomViewer.Dock = System.Windows.Forms.DockStyle.None;
            this.RoomViewer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roomsToolStripMenuItem});
            this.RoomViewer.Location = new System.Drawing.Point(66, 0);
            this.RoomViewer.Name = "RoomViewer";
            this.RoomViewer.Size = new System.Drawing.Size(64, 24);
            this.RoomViewer.TabIndex = 53;
            this.RoomViewer.Text = "menuStrip2";
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.roomsToolStripMenuItem.Text = "Rooms";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdminTool});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(751, 24);
            this.menuStrip1.TabIndex = 54;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AdminTool
            // 
            this.AdminTool.BackColor = System.Drawing.SystemColors.ControlDark;
            this.AdminTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roomDesignerToolStripMenuItem});
            this.AdminTool.Name = "AdminTool";
            this.AdminTool.Size = new System.Drawing.Size(55, 20);
            this.AdminTool.Text = "Admin";
            // 
            // roomDesignerToolStripMenuItem
            // 
            this.roomDesignerToolStripMenuItem.Name = "roomDesignerToolStripMenuItem";
            this.roomDesignerToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.roomDesignerToolStripMenuItem.Text = "Room Designer";
            this.roomDesignerToolStripMenuItem.Click += new System.EventHandler(this.roomDesignerToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 35);
            this.button1.TabIndex = 55;
            this.button1.Text = "Refresh Rooms";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RoomPanel
            // 
            this.RoomPanel.Location = new System.Drawing.Point(144, 27);
            this.RoomPanel.Name = "RoomPanel";
            this.RoomPanel.Size = new System.Drawing.Size(607, 304);
            this.RoomPanel.TabIndex = 56;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 330);
            this.Controls.Add(this.RoomPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RoomViewer);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "`";
            this.RoomViewer.ResumeLayout(false);
            this.RoomViewer.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip RoomViewer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AdminTool;
        private System.Windows.Forms.ToolStripMenuItem roomDesignerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel RoomPanel;
    }
}


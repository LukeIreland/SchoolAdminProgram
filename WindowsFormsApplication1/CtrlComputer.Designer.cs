namespace WindowsFormsApplication1
{
    partial class CtrlComputer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlComputer));
            this.CompButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CompButton
            // 
            this.CompButton.BackColor = System.Drawing.Color.White;
            this.CompButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CompButton.BackgroundImage")));
            this.CompButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CompButton.Location = new System.Drawing.Point(0, 0);
            this.CompButton.Name = "CompButton";
            this.CompButton.Size = new System.Drawing.Size(62, 53);
            this.CompButton.TabIndex = 38;
            this.CompButton.UseVisualStyleBackColor = false;
            this.CompButton.Click += new System.EventHandler(this.CompButton_Click);
            this.CompButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CompButton_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CtrlComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CompButton);
            this.Name = "CtrlComputer";
            this.Size = new System.Drawing.Size(61, 53);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CompButton;
        private System.Windows.Forms.Label label1;
    }
}

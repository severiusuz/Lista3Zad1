namespace Zad1
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
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel_red = new System.Windows.Forms.Panel();
            this.panel_yellow = new System.Windows.Forms.Panel();
            this.panel_green = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panel_red
            // 
            this.panel_red.BackColor = System.Drawing.Color.Gray;
            this.panel_red.Location = new System.Drawing.Point(97, 32);
            this.panel_red.Name = "panel_red";
            this.panel_red.Size = new System.Drawing.Size(50, 50);
            this.panel_red.TabIndex = 0;
            // 
            // panel_yellow
            // 
            this.panel_yellow.BackColor = System.Drawing.Color.Gray;
            this.panel_yellow.Location = new System.Drawing.Point(97, 88);
            this.panel_yellow.Name = "panel_yellow";
            this.panel_yellow.Size = new System.Drawing.Size(50, 50);
            this.panel_yellow.TabIndex = 1;
            // 
            // panel_green
            // 
            this.panel_green.BackColor = System.Drawing.Color.Gray;
            this.panel_green.Location = new System.Drawing.Point(97, 144);
            this.panel_green.Name = "panel_green";
            this.panel_green.Size = new System.Drawing.Size(50, 50);
            this.panel_green.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.panel_green);
            this.Controls.Add(this.panel_yellow);
            this.Controls.Add(this.panel_red);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel_red;
        private System.Windows.Forms.Panel panel_yellow;
        private System.Windows.Forms.Panel panel_green;
        private System.Windows.Forms.Timer timer1;
    }
}


namespace BAGACHi
{
    partial class Bagachi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bagachi));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progBar = new System.Windows.Forms.Panel();
            this.prog = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logInPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.logBtn = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.loadingSceenLogo = new System.Windows.Forms.PictureBox();
            this.progBar.SuspendLayout();
            this.logInPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingSceenLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progBar
            // 
            this.progBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progBar.BackColor = System.Drawing.Color.Black;
            this.progBar.Controls.Add(this.prog);
            this.progBar.Location = new System.Drawing.Point(0, 445);
            this.progBar.Margin = new System.Windows.Forms.Padding(0);
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(800, 5);
            this.progBar.TabIndex = 4;
            // 
            // prog
            // 
            this.prog.BackColor = System.Drawing.Color.IndianRed;
            this.prog.Dock = System.Windows.Forms.DockStyle.Left;
            this.prog.Location = new System.Drawing.Point(0, 0);
            this.prog.Name = "prog";
            this.prog.Size = new System.Drawing.Size(1, 5);
            this.prog.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(20, 112);
            this.textBox2.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(260, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(20, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 51);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username: ";
            // 
            // logInPanel
            // 
            this.logInPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logInPanel.BackColor = System.Drawing.Color.DimGray;
            this.logInPanel.Controls.Add(this.label1);
            this.logInPanel.Controls.Add(this.textBox1);
            this.logInPanel.Controls.Add(this.label2);
            this.logInPanel.Controls.Add(this.textBox2);
            this.logInPanel.Controls.Add(this.logBtn);
            this.logInPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.logInPanel.Location = new System.Drawing.Point(237, 95);
            this.logInPanel.MaximumSize = new System.Drawing.Size(300, 200);
            this.logInPanel.Name = "logInPanel";
            this.logInPanel.Padding = new System.Windows.Forms.Padding(20);
            this.logInPanel.Size = new System.Drawing.Size(300, 200);
            this.logInPanel.TabIndex = 5;
            // 
            // logBtn
            // 
            this.logBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.logBtn.BackColor = System.Drawing.Color.Transparent;
            this.logBtn.BackgroundImage = global::BAGACHi.Properties.Resources.btnBG;
            this.logBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logBtn.FlatAppearance.BorderSize = 0;
            this.logBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logBtn.Location = new System.Drawing.Point(108, 142);
            this.logBtn.Margin = new System.Windows.Forms.Padding(0);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(84, 36);
            this.logBtn.TabIndex = 0;
            this.logBtn.Text = "button1";
            this.logBtn.UseVisualStyleBackColor = false;
            this.logBtn.Click += new System.EventHandler(this.logBtn_Click_1);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.notifyIcon1.BalloonTipText = "Lorem ipsum...";
            this.notifyIcon1.BalloonTipTitle = "Bagachi is RUnning...";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Tag = "Notif";
            this.notifyIcon1.Text = "BAgachi....";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // loadingSceenLogo
            // 
            this.loadingSceenLogo.Image = ((System.Drawing.Image)(resources.GetObject("loadingSceenLogo.Image")));
            this.loadingSceenLogo.Location = new System.Drawing.Point(237, 95);
            this.loadingSceenLogo.MaximumSize = new System.Drawing.Size(300, 200);
            this.loadingSceenLogo.Name = "loadingSceenLogo";
            this.loadingSceenLogo.Size = new System.Drawing.Size(300, 200);
            this.loadingSceenLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loadingSceenLogo.TabIndex = 6;
            this.loadingSceenLogo.TabStop = false;
            // 
            // Bagachi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loadingSceenLogo);
            this.Controls.Add(this.logInPanel);
            this.Controls.Add(this.progBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bagachi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.progBar.ResumeLayout(false);
            this.logInPanel.ResumeLayout(false);
            this.logInPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingSceenLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel progBar;
        private System.Windows.Forms.Panel prog;
        private System.Windows.Forms.PictureBox loadingSceenLogo;
        private System.Windows.Forms.Button logBtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel logInPanel;
        public System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}
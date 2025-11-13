namespace BAGACHi
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.topPanel = new System.Windows.Forms.Panel();
            this.extBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.extBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Exit";
            // 
            // topPanel
            // 
            this.topPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.topPanel.Location = new System.Drawing.Point(0, 12);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(800, 438);
            this.topPanel.TabIndex = 1;
            this.topPanel.DragOver += new System.Windows.Forms.DragEventHandler(this.topPanel_DragOver);
            // 
            // extBtn
            // 
            this.extBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.extBtn.Image = ((System.Drawing.Image)(resources.GetObject("extBtn.Image")));
            this.extBtn.InitialImage = ((System.Drawing.Image)(resources.GetObject("extBtn.InitialImage")));
            this.extBtn.Location = new System.Drawing.Point(768, 0);
            this.extBtn.MaximumSize = new System.Drawing.Size(32, 32);
            this.extBtn.Name = "extBtn";
            this.extBtn.Size = new System.Drawing.Size(32, 32);
            this.extBtn.TabIndex = 1;
            this.extBtn.TabStop = false;
            this.extBtn.Click += new System.EventHandler(this.extBtn_Click_1);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.extBtn);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.extBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox extBtn;
    }
}
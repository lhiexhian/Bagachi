using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAGACHi
{
    public partial class Bagachi : Form
    {
        public Bagachi()
        {
            ControlExtension.Draggable(this, true);
            InitializeComponent();
            timer1.Start();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            prog.Width += 10;
            if (prog.Width >= 800)
            {
                timer1.Stop();
                //Log in form
                logInPanel.Visible = true;
                loadingSceenLogo.Visible = false;
                //this.Hide();
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void logBtn_Click_1(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            this.Hide();
        }
    }
}

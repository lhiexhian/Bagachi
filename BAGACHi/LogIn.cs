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
                logInPanel.Size = new Size(300, 200);
                loadingSceenLogo.Visible = false;
                loadingSceenLogo.Size = new Size(0, 0);
                //this.Hide();
            }
        }

    }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            endThis.Start();//start the timer
        }

        private void endThis_Tick(object sender, EventArgs e)
        {
            Bagachi log = new Bagachi();
            this.Hide();//hide this form
            log.Show();//show the login form
            endThis.Stop();//stop the timer
            //sthis.Close();//close this form
        }
    }
}

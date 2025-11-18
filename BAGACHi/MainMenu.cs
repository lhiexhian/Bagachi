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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            //ControlExtension.Draggable(topPanel, true);
        }
        private void extBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void topPanel_DragOver(object sender, DragEventArgs e)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            picBoxMustang.Top -= 15;
            picBoxMustang.Height -= 4;
            picBoxMustang.Width -= 4;
            if (picBoxMustang.Top == 0 )
            {
                picBoxMustang.Top = picBoxMustang.Top.Defa
            }
        }
    }
}

using System;
using System.Windows.Forms;

namespace Three_Forms
{
    public partial class Form3 : Form
    {
        public Form prevForm;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prevForm = this;
            Close();
            prevForm.Show();
            Hide();
        }
    }
}

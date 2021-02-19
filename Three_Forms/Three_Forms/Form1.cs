namespace Three_Forms
{
    using System.Diagnostics;
    using System.Windows.Forms;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }

        private void btnModal_Click(object sender, System.EventArgs e)
        {
            Form2 form2 = new Form2();

            DialogResult result= form2.ShowDialog();

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("You clicked on Yes");
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("You clicked on Cancel");
            }
        }

        private void btnNonModal_Click(object sender, System.EventArgs e)
        {
            Form3 form3 = new Form3();

            form3.Show();
        }
    }
}
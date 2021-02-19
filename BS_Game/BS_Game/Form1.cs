using System.Drawing;
using System.Windows.Forms;

namespace BS_Game
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {

        }
        private void lblStartGame_MouseHover(object sender, System.EventArgs e)
        {
            lblStartGame.ForeColor = Color.Yellow;
            lblStartGame.Font = new Font(lblStartGame.Font.Name, 20, FontStyle.Regular);
        }

        private void lblStartGame_MouseLeave(object sender, System.EventArgs e)
        {
            lblStartGame.ForeColor = Color.White;
            lblStartGame.Font = new Font(lblStartGame.Font.Name, 9, FontStyle.Regular);
        }

        private void lblInfo_MouseHover(object sender, System.EventArgs e)
        {
            lblInfo.ForeColor = Color.Yellow;
            lblInfo.Font = new Font(lblInfo.Font.Name, 20, FontStyle.Regular);
        }

        private void lblInfo_MouseLeave(object sender, System.EventArgs e)
        {
            lblInfo.ForeColor = Color.White;
            lblInfo.Font = new Font(lblInfo.Font.Name, 9, FontStyle.Regular);
        }

        private void lblClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void lblClose_MouseHover(object sender, System.EventArgs e)
        {
            lblClose.ForeColor = Color.Yellow;
            lblClose.Font = new Font(lblClose.Font.Name, 20, FontStyle.Regular);
        }

        private void lblClose_MouseLeave(object sender, System.EventArgs e)
        {
            lblClose.ForeColor = Color.White;
            lblClose.Font = new Font(lblClose.Font.Name, 9, FontStyle.Regular);
        }

        private void btnBulgarian_Click(object sender, System.EventArgs e)
        {
            lblClose.Text = "Затвори";
            lblStartGame.Text = "Започни игра";
            lblInfo.Text = "Как се Играе?";
        }

        private void btnEnglish_Click(object sender, System.EventArgs e)
        {
            lblClose.Text = "Close";
            lblStartGame.Text = "Start Game";
            lblInfo.Text = "How to play";
        }
    }
}
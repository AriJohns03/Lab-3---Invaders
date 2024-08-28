using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3___Invaders
{
    public partial class NicknameForm : Form
    {
        public NicknameForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LeaderBoardForm leaderBoardForm = new LeaderBoardForm();
            leaderBoardForm.Closed += (s, args) => this.Close();
            leaderBoardForm.Show();
        }
    }
}

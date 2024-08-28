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
	public partial class HomePageForm : Form
	{
		private Game game;
		public int Frame = 0;
		public Rectangle FormArea { get { return this.ClientRectangle; } }
		Random random = new Random();

		public HomePageForm()
		{
			InitializeComponent();
			game = new Game(random, FormArea);
			animationTimer.Start();
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			game.Draw(graphics, Frame, false);
		}

		private void animationTimer_Tick(object sender, EventArgs e)
		{
			if (Frame < 3)
				Frame++;
			else
				Frame = 0;
			game.Twinkle();
			Refresh();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form1 form1 = new Form1();
			form1.Closed += (s, args) => this.Close();
			form1.Show();

		}

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LeaderBoardForm leaderBoardForm = new LeaderBoardForm();
			leaderBoardForm.Closed += (s, args) => this.Close();
            leaderBoardForm.Show();
        }
    }
}

﻿using System;
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
	public partial class LeaderBoardForm : Form
	{
		public LeaderBoardForm()
		{
			InitializeComponent();
		}

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePageForm homePage = new HomePageForm();
            homePage.Closed += (s, args) => this.Close();
            homePage.Show();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Mode : Form
    {
        public Mode()
        {
            InitializeComponent();
        }
        void cl_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Computer Computer = new Computer();
            this.Hide();
            Computer.ShowDialog();
            Computer.FormClosed += new FormClosedEventHandler(cl_FormClosed);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Player Player = new Player();
            this.Hide();
            Player.ShowDialog();
            Player.FormClosed += new FormClosedEventHandler(cl_FormClosed);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Main Main = new Main();
            this.Hide();
            Main.ShowDialog();
            Main.FormClosed += new FormClosedEventHandler(cl_FormClosed);
        }
    }
    
}

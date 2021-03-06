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
    public partial class Form8 : Form
    {
        public enum Player
        {
            X, O
        }
        Player currentPlayer;
        List<Button> buttons;
        Random rand = new Random();
        int Computerscore = 0;
        int Playerscore = 0;
        int Computermoves = 0;
        int Playermoves = 0;
        private Games CurrentGame;
        public Form8()
        {
            CurrentGame = new Games
            {
                CompGameId = Program.CompCompletedGames.Count + 1
            };

            InitializeComponent();
            ClearGame();
        }
        
        private void loadbuttons()
        {
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };

        }

        private void playerClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
            currentPlayer = Player.X;
            button.Text = currentPlayer.ToString();
            button.Enabled = false;
            button.ForeColor = Color.Black;
            button.BackColor = Color.Transparent;
            buttons.Remove(button);
            Playermoves++;
            Playermove1.Text = Playermoves.ToString();
            Slow();
            WinorDraw();
            Check();                        

        }
        private void AIlogic()
        {
            if (buttons.Count > 0)
            {
                int index = rand.Next(buttons.Count);
                buttons[index].Enabled = false;
                buttons[index].ForeColor = Color.Black;
                buttons[index].BackColor = Color.Transparent;
                currentPlayer = Player.O;
                buttons[index].Text = currentPlayer.ToString();
                buttons.RemoveAt(index);
                Computermoves++;
                Computermove1.Text = Computermoves.ToString();
                Check();
            }
        }
        public void Slow()
        {
            
            var end = DateTime.Now + TimeSpan.FromSeconds(1);
            while (DateTime.Now < end);
        }
        private void WinorDraw()
        {
            

            if (button1.Text == "" && button2.Text == "O" && button3.Text == "O"
    || button1.Text == "" && button4.Text == "O" && button7.Text == "O"
    || button1.Text == "" && button5.Text == "O" && button9.Text == "O")
            {
                if (buttons.Contains(button1))
                {
                    button1.Text = "O";
                    button1.Enabled = false;
                    button1.ForeColor = Color.Black;
                    button1.BackColor = Color.Transparent;
                    buttons.Remove(button1);
                    Computermoves++;
                    Computermove1.Text = Computermoves.ToString();
                }
            }
            else if (button1.Text == "O" && button2.Text == "" && button3.Text == "O"
                || button2.Text == "" && button5.Text == "O" && button8.Text == "O")
            {
                if (buttons.Contains(button2))
                {
                    button2.Text = "O";
                    button2.Enabled = false;
                    button2.ForeColor = Color.Black;
                    button2.BackColor = Color.Transparent;
                    buttons.Remove(button2);
                    Computermoves++;
                    Computermove1.Text = Computermoves.ToString();
                }
            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == ""
                || button3.Text == "" && button5.Text == "O" && button7.Text == "O"
                || button3.Text == "" && button6.Text == "O" && button9.Text == "O")
            {
                if (buttons.Contains(button3))
                {
                    button3.Text = "O";
                    button3.Enabled = false;
                    button3.ForeColor = Color.Black;
                    button3.BackColor = Color.Transparent;
                    buttons.Remove(button3);
                    Computermoves++;
                    Computermove1.Text = Computermoves.ToString();
                }
            }
            else if (button4.Text == "" && button5.Text == "O" && button6.Text == "O"
                || button1.Text == "O" && button4.Text == "" && button7.Text == "O")
            {
                if (buttons.Contains(button4))
                {
                    button4.Text = "O";
                    button4.Enabled = false;
                    button4.ForeColor = Color.Black;
                    button4.BackColor = Color.Transparent;
                    buttons.Remove(button4);
                    Computermoves++;
                    Computermove1.Text = Computermoves.ToString();
                }
            }
            else if (button4.Text == "O" && button5.Text == "" && button6.Text == "O"
                 || button1.Text == "O" && button5.Text == "" && button9.Text == "O"
                 || button3.Text == "O" && button5.Text == "" && button7.Text == "O")
            {
                if (buttons.Contains(button5))
                {
                    button5.Text = "O";
                    button5.Enabled = false;
                    button5.ForeColor = Color.Black;
                    button5.BackColor = Color.Transparent;
                    buttons.Remove(button5);
                    Computermoves++;
                    Computermove1.Text = Computermoves.ToString();
                }
            }
            else if (button4.Text == "O" && button5.Text == "O" && button6.Text == ""
                 || button3.Text == "O" && button6.Text == "" && button9.Text == "O")
            {
                if (buttons.Contains(button6))
                {
                    button6.Text = "O";
                    button6.Enabled = false;
                    button6.ForeColor = Color.Black;
                    button6.BackColor = Color.Transparent;
                    buttons.Remove(button6);
                    Computermoves++;
                    Computermove1.Text = Computermoves.ToString();
                }
            }
            else if (button7.Text == "" && button8.Text == "O" && button9.Text == "O"
                || button1.Text == "O" && button4.Text == "O" && button7.Text == ""
                || button3.Text == "O" && button5.Text == "O" && button7.Text == "")
            {
                if (buttons.Contains(button7))
                {
                    button7.Text = "O";
                    button7.Enabled = false;
                    button7.ForeColor = Color.Black;
                    button7.BackColor = Color.Transparent;
                    buttons.Remove(button7);
                    Computermoves++;
                    Computermove1.Text = Computermoves.ToString();
                }
            }
            else if (button7.Text == "O" && button8.Text == "" && button9.Text == "O"
                || button2.Text == "O" && button5.Text == "O" && button8.Text == "")
            {
                if (buttons.Contains(button8))
                {
                    button8.Text = "O";
                    button8.Enabled = false;
                    button8.ForeColor = Color.Black;
                    button8.BackColor = Color.Transparent;
                    buttons.Remove(button8);
                    Computermoves++;
                    Computermove1.Text = Computermoves.ToString();
                }
            }
            else if (button7.Text == "O" && button8.Text == "O" && button9.Text == ""
                || button1.Text == "O" && button5.Text == "O" && button9.Text == ""
                || button3.Text == "O" && button6.Text == "O" && button9.Text == "")
            {
                if (buttons.Contains(button9))
                {
                    button9.Text = "O";
                    button9.Enabled = false;
                    button9.ForeColor = Color.Black;
                    button9.BackColor = Color.Transparent;
                    buttons.Remove(button9);
                    Computermoves++;
                    Computermove1.Text = Computermoves.ToString();
                }
            }
            else if (button1.Text == "" && button2.Text == "X" && button3.Text == "X"
                || button1.Text == "" && button4.Text == "X" && button7.Text == "X"
                || button1.Text == "" && button5.Text == "X" && button9.Text == "X")
            {
                if (buttons.Contains(button1))
                {
                    button1.Text = "O";
                    button1.Enabled = false;
                    button1.ForeColor = Color.Black;
                    button1.BackColor = Color.Transparent;
                    buttons.Remove(button1);
                    Computermoves++;
                    Computermove1.Text = Computermoves.ToString();
                }
            }
             else if (button1.Text == "X" && button2.Text == "" && button3.Text == "X"
                || button2.Text == "" && button5.Text == "X" && button8.Text == "X")
            {
                if (buttons.Contains(button2))
                {
                    button2.Text = "O";
                    button2.Enabled = false;
                    button2.ForeColor = Color.Black;
                    button2.BackColor = Color.Transparent;
                    buttons.Remove(button2);
                    Computermoves++;
                    Computermove1.Text = Computermoves.ToString();
                }
            }
            else if (button1.Text == "X" && button2.Text == "X" && button3.Text == ""
                || button3.Text == "" && button5.Text == "X" && button7.Text == "X"
                || button3.Text == "" && button6.Text == "X" && button9.Text == "X")
            {
                if (buttons.Contains(button3))
                {
                    button3.Text = "O";
                    button3.Enabled = false;
                    button3.ForeColor = Color.Black;
                    button3.BackColor = Color.Transparent;
                    buttons.Remove(button3);
                    Computermoves++;
                    Computermove1.Text = Computermoves.ToString();
                }
            }
            else if (button4.Text == "" && button5.Text == "X" && button6.Text == "X"
                || button1.Text == "X" && button4.Text == "" && button7.Text == "X")
            {
                if (buttons.Contains(button4))
                {
                    button4.Text = "O";
                    button4.Enabled = false;
                    button4.ForeColor = Color.Black;
                    button4.BackColor = Color.Transparent;
                    buttons.Remove(button4);
                    Computermoves++;
                    Computermove1.Text = Computermoves.ToString();
                }
            }
            else if (button4.Text == "X" && button5.Text == "" && button6.Text == "X"
                 || button1.Text == "X" && button5.Text == "" && button9.Text == "X"
                 || button3.Text == "X" && button5.Text == "" && button7.Text == "X")
            {
                if (buttons.Contains(button5))
                {
                    button5.Text = "O";
                    button5.Enabled = false;
                    button5.ForeColor = Color.Black;
                    button5.BackColor = Color.Transparent;
                    buttons.Remove(button5);
                    Computermoves++;
                    Computermove1.Text = Computermoves.ToString();
                }
            }
            else if (button4.Text == "X" && button5.Text == "X" && button6.Text == ""
                 || button3.Text == "X" && button6.Text == "" && button9.Text == "X")
            {
                if (buttons.Contains(button6))
                {
                    button6.Text = "O";
                    button6.Enabled = false;
                    button6.ForeColor = Color.Black;
                    button6.BackColor = Color.Transparent;
                    buttons.Remove(button6);
                    Computermoves++;
                    Computermove1.Text = Computermoves.ToString();
                }
            }
            else if (button7.Text == "" && button8.Text == "X" && button9.Text == "X"
                || button1.Text == "X" && button4.Text == "X" && button7.Text == ""
                || button3.Text == "X" && button5.Text == "X" && button7.Text == "")
            {
                if (buttons.Contains(button7))
                {
                    button7.Text = "O";
                    button7.Enabled = false;
                    button7.ForeColor = Color.Black;
                    button7.BackColor = Color.Transparent;
                    buttons.Remove(button7);
                    Computermoves++;
                    Computermove1.Text = Computermoves.ToString();
                }
            }
            else if (button7.Text == "X" && button8.Text == "" && button9.Text == "X"
                || button2.Text == "X" && button5.Text == "X" && button8.Text == "")
            {
                if (buttons.Contains(button8))
                {
                    button8.Text = "O";
                    button8.Enabled = false;
                    button8.ForeColor = Color.Black;
                    button8.BackColor = Color.Transparent;
                    buttons.Remove(button8);
                    Computermoves++;
                    Computermove1.Text = Computermoves.ToString();
                }
            }
            else if (button7.Text == "X" && button8.Text == "X" && button9.Text == ""
                || button1.Text == "X" && button5.Text == "X" && button9.Text == ""
                || button3.Text == "X" && button6.Text == "X" && button9.Text == "")
            {
                if (buttons.Contains(button9))
                {
                    button9.Text = "O";
                    button9.Enabled = false;
                    button9.ForeColor = Color.Black;
                    button9.BackColor = Color.Transparent;
                    buttons.Remove(button9);
                    Computermoves++;
                    Computermove1.Text = Computermoves.ToString();
                }
            }

            else
            {
                AIlogic();

            }

        }
        private void Check()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X"
                || button4.Text == "X" && button5.Text == "X" && button6.Text == "X"
                || button7.Text == "X" && button9.Text == "X" && button8.Text == "X"
                || button1.Text == "X" && button4.Text == "X" && button7.Text == "X"
                || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
                || button3.Text == "X" && button6.Text == "X" && button9.Text == "X"
                || button1.Text == "X" && button5.Text == "X" && button9.Text == "X"
                || button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                Playerscore++;


                label7.Text = Playerscore.ToString();
                MessageBox.Show("Player Wins " + Playerscore + " match(s) in " + Playermoves + " moves" + Environment.NewLine + "Computer wins " + Computerscore + " match(s)");
                Playermoves = 0;

                ClearGame();
                score();
            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
                || button4.Text == "O" && button5.Text == "O" && button6.Text == "O"
                || button7.Text == "O" && button9.Text == "O" && button8.Text == "O"
                || button1.Text == "O" && button4.Text == "O" && button7.Text == "O"
                || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
                || button3.Text == "O" && button6.Text == "O" && button9.Text == "O"
                || button1.Text == "O" && button5.Text == "O" && button9.Text == "O"                || button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                Computerscore++;
                
                label8.Text = Computerscore.ToString();
                MessageBox.Show("Computer Wins " + Computerscore + " match(s) in " + Computermoves + " moves" + Environment.NewLine + "Player wins " + Playerscore + " match(s)");
                Computermoves = 0;
                ClearGame();
                score();
            }
            else if (button1.Text != "" && button2.Text != "" && button3.Text != "" &&
                    button4.Text != "" && button5.Text != "" && button6.Text != "" &&
                    button7.Text != "" && button8.Text != "" && button9.Text != "")
                {
                MessageBox.Show("It's a Draw");
                ClearGame();
            }
        }
        public void score()
        {
            if (Computerscore == 2 && Playerscore == 1
                || Computerscore == 3 && Playerscore == 0)

            {
                MessageBox.Show("Computer Wins Overall!" + Environment.NewLine + "Computer Score: " + Computerscore + " match(s)"
                    + Environment.NewLine + "Player Score: " + Playerscore + " match(s)");
                GameOver();
            }
            else if (Playerscore == 3 && Computerscore == 0
                || Playerscore == 2 && Computerscore == 1)
            {
                MessageBox.Show("Player Wins Overall!" + Environment.NewLine + "Player Score: " + Playerscore + " match(s)"
                    + Environment.NewLine + "Computer Score: " + Computerscore + " match(s)");
                GameOver();
            }
            else
            {
                ClearGame();
            }
        }

        public void ClearGame()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            Computermoves = 0;
            Playermoves = 0;
            Playermove1.Text = Playermoves.ToString();
            Computermove1.Text = Computermoves.ToString();
            loadbuttons();
            AIlogic();

        }
        public void GameOver()
        {
            CurrentGame.PlayerScore = Playerscore;
            CurrentGame.ComputerScore = Computerscore;
            CurrentGame.Mode = "Player vs Computer";
            Program.CompCompletedGames.Add(CurrentGame);
            CurrentGame = new Games
            {
                CompGameId = Program.CompCompletedGames.Count + 1
            };

            Form6 GameOver = new Form6();
            this.Hide();
            GameOver.ShowDialog();
            GameOver.FormClosed += new FormClosedEventHandler(cl_FormClosed);
        }
        void cl_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form4 Mode = new Form4();
            this.Hide();
            Mode.ShowDialog();
            Mode.FormClosed += new FormClosedEventHandler(cl_FormClosed);
        }
    }
}
//https://www.mooict.com/wp-content/uploads/2017/10/c-sharp-create-a-tic-tac-toe-game-play-against-ai-opponent20.pdf

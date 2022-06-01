using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame
{
    public partial class Form3 : Form
    {
        bool goLeft = false;
        bool goRight = false;
        bool jumping = false;
        bool hasKey = false;
        int jumpSpeed = 0;
        int force = 8;
        int score = 0;
        int playerSpeed = 10;
        int backgroundSpeed = 8;
        
        public Form3()
        {
            InitializeComponent();
        }

        private void TimerEvent(object sender, EventArgs e)
        {
            player2.Top += jumpSpeed;
            resScore.Text = "Score:" + score;
            if (goLeft == true && player2.Left > 60)
                player2.Left -= playerSpeed;
            if (goRight == true && player2.Left + (player2.Width + 60) < this.ClientSize.Width)
                player2.Left += playerSpeed;

            if (goLeft == true)
                MoveGameElemnt("forward");
            if (goRight == true)
                MoveGameElemnt("backward");

            if (jumping == true)
            {
                jumpSpeed = -15;
                force -= 1;
            }
            else jumpSpeed = 15;

            if (jumping == true && force < 0)
                jumping = false;
            IsIntersects();
        }

        public void IsIntersects()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && Convert.ToString(x.Tag) == "platf")
                {
                    if (player2.Bounds.IntersectsWith(x.Bounds) && jumping == false)
                    {
                        force = 8;
                        player2.Top = x.Top - player2.Height;
                        jumpSpeed = 0;
                    }
                    x.BringToFront();
                }

                if (x is PictureBox && Convert.ToString(x.Tag) == "redGem")
                {
                    if (player2.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {
                        x.Visible = false;
                        score += 1;
                    }
                }
            }

            if (player2.Bounds.IntersectsWith(treasure2.Bounds))
            {
                treasure2.Visible = false;
                hasKey = true;
            }
            if (player2.Bounds.IntersectsWith(door2.Bounds) && hasKey == true)
                WinTheGame();
            if (player2.Top + player2.Height > this.ClientSize.Height + 80)
                FailedTheGame();
        }

        private void WinTheGame()
        {
            door2.Image = Properties.Resources.opendoor;
            timer1.Stop();
            MessageBox.Show("Поздравляю, ты прошел уровень!" +
                "Твой счет: " + score + "!");
            Close();
        }

        private void FailedTheGame()
        {
            timer1.Stop();
            GamePer.getTag = "form3";
            Form2 form2 = new Form2();
            form2.Show();
            Hide();
        }

        private void MoveGameElemnt(string direction)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && Convert.ToString(x.Tag) == "platf" ||
                    x is PictureBox && Convert.ToString(x.Tag) == "redGem" ||
                    x is PictureBox && Convert.ToString(x.Tag) == "treasure2" ||
                    x is PictureBox && Convert.ToString(x.Tag) == "door2")
                {
                    if (direction == "forward")
                        x.Left += backgroundSpeed;
                    if (direction == "backward")
                        x.Left -= backgroundSpeed;
                }
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                goLeft = true;
            if (e.KeyCode == Keys.Right)
                goRight = true;
            if (e.KeyCode == Keys.Space && jumping == false)
                jumping = true;
        }


        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                goLeft = false;
            if (e.KeyCode == Keys.Right)
                goRight = false;
            if (jumping)
                jumping = false;
        }

        private void GameClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

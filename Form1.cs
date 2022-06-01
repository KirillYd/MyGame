using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyGame;

namespace MyGame
{
    public partial class Form1 : Form
    {

        bool goLeft = false;
        bool goRight = false;
        bool jumping = false;
        bool hasKey = false;
        int jumpSpeed = 0;
        double force = 8;
        int score = 0;
        int playerSpeed = 10;
        int backgroundSpeed = 10;
 
        public Form1()
        {
            InitializeComponent();
        }

        public void TimerEvent(object sender, EventArgs e)
        {
            player.Top += jumpSpeed;
            resScore.Text = "Score: " + score;
            if (goLeft == true && player.Left > 60)
                player.Left -= playerSpeed;
            if (goRight == true && player.Left + (player.Width + 60) < this.ClientSize.Width)
                player.Left +=playerSpeed;

            if (goLeft == true)
                MoveElement("forward");
            if (goRight == true)
                MoveElement("backward");

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
                if (x is PictureBox && Convert.ToString(x.Tag) == "platform")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && jumping == false)
                    {
                        force = 8;
                        player.Top = x.Top - player.Height;
                        jumpSpeed = 0;
                    }
                    x.BringToFront();
                }

                if (x is PictureBox && Convert.ToString(x.Tag) == "gem")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {
                        x.Visible = false;
                        score += 1;
                    }
                }
            }
            if (player.Bounds.IntersectsWith(treasure.Bounds))
            {
                treasure.Visible = false;
                hasKey = true;
            }

            if (player.Bounds.IntersectsWith(door.Bounds) && hasKey == true)
            {
                WinTheGame();
            }

            if (player.Top + player.Height > this.ClientSize.Height + 80)
                FailedTheGame();
        }

        private void WinTheGame()
        {
            door.Image = Properties.Resources.opendoor;
            Timer.Stop();
            MessageBox.Show("Поздравляю, ты прошел уровень!" +
                "Твой счет: " + score + "!");
            Form3 lvl2 = new Form3();
            lvl2.Show();
            this.Hide();
        }

        private void FailedTheGame()
        {
            Timer.Stop();
            GamePer.getTag = "form1";
            gameFailed.Visible = true;
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void MoveElement(string direction)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && Convert.ToString(x.Tag) == "platform" ||
                    x is PictureBox && Convert.ToString(x.Tag) == "gem" ||
                    x is PictureBox && Convert.ToString(x.Tag) == "treasure" ||
                    x is PictureBox && Convert.ToString(x.Tag) == "door")
                {
                    if (direction == "forward")
                        x.Left += backgroundSpeed;
                    if (direction == "backward")
                        x.Left -= backgroundSpeed;
                }
            }
        }

        private void DownKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                goLeft = true;
            if (e.KeyCode == Keys.Right)
                goRight = true;
            if (e.KeyCode == Keys.Space && jumping == false)
                jumping = true;
        }

        private void UpKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                goLeft = false;
            if (e.KeyCode == Keys.Right)
                goRight = false;
            if (jumping)
                jumping = false;
        }

        public void CloseGame(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
